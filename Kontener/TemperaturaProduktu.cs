namespace Kontener;

public static class TemperaturaProduktu
{
    public static readonly Dictionary<Produkt, double> Temperatura = new()
    {
        { Produkt.Banan, 13.3 },
        { Produkt.Czekolada, 18 },
        { Produkt.Ryba, 2 },
        { Produkt.Mieso, -15 },
        { Produkt.Lody, -18 },
        { Produkt.Mrozonka, -30 },
        { Produkt.Ser, 7.2 },
        { Produkt.Kielbasa, 5 },
        { Produkt.Maslo, 20.5 },
        { Produkt.Jajko, 19 }
    };

}