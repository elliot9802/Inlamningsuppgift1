public class Tshirt
{
    //Skapar variablerna och väntar på get och sett alla val som vi sedan ger värden inuti vår tshirts metod
    public string Motiv { get; set; }
    public string Storlek { get; set; }
    public string Material { get; set; }
    public int Snittbetyg { get; set; }
    public int Pris { get; set; }

    public static void Tshirts()
    {
        //Skapar listor för de val T-shirtsen ska ha
        List<string> Motiv = new List<string> { "Randig", "Djur", "Texttryck", "Flerfärgad" };
        List<string> Storlek = new List<string> { "XS", "S", "M", "L", "XL" };
        List<string> Material = new List<string>
        {
            "Bomull",
            "Linne",
            "Manchester",
            "Ull",
            "Jersey"
        };
        Random random = new Random();
        List<Tshirt> tshirtList = new List<Tshirt>();
        //Gör en for loop som skapar 30 stycken t shirts och ger dom random val från listorna jag gjorde ovanför
        for (int i = 0; i < 30; i++)
        {
            int snittbetyg = random.Next(0, 10);
            int pris = random.Next(100, 499);
            int getRdnMotiv = random.Next(Motiv.Count);
            int getRdnStrl = random.Next(Storlek.Count);
            int getRdnMtrl = random.Next(Material.Count);
            tshirtList.Add(
                new Tshirt()
                {
                    Motiv = Motiv[getRdnMotiv],
                    Storlek = Storlek[getRdnStrl],
                    Material = Material[getRdnMtrl],
                    Snittbetyg = snittbetyg,
                    Pris = pris
                }
            );
        }
        //Sorterar t shirt listan av fallande från snittbetygen och skriver ut varje t shirts val
        List<Tshirt> sortByRating = tshirtList.OrderByDescending(user => user.Snittbetyg).ToList();
        int j = 1;
        foreach (Tshirt tshirt in sortByRating)
        {
            Console.WriteLine(
                $"Tshirt {j++}: Motiv = {tshirt.Motiv}, Storlek = {tshirt.Storlek}, Material = {tshirt.Material}, Snittbetyg = {tshirt.Snittbetyg}, Pris = {tshirt.Pris}"
            );
        }
    }
}

public class Mugg
{
    //Skapar variablerna och väntar på get och sett alla val som vi sedan ger värden inuti vår muggar metod
    public string Motiv { get; set; }
    public string Typ { get; set; }
    public int Snittbetyg { get; set; }
    public int Pris { get; set; }

    public static void Muggar()
    {
        //Skapar listor för de val Muggarna ska ha
        List<string> Motiv = new List<string>
        {
            "Harry Potter",
            "Djur",
            "Världens bästa",
            "Kärlek"
        };
        List<string> Typ = new List<string> { "Kaffemugg", "Resemuggar", "Termo", "Ölmugg" };

        Random random = new Random();
        List<Mugg> muggList = new List<Mugg>();
        //Gör en for loop som skapar 30 stycken muggar och ger dom random val från listorna jag gjorde ovanför
        for (int i = 0; i < 30; i++)
        {
            int snittbetyg = random.Next(0, 10);
            int pris = random.Next(100, 499);
            int getRdnMotiv = random.Next(Motiv.Count);
            int getRdnTyp = random.Next(Typ.Count);
            muggList.Add(
                new Mugg()
                {
                    Motiv = Motiv[getRdnMotiv],
                    Typ = Typ[getRdnTyp],
                    Snittbetyg = snittbetyg,
                    Pris = pris
                }
            );
        }
        //Sorterar mugg listan av stigande från snittbetygen och skriver ut varje muggs val
        List<Mugg> sortByRating = muggList.OrderBy(user => user.Snittbetyg).ToList();
        int j = 1;
        foreach (Mugg mugg in sortByRating)
        {
            Console.WriteLine(
                $"Mugg {j++}: Motiv = {mugg.Motiv}, Typ = {mugg.Typ}, Snittbetyg = {mugg.Snittbetyg}, Pris = {mugg.Pris}"
            );
        }
    }
}

public class Program
{
    public static void Main()
    {
        //Gör en while loop för våran switch meny vi skapar för ge användaren en bra meny och välja på i butiken
        string menyVal = "0";
        while (menyVal != "4")
        {
            Console.WriteLine("Välj ett alternativ");
            Console.WriteLine("1. Butiksinformation, adresser");
            Console.WriteLine("2. Muggar");
            Console.WriteLine("3. Tshirts");
            Console.WriteLine("4. Avsluta programmet");
            menyVal = Console.ReadLine();

            Console.WriteLine();
            switch (menyVal)
            {
                case "1":
                    //Clearar konsolen varje gång en av valen laddas för att göra det mer clean för användaren att gå igenom konsolen utan att det är förvirrande från förrgående val
                    Console.Clear();
                    Console.WriteLine(
                        "Butikens information\nVi säljer 30 Tshirts och 30 Muggar\nT-shirtutbud är sorterat efter fallande snittbetygg\nMuggutbud är sorterat efter stigande snittbetyg\n"
                    );
                    Console.WriteLine(
                        "\nVåra adresser\nFaktueringsadress\nGatvägen 1234\nBesöksadress\nVäggatan 4321\n"
                    );
                    break;

                case "2":
                    Console.Clear();
                    Mugg.Muggar();
                    break;

                case "3":
                    Console.Clear();
                    Tshirt.Tshirts();
                    break;

                case "4":
                    Console.Clear();
                    Console.WriteLine("Hejdå");
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Du valde inte ett giltligt alternativ, testa igen\n");
                    break;
            }
        }
    }
}
