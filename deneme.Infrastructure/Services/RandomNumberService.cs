using deneme.Application.Interfaces;
using deneme.Domain.Entities;

namespace deneme.Infrastructure.Services;

public class RandomNumberService : IRandomNumberService
{
    private readonly Random _random = new();

    public RandomNumber GenerateRandomNumber(int min = 1, int max = 100)
    {
        var number = _random.Next(min, max + 1);
        return new RandomNumber(number);
    }
}
