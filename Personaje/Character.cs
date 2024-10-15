
namespace Personaje;

public class Character(string name)
{
    public string Name = name;
    private int MaxHitPoints { get; set; } = 100;
    public int BaseDamage { get; set; } = 3;
    public int BaseArmor { get; set; } = 2;
    public int Health { get; set; } = 60;
    public readonly List<IItem> Inventory = [];
    public readonly List<IMinion> Pers = [];
    
    public int Attack()
    {
        Inventory.OfType<Weapon>().FirstOrDefault()?.Apply(this);
        return BaseDamage;
    }

    public int Defense()
    {
        Inventory.OfType<Protection>().FirstOrDefault()?.Apply(this);
        return BaseArmor;
    }

    public void Heal(int potion)
    {
        Health += potion;
        if (Health > MaxHitPoints)
        {
            Health = MaxHitPoints;
        }
    }

    public void ReceiveDamage(int damage)
    {
        Health -= damage;
        if (Health < 0)
        {
            Health = 0;
        }
    }

    public void AddInventory(IItem item)
    {
        Inventory.Add(item);
    }

    public override string ToString()
    {
        return $"Character:\n\tName: {Name}\n\tMaxHitPoints: {MaxHitPoints}";
    }
}

