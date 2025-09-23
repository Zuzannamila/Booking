using System.ComponentModel.DataAnnotations;

namespace Booking.Dal.Initialization;

public static class SampleData
{
    // ********** VISITS  *********
    public static List<Visit> Visits => new()
    {
        new() { },
    };

    // ********** CLIENTS *********
    public static List<Client> Clients => new()
    {
        new() { FirstName = "Zuzanna", LastName = "Wrzeszcz", Email = "zuza.mila19@gmail.com" },
        new() { FirstName = "Magdalena", LastName = "Mazur", Email = "magdamila92@gmail.com" },
        new() { FirstName = "Martyna", LastName = "Mila", Email = "martynamila2001@gmail.com" },
        new() { FirstName = "Katarzyna", LastName = "Juchacz", Email = "milakatarzyna@gmail.com" },
        new() { FirstName = "Jadwiga", LastName = "Siuda", Email = "igawrzeszcz@gmail.com" },
        new() { FirstName = "Kaja", LastName = "Wrzeszcz", Email = "kaja@kosmosltd.com" },
        new() { FirstName = "Ewa", LastName = "Kwasniewska", Email = "zuza.mila@onet.pl" },
        new() { FirstName = "Alicja", LastName = "Szyszkowska", Email = "lemilepoznan@gmail.com" },
        new() {FirstName = "Borys", LastName = "Wrzeszcz", Email = "borys.wrzeszcz@gmail.com" }
    };

    // ********** PROFESSIONALS ********
    public static List<OpeningHours> OpeningHours1 => new()
    {
        new() { Day = DayOfWeek.Monday, Start = new TimeSpan(12, 0, 0), End = new TimeSpan(20, 0, 0) },
        new() { Day = DayOfWeek.Tuesday, Start = new TimeSpan(0, 0, 0), End = new TimeSpan(0, 0, 0) },
        new() { Day = DayOfWeek.Wednesday, Start = new TimeSpan(10, 0, 0), End = new TimeSpan(18, 0, 0) },
        new() { Day = DayOfWeek.Thursday, Start = new TimeSpan(12, 0, 0), End = new TimeSpan(20, 0, 0) },
        new() { Day = DayOfWeek.Friday, Start = new TimeSpan(10, 0, 0), End = new TimeSpan(18, 0, 0) },
        new() { Day = DayOfWeek.Saturday, Start = new TimeSpan(10, 0, 0), End = new TimeSpan(15, 0, 0) },
        new() { Day = DayOfWeek.Sunday, Start = new TimeSpan(0, 0, 0), End = new TimeSpan(0, 0, 0) },
    };
    public static List<OpeningHours> OpeningHours2 => new()
    {
        new() { Day = DayOfWeek.Monday, Start = new TimeSpan(9, 0, 0), End = new TimeSpan(17, 0, 0) },
        new() { Day = DayOfWeek.Tuesday, Start = new TimeSpan(9, 0, 0), End = new TimeSpan(17, 0, 0) },
        new() { Day = DayOfWeek.Wednesday, Start = new TimeSpan(8, 0, 0), End = new TimeSpan(16, 0, 0) },
        new() { Day = DayOfWeek.Thursday, Start = new TimeSpan(0, 0, 0), End = new TimeSpan(0, 0, 0) },
        new() { Day = DayOfWeek.Friday, Start = new TimeSpan(8, 0, 0), End = new TimeSpan(16, 0, 0) },
        new() { Day = DayOfWeek.Saturday, Start = new TimeSpan(10, 0, 0), End = new TimeSpan(15, 0, 0) },
        new() { Day = DayOfWeek.Sunday, Start = new TimeSpan(0, 0, 0), End = new TimeSpan(0, 0, 0) },
    };

