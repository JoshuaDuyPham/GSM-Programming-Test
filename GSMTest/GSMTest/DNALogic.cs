using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GSMTest
{
    //Holds the methods and logic for the program
    class DNALogic
    {
        //Finds if a sequence is a valid 
        private bool isValidSequence(string input)
        {
            if (Regex.IsMatch(input, @"^[ATGCatcg]+$"))
                return true;
            return false;
        }
        //Create the array containing all of the DNA sequences so that you can match up an ascii value with an index
        private string[] createSequence()
        {
            int count = 0;
            string[] sequences = new string[256];
            //Go though every possible combination
            for (int i = 0; i < 4; i++)
            {
                for (int i1 = 0; i1 < 4; i1++)
                {
                    for (int i2 = 0; i2 < 4; i2++)
                    {
                        for (int i3 = 0; i3 < 4; i3++)
                        {
                            sequences[count] = i + "" + i1 + "" + i2 + "" + i3;
                            count++;
                        }
                    }
                }
            }
            //Replace the numbers with corrisponding letters in DNA
            for (int i = 0; i < 256; i++)
            {
                sequences[i] = sequences[i].Replace('0', 'A');
                sequences[i] = sequences[i].Replace('1', 'T');
                sequences[i] = sequences[i].Replace('2', 'G');
                sequences[i] = sequences[i].Replace('3', 'C');
            }
            return sequences;
        }

        //Converts a string to DNA
        public string toDNA(string input)
        {
            string output = "";
            string[] seq = new string[256];
            seq = createSequence();
            foreach (char c in input)
            {
                output += seq[(int)c];
            }
            return output;
        }
        //Converts a string to RNA
        public string toRNA(string input)
        {
            return toDNA(input).Replace("T", "U");
        }
        //Converts a DNA to string
        public string findStrand(string input)
        {
            if (input.Length % 4 == 0 && isValidSequence(input))
            {
                string output = "";
                string[] seq = new string[256];
                seq = createSequence();
                //Take every a sequence of every 4 letters and convert it to the # in ascii
                for (int i = 0; i < input.Length/4; i++)
                {
                    string value = input.Substring(i*4, 4);
                    int pos = Array.IndexOf(seq, value);
                    if (pos > -1)
                    {
                        output += (Convert.ToChar(pos)).ToString();
                    }
                }
                return output;
            }
            return "Invalid DNA strand";
        }
        //Converts complementary DNA strand to string
        public string findCompliment(string input)
        {
            if (input.Length % 4 == 0 && isValidSequence(input))
            {
                //Swap the A's and T's, and the C's and G's
                input = Regex.Replace(input, "A|T", (m) => m.Value == "A" ? "T" : "A");
                input = Regex.Replace(input, "C|G", (m) => m.Value == "C" ? "G" : "C");
                return findStrand(input);
            }
            return "Invalid RNA strand";
        }
        //Given two strings, find the longest common subsequence
        public string findLongestSequence(string input1, string input2)
        {
            //Check if the input only contains A,T,C,G
            if (isValidSequence(input1) && isValidSequence(input2))
            {
                int x = input1.Length;
                int y = input2.Length;
                //Create a table to easily find common subsequences
                int[,] L = new int[x + 1, y + 1];

                // Build the table from left to right, top to bottom.
                for (int i = 0; i <= x; i++)
                {
                    for (int j = 0; j <= y; j++)
                    {
                        if (i == 0 || j == 0)
                            L[i, j] = 0;
                        //if letters match, the value on the table gets incremented by one
                        else if (input1[i - 1] == input2[j - 1])
                            L[i, j] = L[i - 1, j - 1] + 1;
                        else
                            L[i, j] = Math.Max(L[i - 1, j], L[i, j - 1]);
                    }
                }

                // Store the index into a temporary varible to print
                int index = L[x, y];
                int temp = index;

                // Array stores the letters that are part of the LCS
                char[] lcs = new char[index + 1];

                // Set the terminating character 
                lcs[index] = '\0';

                // Start from the bottom right corner of the table and find and store each characters into the array 
                int k = x, l = y;
                while (k > 0 && l > 0)
                {
                    // If the current spots are equal, then character is part of LCS 
                    if (input1[k - 1] == input2[l - 1])
                    {
                        // Put current character in the result 
                        lcs[index - 1] = input1[k - 1];

                        // reduce values of i, j and index 
                        k--;
                        l--;
                        index--;
                    }

                    // If not equal, then find the larger number and move in that direction 
                    else if (L[k - 1, l] > L[k, l - 1])
                        k--;
                    else
                        l--;
                }

                //Put the lcs into a string and return it
                String output = "";
                for (int q = 0; q <= temp; q++)
                    output += lcs[q];
                if (temp == 0)
                    output = "No LCS was found";
                return output;
            }
            return "Invalid Input";
        }

    }
}
