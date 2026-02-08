namespace deneme.Domain.Entities;

public class RandomNumber
{
    public int Value { get; set; }
    public DateTime GeneratedAt { get; set; }

    public RandomNumber(int value)
    {
        Value = value;
        GeneratedAt = DateTime.UtcNow;
    }
}
