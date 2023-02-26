//Zadanie dzien4

string name = "Ewa";
int age = 33;
bool kobieta = true;

if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}

if (age < 18 && kobieta == false)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}

if (kobieta == true && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else
{
    Console.WriteLine("Mężczyzna powyżej 30 lat");
}


