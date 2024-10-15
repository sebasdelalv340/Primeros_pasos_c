namespace Personaje;

public abstract class Protection(string name, int armor): IItem
{
    public string Name = name;
    public int Armor = armor;
    
    public virtual void Apply(Character character)
    {
        character.BaseArmor += Armor;
    }
}