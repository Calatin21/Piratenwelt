namespace Piratenwelt {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("It's a Pirates World!");
            List<Pirat> pirats = new List<Pirat>();
        
            Pirat standi = new Pirat("Käpt'n Standard");
            Pirat klopp = new Pirat("Kloppo");
            Pirat aufi = new Pirat("Siggi Steht im Weg");
            Pirat abi = new Pirat("Abi Abe");
            Pirat wolfi = new Pirat("Wolfi Rolf");
            Pirat zwischi = new Pirat("Mal hier mal Da");
            Pirat bari = new Pirat("der blaue Klaus");
            Pirat neussi = new Pirat("Biker Joe");
          
            GangContext standard = new GangContext() { Gang = new List<Pirat>()};
            GangContext dortmunder = new GangContext("Dortmunder Gang") { Gang = new List<Pirat>() };
            GangContext aufdem = new GangContext("Auf dem Gang") { Gang = new List<Pirat>() };
            GangContext abgang = new GangContext("Ab Gang") { Gang = new List<Pirat>() };
            GangContext wolfg = new GangContext("Wolf Gang") { Gang = new List<Pirat>() };
            GangContext zwischen = new GangContext("Zwischen Gang") { Gang = new List<Pirat>() };
            GangContext bar = new GangContext("Gang Bar") { Gang = new List<Pirat>() };
            GangContext neusser = new GangContext("Neusser Jungx Gang") { Gang = new List<Pirat>() };

            standard.AddPirat(standi);          
            dortmunder.AddPirat(klopp);          
            aufdem.AddPirat(aufi);
            abgang.AddPirat(abi);
            wolfg.AddPirat(wolfi);
            zwischen.AddPirat(zwischi);
            bar.AddPirat(bari);
            neusser.AddPirat(neussi);
            for (int i = 0; i < 170; i++) {
                if (i < 100) standard.AddPirat(new Pirat());
                else if (i < 110) dortmunder.AddPirat(new Pirat());
                else if (i < 120) aufdem.AddPirat(new Pirat());
                else if (i < 130) abgang.AddPirat(new Pirat());
                else if (i < 140) wolfg.AddPirat(new Pirat());
                else if (i < 150) zwischen.AddPirat(new Pirat());
                else if (i < 160) bar.AddPirat(new Pirat());
                else neusser.AddPirat(new Pirat());
            }
            List<GangContext> banden = new List<GangContext>();
            banden.Add(standard);   
            banden.Add(dortmunder);
            banden.Add(aufdem);
            banden.Add(abgang);
            banden.Add(wolfg);
            banden.Add(zwischen);
            banden.Add(bar);
            banden.Add(neusser);

            foreach (GangContext item in banden) {
                //Console.WriteLine($"Random: {item.Zg}");
                //Console.WriteLine("");
                foreach (Pirat person in item.Gang) {
                    Console.WriteLine($"ID: {person.PiratID}\tName: {person.Name}\tGang: {person.Gang}");
                }
                Console.WriteLine("");
            }
        }
    }
}