using AutoMapper;
using GroceryAPI.Dtos;
using GroceryAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryAPI.Profiles
{
    public class GroceryProfile : Profile
    {
        public GroceryProfile()
        {
            CreateMap<Grocery, GroceryReadDto>();
            CreateMap<GroceryCreateDto, Grocery>();
            CreateMap<GroceryUpdateDto, Grocery>();
            CreateMap<Grocery, GroceryUpdateDto>();
        }
    }
}
