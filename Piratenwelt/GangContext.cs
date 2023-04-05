namespace Piratenwelt {
    internal class GangContext {
        static int fortlaufend = 1;
        public List<Pirat> Gang { get; set; }
        public int GangContextId { get; set; }
        public string Name { get; set; }
        public Random Zg { get; set; }
        public GangContext() {
            GangContextId = 1;
            Name = "Standardgang";
            Zg = new Random(1);
        }
        public GangContext(String name) {
            fortlaufend++;
            GangContextId = fortlaufend;
            Name = name;
            Zg = new Random(564565476);
        }
        public void AddAnotherPirat() {
            Gang.Add(new Pirat());
        }
        public void AddPirat(Pirat pirat) {
            Gang.Add(pirat);
            pirat.Gang = this.Name;
        }
    }
}
