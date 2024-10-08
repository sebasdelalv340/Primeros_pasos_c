namespace Personaje;

public class Sword: Weapon
{
    protected Sword() : base("Sword", 3)
    {
    }

    public override void Apply(Character character)
    {
        base.Apply(character);
    }
}