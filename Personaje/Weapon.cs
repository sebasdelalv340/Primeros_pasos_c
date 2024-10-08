namespace Personaje;

public abstract class Weapon: IItem
{
    public string Name { get; set; }
    private int Damage { get; set; }

    protected Weapon(string name, int damage)
    {
        Name = name;
        Damage = damage;
    }
    public virtual void Apply(Character character)
    {
        character.BaseDamage += Damage;
    }
}