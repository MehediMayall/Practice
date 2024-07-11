namespace PatternMatching;

public class Pet
{
    public Pet(float Weight, PetType petType)
    {
        this.Weight = Weight;
        PetType = petType;
    }

    public float Weight { get; }
    public PetType PetType { get; }
}

public enum PetType
{
    Fish,
    Animal
}