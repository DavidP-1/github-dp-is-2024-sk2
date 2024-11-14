using System.Data;
using System.Linq.Expressions;
using System.Diagnostics;

string again = "a";
        while(again == "a") {
            Console.WriteLine("*****************************************");
            Console.WriteLine("******* Řazení pomocí bubble sort *******");
            Console.WriteLine("*****************************************");
            Console.WriteLine("************** David Pavlů **************");
            Console.WriteLine("*****************************************");
            Console.WriteLine();



            // Vstup od uživatel - lepší varianta
            Console.WriteLine("Zadejte počet generovaných čísel (celé číslo): ");
            int n;
            while(!int.TryParse(Console.ReadLine(), out n)) {
                Console.Write("Nezadali jste celé číslo. Zadejte celé číslo: ");
            }

            Console.WriteLine("Zadejte dolní mez (celé číslo): ");
            int dm;
            while(!int.TryParse(Console.ReadLine(), out dm)) {
                Console.Write("Nezadali jste celé číslo. Zadejte celé číslo: ");
            }

            Console.WriteLine("Zadejte horní mez (celé číslo): ");
            int hm;
            while(!int.TryParse(Console.ReadLine(), out hm)) {
                Console.Write("Nezadali jste celé číslo. Zadejte celé číslo: ");
            }

            Console.WriteLine("\n\n===============");
            Console.WriteLine("Uživatelský vstup: ");
            Console.WriteLine("Počet čísel: {0}; dolní mez: {1}; horní mez: {2}", n, dm, hm);
            Console.WriteLine("===============\n\n");

            // deklarace pole
            int[] myArray = new int[n];

            // příprava pro generování náhodných čísel
            Random randomNumber = new Random();

            Console.WriteLine("Náhodná čísla: ");

            for(int i = 0; i < n; i++) { 
            myArray[i] = randomNumber.Next(dm, hm+1);
            Console.Write("{0}; ",myArray[i]);
            }

            Stopwatch myStopwatch = new Stopwatch();

            myStopwatch.Start();

            int numberCompare = 0;
            int numberChange = 0;
            for(int i = 0; i < n-1; i++) {
                for(int j = 0; j < n-i-1; j++) {
                    numberCompare++;
                    if(myArray[j] < myArray[j+1]) {
                        int tmp = myArray[j];
                        myArray[j] = myArray[j+1];
                        myArray[j+1] = tmp;
                        numberChange++;

                    }
                }
            }
            myStopwatch.Stop();

            
            Console.WriteLine("\n\nSeřazené pole: ");
            for(int i = 0; i < n; i++) { 
            Console.Write("{0}; ",myArray[i]);
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n\nČas potřebný na seřazení pole algoritmem Bubble sort: {0}", myStopwatch.Elapsed);
            Console.WriteLine("\nPočet porovnání: {0}", numberCompare);
            Console.WriteLine("\nPočet změn: {0}", numberChange);

            Console.ResetColor();

            // Opakování programu
            Console.WriteLine("\nPro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
   


        }