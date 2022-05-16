using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment.Pattern_Making
{
    public class SimplePyramidPattern
    {
        //*
        //* *
        //* * *
        //* * * *
        //* * * * *
        public static void Simple_Triangle_pattern(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <=i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }

        //* * * * *
        //* * * *
        //* * *
        //* *
        //*
        public static void Simple_Triangle_pattern_After_180_degree_rotation(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= n; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }

        //*
        //* *
        //* * *
        //* * * *
        //* * * * *
        //* * * *
        //* * *
        //* *
        //*
        public static void Simple_Triangle_pattern_v2(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("");
            }

            // repeate Simple_Triangle_pattern_After_180_degree_rotation
            for (int i = 1; i <= n-1; i++)
            {
                for (int j = i; j <= n-1; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }

        //   *
        //  ***
        // *****
        //*******
        public static void piramid_m1(int num )
        {
            // row 
            for (int i = 1; i <num; i++)
            {
                // put space 
                for (int j = i; j < num-1; j++)
                {
                    Console.Write(" ");
                }
                // put star in each row 
                for (int k = 1;  k<=i; k++)
                {
                    Console.Write("*");

                }
                // put star from second row 
                for (int l = 2; l <= i; l++)
                {
                    Console.Write("*");

                }
                Console.WriteLine("");


            }
        }

        //   *
        //  ***
        // *****
        //*******

        //https://www.youtube.com/watch?v=CDJW5BqiMSY&list=PLCqWuVe6WFLK9ykzGW86zfBh8daCbk952&index=14
        public static void piramid_m2(int num)
        {
            // row
            for (int i = 1; i < num; i++)
            {
                // put space 
                for (int j = i; j < num - 1; j++)
                {
                    Console.Write(" ");
                }

                //2*i-1 used for writing third for loop 
                for (int k = 1; k <= 2*i-1; k++)
                {
                    Console.Write("*");

                }
                //2*i-1 above used for this for loop
                //for (int l = 2; l <= i; l++)
                //{
                //    Console.Write("*");

                //}
                Console.WriteLine("");


            }
        }
    }
}
