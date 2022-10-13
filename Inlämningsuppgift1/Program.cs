//using static Tshirt;

//public class Tshirt
//{
//    public string motiv;
//    public string material;
//    public int snittbetyg;
//    public int pris;

//    public enum Storlek { XS, S, M, L, XL }
//    public Tshirt(string motiv, string material, int snittbetyg, int pris)
//    {
//        this.motiv = motiv;
//        this.material = material;
//        this.snittbetyg = snittbetyg;
//        this.pris = pris;
//    }



//    public override string ToString()
//    {
//        return "[" + motiv + ", " + storlek + ", " + material + ", " + snittbetyg + "," + pris + "]";
//    }
//}

//public class Example
//{
//    public static void Main()
//    {
//        Tshirt john = new Tshirt("Motiv", "Material", 3, 299);
//        Tshirt sam = new Tshirt("Motiv", "Material", 5, 299);
//        Tshirt roger = new Tshirt("Motiv", "Material", 10, 299);
//        Tshirt hanna = new Tshirt("Motiv", "Material", 8, 299);

//        public record Tshirts(string motiv, Storlek storlek, string material, int snittbetyg, int pris);

//        Tshirts firstTshirt = new Tshirts(Storlek.XS) 

//        List<Tshirt> tshirts = new List<Tshirt>() { john, sam, roger, hanna };

//        tshirts.Sort((x, y) => y.snittbetyg.CompareTo(x.snittbetyg));
//        Console.WriteLine(String.Join(Environment.NewLine, tshirts));
//    }
//}

//Sword original = new Sword(Material.Iron, 5, 0.25f, Gemstone.None);
//Sword fancy = original with { Material = Material.Binarium, Gemstone = Gemstone.Bitstone };
//Sword ultralong = original with { Material = Material.Bronze, Length = 8, Gemstone = Gemstone.Emerald };

//Console.WriteLine(original);
//Console.WriteLine(fancy);
//Console.WriteLine(ultralong);

//public enum Material { Wood, Bronze, Iron, Steel, Binarium }
//public enum Gemstone { Emerald, Amber, Saphhire, Diamond, Bitstone, None }
//public record Sword(Material Material, float Length, float CrossguardWidth, Gemstone Gemstone);

//Random random = new Random();
//Type type = typeof(Material/*, Storlek*/);

//Array values = type.GetEnumValues();

//for (int i = 0; i < 30; i++)
//{
//    int index = random.Next(values.Length);
//    Material material = (Material)values.GetValue(index);
//    //Storlek storlek = (Storlek)values.GetValue(index);


//    Console.WriteLine("Material = {0}", material);
//}


//class MyClass
//{
//    public int ObjectNumber { get; set; }
//    public string SomeVariable { get; set; }
//    public string AnotherVariable { get; set; }
//}

//// You should use keyboard input value for this 
//int objectsToCreate = 10;

//// Create an array to hold all your objects
//MyClass[] myObjects = new MyClass[objectsToCreate];

//for (int i = 0; i < objectsToCreate; i++)
//{
//    // Instantiate a new object, set it's number and
//    // some other properties
//    myObjects[i] = new MyClass()
//    {
//        ObjectNumber = i + 1,
//        SomeVariable = "SomeValue",
//        AnotherVariable = "AnotherValue"
//    };
//}


//public class Example
//{
//    public static void Main()
//    {
//        Tshirt original = new Tshirt(Material.Bomull, Storlek.XS, Motiv.Bildtryck, 5);
//        Tshirt fancy = original with { Material = Material.Siden, Storlek = Storlek.S, Snittbetyg = 10};
//        Tshirt ultralong = original with { Material = Material.Polyester, Storlek = Storlek.M, Motiv = Motiv.Flerfärgad, Snittbetyg = 2 };


//        //for (int i = 0; i < 30; i++)


//        //Console.WriteLine(original);
//        //Console.WriteLine(fancy);
//        //Console.WriteLine(ultralong);

//        List<Tshirt> tshirts = new List<Tshirt>() { original, fancy, ultralong, };

//        tshirts.Sort((x, y) => y.Snittbetyg.CompareTo(x.Snittbetyg));
//        Console.WriteLine(String.Join(Environment.NewLine, tshirts));
//    }
//public enum Material { Bomull, Siden, Polyester, Ull, Jersey }
//    public enum Storlek { XS, S, M, L, XL, XXL }
//    public enum Motiv { Text, Randig, Flerfärgad, Bildtryck }
//    public record Tshirt(Material Material, Storlek Storlek, Motiv Motiv, int Snittbetyg);




//}