    public static List<Professional> Professionals => new()
    {
        new() { Id = Guid.NewGuid() , FullName = "Jagoda Siuda", Schedules = OpeningHours1 },
        new() { Id = Guid.NewGuid() , FullName = "Marcelina Kokoszka", Schedules = OpeningHours1 },
        new() { Id = Guid.NewGuid() , FullName = "Kaja Meller", Schedules = OpeningHours1 },
        new() { Id = Guid.NewGuid() , FullName = "Oliwia Bajer", Schedules = OpeningHours1 },
        new() { Id = Guid.NewGuid() , FullName = "Angelika Szłapka", Schedules = OpeningHours1 },
        new() { Id = Guid.NewGuid() , FullName = "Magdalena Wieczorek", Schedules = OpeningHours2 },
        new() { Id = Guid.NewGuid() , FullName = "Milena Gacko", Schedules = OpeningHours2 },
        new() { Id = Guid.NewGuid() , FullName = "Wioletta Wypusz", Schedules = OpeningHours2 },
        new() { Id = Guid.NewGuid() , FullName = "Wiktoria Dziubek", Schedules = OpeningHours2 },
        new() { Id = Guid.NewGuid() , FullName = "Magdalena Gazda", Schedules = OpeningHours2 }
    };  

    // ********** ADDRESSES **********
    public static List<Address> Addresses =>
        new()
    {
        new() { Street = "ul. Bohaterów Bukowskich", Unit = "19", PostalCode = "64-320", City = "Buk", Province = "Wielkopolska", Country = "Polska" },
        new() { Street = "Plac Przemysława", Unit = "1", PostalCode = "64-320", City = "Buk", Province = "Wielkopolska", Country = "Polska" },
        new() { Street = "Plac Stanisława Reszki", Unit = "24", PostalCode = "64-320", City = "Buk", Province = "Wielkopolska", Country = "Polska" },
        new() { Street = "ul. Mury", Unit = "29", PostalCode = "64-320", City = "Buk", Province = "Wielkopolska", Country = "Polska" },
        new() { Street = "ul. Szarych Szeregów", Unit = "8", PostalCode = "64-320", City = "Buk", Province = "Wielkopolska", Country = "Polska" },
        new() { Street = "Plac Stanisława Reszki", Unit = "27", PostalCode = "64-320", City = "Buk", Province = "Wielkopolska", Country = "Polska" },
        new() { Street = "ul. Bohaterów Bukowskich", Unit = "15", PostalCode = "64-320", City = "Buk", Province = "Wielkopolska", Country = "Polska" },
        new() { Street = "Plac Stanislawa Reszki", Unit = "5", PostalCode = "64-320", City = "Buk", Province = "Wielkopolska", Country = "Polska" },
        new() { Street = "ul. Bohaterów Bukowskich", Unit = "18", PostalCode = "64-320", City = "Buk", Province = "Wielkopolska", Country = "Polska" },
        new() { Street = "ul. Bohaterów Bukowskich", Unit = "20", PostalCode = "64-320", City = "Buk", Province = "Wielkopolska", Country = "Polska" }
    };

