
Opps fighters = new();
Player p = new();
Store ica = new();
Random gen = new();


Console.WriteLine("What is your name?");
p.name = Console.ReadLine();
Console.Clear();
while (true)
{
    var currentdatetime = DateTime.Now;
    Console.WriteLine($"{currentdatetime.Hour}:{currentdatetime.Minute}:{currentdatetime.Second}");
    Console.WriteLine("What Do You Wish To Do? 1. Heal, 2. Go to store, 3. Fight, 4. Gamble. (Answer with numbers!)");
    string ac = Console.ReadLine();
    Console.Clear();
    int Ec = 0;
    int.TryParse(ac, out Ec);

    if (Ec == 1)
    {
        Console.Clear();
        int heal = gen.Next(3, 20);
        p.hp += heal;
        Console.WriteLine($"You gained {heal} int health, you now have {p.hp}/100 int health");
    }
    else if (Ec == 2)
    {
        Console.WriteLine("What do you want to buy? (answer in numbers!)");
        for (int i = 0; i < ica.armours.Count + ica.weapons.Count; i++)
        {
            if (i == 0)
            {
                Console.WriteLine("Armours:");
            }
            if (i < ica.armours.Count)
            {
                Console.WriteLine($"{i + 1}.  {ica.armours[i].name}, ${ica.armours[i].price}, Protection: {ica.armours[i].strength}");
            }
            if (i == ica.armours.Count)
            {
                Console.WriteLine("Weapons:");
            }
            if (i >= ica.armours.Count)
            {
                Console.WriteLine($"{i + 1}.  {ica.weapons[i - ica.armours.Count].name}, ${ica.weapons[i - ica.armours.Count].price}, Strength: {ica.weapons[i - ica.armours.Count].strength}, Durability: {ica.weapons[i - ica.armours.Count].durability}");
            }
        }
        string bc = Console.ReadLine();
        int buyChoise;
        int.TryParse(bc, out buyChoise);
        for (int i = 0; i < ica.armours.Count + ica.weapons.Count; i++)
        {
            if (buyChoise <= ica.armours.Count)
            {
                if (i + 1 == buyChoise)
                {
                    p.cash -= ica.armours[i].price;
                    if (p.cash < 0)
                    {
                        p.cash += ica.armours[i].price;
                        Console.WriteLine("That's to expensive!");
                    }
                    else
                    {
                        p.wearing.Add(ica.armours[i]);
                        Console.WriteLine($"You bought {ica.armours[i].name}");
                    }
                }
            }
            else if (buyChoise > ica.armours.Count)
            {
                if (i + 1 == buyChoise)
                {
                    p.cash -= ica.weapons[i - ica.armours.Count].price;
                    if (p.cash < 0)
                    {
                        p.cash += ica.weapons[i - ica.armours.Count].price;
                        Console.WriteLine("That's to expensive!");
                    }
                    else
                    {
                        p.tools.Add(ica.weapons[i - ica.armours.Count]);
                        Console.WriteLine($"You bought {ica.weapons[i - ica.armours.Count].name}");
                    }
                }
            }
        }
        Console.ReadLine();
    }
    else if (Ec == 3)
    {
        Console.BackgroundColor = ConsoleColor.Red;
        int F = gen.Next(fighters.Fighters.Count);
        Console.WriteLine($"You are fighting {fighters.Fighters[F].name}");
        Console.WriteLine("They are wearing:");
        for (int i = 0; i < fighters.Fighters[F].armours.Count; i++)
        {
            Console.WriteLine($"{fighters.Fighters[F].armours[i].name}, Strength: {fighters.Fighters[F].armours[i].strength}");
        }
        Console.WriteLine("(Press enter to continue!)");
        Console.ReadLine();
        while (fighters.Fighters[F].health > 0 && p.hp > 0)
        {
            Console.Clear();
            Console.WriteLine("What do you wish to do? 1. Attack, 2. Defend. (Answer with 1, or 2)");
            string fc = Console.ReadLine();
            int.TryParse(fc, out int choise);
            int oc = gen.Next(1, 3);
            int ps = gen.Next(1, 3);
            int os = gen.Next(1, 3);
            if (choise == 2)
            {
                if (oc == 1)
                {
                    Console.WriteLine($"{fighters.Fighters[F].name} Attacked but you defended");
                }
                if (oc == 2)
                {
                    Console.WriteLine($"You both defended");
                }
            }
            else if (choise == 1)
            {
                if (ps == 1)
                {
                    if (oc == 1)
                    {
                        if (os == 1)
                        {
                            Console.WriteLine($"You both attacked and hit!");
                            p.hp -= fighters.Fighters[F].strength;
                            fighters.Fighters[F].health -= p.strength;
                        }
                        if (os == 2)
                        {
                            Console.WriteLine($"You both attacked but only you hit!");
                            fighters.Fighters[F].health -= p.strength;
                        }
                    }
                    if (oc == 2)
                    {
                        Console.WriteLine($"{fighters.Fighters[F].name} defended!");
                    }
                }
                if (ps == 2)
                {
                    if (oc == 1)
                    {
                        if (os == 1)
                        {
                            Console.WriteLine($"You both attacked but you missed and {fighters.Fighters[F].name} hit!");
                            p.hp -= fighters.Fighters[F].strength;
                        }
                        if (os == 2)
                        {
                            Console.WriteLine("You both missed");
                        }
                    }
                }
            }
            Console.WriteLine($"You have {p.hp} in health, and {fighters.Fighters[F].name} has {fighters.Fighters[F].health} in health! press enter to continue!");
            Console.ReadLine();
        }
    }
}



Console.ReadLine();