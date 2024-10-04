namespace _3M05sortWstawianie
{
    class Tablica
    {
        private const int N = 50;
        private int[] tablica = new int[N];
        public Tablica()
        {
            Random r = new Random();
            for(int i = 0; i < N; i++) 
                tablica[i] = r.Next(0,101);
            /*
            for(int i = 0;i < N; i++)
            {
                Console.Write($"podaj element {i+1}: ");
                string s = Console.ReadLine();
                tablica[i] = int.Parse(s);
            }
            */
        }
        public void sortujTablice(bool czyMalejaco = true)
        {
            int maks;
            for(int i = 0;i < N;i++)
            {
                if (czyMalejaco)
                    maks = znajdzMaks(i);
                else
                    maks = znajdzMin(i);
                int temp = tablica[maks];
                for(int j = maks ; j >= i+1; j--)
                    tablica[j] = tablica[j-1];
                tablica[i] = temp;
            }

        }
        private int znajdzMin(int n)
        {
            int min = n;
            for (int i = n + 1; i < N; i++)
                if (tablica[i] < tablica[min])
                    min = i;

            return min;
        }
        private int znajdzMaks(int n)
        {
            int maks = n;
            for(int i = n+1; i<N; i++)
                if(tablica[i] > tablica[maks])
                    maks = i;
                  
            return maks;
        }
        public void wypiszTablice()
        {
            foreach(int i in tablica) 
                Console.Write($"{i}, ");
            Console.WriteLine();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Podaj 50 elementów tablicy");
            Tablica tablica = new Tablica();
            Console.WriteLine("tablica nieposortowana:");
            tablica.wypiszTablice();
            Console.WriteLine("tablica posortowana:");
            tablica.sortujTablice();
            tablica.wypiszTablice();
            Console.WriteLine("tablica posortowana:");
            tablica.sortujTablice(false);
            tablica.wypiszTablice();
        }
    }
}
