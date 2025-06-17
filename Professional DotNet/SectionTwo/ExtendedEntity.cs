namespace SectionTwo;

public class ExtendedEntity: Entity
{
    public ExtendedEntity()
    {
        BaseEntity = new Entity();
    }

    public Entity BaseEntity { get; }
    public DateTime BirthDate { get; set; }
}