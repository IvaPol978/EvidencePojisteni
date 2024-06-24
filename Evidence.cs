namespace EvidencePojisteni
{
    internal class Evidence
    {
        private NastrojeEvidence nastroje = new NastrojeEvidence();

        public void OtevritEvidenci()
        {
            bool pokracovat = true;
            while (pokracovat)
            {
                //Zobrazení úvodu evidence, možnosti evidence
                UvodniText();

                int volba = int.Parse(Console.ReadLine());

                switch (volba)
                {
                    case 1:
                        VolbaPridej();
                        break;
                    case 2:
                        VolbaVypis();
                        break;
                    case 3:
                        VolbaVyhledej();
                        break;
                    case 4:
                        {
                            pokracovat = false;
                            Console.WriteLine("Ukončíte libovolnou klávesou...");
                        }
                        break;
                    default:
                        Console.WriteLine("Zadali jste neplatnou volbu, zvolte prosím jednu z nabízených možností.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        private void UvodniText()
        {
            Console.Clear();
            Console.WriteLine("---------------------------");
            Console.WriteLine("Evidence pojištěných");
            Console.WriteLine("---------------------------");
            Console.WriteLine();
            Console.WriteLine("Možnosti evidence:");
            Console.WriteLine("1 - Přidat nového pojišteného");
            Console.WriteLine("2 - Vypsat všechny pojištěné");
            Console.WriteLine("3 - Vyhledat pojištěného");
            Console.WriteLine("4 - Konec");
            Console.WriteLine("Zvolte akci:");
        }

        //Ošetření prázdného vstupu
        private string Zadani(string nazevVstupu)
        {
            Console.WriteLine(nazevVstupu);
            string vstup = Console.ReadLine();
            while (string.IsNullOrEmpty(vstup))
            {
                Console.WriteLine("Pole je nutné vyplnit.");
                Zadani(nazevVstupu);
            }
            return vstup;
        }


        private void VolbaPridej()
        {
            //Zadávání údajů od uživatele
            string pridavaneJmeno = Zadani("Zadejte jméno pojištěného");
            string pridavanePrijmeni = Zadani("Zadejte příjmení pojištěného:");
            string pridavaneTelCislo = Zadani("Zadejte telefonní číslo?");
            Console.WriteLine("Zadejte věk:");
            int pridavanyVek = int.Parse(Console.ReadLine());

            //Metoda přidání pojištěnce do seznamu
            nastroje.PridatPojistence(new Pojistenec(pridavaneJmeno, pridavanePrijmeni, pridavaneTelCislo, pridavanyVek));

            //Potvrzení uložení
            Console.WriteLine();
            Console.WriteLine("Data byla uložena. Pokračujte libovolnou klávesou...");
            Console.ReadKey();
        }


        private void VolbaVypis()
        {
            //Metoda vypsání všech pojištěnců v seznamu
            nastroje.VypisPojistence();

            Console.WriteLine("Pokračujte libovolnou klávesou...");
            Console.ReadKey();
        }

        private void VolbaVyhledej()
        {
            //Zadávání jména a příjmení uživatelem
            string hledaneJmeno = Zadani("Zadejte jméno pojištěnce:");
            string hledanePrijmeni = Zadani("Zadejte příjmení pojištěnce");

            //Metoda pro vyhledání a vypsání pojištěnce
            nastroje.NajdiPojistence(hledaneJmeno, hledanePrijmeni);

            Console.WriteLine("Pokračujte libovolnou klávesou...");
            Console.ReadKey();
        }


    }

}