    // *********** SERVICES *************
    public static List<Service> DryByServices => new()
    {
        new() { Name = "Manicure hybrydowy", CategoryId = 2, SubCategoryId = 12, Price = 160m, Duration = TimeSpan.FromMinutes(85) },
        new() { Name = "Manicure hybrydowy (nowa stylistka)", CategoryId = 2, SubCategoryId = 12, Price = 140m, Duration = TimeSpan.FromMinutes(100) },
        new() { Name = "Manicure hybrydowy (ekspres 1h)", CategoryId = 2, SubCategoryId = 12, Price = 150m, Duration = TimeSpan.FromMinutes(55) },
        new() { Name = "Manicure klasyczny z odżywką", CategoryId = 2, SubCategoryId = 14, Price = 100m, Duration = TimeSpan.FromMinutes(45) },
        new() { Name = "Manicure żelowy na naturalną płytkę (krótkie)", CategoryId = 2, SubCategoryId = 13, Price = 180m, Duration = TimeSpan.FromMinutes(85) },
        new() { Name = "Uzupełnienie żelu – do 3,5 tygodnia (krótkie)", CategoryId = 2, SubCategoryId = 17, Price = 180m, Duration = TimeSpan.FromMinutes(90) },
        new() { Name = "Korekta/Odnowa – powyżej 3,5 tygodnia (krótkie)", CategoryId = 2, SubCategoryId = 17, Price = 190m, Duration = TimeSpan.FromMinutes(100) },
        new() { Name = "Manicure męski", CategoryId = 2, SubCategoryId = 14, Price = 90m,  Duration = TimeSpan.FromMinutes(45) },
        new() { Name = "Pedicure hybrydowy", CategoryId = 2, SubCategoryId = 15, Price = 190m, Duration = TimeSpan.FromMinutes(80) },
        new() { Name = "Pedicure hybrydowy (nowa stylistka)", CategoryId = 2, SubCategoryId = 15, Price = 170m, Duration = TimeSpan.FromMinutes(90) },
        new() { Name = "Pedicure klasyczny z malowaniem", CategoryId = 2, SubCategoryId = 16, Price = 150m, Duration = TimeSpan.FromMinutes(60) },
        new() { Name = "Hybryda na paznokcie (bez opracowania podeszwy stóp)", CategoryId = 2, SubCategoryId = 15, Price = 150m, Duration = TimeSpan.FromMinutes(60) },
    };
    public static List<Service> ShoreditchNailsServices => new()
    {
        new() { Name = "Manicure hybrydowy", CategoryId = 2, SubCategoryId = 12, Price = 240m, Duration = TimeSpan.FromMinutes(75) },
        new() { Name = "Manicure hybrydowy + zdobienia", CategoryId = 2, SubCategoryId = 12, Price = 250m, Duration = TimeSpan.FromMinutes(90) },
        new() { Name = "Uzupełnienie żelu (wyk. u nas) – do 4 tyg.", CategoryId = 2, SubCategoryId = 17, Price = 280m, Duration = TimeSpan.FromMinutes(110) },
        new() { Name = "Uzupełnienie żelu (wyk. u nas) + zdobienia", CategoryId = 2, SubCategoryId = 17, Price = 300m, Duration = TimeSpan.FromMinutes(120) }
    };
    public static List<Service> TheSixServices => new()
    {
        new() { Name = "Manicure klasyczny", CategoryId = 2, SubCategoryId = 14, Price =  65m, Duration = TimeSpan.FromMinutes(45) },
        new() { Name = "Manicure hybrydowy", CategoryId = 2, SubCategoryId = 12, Price = 120m, Duration = TimeSpan.FromMinutes(90) },
        new() { Name = "Manicure hybrydowy – paznokcie długie", CategoryId = 2, SubCategoryId = 12, Price = 130m, Duration = TimeSpan.FromMinutes(90) },
        new() { Name = "Manicure hybrydowy + zdobienia", CategoryId = 2, SubCategoryId = 12, Price = 150m, Duration = TimeSpan.FromMinutes(120) },
        new() { Name = "Uzupełnianie żelem + kolor", CategoryId = 2, SubCategoryId = 17, Price = 150m, Duration = TimeSpan.FromMinutes(135) }
    };

    public static List<Service> HersheSonsServices => new()
    {
        new() { Name = "Cięcie + modelowanie (wł. krótkie) – Top Stylista", CategoryId = 1, SubCategoryId = 6,  Price = 200m, Duration = TimeSpan.FromMinutes(60) },
        new() { Name = "Cięcie + modelowanie (wł. średnie) – Top Stylista", CategoryId = 1, SubCategoryId = 6,  Price = 220m, Duration = TimeSpan.FromMinutes(60) },
        new() { Name = "Cięcie + modelowanie (wł. długie) – Top Stylista", CategoryId = 1, SubCategoryId = 6,  Price = 240m, Duration = TimeSpan.FromMinutes(90) },
        new() { Name = "Cięcie męskie", CategoryId = 1, SubCategoryId = 7,  Price = 140m, Duration = TimeSpan.FromMinutes(60) },
        new() { Name = "Modelowanie włosów (średnie)", CategoryId = 1, SubCategoryId = 9,  Price = 150m, Duration = TimeSpan.FromMinutes(60) },
        new() { Name = "Peeling skóry głowy Kérastase", CategoryId = 1, SubCategoryId = 11, Price =  90m, Duration = TimeSpan.FromMinutes(30) },
        new() { Name = "Rytuał Premiere (Kérastase)", CategoryId = 1, SubCategoryId = 11, Price = 220m, Duration = TimeSpan.FromMinutes(30) }
    };

    public static List<Service> AquaLondonServices => new()
    {
        new() { Name = "Depilacja laserowa – Nogi całe", CategoryId = 5, SubCategoryId = 32, Price = 390m, Duration = TimeSpan.FromMinutes(45) },
        new() { Name = "Depilacja laserowa – Ręce całe", CategoryId = 5, SubCategoryId = 32, Price = 275m, Duration = TimeSpan.FromMinutes(30) },
        new() { Name = "Depilacja laserowa – Bikini całkowite", CategoryId = 5, SubCategoryId = 35, Price = 270m, Duration = TimeSpan.FromMinutes(20) },
        new() { Name = "Depilacja laserowa – Uda", CategoryId = 5, SubCategoryId = 32, Price = 275m, Duration = TimeSpan.FromMinutes(30) },
    };

