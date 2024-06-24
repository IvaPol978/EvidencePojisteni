namespace EvidencePojisteni
{
    internal class Pojistenec
    {
        public string Jmeno { get; private set; }

        public string Prijmeni { get; private set; }

        public int Vek { get; }

        public DateTime DatumNarozeni { get; }

        public string TelefonCislo { get; }

        public Pojistenec(string jmeno, string prijmeni, string telefonCislo, int vek)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            TelefonCislo = telefonCislo;
            Vek = vek;
        }

        public override string ToString()
        {
            return string.Format($"{Jmeno}\t{Prijmeni}\t{Vek}\t{TelefonCislo}");
        }
    }
}
