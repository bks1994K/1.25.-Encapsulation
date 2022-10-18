using Animals;

AnimalsInZoo[] bears = new AnimalsInZoo[]
    {
    new AnimalsInZoo("bear", "forest", 1000, new []{"fish", "meat"}, true, "Byyyyeer", "Vinni", 50.5, 3),
    new AnimalsInZoo("bear", "forest", 1000, new []{"fish", "meat"}, true, "Byyyyeer", "Puh", 30, 1),
    };

for (int i = 0; i < bears.Length; i++)
{
    bears[i].DoEat(new[] { "fish", "meat", "grass" }, new[] { 10d, 40d, 20d });
    bears[i].DoEat(new[] { "fish", "meat", "grass" }, new[] { 10d, 10d, 20d });
    bears[i].DoSound();
    bears[i].DoPlay();
}

Console.WriteLine();

AnimalsInZoo[] bearsAndCows = new AnimalsInZoo[]
    {
        new AnimalsInZoo("bear", "Misha"),
        new AnimalsInZoo("cow", "Burenka"),
    };
for (int i = 0; i < bearsAndCows.Length; i++)
{
    bearsAndCows[i].DoEat(new[] { "meat", "grass" }, new[] { 30d, 20d });
    bearsAndCows[i].DoSound();
    bearsAndCows[i].DoPlay();
}
