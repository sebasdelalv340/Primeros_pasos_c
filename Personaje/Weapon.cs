namespace Personaje;

public abstract class Weapon(string name, int damage): IItem
{
    public string Name = name;
    public int Damage = damage;
    
    public virtual void Apply(Character character)
    {
        character.BaseDamage += Damage;
    }
}