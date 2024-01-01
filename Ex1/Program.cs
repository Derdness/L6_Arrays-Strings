/*Задача 1: Задайте двумерный массив символов 
(тип char [,]). Создать строку из символов этого массива.
*/

using System.Text;
//Инициализируем двумерный массив символов
char[,] arr = {{'H','e','l','l','o'},{'w','o','r','l','d'}};
//Класс для обработки строк
StringBuilder sb = new StringBuilder();//Класс для обработки строк

string result = String.Empty;
//Пройдём по каждому символу в заданном массиве и
//добавим его к концу построителя? строк
foreach(char letter in arr)
{
    sb.Append(letter);
}
//Получим финальную строку
result = sb.ToString();
Console.WriteLine(result);