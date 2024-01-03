public class Osoba
{
    public string Imie {get; set;}
    public string Nazwisko {get; set;}
    public string Plec {get; set;}
    public DateTime DataUrodzenia {get; set;}

    public Osoba(string imie, string nazwisko, string plec, DateTime dataUrodzenia)
    {
        Imie = imie;
        Nazwisko = nazwisko;
        Plec = plec;
        DataUrodzenia = dataUrodzenia;
    }
    public void WyswietlInfo()
    {
        Console.WriteLine($"Imię: {Imie}");
        Console.WriteLine($"Nazwisko: {Nazwisko}");
        Console.WriteLine($"Płeć: {Plec}");
        Console.WriteLine($"Data urodzenia: {DataUrodzenia.ToShortDateString()}");
    }
}
 
class Program
{
    static void Main()
    {
        Osoba osoba = new Osoba("Karol", "Ostrowski", "Mężczyzna", new DateTime(2005, 03, 24));
        osoba.WyswietlInfo();
        Console.ReadKey();
    }
}