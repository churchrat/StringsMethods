namespace Hideout
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string map = Console.ReadLine();
            bool foundHideout = false;
            int index = -1;
            int count = 0;
            int minimumCount = 0;
            while (foundHideout == false)
            {
                string[] input = Console.ReadLine().Split();
                char searchedCharacter = char.Parse(input[0]);
                minimumCount = int.Parse(input[1]);

                for (int i = 0; i < map.Length; i++)
                {
                    if (map[i] == searchedCharacter)
                    {
                        if (count == 0)
                        {
                            index = i;
                        }
                        count++;
                        if (count >= minimumCount)
                        {
                            foundHideout = true;
                            minimumCount = count;
                        }
                    }
                    else
                    {
                        count = 0;
                    }
                }
            }
            Console.WriteLine($"Hideout found at index {index} and it is with size {minimumCount}!");
        }
    }
}