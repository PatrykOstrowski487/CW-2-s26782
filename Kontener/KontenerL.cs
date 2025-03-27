namespace Kontener;

public class KontenerL : Kontener, IHazardNotifier
{
    public bool niebezpiecznyLadunek;
    
    public KontenerL(double wysokosc, double masaWlasna, double glebokosc, double maxMasaLadunku, bool niebezpiecznyLadunek)
        : base( wysokosc, masaWlasna, glebokosc, maxMasaLadunku)
    {
        this.niebezpiecznyLadunek = niebezpiecznyLadunek;
        numerSeryjny = numerSeryjny + "L-" + counter;
    }

    public void Zaladowanie(double masaZaladunku)
    {
        if (niebezpiecznyLadunek)
        {
            if (masaLadunku + masaZaladunku > 0.5 * pojemnosc)
            {
                Ostrzezenie("Ladunek przekracza limit zaladunku niebezpiecznego towaru!");
            }
            else
            {
                masaLadunku += masaZaladunku;
                masaCalkowita += masaZaladunku;
                Console.WriteLine("Pomyslnie zaladowano towar!");
            }
        }
        else
        {
            if (masaLadunku + masaZaladunku > 0.9 * pojemnosc)
            {
                Ostrzezenie("Ladunek przekracza limit zaladunku normalnego towaru!");
            }
            else
            {
                masaLadunku += masaZaladunku;
                masaCalkowita += masaZaladunku;
                Console.WriteLine("Pomyslnie zaladowano towar!");
            }
        }
    }

    public void Ostrzezenie(string ostrzezenie)
    {
        Console.WriteLine($"[ALERT] {ostrzezenie} (kontener : {numerSeryjny})");
    }

    public override string ToString()
    {
        return base.ToString() + $", Niebezpieczny Ladunek: {(niebezpiecznyLadunek ? "Tak" : "Nie")}";
    }
    
}