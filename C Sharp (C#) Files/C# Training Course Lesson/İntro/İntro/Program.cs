using İntro.Business;
using İntro.Entities;

//variables -> camelCase
string message1 = "Krediler";
int term = 12;
double amount = 100000;
bool isAuthenticated = true;

Console.WriteLine("Hello, World!");
Console.WriteLine(message1);

//condition structure
if (isAuthenticated)
{
    Console.WriteLine("Buton -> Hoşgeldin Ahmet.");
}
else
{
    Console.WriteLine("Buton -> Sisteme giriş yap!");
}

//string[] loans2 = new string[] { 6 };
//loans2[0] = "Kredi 1";

string[] loans1 = {"Kredi 1", "Kredi 2", "Kredi 3", "Kredi 4", "Kredi 5", "Kredi 6"}; //database den gelecek.

     //start        //condition    //increment
for (int i = 0; i < loans1.Length; i++)
{
    Console.WriteLine(loans1[i]);
}

CourseManager courseManager = new CourseManager();
Course[] courses2 = courseManager.GetAll();

for (int i = 0; i <courses2.Length; i++)
{
    Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price);
}

Console.WriteLine("Kod bitti.");