//public class Example
//{
//    public static void Main()
//    {
//        Tshirt john = new Tshirt("Motiv", "Material", 3, 299);
//        Tshirt sam = new Tshirt("Motiv", "Material", 5, 299);
//        Tshirt roger = new Tshirt("Motiv", "Material", 10, 299);
//        Tshirt hanna = new Tshirt("Motiv", "Material", 8, 299);

//        public record Tshirts(string motiv, Storlek storlek, string material, int snittbetyg, int pris);

//        Tshirts firstTshirt = new Tshirts(Storlek.XS) 

//        List<Tshirt> tshirts = new List<Tshirt>() { john, sam, roger, hanna };

//        tshirts.Sort((x, y) => y.snittbetyg.CompareTo(x.snittbetyg));
//        Console.WriteLine(String.Join(Environment.NewLine, tshirts));
//    }
//}


//public static void Main(string[] args)
//{
//    Random random = new Random();
//    Type type = typeof(CustomColor);

//    Array values = type.GetEnumValues();
//    //Array values = Enum.GetValues(type);

//    for (int i = 0; i < 10; ++i)
//    {
//        int index = random.Next(values.Length);
//        CustomColor value = (CustomColor)values.GetValue(index);

//        Console.WriteLine(value);
//    }
//}


//public class Items
//{

//    public class Tshirts
//    {
//        public int snittbetyg;

//        private int pris;
//        private class Motiv
//        {

//        }

//        private class Material
//        {

//        }

//        public void SnittbetygMetod(int snittbetyg)
//        {
//            Snittbetyg = snittbetyg;
//        }

//        public int Snittbetyg
//        {
//            get { return snittbetyg; }
//            set
//            {
//                Snittbetyg.Sort((x, y) => y.snittbetyg.CompareTo(x.snittbetyg));
//            }
//        }

//    }
//}

//public class Items
//{


//class Items
//{
//class Mugsg
//{
//    public string Motiv { get; set; }
//    public string Typ { get; set; }
//    public int Snittbetyg { get; set; }
//    public int Pris { get; set; }
//    public Mugsg()
//    {
//        {
//            List<string> Motiv = new List<string> { "Harry Potter", "Djur", "Världens bästa", "Kärlek" };
//            List<string> Typ = new List<string> { "Kaffemugg", "Resemuggar", "Termo", "Ölmugg" };

//            // Important these are outside the loop
//            // so they are only created ONCE.
//            Random random = new Random();
//            List<Mugg> muggList = new List<Mugg>();

//            for (int i = 0; i < 30; i++)
//            {
//                int snittbetyg = random.Next(10, 0);
//                int pris = random.Next(100, 499);
//                int getRdnMotiv = random.Next(Motiv.Count);
//                int getRdnTyp = random.Next(Typ.Count);
//                muggList.Add(new Mugg() { Motiv = Motiv[getRdnMotiv], Typ = Typ[getRdnTyp], Snittbetyg = snittbetyg, Pris = pris });
//            }

//            // Don't sort inside the loop.
//            // Sort after the entire list has been created.
//            List<Mugg> sortByRating = muggList.OrderBy(user => user.Snittbetyg).ToList();
//            int j = 1;
//            foreach (Mugg mugg in sortByRating)
//            {
//                Console.WriteLine($"Mugg {j++}: Motiv = {mugg.Motiv}, Typ = {mugg.Typ}, Snittbetyg = {mugg.Snittbetyg}, Pris = {mugg.Pris}");
//            }
//        }
//    }


//}


//------------------------------------------------------------------------------
//MUGG
//______________________________________________________________________________


namespace items
{
    public class Tshirt
    {
        public string Motiv { get; set; }
        public string Storlek { get; set; }
        public string Material { get; set; }
        public int Snittbetyg { get; set; }
        public int Pris { get; set; }

        public static void Tshirts()
        {
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

            List<Tshirt> sortByRating = tshirtList
                .OrderByDescending(user => user.Snittbetyg)
                .ToList();
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
        public string Motiv { get; set; }
        public string Typ { get; set; }
        public int Snittbetyg { get; set; }
        public int Pris { get; set; }

        public static void Muggar()
        {
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
                        Console.WriteLine(
                            "Butikens information\nVi säljer 30 Tshirts och 30 Muggar\nT-shirtutbud är sorterat efter fallande snittbetygg\nMuggutbud är sorterat efter stigande snittbetyg\n"
                        );
                        Console.WriteLine(
                            "\nVåra adresser\nFaktueringsadress\nGatvägen 1234\nBesöksadress\nVäggatan 4321\n"
                        );
                        break;

                    case "2":
                        Mugg.Muggar();
                        break;

                    case "3":
                        Tshirt.Tshirts();
                        break;

                    case "4":
                        break;

                    default:
                        Console.WriteLine("Du valde inte ett giltligt alternativ, testa igen\n");
                        break;
                }
            }
        }
    }
}