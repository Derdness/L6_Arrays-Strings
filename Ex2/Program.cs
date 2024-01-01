/*Задача 2: Задайте строку, содержащую латинские 
буквы в обоих регистрах. Сформируйте строку, 
в которой все заглавные буквы заменены на строчные.
*/

string original = "A qUiCk BrOwN fOx JuMpS oVeR a LaZy DoG.";
string capital = String.Empty;

//Записываем в новую строку первую с символами в нижнем регистре
capital = original.ToLower();

Console.WriteLine(original);
Console.WriteLine(capital);