    public static List<Service> AvedaServices => new()
    {
        new() { Name = "Lifting rzęs", CategoryId = 3, SubCategoryId = 21, Price = 160m, Duration = TimeSpan.FromMinutes(90) }, 
        new() { Name = "Przedłużanie rzęs 1:1 (Express / TOP Stylistka)", CategoryId = 3, SubCategoryId = 22, Price = 140m, Duration = TimeSpan.FromMinutes(60) },
        new() { Name = "Przedłużanie rzęs 2D/3D (stylizacja)", CategoryId = 3, SubCategoryId = 23, Price = 220m, Duration = TimeSpan.FromMinutes(120) }
    };
    public static List<Service> CowshedServices => new()
    {
        new() { Name = "Depilacja laserowa – Bikini klasyczne", CategoryId = 5, SubCategoryId = 34, Price = 140m, Duration = TimeSpan.FromMinutes(30) },
        new() { Name = "Depilacja laserowa – Bikini głębokie", CategoryId = 5, SubCategoryId = 35, Price = 190m, Duration = TimeSpan.FromMinutes(30) },
        new() { Name = "Depilacja laserowa – Łydki", CategoryId = 5, SubCategoryId = 32, Price = 150m, Duration = TimeSpan.FromMinutes(30) },
        new() { Name = "Depilacja laserowa – Uda", CategoryId = 5, SubCategoryId = 32, Price = 190m, Duration = TimeSpan.FromMinutes(40) },
        new() { Name = "Depilacja laserowa – Całe nogi", CategoryId = 5, SubCategoryId = 32, Price = 250m, Duration = TimeSpan.FromMinutes(60) },
        new() { Name = "Depilacja laserowa – Całe ręce", CategoryId = 5, SubCategoryId = 32, Price = 220m, Duration = TimeSpan.FromMinutes(40) }
    };
    public static List<Service> AmaServices => new()
    {
        new() { Name = "Strzyżenie damskie (końcówki)", CategoryId = 1, SubCategoryId = 6,  Price = 110m, Duration = TimeSpan.FromMinutes(75) },
        new() { Name = "Koloryzacja AirTouch", CategoryId = 1, SubCategoryId = 8,  Price = 800m, Duration = TimeSpan.FromMinutes(420) },
        new() { Name = "Tonowanie włosów", CategoryId = 1, SubCategoryId = 8,  Price = 200m, Duration = TimeSpan.FromMinutes(90) },
        new() { Name = "Laminacja brwi + farbowanie i regulacja", CategoryId = 3, SubCategoryId = 18, Price = 150m, Duration = TimeSpan.FromMinutes(60) },
        new() { Name = "Farbowanie + regulacja brwi", CategoryId = 3, SubCategoryId = 19, Price =  90m, Duration = TimeSpan.FromMinutes(50) },
        new() { Name = "Regulacja brwi", CategoryId = 3, SubCategoryId = 19, Price =  70m, Duration = TimeSpan.FromMinutes(30) }
    };

    public static List<Service> LarryKingServices => new()
    {
        new() { Name = "Strzyżenie męskie", CategoryId = 1, SubCategoryId = 7,  Price =  90m, Duration = TimeSpan.FromMinutes(45) },
        new() { Name = "Strzyżenie + modelowanie (wł. krótkie)", CategoryId = 1, SubCategoryId = 6,  Price = 150m, Duration = TimeSpan.FromMinutes(60) },
        new() { Name = "Farba + strzyżenie + modelowanie (średnie)", CategoryId = 1, SubCategoryId = 8,  Price = 310m, Duration = TimeSpan.FromMinutes(120) },
        new() { Name = "Sombre + modelowanie (wł. długie)", CategoryId = 1, SubCategoryId = 8,  Price = 320m, Duration = TimeSpan.FromMinutes(150) },
        new() { Name = "Keratynowe prostowanie (wł. średnie)", CategoryId = 1, SubCategoryId = 11, Price = 470m, Duration = TimeSpan.FromMinutes(180) },
        new() { Name = "Botox + modelowanie (wł. średnie)", CategoryId = 1, SubCategoryId = 11, Price = 280m, Duration = TimeSpan.FromMinutes(120) }
    };

