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
            char[] a = s.ToCharArray();
            char[] b = t.ToCharArray();
            Array.Sort(a);
            Array.Sort(b);
            return new string(a) == new string(b);
        }
    }
}
