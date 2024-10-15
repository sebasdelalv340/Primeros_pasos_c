namespace Personaje;

public abstract class Minion: IMinion
{
    private string Name { get; set; }
    private int Damage { get; set; }
    private int Health { get; set; }

    protected Minion(string name, int damage, int health)
    {
        Name = name;
        Damage = damage;
        Health = health;
    }
        
    public void Attack(int damage)
    {
        Damage += damage;
    }

    public void ReceiveDamage(int damage)
    {
        Health -= damage;
        if (Health < 0)
        {
            Health = 0;
        }
    }
}