namespace DizideTekrarEdenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan dizi elemanlarını alıriz
            Console.WriteLine("Diziyi girin :"); //bosluk kullan
            string input = Console.ReadLine();
            string[] elements = input.Split(' ');

            // Elemanları ve tekrar sayılarını tutacak bir sözlük oluştururuz -dictionary
            Dictionary<string, int> elementCounts = new Dictionary<string, int>();

            // Elemanları say
            foreach (string element in elements)
            {
                if (elementCounts.ContainsKey(element))
                {
                    elementCounts[element]++;
                }
                else
                {
                    elementCounts[element] = 1;
                }
            }

            // Tekrar eden elemanları ve tekrar sayılarını yazdirir
            Console.WriteLine("Tekrar eden elemanlar ve tekrar sayıları:");
            foreach (KeyValuePair<string, int> kvp in elementCounts)
            {
                if (kvp.Value > 1)
                {
                    Console.WriteLine($"{kvp.Key}: {kvp.Value} kez");
                }
            }
        }
    }
}
