// Kobieta poniżej 30 lat
// Ewa, lat 30
// Niepełnoletni mężczyzna

string name = "Ewa";
int age = 28;
bool isWoman = true;

if (isWoman == true && age < 30) 
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 36)
{
    Console.WriteLine("Ewa, lat 36");     
}
else if (isWoman == false && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else
{
    Console.WriteLine("Brak danych");
}