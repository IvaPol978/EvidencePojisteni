namespace EvidencePojisteni
{
    internal class NastrojeEvidence
    {
        public List<Pojistenec> Pojistenci = new List<Pojistenec>();

        public void PridatPojistence(Pojistenec pojistenec)
        {
            Pojistenci.Add(pojistenec);
        }

        public void VypisPojistence()
        {
            foreach (Pojistenec p in Pojistenci)
            {
                Console.WriteLine(p);
            }
        }

        public void NajdiPojistence(string hledaneJmeno, string hledanePrijmeni)
        {
            var hledani = Pojistenci.Where(p => p.Jmeno == hledaneJmeno && p.Prijmeni == hledanePrijmeni);
            foreach (var p in hledani)
            {
                Console.WriteLine(p);
            }
        }

    }

}
