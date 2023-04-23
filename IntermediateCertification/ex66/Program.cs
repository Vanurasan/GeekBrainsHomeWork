int summary = 0;
            void Numbers(int number, int mumber)
            {
                if (number < mumber+1)
                {

                    Numbers(number + 1, mumber);
                    summary = summary + number;
                }
            }

            int N = Convert.ToInt32(Console.ReadLine());
            int M = Convert.ToInt32(Console.ReadLine());

            Numbers(N, M);

            Console.WriteLine(summary);