using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Personaje.Tests;

[TestClass]
public class CharacterTest
{
    [TestMethod]
    public void AttackTest()
    {
        var character = new Character("Test");
        var weapon = new Sword();
        character.AddInventory(weapon);
        var damage = character.Attack();
        Assert.AreEqual(6, damage);
    }

    [TestMethod]
    public void DefenseTest()
    {
        var character = new Character("Test");
        var protection = new Shield();
        character.AddInventory(protection);
        var armor = character.Defense();
        Assert.AreEqual(4, armor);
    }

    [TestMethod]
    public void HealTest()
    {
        var character = new Character("Test");
        var potion = 4;
        character.Heal(potion);
        Assert.AreEqual(64, character.Health);
    }

    [TestMethod]
    public void ReceiveDamageTest()
    {
        var character = new Character("Test");
        var damage = 20;
        character.ReceiveDamage(damage);
        Assert.AreEqual(40, character.Health);
    }

    [TestMethod]
    public void AddInventoryTest()
    {
        var character = new Character("Test");
        var item = new Axe();
        character.AddInventory(item);
        Assert.AreEqual(1, character.Inventory.Count);
    }
}