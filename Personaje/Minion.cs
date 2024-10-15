namespace Personaje;

public class Minion(string name, int damage, int health): IMinion
{
    public string Name = name;
    public int Damage = damage;
    public int Health = health;
        
    public virtual int Attack()
    {
        return Damage;
    }

    public virtual void ReceiveDamage(int damage)
    {
        Health -= damage;
        if (Health < 0)
        {
            Health = 0;
        }
    }
}