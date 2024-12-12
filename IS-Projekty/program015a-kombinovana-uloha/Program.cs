using System.Linq.Expressions;

string again = "a";
        while(again == "a") {
            Console.WriteLine("*****************************************");
            Console.WriteLine("**** Generátor pseudonáhodných čísel ****");
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

            int positive = 0;
            int negative = 0;
            int zero = 0;
            int odd = 0;
            int even = 0;
            int MAX = myArray[0];
            int MIN = myArray[0];
            int posMAX = 0;
            int posMIN = 0;
            for(int i = 0; i < n; i++) { 
            myArray[i] = randomNumber.Next(dm, hm+1);
            Console.Write("{0}; ",myArray[i]);


            if(myArray[i] > 0) 
                positive++;
            else if(myArray[i] < 0) 
                negative++;
            else
                zero++;

            if(myArray[i] % 2 ==0)
            even++;
            else
            odd++;
            }

            for(int i = 1; i < n; i++) {
                if(myArray[i] > MAX) {
                    MAX = myArray[i];
                    posMAX = i;
                }

                if(myArray[i] < MIN) {
                    MIN = myArray[i];
                    posMIN = i;
                }
            }

                Console.WriteLine("\nPočet kladných čísel: {0}, počet záporných čísel: {1}, počet nul: {2}", positive, negative, zero);
                Console.WriteLine("Počet sudých čísel: {0}, počet lichých čísel: {1}", even, odd);
                Console.WriteLine("Maximum: {0}; První pozice v poli: {1}", MAX, posMAX);
                Console.WriteLine("Minimum: {0}; První pozice v poli: {1}", MIN, posMIN);

            // Opakování programu
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
   


        }