    public static List<Service> GiellyGreenServices => new()
    {
        new() { Name = "Strzyżenie damskie + modelowanie", CategoryId = 1, SubCategoryId = 6, Price = 200m, Duration = TimeSpan.FromMinutes(60) },
        new() { Name = "Modelowanie włosów", CategoryId = 1, SubCategoryId = 9, Price = 150m, Duration = TimeSpan.FromMinutes(60) },
        new() { Name = "Koloryzacja jednolita", CategoryId = 1, SubCategoryId = 8, Price = 450m, Duration = TimeSpan.FromMinutes(120) },
        new() { Name = "Sombre/Balayage/Handtouch", CategoryId = 1, SubCategoryId = 8, Price = 700m, Duration = TimeSpan.FromMinutes(210) },
        new() { Name = "Tonowanie + modelowanie", CategoryId = 1, SubCategoryId = 8, Price = 350m, Duration = TimeSpan.FromMinutes(90) }
    };

    // *********** SERVICE CATEGORIES *************
    public static List<ServiceCategory> ServiceCategories => new()
    {
        new() { Id = 1, Name = "Fryzjer", SubCategories = ServiceSubCategories1 },
        new() { Id = 2, Name = "Paznokcie", SubCategories = ServiceSubCategories2 },
        new() { Id = 3, Name = "Brwi i rzęsy", SubCategories = ServiceSubCategories3 },
        new() { Id = 4, Name = "Makijaż", SubCategories = ServiceSubCategories4 },
        new() { Id = 5, Name = "Depilacja", SubCategories = ServiceSubCategories5 },
    };

    public static List<ServiceSubCategory> ServiceSubCategories1 => new()
    {
        new() { Id = 6, Name = "Strzyżenie damskie", CategoryId = 1 },
        new() { Id = 7, Name = "Strzyżenie meskie", CategoryId = 1 },
        new() { Id = 8, Name = "Koloryzacja", CategoryId = 1 },
        new() { Id = 9, Name = "Modelowanie i stylizacja", CategoryId = 1 },
        new() { Id = 10, Name = "Upięcia okolicznościowe", CategoryId = 1 },
        new() { Id = 11, Name = "Pielęgnacja", CategoryId = 1 }
    };
    public static List<ServiceSubCategory> ServiceSubCategories2 => new()
    {
        new() { Id = 12, Name = "Manicure hybrydowy", CategoryId = 2 },
        new() { Id = 13, Name = "Manicure żelowy", CategoryId = 2 },
        new() { Id = 14, Name = "Manicure klasyczny", CategoryId = 2 },
        new() { Id = 15, Name = "Pedicure hybrydowy", CategoryId = 2 },
        new() { Id = 16, Name = "Pedicure klasyczny", CategoryId = 2 },
        new() { Id = 17, Name = "Uzupełnienie żel", CategoryId = 2 }
    };
    public static List<ServiceSubCategory> ServiceSubCategories3 => new()
    {
        new() { Id = 18, Name = "Laminacja brwi", CategoryId = 3 },
        new() { Id = 19, Name = "henna/koloryzacja + regulacja", CategoryId = 3 },
        new() { Id = 20, Name = "Architektura i geometria brwi", CategoryId = 3 },
        new() { Id = 21, Name = "Lifting rzęs", CategoryId = 3 },
        new() { Id = 22, Name = "Przedlużanie rzęs 1:1", CategoryId = 3 },
        new() { Id = 23, Name = "Przedłużanie rzęs 2D/3D/mega volume", CategoryId = 3 }
    };
    public static List<ServiceSubCategory> ServiceSubCategories4 => new()
    {
        new() { Id = 24, Name = "Makijaż dzienny", CategoryId = 4 },
        new() { Id = 25, Name = "Makijaż wieczorowy", CategoryId = 4 },
        new() { Id = 26, Name = "Makijaż okolicznościowy", CategoryId = 4 },
        new() { Id = 27, Name = "Makijaż ślubny", CategoryId = 4 }
    };
    public static List<ServiceSubCategory> ServiceSubCategories5 => new()
    {
        new() { Id = 28, Name = "Wosk - nogi całe/łydki/uda", CategoryId = 5 },
        new() { Id = 29, Name = "Wosk - pachy", CategoryId = 5 },
        new() { Id = 30, Name = "Wosk - bikini klasyczne", CategoryId = 5 },
        new() { Id = 31, Name = "Wosk - bikini głębokie", CategoryId = 5 },
        new() { Id = 32, Name = "Depilacja laserowa - nogi całe/łydki/pachy", CategoryId = 5 },
        new() { Id = 33, Name = "Depilacja laserowa - pachy", CategoryId = 5 },
        new() { Id = 34, Name = "Depilacja laserowa - bikini klasyczne", CategoryId = 5 },
        new() { Id = 35, Name = "Depilacja laserowa - bikini głębokie", CategoryId = 5 },
        new() { Id = 36, Name = "Pasta cukrowa - twarz/bikini", CategoryId = 5 }
    };

