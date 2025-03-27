using Kontener;


KontenerL pierwszy = new KontenerL(120, 20,40,200, true);
KontenerC drugi = new KontenerC(120, 20,40,200, Produkt.Banan, 16);
KontenerG trzeci = new KontenerG(120, 20,40,200, 30);
KontenerG czwarty = new KontenerG(120, 20,40,200, 30);
// Ladowanie do kontenerow
pierwszy.Zaladowanie(100);
drugi.Zaladowanie(Produkt.Banan, 100);
trzeci.Zaladowanie(100);
czwarty.Zaladowanie(80);
Statek statek2 = new Statek(15, 32, 3);
Statek statek1 = new Statek(15, 32, 3);
// ladowanie na statek pojedynczo
statek1.ZaladowanieKontenera(drugi);
Console.WriteLine(statek1);
// ladowanie na statek lista
statek1.ZaladowanieKontenera([pierwszy,trzeci]);
Console.WriteLine(statek1);
// usuwanie kontenera ze statku
statek1.UsuniecieKonteneraZeStatku(pierwszy);
Console.WriteLine(statek1);
// oproznianie
Console.WriteLine(pierwszy);
pierwszy.Oproznianie();
Console.WriteLine(pierwszy);
// przenoszenie ze statku na statek
statek1.Przeniesienie(statek2, drugi);

Console.WriteLine(statek1);
Console.WriteLine(statek2);



