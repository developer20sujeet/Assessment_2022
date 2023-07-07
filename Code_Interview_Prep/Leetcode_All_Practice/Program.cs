using System.Runtime.CompilerServices;

class Program
{

    static void Main(string[] args)
    {

        string sentence = "aabdsda";

        HashSet<char> seen = new HashSet<char>();
        Dictionary<char, int> counts = new Dictionary<char, int>(); 

        // Convert sentence to lowercase and iterate over each character
        foreach (char currChar in sentence.ToLower().ToCharArray())
        {
            if (char.IsLetter(currChar))
            {
                // Add the character to set
                seen.Add(currChar);
                counts.Add(currChar, 1);
            }
        }

        // Return true if set size is 26 (total number of alphabets)
        //return seen.Count == 26;


    }
}