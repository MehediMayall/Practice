using AutoMapper;
using DishesAPI.Entities;

namespace DishesAPI;

public class DishProfile : Profile {
    public DishProfile()
    {
        CreateMap<Dish, DishDto>();
    }
}