using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GroceryAPI.Data;
using GroceryAPI.Dtos;
using GroceryAPI.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace GroceryAPI.Controllers
{
    [Route("api/Grocery")]
    [ApiController]
    public class GroceriesController : ControllerBase
    {
        private readonly IGroceryRepo _repo;
        private readonly IMapper _mapper;

        public GroceriesController(IGroceryRepo repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }


        [HttpGet]
        public ActionResult<IEnumerable<GroceryReadDto>> GetAllGrocery()
        {
            var groceryItems = _repo.GetAllGrocery();
            return Ok(_mapper.Map<IEnumerable<GroceryReadDto>>(groceryItems));
        }

        [HttpGet("{Id}", Name = "GetGroceryByID")]
        public ActionResult<GroceryReadDto> GetGroceryByID(int Id)
        {
            var groceryItem = _repo.GetGroceryByID(Id);
            if (groceryItem != null)
            {
                return Ok(_mapper.Map<GroceryReadDto>(groceryItem));
            }

            return NotFound();
        }

        [HttpPost]
        public ActionResult<GroceryReadDto> CreateGrocery(GroceryCreateDto groceryCreateDto)
        {
            var groceryModel = _mapper.Map<Grocery>(groceryCreateDto);
            _repo.CreateGrocery(groceryModel);
            _repo.SaveChanges();
            var groceryReadDto = _mapper.Map<GroceryReadDto>(groceryModel);

            return CreatedAtRoute(nameof(GetGroceryByID), new { Id = groceryReadDto.Id }, groceryReadDto);
            //return Ok(groceryReadDto);
        }

        [HttpPut("{Id}")]
        public ActionResult UpdateGrocery(int Id, GroceryUpdateDto groceryUpdateDto)
        {
            var groceryModelFromRepo = _repo.GetGroceryByID(Id);
            if (groceryModelFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(groceryUpdateDto, groceryModelFromRepo);

            _repo.UpdateGrocery(groceryModelFromRepo);
            _repo.SaveChanges();
            return NoContent();
        }

        [HttpPatch("{Id}")]
        public ActionResult PartialGroceryUpdate(int Id, JsonPatchDocument<GroceryUpdateDto> patchDoc)
        {
            var groceryModelFromRepo = _repo.GetGroceryByID(Id);
            if (groceryModelFromRepo == null)
            {
                return NotFound();
            }
            var groceryToPatch = _mapper.Map<GroceryUpdateDto>(groceryModelFromRepo);
            patchDoc.ApplyTo(groceryToPatch, ModelState);
            if (!TryValidateModel(groceryToPatch))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(groceryToPatch, groceryModelFromRepo);
            _repo.UpdateGrocery(groceryModelFromRepo);
            _repo.SaveChanges();
            return NoContent();       

        }

        [HttpDelete("{Id}")]
        public ActionResult DeleteGrocery(int Id)
        {
            var groceryModelFromRepo = _repo.GetGroceryByID(Id);
            if (groceryModelFromRepo == null)
            {
                return NotFound();
            }
            _repo.DeleteGrocery(groceryModelFromRepo);
            _repo.SaveChanges();
            return NoContent();

        }
    }
}
