using İntro.Business;
using İntro.DataAccess.Concretes;
using Intro.DataAccess.Concretes;
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

CourseManager courseManager = new (new DapperCourseDal());
List<Course> courses2 = courseManager.GetAll();

for (int i = 0; i <courses2.Count; i++)
{
    Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price);
}

Console.WriteLine("Kod bitti.");

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdentity = "12345678910";
customer1.FirstName = "Ahmet Berkay";
customer1.LastName = "Yılmaz";
customer1.CustomerNumber = "654321";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIdentity = "98765432101";
customer2.FirstName = "Elif";
customer2.LastName = "Çakmak";
customer2.CustomerNumber = "987654";

CorporateCustomer customer3 = new CorporateCustomer(); 
customer3.Id = 3;
customer3.Name = "Kodlamaio";
customer3.CustomerNumber = "654321";
customer3.TaxNumber = "12345678985";

CorporateCustomer customer4 = new CorporateCustomer();
customer4.Id = 4;
customer4.Name = "Adc";
customer4.CustomerNumber = "753159";
customer4.TaxNumber = "75395148625";

int number1 = 10; //20
int number2 = 20;
number1 = number2;
number2 = 50;
Console.WriteLine(number1);

//value types -> int, bool, double...
//reference types -> array, class, interface...

string[] cities1 = { "Ankara", "İstanbul", "İzmir" };
string[] cities2 = { "Bursa", "Bolu", "Diyarbakır" };
cities2 = cities1;
cities1[0] = "Adana";
Console.WriteLine(cities2[0]);
                                //101      //102     //103      //104
BaseCustomer[] customers = { customer1, customer2, customer3, customer4 };

//polymorphism
foreach (BaseCustomer customer in customers)
{
    Console.WriteLine(customer.CustomerNumber);
}

