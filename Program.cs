namespace Assignment_7._2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsAnagram("rat", "car"));
            Console.WriteLine(IsAnagram("anagram", "nagaram"));
        }

        static bool IsAnagram(string s, string t)
        {
            Dictionary<char, int> frequency = new();
            foreach (var item in s)
            {
                if (frequency.ContainsKey(item))
                    frequency[item]++;
                else
                    frequency.Add(item, 1);
            }
            foreach (var item in t)
            {
                if (frequency.ContainsKey(item))
                    frequency[item]--;
                else
                    return false;
            }
            foreach (var item in frequency)
            {
                if (item.Value != 0)
                    return false;
            }
            return true;
        }
    }
}
