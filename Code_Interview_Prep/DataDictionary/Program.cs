
using System;
using System.Collections.Generic;
using System.Xml.Linq;

class GFG
{

    // Main Method
    static public void Main()
    {

        //In Dictionary, key must be unique. Duplicate keys are not allowed if you try to use duplicate key then compiler will throw an exception.


        //Add_Show_DicationaryData();

        Remove_elements_Dictionary();

        check_availability_elements_Dictionary();

    }

    private static void check_availability_elements_Dictionary()
    {

        Dictionary<int, string> My_dict = new Dictionary<int, string>();

        My_dict.Add(1123, "Welcome");
        My_dict.Add(1124, "to");
        My_dict.Add(1125, "GeeksforGeeks");

        // Remember it 
        if (My_dict.ContainsKey(1122) == true)
        {
            Console.WriteLine("Key is found...!!");
        }
        else
        {
            Console.WriteLine("Key is not found...!!");
        }
        //Remember it 
        if (My_dict.ContainsValue("GeeksforGeeks") == true)
        {
            Console.WriteLine("Value is found...!!");
        }

        else
        {
            Console.WriteLine("Value is not found...!!");
        }
    }

    private static void Remove_elements_Dictionary()
    {
        Dictionary<int, string> My_dict = new Dictionary<int, string>();

        My_dict.Add(1123, "Welcome");
        My_dict.Add(1124, "to");
        My_dict.Add(1125, "GeeksforGeeks");

        // Before Remove() method
        foreach (KeyValuePair<int, string> ele in My_dict)
        {
            Console.WriteLine("{0} and {1}",
                        ele.Key, ele.Value);
        }

        Console.WriteLine();

        // Using Remove() method 
        My_dict.Remove(1123);

        // After Remove() method
        foreach (KeyValuePair<int, string> ele in My_dict)
        {
            Console.WriteLine("{0} and {1}",
                        ele.Key, ele.Value);
        }
        Console.WriteLine();


        // Using Clear() method
        My_dict.Clear();

        Console.WriteLine("Total number of key/value " +
         "pairs present in My_dict:{0}", My_dict.Count);
    }

    private static void Add_Show_DicationaryData()
    {
        Dictionary<int, string> My_dict1 = new Dictionary<int, string>();

        My_dict1.Add(1123, "Welcome");
        My_dict1.Add(1124, "to");
        My_dict1.Add(1125, "GeeksforGeeks");

        foreach (KeyValuePair<int, string> ele1 in My_dict1)
        {
            Console.WriteLine("{0} and {1}",
                        ele1.Key, ele1.Value);
        }
        Console.WriteLine();

        // Creating another dictionary
        // using Dictionary<TKey,TValue> class
        // adding key/value pairs without
        // using Add method
        Dictionary<string, string> My_dict2 = new Dictionary<string, string>(){
                                {"a.1", "Dog"},
                                {"a.2", "Cat"},
                                {"a.3", "Pig"} };

        foreach (KeyValuePair<string, string> ele2 in My_dict2)
        {
            Console.WriteLine("{0} and {1}", ele2.Key, ele2.Value);
        }
    }

    public static void count_of_character()
    {

        string input = "some input string";
        Dictionary<char, int> charCount = new Dictionary<char, int>();

        foreach (char c in input)
        {
            if (charCount.ContainsKey(c))
            {
                charCount[c]++;
            }
            else
            {
                charCount[c] = 1;
                //charCount.Add(c, 1);
            }
        }

        foreach (var kvp in charCount)
        {
            Console.WriteLine($"Character {kvp.Key}: {kvp.Value} occurrences");
        }

        // Can access directly as below 
        int count = charCount['C'];


    }
}

