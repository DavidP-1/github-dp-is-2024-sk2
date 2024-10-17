      // CHCI, ABY SE PROGRAM OPAKOVAL PO STISKU KLÁVESY "A"
        string again = "a";
        while(again == "a") {
            Console.WriteLine("********************");
            Console.WriteLine("***** Obdelník *****");
            Console.WriteLine("********************");
            Console.WriteLine("**** David Pavlů ***");
            Console.WriteLine("********************");
            Console.WriteLine();



            // Vstup od uživatel - lepší varianta
            Console.WriteLine("Zadejte šířku obrazce (celé číslo): ");
            int width;
            while(!int.TryParse(Console.ReadLine(), out width)) {
                Console.Write("Nezadali jste celé číslo. Zadejte celé číslo: ");
            }

              Console.WriteLine("Zadejte výšku obrazce (celé číslo): ");
            int height;
            while(!int.TryParse(Console.ReadLine(), out height)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu celé číslo: ");
            }

            // for(int i = 1; i <=10; i++) {
            //     Console.WriteLine(i);
            // }

            // int j = 1;
            // while(j <= 10) {
            //     Console.WriteLine(j);
            //     j++;
            // }

            for(int i =1; i <= height ; i++) {
                for(int j=1; j <= width ; j++) {
                    Console.Write("* ");
                    System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100));
                }
                Console.WriteLine();
            }



            // Opakování programu
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }
