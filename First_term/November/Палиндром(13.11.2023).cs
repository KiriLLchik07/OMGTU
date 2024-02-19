using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

class Program
{
    public static bool CheckPolindrom(string text)
    {
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] != text[text.Length - i - 1])
                return false;
        }
        return true;
    }
  
    static void Main()
    {
        string text = Console.ReadLine();
        int MaxLength = 0;

        for (int i = 0; i < text.Length; i++) 
        {
            for(int j = i + 1;j < text.Length; j++) 
            {
                if (CheckPolindrom(text.Substring(i, j - i - 1)))
                {
                    if(MaxLength < j - i)
                    {
                        MaxLength = j - i;
                    }
                }   
            }
        }

        Console.WriteLine($"Наибольшая длина полиндрома: {MaxLength}");
    }

}
