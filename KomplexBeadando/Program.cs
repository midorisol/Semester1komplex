namespace KomplexBeadando
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string[] maininput = Console.ReadLine().Split();
            int n = int.Parse(maininput[0]);
            int m = int.Parse(maininput[1]);    
            if (1 >= n && n >= 1000 && 1 >= m && m >= 1000)
            {
                Console.WriteLine("Please, enter a number between 1 and 1000");
                return;
            }
 
            int[,] homerseklet = new int[n, m];
 
            for (int i = 0; i < n; i++)
            {
                string[] row = Console.ReadLine().Split();
                for (int j = 0; j < m; j++)
                {
                    homerseklet[i, j] = int.Parse(row[j]);
                    if (homerseklet[i, j] <= -50 || homerseklet[i, j] >= 50)
                    {
                        Console.WriteLine("Please, enter a number between -50 and 50");
                        return;
                    }
                }
            }

            int legmelegebbatlag = 0;
            int legmelegebbatlagind = 0;

            for (int i = 0; i < n; i++)
            {
                int osszeg = 0;
                for (int j = 0; j < m; j++)
                {
                    osszeg += homerseklet[i, j];
                }
                
                if (osszeg > legmelegebbatlag)
                {
                    legmelegebbatlag = osszeg;
                    legmelegebbatlagind = i + 1;
                }
            }
               
            Console.WriteLine(legmelegebbatlagind);
        }
    }
}