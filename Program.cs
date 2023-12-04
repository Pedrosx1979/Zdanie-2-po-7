// See https://aka.ms/new-console-template for more information


Console.WriteLine("Wprowadź liczbę  : "); //  deklaracja liczby dp zbadnia
int a = Int32.Parse(Console.ReadLine()); // odczytanie liczby dp zbadnia



if (a % 2 == 0)  //sprawdanie warunku parzystości liczby
{
    Console.WriteLine($"Liczba {a} jest parzysta");
    Console.ReadLine();
}
else
{
    Console.WriteLine($"Liczba {a}  nie jest parzysta");
    Console.ReadLine();
};