    // ********** VENUES ************
    public static List<OpeningHours> OpeningHoursOfVenues => new()
    {
        new() { Day = DayOfWeek.Monday, Start = new TimeSpan(10, 0, 0), End = new TimeSpan(20, 0, 0) },
        new() { Day = DayOfWeek.Tuesday, Start = new TimeSpan(10, 0, 0), End = new TimeSpan(20, 0, 0) },
        new() { Day = DayOfWeek.Wednesday, Start = new TimeSpan(10, 0, 0), End = new TimeSpan(20, 0, 0) },
        new() { Day = DayOfWeek.Thursday, Start = new TimeSpan(10, 0, 0), End = new TimeSpan(20, 0, 0) },
        new() { Day = DayOfWeek.Friday, Start = new TimeSpan(08, 0, 0), End = new TimeSpan(18, 0, 0) },
        new() { Day = DayOfWeek.Saturday, Start = new TimeSpan(10, 0, 0), End = new TimeSpan(15, 0, 0) },
        new() { Day = DayOfWeek.Sunday, Start = new TimeSpan(0, 0, 0), End = new TimeSpan(0, 0, 0) },
    };
    public static List<Venue> Venues => new()
    {
        new() { Id = Guid.NewGuid(), Name = "Dry By", Latitude = 52.361261, Longitude = 16.513434, AddressInformation = Addresses[8], Services = DryByServices, OpeningHours = OpeningHoursOfVenues },
        new() { Id = Guid.NewGuid(), Name = "Hershesons", Latitude = 52.361050, Longitude = 16.517329, AddressInformation = Addresses[1], Services = HersheSonsServices, OpeningHours = OpeningHoursOfVenues },
        new() { Id = Guid.NewGuid(), Name = "Larry King", Latitude = 52.358287, Longitude = 16.524206, AddressInformation = Addresses[7], Services = LarryKingServices, OpeningHours = OpeningHoursOfVenues },
        new() { Id = Guid.NewGuid(), Name = "Gielly Green", Latitude = 52.357476, Longitude = 16.511665, AddressInformation = Addresses[6], Services = GiellyGreenServices, OpeningHours = OpeningHoursOfVenues },
        new() { Id = Guid.NewGuid(), Name = "The Six", Latitude = 52.352343, Longitude = 16.517343, AddressInformation = Addresses[3], Services = TheSixServices, OpeningHours = OpeningHoursOfVenues },
        new() { Id = Guid.NewGuid(), Name = "Cowshed Spa", Latitude = 52.349889, Longitude = 16.526885, AddressInformation = Addresses[4], Services = CowshedServices, OpeningHours = OpeningHoursOfVenues },
        new() { Id = Guid.NewGuid(), Name = "AMA", Latitude = 52.359044, Longitude = 16.522915, AddressInformation = Addresses[5], Services = AmaServices, OpeningHours = OpeningHoursOfVenues },
        new() { Id = Guid.NewGuid(), Name = "Agua London", Latitude = 52.356893, Longitude = 16.510765, AddressInformation = Addresses[9], Services = AquaLondonServices, OpeningHours = OpeningHoursOfVenues },
        new() { Id = Guid.NewGuid(), Name = "Aveda Lifestyle Salon and Spa", Latitude = 52.359149, Longitude = 16.521900, AddressInformation = Addresses[2], Services = AvedaServices },
        new() { Id = Guid.NewGuid(), Name = "Shoreditch Nails", Latitude = 52.355673, Longitude = 16.512809, AddressInformation = Addresses[0], Services = ShoreditchNailsServices },
    };
}
