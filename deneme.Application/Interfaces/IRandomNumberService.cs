using deneme.Domain.Entities;

namespace deneme.Application.Interfaces;

public interface IRandomNumberService
{
    RandomNumber GenerateRandomNumber(int min = 1, int max = 100);
}
