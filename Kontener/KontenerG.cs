namespace Kontener;

public class KontenerG : Kontener, IHazardNotifier
{

    public double cisnienie;
    
    public KontenerG(double wysokosc, double masaWlasna, double glebokosc, double maxMasaLadunku, double cisnienie)
        : base(wysokosc, masaWlasna, glebokosc, maxMasaLadunku)
    {
        this.cisnienie = cisnienie;
        numerSeryjny = numerSeryjny + "G-" + counter;
    }

    public void Ostrzezenie(string ostrzezenie)
    {
        Console.WriteLine($"[ALERT] {ostrzezenie} (kontener : {numerSeryjny})");
    }

    public void Oproznianie()
    {
        if (masaLadunku > 0)
        {
            masaCalkowita = masaCalkowita - 0.95 * masaLadunku;
            masaLadunku = 0.05 * masaLadunku;
        }
        else
        {
            Console.WriteLine("Oproznienie nie jest mozliwe, kontener nie zawiera zadnej zawartosci");
        }
    }

    public override string ToString()
    {
        return base.ToString() + $", Cisnienie: {cisnienie}atm";
    }
}