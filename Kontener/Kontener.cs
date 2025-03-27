using System.Reflection.Metadata;

namespace Kontener;

public abstract class Kontener
{
    public double masaLadunku { get; set; }
    public double wysokosc { get; set; }
    public double masaWlasna { get; set; }
    public double glebokosc { get; set; }
    protected static int counter = 0;
    public double pojemnosc { get;  set; }
    public string numerSeryjny { get; set; }
    public double masaCalkowita;

    public Kontener(double wysokosc, double masaWlasna, double glebokosc, double pojemnosc)
    {
        masaLadunku = 0;
        this.masaWlasna = masaWlasna;
        this.wysokosc = wysokosc;
        masaLadunku = masaLadunku;
        this.glebokosc = glebokosc;
        this.pojemnosc = pojemnosc;
        masaCalkowita = masaWlasna + masaLadunku;
        numerSeryjny = "KON-";
        counter++;
    }

    public void Oproznianie()
    {
        if (masaLadunku > 0)
        { 
            masaCalkowita = masaCalkowita - masaLadunku;
           masaLadunku = 0;
            Console.WriteLine("Kontener zostal oprozniony!");
        }
        else
        {
            Console.WriteLine("Oproznienie nie jest mozliwe, kontener nie zawiera zadnej zawartosci");
        }
    }

    public void Zaladowanie(double masaZaladunku)
    {
        if (masaLadunku + masaZaladunku > pojemnosc)
        {
            throw new OverfillException("Przekroczyles maksymalna pojemnosc kontenera");
        }

        masaLadunku += masaZaladunku;
        masaCalkowita += masaZaladunku;
        Console.WriteLine("Pomyslnie zaladowano towar!");
    }

    public override string ToString()
    {
        return $"Kontener: {numerSeryjny}, Masa calkowita: {masaCalkowita}kg";
    }
    
}