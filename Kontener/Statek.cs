namespace Kontener;

public class Statek
{
    public static HashSet<Statek> statki = new HashSet<Statek>();
    public HashSet<Kontener> kontenery { get; set; }
    private static int ucounter = 0;
    
    public double predkosc { get; set; }
    public int ladownosc { get; set; }
    public double maksymalnaMasaKontenerow { get; set; }
    public double masaKontenerow { get; set; }
    public int numerStatku { get; set; }

    public Statek(double predkosc, int ladownosc, double maksymalnaMasaKontenerow)
    {
        ucounter++;
        kontenery = new HashSet<Kontener>();
        this.predkosc = predkosc;
        this.ladownosc = ladownosc;
        this.maksymalnaMasaKontenerow = maksymalnaMasaKontenerow;
        masaKontenerow = 0;
        statki.Add(this);
        numerStatku = ucounter;
    }

    public void ZaladowanieKontenera(Kontener kontener)
    {
        if (masaKontenerow + kontener.masaCalkowita > maksymalnaMasaKontenerow * 1000 || kontenery.Count + 1 > ladownosc)
        {
            Console.WriteLine("Nie mozna zaladowac kontenera na statek!");
        }
        else
        {
            kontenery.Add(kontener);
            masaKontenerow += masaKontenerow + kontener.masaCalkowita;
        }
    }

    public void ZaladowanieKontenera(List<Kontener> konteneryDoZaladowania)
    {
        
        double masaKonterowDoZaladowania = 0;
        foreach (Kontener k in konteneryDoZaladowania)
        {
            masaKonterowDoZaladowania += k.masaCalkowita;
        }

        if (masaKontenerow + masaKonterowDoZaladowania > maksymalnaMasaKontenerow * 1000 || konteneryDoZaladowania.Count + kontenery.Count > ladownosc)
        {
            Console.WriteLine("Kontenery nie sa mozliwe do zaladowania");
        }
        else
        {
            foreach(Kontener k in konteneryDoZaladowania)
            {
                kontenery.Add(k);
                masaKontenerow += masaKontenerow + k.masaCalkowita;
            }
        }
    }

    public void UsuniecieKonteneraZeStatku(Kontener kontener)
    {
        if (kontenery.Contains(kontener))
        {
            kontenery.Remove(kontener);
        }
        else
        {
            Console.WriteLine("Dany kontener nie znajduje sie na tym statku, usuniecie niemozliwe.");
        }
    }

    public void Przeniesienie(Statek statek, Kontener kontener)
    {
        if (kontenery.Contains(kontener))
        {
            kontenery.Remove(kontener);
            statek.kontenery.Add(kontener);
        }
        else
        {
            Console.WriteLine("Tego kontenera nie ma na tym statku, przeniezienie nie jest mozliwe.");
        }
    }

    public void Zastapienie(string numerSeryjnyKontenera, Kontener kontener)
    {
        bool czyZastapiono = false;
        foreach (Kontener k in kontenery.ToList())
        {
            if (k.numerSeryjny == numerSeryjnyKontenera)
            {
                kontenery.Remove(k);
                kontenery.Add(kontener);
                czyZastapiono = true;
            }
            
        }

        if (czyZastapiono)
        {
            Console.WriteLine("Zastapiono pomyslnie!");
        }
        else
        {
            Console.WriteLine("Nie znaleziono kontenera o tym numerze na tym statku. Zastapienie niepomyslne.");
        }
    }

    public override string ToString()
    {
        string info = $"Statek {numerStatku}: Predkosc - {predkosc}wezlow, Ladownosc - {ladownosc}kontenerow,\n Maksymalna Masa Ladunku - {maksymalnaMasaKontenerow}t \n + Ladunek: ";
        foreach (var kontener in kontenery)
        {
            info += $"\n  - {kontener}";
        }

        return info;
    }
}