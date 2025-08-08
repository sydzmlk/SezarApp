using System;
using System.ComponentModel.Design;

while (true)
{
    try
    {
        Menyu();

        string firs = FirstWord();

        if (firs == null)
        {
            Console.WriteLine("Invalid input! No digits or empty input allowed.");
            string answer = Question();

            if (answer == "1")
                continue;
            else if (answer == "2")
                break;
            else
                break;
        }

        //SIFRELEME HISSESI
        Console.WriteLine("How much do you want to slide?");
        string slide = Console.ReadLine();

        if (slide == null || slide.Length == 0 || slide.Any(char.IsLetter))
        {
            Console.WriteLine("The input should be digit!");
            Question();
        }
        else
        {
            int a = Convert.ToInt32(slide);
            string resume = caesar(firs, a);
            Console.WriteLine(resume);
            Question();

        }

    }
    catch (Exception ex)
    {
        Console.WriteLine("Wrong: " + ex.Message);
        Question();
    }

    static void Menyu()
    {
        Console.WriteLine("Hello, you are welcome to Caesar encryption!");
        Console.WriteLine("Please enter the words:");
    }

    static string FirstWord()
    {
        string firstword = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(firstword) || firstword.Any(char.IsDigit))
        {
            return null;
        }
        return firstword;
    }

    //Davam
    static string Question()
    {
        Console.WriteLine("Do you want to continue?");
        Console.WriteLine("1 = Yes");
        Console.WriteLine("2 = No");
        string answer = Console.ReadLine();

        if (answer != "1" && answer != "2")
        {
            throw new Exception("Wrong choice! You must enter 1 or 2.");
        }

        return answer;

    }


    //Esas hisse
    static string caesar(string text, int slide)
    {
        string result = "";

        for (int i = 0; i < text.Length; i++)
        {
            char ch = text[i];
            int value = (int)ch; //ASCII hesablamag

            if (char.IsUpper(ch))
            {
                value += slide;
                if (value > 'Z')
                {
                    value = value - 26;
                }
                result += (char)value;
            }
            else if (char.IsLower(ch))
            {
                value += slide;
                if (value > 'z')
                {
                    value = value - 26;
                }
                result += (char)value;
            }
            else
            {
                result += ch;
            }
        }
        return result;
    }
}
