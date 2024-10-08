namespace Personaje;

public abstract class Protection: IItem
{
    public string Name { get; set; }
    private int Armor { get; set; }
    
    protected Protection(string name, int armor)
    {
        Name = name;
        Armor = armor;
    }

    public virtual void Apply(Character character)
    {
        character.BaseArmor += Armor;
    }
}