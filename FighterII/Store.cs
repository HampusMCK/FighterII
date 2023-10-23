public class Store
{
    public List<Weapons> weapons = new()
    {
        new Weapons{name = "Steel Sword", price = 15, durability = 12, strength = 10},
        new Weapons{name = "Bow and Arrow", price = 20, durability = 15, strength = 15},
        new Weapons{name = "Axe", price = 25, durability = 25, strength = 20}
    };
    public List<Armour> armours = new()
    {
        new Armour{name = "Leather Chest Plate", strength = 15, place = 2},
        new Armour{name = "Leather Leggings", strength = 10, place = 3},
        new Armour{name = "Chainmil Chest Plate", strength = 20, place = 2},
        new Armour{name = "Chainmil Leggings", strength = 17, place = 3},
        new Armour{name = "Iron Helmet", strength = 12, place = 1}
    };
}
