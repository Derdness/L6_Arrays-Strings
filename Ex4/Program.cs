/*Задача 4*(не обязательная): Задайте строку, 
состоящую из слов, разделенных пробелами. 
Сформировать строку, в которой слова расположены 
в обратном порядке. В полученной строке слова 
должны быть также разделены пробелами.
*/

using System.Text;

string original = "съешь ещё этих мягких французских булок " + 
                  "да выпей чаю";
string result = String.Empty;

//Сборщики строк для рассматриваемого слова 
//и итоговой строки
StringBuilder word = new StringBuilder();
StringBuilder sentence = new StringBuilder();

//Проходим строку посимвольно, записывая символы
//в текущее слово до тех пор, пока не встретим пробел
foreach(char letter in original)
{
    if(!Char.IsWhiteSpace(letter))
    {
        word.Append(letter);
    }
    else
    {
        //Встретив пробел, вставляем слово в начало строки,
        //очищаем текущее слово
        //и вставляем встреченный пробел в начало строки
        sentence.Insert(0,word);
        word.Clear();
        sentence.Insert(0,letter);
    }
}
//Т.к. строка может закончиться не на пробел,
//вставляем в начало строки последнее слово
sentence.Insert(0,word);

result = sentence.ToString();
Console.WriteLine(original);
Console.WriteLine(result);