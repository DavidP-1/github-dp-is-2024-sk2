// CHCI, ABY SE PROGRAM OPAKOVAL PO STISKU KLÁVESY "A"
        string again = "a";
        while(again == "a") {
            // Console.Clear();
            Console.WriteLine("*******************************");
            Console.WriteLine("**** Součet a součin cifer ****");
            Console.WriteLine("*******************************");
            Console.WriteLine("********* David Pavlů *********");
            Console.WriteLine("*******************************");
            Console.WriteLine();

            // Vstup od uživatel - lepší varianta
            Console.WriteLine("Zadejte celé číslo jehož ciferný součet chcete spočítat: ");
            int number;
            while(!int.TryParse(Console.ReadLine(), out number)) {
                Console.Write("Nezadali jste celé číslo. Zadejte celé číslo: ");
            }

            // výpis vtupní hodnoty
            Console.WriteLine("\n\n===========================");
            Console.WriteLine("Uživatel zadal: {0}", number);
            Console.WriteLine("===========================\n\n");


            int suma = 0;
            int multi = 1;
            int numberbackup = number;
            int digit;

            // Pokud je číslo záporn, tak mínus odstraníme
            if (number <0) {
                number = - number;
            }

            while(number >= 10) {
                digit = number % 10;  // % operátor modulo
                number = (number - digit) / 10;
                Console.WriteLine("Digit = {0}", digit);
                suma = suma + digit;
                multi = multi * digit;
            }
            Console.WriteLine("Digit = {0}", number);
            suma = suma + number;
            multi = multi * number;

            Console.WriteLine("\n\nSoučet cifer čísla {0} je {1}", numberbackup, suma);
            Console.WriteLine("Součin cifer čísla {0} je {1}\n\n", numberbackup, multi);

            // Opakování programu
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }