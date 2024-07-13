
using System.ComponentModel.Design;
using System.Numerics;
using System.Text.RegularExpressions;




//For  matching the entire string  "aAbcd-1203-DEFG-321"

/*string pattern = @"^aAbcd-1203-DEFG-321$";

Regex rg = new Regex(pattern);

string GivenPattern = "aAbcd-1203-DEFG-321";

MatchCollection matched = rg.Matches(GivenPattern);

for (int count = 0; count < matched.Count; count++)
    Console.WriteLine(matched[count].Value);*/


/* For matching string with following conditions 
  1. MUST HAVE UPPERCASE
  2.MUST HAVE LOWERCASE  
  3.MUST HAVE @, $
  4. MUST HAVE DIGIT 8,7,3
*/


//positive lookahead assertion. It's a zero-width assertion, it doesn't consume any characters in the string. Instead, it asserts whether a certain pattern can be matched at a particular position in the string without actually consuming characters.
/*string pattern = @"^(?=.*[$])(?=.*[@])(?=.*[A])(?=.*[a])(?=.*[3])(?=.*[7])(?=.*[8])[@$Aa378]+$";

Regex rg = new Regex(pattern);
string givenpattern = "@$Aa378";
Match matched = rg.Match(givenpattern);
if (matched.Success)
    Console.WriteLine($"sucessfully matched {givenpattern}");*/


//Program to test whether the given identifier is valid or not
/*namespace Subina {
    class Program { 
    static void Main(string[] args)
    {
        char[] a = new char[10];
        int flag = 0;
        int i = 0;
        Console.WriteLine("\nEnter an identifier:");
        string input = Console.ReadLine();
        foreach (char c in input)
        {
            a[i] = c;
            i++;

            // Break if we've filled up the char array
            if (i >= a.Length)
                break;
        }
        if (char.IsLetter(a[0]) || a[0] == '-')
        {
            flag = 1;
        }
        else
        {
            Console.WriteLine("not valid identifier");
        }
        while (i < a.Length && a[i] != '\0')
        {
            if (!char.IsDigit(a[i]) && char.IsLetter(a[i]) && a[i] == '-')
            {
                flag = 0;
                break;
            }
            i++;
        }
        if (flag == 1)
        {
            Console.WriteLine("valid identifier");

        }
        else
        {
            Console.WriteLine("Not valid identifier");
        }
        Console.ReadKey();
    }
}
}*/

//Program for lexical analyzer in c

/*using System;
using System.IO;

class Program
{
    static int IsKeyword(string buffer)
    {
        string[] keywords = { "auto", "break", "case", "char", "const", "continue", "default", "do", "double", "else", "enum", "extern", "float", "for", "goto", "if", "int", "long", "register", "return", "short", "signed", "sizeof", "static", "struct", "switch", "typedef", "union", "unsigned", "void", "volatile", "while" };

        foreach (string keyword in keywords)
        {
            if (keyword == buffer)
            {
                return 1; // Keyword found
            }
        }
        return 0; // Keyword not found
    }

    static void Main(string[] args)
    {
        char ch;
        char[] buffer = new char[15];
        char[] operators = { '+', '-', '*', '/', '=', '%' };
        int j = 0;

        try
        {
            StreamReader file = new StreamReader("C:\\projects for learning csharp\\RegEx\\aa.txt.txt"); // Specify full file path here
            while (!file.EndOfStream)
            {
                ch = (char)file.Read();
                foreach (char op in operators)
                {
                    if (ch == op)
                    {
                        Console.WriteLine($"{ch} is an operator");
                    }
                }

                if (char.IsLetterOrDigit(ch))
                {
                    buffer[j++] = ch;
                    if (j >= buffer.Length)
                    {
                        Console.WriteLine("Buffer overflow");
                        j = 0;
                    }
                }
                else if ((ch == ' ' || ch == '\n') && (j != 0))
                {
                    string bufferStr = new string(buffer, 0, j);
                    j = 0;
                    if (IsKeyword(bufferStr) == 1)
                        Console.WriteLine($"{bufferStr} is a keyword");
                    else
                        Console.WriteLine($"{bufferStr} is an identifier");
                }
            }
            file.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error reading the file: " + ex.Message);
        }
    }
}

*/