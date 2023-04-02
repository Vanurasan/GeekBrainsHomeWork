double[] cords = new double[6];
            string[] cordsnames = new string[] { "x1", "y1", "z1", "x2", "y2", "z2" };
            // Получиться таблица координат строки = точки
            Console.WriteLine("Введите:");
            for (int i = 0; i<6; i++) 
            {
                Console.Write(cordsnames[i] + ":");
                cords[i] = Convert.ToDouble(Console.ReadLine());
            }

            double distance = Math.Sqrt(Math.Pow(cords[3] - cords[0], 2) + Math.Pow(cords[4] - cords[1], 2) + Math.Pow(cords[5] - cords[2], 2));
            Console.WriteLine(distance);