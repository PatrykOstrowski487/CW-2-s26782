namespace Kontener;

public class KontenerC : Kontener
{
    public double temperatura;
    public Produkt produkt;
    
    public KontenerC(double wysokosc, double masaWlasna, double glebokosc, double pojemnosc, Produkt produkt, double temperatura)
        : base(wysokosc, masaWlasna, glebokosc, pojemnosc)
    {
        this.produkt = produkt;
        numerSeryjny = numerSeryjny + "C-" + counter;
        if (temperatura < TemperaturaProduktu.Temperatura[produkt])
        {
            Console.WriteLine("Temperatura produktu, nie moze byc nizsza niz wymagana dla danego produktu. Ustawiam temperature na minimalna temperature wymagana dla tego produktu.");
            this.temperatura = TemperaturaProduktu.Temperatura[produkt];
        }
        else
        {
            this.temperatura = temperatura;
        }
    }

    public void Zaladowanie(Produkt produktDoZaladowania, double ilosc)
    {
        if (produkt != produktDoZaladowania)
        {
            Console.WriteLine("Proboujesz zaladowac inny produkt niz produkt, do ktorego jest przeznaczony kontener");
        }
        else
        {
            Zaladowanie(ilosc);
        }
    }

    public override string ToString()
    {
        return base.ToString() + $", Produkt: {produkt}, Temperatura: {temperatura}";
    }

}