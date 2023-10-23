public class Opps
{
    public List<OppInfo> Fighters = new()
    {
        new OppInfo{name = "Fredrick", health = 100, strength = 12, armours = new()
            {
                new Armour{name = "Leather Chest Plate", strength = 15, place = 2},
                new Armour{name = "Leather Leggings", strength = 10, place = 3}
            }
        },
        new OppInfo{name = "Johan", health = 100, strength = 16, armours = new()
            {
                new Armour{name = "Chainmil Chest Plate", strength = 20, place = 2},
                new Armour{name = "Chainmil Leggings", strength = 17, place = 3},
                new Armour{name = "Iron Helmet", strength = 12, place = 1}
            }
        }
    };
}

public class OppInfo
{
    public string name;
    public int health;
    public int strength;
    public List<Weapons> weapons = new();
    public List<Armour> armours = new();
}