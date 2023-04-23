void Numbers(int number)
    {
        if (number > 0)
        {
            Console.Write(number+" ");
            Numbers(number - 1);
        }
    }

int N = Convert.ToInt32(Console.ReadLine());
Numbers(N);