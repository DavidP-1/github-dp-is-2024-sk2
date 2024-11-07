static void Main() {

string again = "a";
        while(again == "a");
            Console.WriteLine("***********************");
            Console.WriteLine("**** Analýza textu ****");
            Console.WriteLine("***********************");
            Console.WriteLine("***** David Pavlů *****");
            Console.WriteLine("***********************");
            Console.WriteLine();

           
            Console.Write("\nZadejte text pro anylýzu: ");
            string myText = Console.ReadLine();
            
            Console.WriteLine();
            Console.WriteLine(myText);
            Console.WriteLine(myText[0]);
            Console.WriteLine(myText.Length);
            Console.WriteLine(myText[myText.Length]-1);

            string samohlasky = "aáeéěiíoóuúůyý";
            string souhlasky = "qwrtzpsdfghjklxcvbnmščřžň";
            string cislice = "0123456789";

            int pocetsam = 0;
            int pocetsou = 0;
            int pocetcis = 0;
            int pocetost = 0;

            foreach(char znak in myText) {
                if(souhlasky.Contains(znak)) {
                    pocetsou++;
                }
                else if(samohlasky.Contains(znak)) {
                    pocetsam++;
                }
                else if(cislice.Contains(znak)) {
                    pocetcis++;
                }
                else pocetost++;
                }


            Console.WriteLine("\nPočet samohlásek: {0}", pocetsam);
            Console.WriteLine("\nPočet souhlásek: {0}", pocetsou);
            Console.WriteLine("\nPočet číslic: {0}", pocetcis);
            Console.WriteLine("\nPočet ostatních: {0}", pocetost);


            // Opakování programu
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
            }

            

            
