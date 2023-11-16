var name = "Ewa";
var isWoman = true;
var age = 33;


if (name == "Ewa" && age == 33 && isWoman ==true)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (isWoman == true && age <30 )
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (isWoman == false && age <18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}