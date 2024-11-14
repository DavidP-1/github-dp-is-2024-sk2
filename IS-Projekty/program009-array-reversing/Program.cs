﻿using System.Data;
using System.Linq.Expressions;
using System.Diagnostics;

string again = "a";
        while(again == "a") {
            Console.WriteLine("*****************************************");
            Console.WriteLine("************** Reverze pole *************");
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
            Console.WriteLine("===============\n");

            // deklarace pole
            int[] myArray = new int[n];

            // příprava pro generování náhodných čísel
            Random randomNumber = new Random();

            Console.WriteLine("Náhodná čísla: ");

            for(int i = 0; i < n; i++) { 
            myArray[i] = randomNumber.Next(dm, hm+1);
            Console.Write("{0}; ",myArray[i]);
            }

            for(int i = 0; i < n/2; i++) {
                int tmp =myArray[i];
                myArray[i] = myArray[n-i-1];
                myArray[n-i-1] = tmp;
            }

            Console.WriteLine("\n\nPole po reverzi: ");

            for(int i = 0; i < n; i++) { 
            Console.Write("{0}; ",myArray[i]);
            }


            // Opakování programu
            Console.WriteLine("\nPro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
   


        }