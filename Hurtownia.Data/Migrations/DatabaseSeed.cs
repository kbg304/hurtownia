using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using Hurtownia.Data.DAO;

namespace Hurtownia.Data.Migrations
{
    public class DatabaseSeed
    {
        private readonly HurtowniaDbContext _context;

        public DatabaseSeed(HurtowniaDbContext context)
        {
            _context = context;
        }


        public void Seed()
        {
            _context.Adresy.AddRange(Adresy);
            _context.SaveChanges();
            
            _context.Klienci.AddRange(Klienci);
            _context.SaveChanges();
            
            _context.Produkty.AddRange(Produkty);
            _context.SaveChanges();
            
            _context.Pracownicy.AddRange(Pracownicy);
            _context.SaveChanges();
            
            _context.Firmy.AddRange(Firmy);
            _context.SaveChanges();
            
            _context.Faktury.AddRange(Faktury);
            _context.SaveChanges();
            
            _context.Pozycje.AddRange(Pozycje);
            _context.SaveChanges();
            
            _context.Zamowienia.AddRange(Zamowienia);
            _context.SaveChanges();


        }

        private static List<Adres> Adresy = new List<Adres>()
        {
            new Adres() {Miejscowosc = "Opole", Ulica = "1 Maja", NrDomu = "12", KodPocztowy = "45-068"},
            new Adres()
            {
                Miejscowosc = "Opole", Ulica = "Prószkowska", NrDomu = "2", NrLokalu = "1", KodPocztowy = "45-710"
            },
            new Adres() {Miejscowosc = "Brzeg", Ulica = "Długa", NrDomu = "12", NrLokalu = "4", KodPocztowy = "49-300"},
            new Adres() {Miejscowosc = "Wrocław", Ulica = "Sucha", NrDomu = "65", KodPocztowy = "50-086"},
            new Adres()
            {
                Miejscowosc = "Brzeg", Ulica = "Poprzeczna", NrDomu = "16", NrLokalu = "2", KodPocztowy = "49-300"
            }
        };

        private static List<Klient> Klienci = new List<Klient>
        {
            new Klient() {Imie = "Jan", Nazwisko = "Nowak", Email = "jan.nowak@poczta.pl",NrTel = "534416789", Adres = Adresy[0]},
            new Klient() {Imie = "Janusz",Nazwisko = "Kowalski",Email = "janusz.kowalski@poczta.pl",NrTel = "657897564",Adres = Adresy[1]},
            new Klient() {Imie = "Marek",Nazwisko = "Kaczmarek", Email = "marek.kaczmarek@poczta.pl",NrTel = "787456345",Adres = Adresy[2]},
            new Klient() {Imie = "Andrzej",Nazwisko = "Kowalczyk",Email = "andrzej.kowalczyk@poczta.pl",NrTel = "634234578",Adres = Adresy[3]},
            new Klient() {Imie = "Stanisław",Nazwisko = "Polak",Email = "stanislaw.polak@poczta.pl",NrTel = "758825543",Adres = Adresy[4]},
            new Klient() {Imie= "Adrian", Nazwisko = "Mankiewicz",Email = "adrianke123@gmail.com",NrTel = "123456789",Adres = new Adres(){Miejscowosc = "Krzyzowice",NrDomu = "69",NrLokalu = "4",KodPocztowy = "49-332"}}

        };

        private static List<Kategoria> Kategorie = new List<Kategoria>
        {
            new Kategoria() {NazwaKategorii = "Przewody"},
            new Kategoria() {NazwaKategorii = "Osprzet Elektroinstalacyjny"},
            new Kategoria() {NazwaKategorii = "Oswietlenie"},
            new Kategoria() {NazwaKategorii = "Narzedzia"},
            new Kategoria() {NazwaKategorii = "Zabezpieczenia pradowe"}
        };
        
        private static List<Produkt> Produkty= new List<Produkt>
        {
            new Produkt() {Producent = "TFKable S.A.",Model = "YDYp 3x1,5 750V",Nazwa = "Przewód płaski",CenaNetto = 1.70f,Kategoria =Kategorie[0]},
            new Produkt() {Producent = "TFKable S.A.",Model = "YDYp 3x2,5 750V",Nazwa = "Przewód płaski",CenaNetto = 2.50f,Kategoria =Kategorie[0]},
            new Produkt() {Producent = "Ospel S.A.",Model = "ŁP-3Y/m",Nazwa = "Łącznik schodowy",CenaNetto = 14.00f, Kategoria =Kategorie[1]},
            new Produkt() {Producent = "Legrand",Model = "Cariva 2P+Z",Nazwa = "Gniazdo pojedyncze",CenaNetto = 9.56f,Kategoria =Kategorie[1]},
            new Produkt() {Producent = "Kanlux",Model = "TORIM DLP-50 B-W",Nazwa = "Sufitowa oprawa punktowa",CenaNetto = 125.12f,Kategoria = Kategorie[2]},
            new Produkt() {Producent = "Osram",Model = "Parathom MR11 2,5W-20W",Nazwa = "Żarówka led",CenaNetto = 14.95f,Kategoria = Kategorie[2]},
            new Produkt() {Producent = "Topex",Model = "PH 1000V",Nazwa = "Wkrętak krzyżowy",CenaNetto = 8.36f,Kategoria = Kategorie[3]},
            new Produkt() {Producent = "Knipex",Model = "11 02 160",Nazwa = "Szczypce do ściągania izolacji",CenaNetto = 124.90f,Kategoria = Kategorie[3]},
            new Produkt() {Producent = "Legrand",Model = "P304 4P 100A",Nazwa = "Wyłącznik różnicowoprądowy",CenaNetto = 138.17f,Kategoria = Kategorie[4]},
            new Produkt() {Producent = "Eaton",Model = "CLS6-B16-B",Nazwa = "Wyłącznik nadprądowy",CenaNetto = 6.30f,Kategoria = Kategorie[4]}
        };
        
        private static List<Pracownik> Pracownicy = new List<Pracownik>
        {
            new Pracownik() {Imie = "Adrian",Nazwisko = "Mazurek",Stanowisko = "sprzedawca",PensjaBrutto = 2250.00f,Adres = Adresy[2]},
            new Pracownik() {Imie = "Patryk",Nazwisko = "Adamczyk",Stanowisko = "właściciel",PensjaBrutto = 5400.50f,Adres = Adresy[0]},
            new Pracownik() {Imie = "Mateusz",Nazwisko = "Sikorski",Stanowisko = "dostawca",PensjaBrutto = 3500.12f,Adres = Adresy[1]}
        };

        private static List<Firma> Firmy = new List<Firma>
        {
            new Firma() {Nazwa = "ELPOL",Nip = "7476953241",Regon = "68423658741235",Adres = Adresy[4],Klient = Klienci[0]},
            new Firma() {Nazwa = "Janusz-Pol",Nip = "7576128961",Regon = "63214876424536",Adres = Adresy[3],Klient = Klienci[1]},
            new Firma() {Nazwa = "PHU Bud-Mar",Nip = "7876423425",Regon = "69841357856321",Adres = Adresy[2],Klient = Klienci[2]},
            new Firma() {Nazwa = "Remontex",Nip = "8785695632",Regon = "61475698743654",Adres = Adresy[1],Klient = Klienci[3]},
            new Firma() {Nazwa = "Stan-Pol",Nip = "8486254782",Regon = "62148635784563",Adres = Adresy[0],Klient = Klienci[4]}
        };

        private static List<Faktura> Faktury = new List<Faktura>
        {
            new Faktura() {NumerFaktury = "FV/2018/45",Vat = 23,SposobPlatonosci = "przelew",DataWystawienia = new DateTime(2018,11,3),TerminPlatnosci = new DateTime(2018,11,17),Firma = Firmy[4],Pracownik = Pracownicy[0]},
            new Faktura() {NumerFaktury = "FV/2018/44",Vat = 23,SposobPlatonosci = "gotówka",DataWystawienia = new DateTime(2018,10,25),TerminPlatnosci = new DateTime(2018,11,8),Firma = Firmy[3],Pracownik = Pracownicy[0]},
            new Faktura() {NumerFaktury = "FV/2019/04",Vat = 23,SposobPlatonosci = "gotówka",DataWystawienia = new DateTime(2019,1,5),TerminPlatnosci = new DateTime(2019,1,19),Firma = Firmy[2],Pracownik = Pracownicy[0]},
            new Faktura() {NumerFaktury = "FV/2019/06",Vat = 23,SposobPlatonosci = "przelew",DataWystawienia = new DateTime(2019,1,6),TerminPlatnosci = new DateTime(2019,1,20),Firma = Firmy[1],Pracownik = Pracownicy[0]},
            new Faktura() {NumerFaktury = "FV/2019/10",Vat = 23,SposobPlatonosci = "przelew",DataWystawienia = new DateTime(2019,1/10),TerminPlatnosci = new DateTime(2019,1/24),Firma = Firmy[0],Pracownik = Pracownicy[0]}
        };

        private static List<Pozycja> Pozycje = new List<Pozycja>
        {
            new Pozycja() {Ilosc = 100,Faktura = Faktury[0],Produkt = Produkty[0]},
            new Pozycja() {Ilosc = 100,Faktura = Faktury[0],Produkt = Produkty[1]},
            new Pozycja() {Rabat = 2, Ilosc = 5,Faktura = Faktury[1],Produkt = Produkty[5]},
            new Pozycja() {Rabat = 2, Ilosc = 3,Faktura = Faktury[1],Produkt = Produkty[4]},
            new Pozycja() {Ilosc = 10,Faktura = Faktury[2],Produkt = Produkty[2]},
            new Pozycja() {Ilosc = 12,Faktura = Faktury[2],Produkt = Produkty[3]},
            new Pozycja() {Ilosc = 2,Faktura = Faktury[3],Produkt = Produkty[7]},
            new Pozycja() {Ilosc = 1,Faktura = Faktury[3],Produkt = Produkty[6]},
            new Pozycja() {Ilosc = 3,Faktura = Faktury[4],Produkt = Produkty[8]},
            new Pozycja() {Ilosc = 2, Faktura = Faktury[4],Produkt = Produkty[9]}
        };

        public static List<Zamowienie> Zamowienia = new List<Zamowienie>
        {
            new Zamowienie() {DataZamowieia = new DateTime(2018,11,3),Firma = Firmy[4],Faktura = Faktury[0]},
            new Zamowienie() {DataZamowieia = new DateTime(2018,10,24),Firma = Firmy[3],Faktura = Faktury[1]},
            new Zamowienie() {DataZamowieia = new DateTime(2019,1,4),Firma = Firmy[2],Faktura = Faktury[2]},
            new Zamowienie() {DataZamowieia = new DateTime(2019,1,6),Firma = Firmy[1],Faktura = Faktury[3]},
            new Zamowienie() {DataZamowieia = new DateTime(2019,1,9),Firma = Firmy[0],Faktura = Faktury[4]}
        };


    }
}