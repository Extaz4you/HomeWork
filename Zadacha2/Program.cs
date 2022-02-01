            // Найти максимальное число среди 3 чисел
            
            double a = new Random().Next(1,100), b = new Random().Next(1,100), c = new Random().Next(1, 100);
            
                if (a > b && a > c)
                    Console.WriteLine("Nubmer Max = " + a); 
                else if (b > c)
                    Console.WriteLine("Number Max = " + b); 
                else
                    Console.WriteLine("Number Max = " + c); 
            
            Console.ReadLine();