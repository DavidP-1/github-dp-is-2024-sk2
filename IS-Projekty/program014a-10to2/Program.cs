﻿string again = "a";
        while(again == "a") {
            Console.WriteLine("***********************************");
            Console.WriteLine("**** Převod z 10 do 2 soustavy ****");
            Console.WriteLine("***********************************");
            Console.WriteLine("*********** David Pavlů ***********");
            Console.WriteLine("***********************************");
            Console.WriteLine();



            // Vstup od uživatel - lepší varianta
            Console.WriteLine("Zadejte číslo desítkové soustavy (přirozené číslo): ");
            uint cislo;
            while(!uint.TryParse(Console.ReadLine(), out cislo)) {
                Console.Write("Špatný vstup. Zadejte znovu číslo desítkové soustavy (přirozené číslo): ");
            }

            uint [] myArray = new uint [32];
            uint zaloha = cislo;
            uint zbytek;

            uint i = 0;
            while(cislo > 0) {
                zbytek = cislo % 2;
                cislo = (cislo - zbytek)/2;
                myArray[i] = zbytek;

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Celá část = {0}; zbytek = {1}", cislo, zbytek);
                i++;
            }

            Console.WriteLine("Poslední využitý index pole: {0}", i-1);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nVýsledek: {0}");

            for(uint j = i-1;j>=0; j--) {
                Console.Write("{0}", myArray[j]);
            }

            Console.ForegroundColor = ConsoleColor.White;


            // Opakování programu
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }