public class Opps
{
    public List<OppInfo> Fighters = new()
    {
        new OppInfo{name = "Fredrick", health = 100, armours = new()
            {
                new Armour{name = "Leather Chest Plate", strength = 15, place = "Chest"},
                new Armour{name = "Leather Leggings", strength = 10, place = "Legs"}
            }
        }
    };
}

public class OppInfo
{
    public string name;
    public int health;
    public List<Armour> armours = new();
}