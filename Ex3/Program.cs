/*Задача 3: Задайте произвольную строку.
Выясните, является ли она палиндромом.
*/

string palindrome = "А роза упала на лапу Азора";
string notPalindrome = "С новым годом";

Console.Write(palindrome);
Console.Write("\t");
Console.WriteLine(PalindromeCheck(palindrome));

Console.Write(notPalindrome);
Console.Write("\t");
Console.WriteLine(PalindromeCheck(notPalindrome));

/// <summary>
/// Проверка, является ли строка палиндромом.
/// Рассматривает строку без учёта whitespace разделителей
/// и без учёта регистра.
/// </summary>
/// <param name="strRaw">Проверяемая строка.</param>
/// <returns>True - если палиндром, иначе - False</returns>
bool PalindromeCheck(string strRaw)
{   
    bool result = true;
    string str = string.Empty;
    System.Text.StringBuilder sb = new System.Text.StringBuilder();

    //Создаём строку без разделителей в нижнем регистре
    foreach(char letter in strRaw.ToLower())
    {
        if(!Char.IsWhiteSpace(letter))
            sb.Append(letter);
    }
    str = sb.ToString();

    //С обоих концов строки сравниваем символы попарно,
    //если находим несовпадающие - строка не палиндром.
    for(int i=0;i<str.Length/2;i++)
    {   
        if(str[i]!=str[str.Length - 1 - i])
        {
            result = false;
            break;
        }
    }
    
    return result;
}