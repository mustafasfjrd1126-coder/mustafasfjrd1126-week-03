Creature first = new Creature();
Creature second = new Creature();
Creature third = new Creature();

// TODO: Sett properties til ulike verdier.
// TODO: Skriv verdiene for alle tre objektene.


first.Name = "Mennesker";
first.Species = "kan tenke";
first.Energy = 100;

second.Name = "Dyrer";
second.Species = "kan bevege seg";
second.Energy = 1500;

third.Name = "Planter";
third.Species = "kan fotosyntese";
third.Energy = 15;

first.Ferdigheter(first.Name,first.Species, first.Energy);
second.Ferdigheter(second.Name,second.Species,second.Energy);
third.Ferdigheter(third.Name,third.Species,third.Energy);

// System.Console.WriteLine($"{first.Name} {first.Species} og har {first.Energy} energy");
// System.Console.WriteLine($"{second.Name} {second.Species} og har {second.Energy} energy");
// System.Console.WriteLine($"{third.Name} {third.Species} og har {third.Energy} energy");


