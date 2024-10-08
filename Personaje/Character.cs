
using System.Collections;

namespace Personaje;

public class Character
{
    public string Name { get; set; }
    public int MaxHitPoints { get; set; } = 100;
    public int BaseDamage { get; set; } = 3;
    public int BaseArmor { get; set; } = 2;
    public int Health { get; set; } = 60;
    public List<IItem> _inventory = [];

    public Character(string name)
    {
        Name = name;
    }
    
    public int Attack(Weapon weapon)
    {
        weapon.Apply(this);
        return BaseDamage;
    }

    public int Defense(Protection protection)
    {
        protection.Apply(this);
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
        _inventory.Add(item);
    }
}

