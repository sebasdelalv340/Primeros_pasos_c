
using Personaje;

Character personaje1 = new Character ("elfo");
Weapon espada = new Sword();
Protection armadura = new Shield();

Character personaje2 = new Character("orco");
Weapon hacha = new Axe();
Protection casco = new Helmet();

personaje1.AddInventory(espada);
personaje1.AddInventory(armadura);

personaje2.AddInventory(hacha);
personaje2.AddInventory(casco);











