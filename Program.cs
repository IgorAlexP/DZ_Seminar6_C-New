/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */


Console.Write("Введите числа через запятую: ");
string? input = Console.ReadLine();
char splitSymbol = ',';

WriteArray(ParseArray(input, splitSymbol));

int[] ParseArray(string inputNumbers, char split)
{
int numbersCount = 1;
for(int i = 0; i < inputNumbers.Length; i++)
{
if(inputNumbers[i] == split)
numbersCount++;
}
int[] numbers = new int[numbersCount];
int numberIndex = 0;
string subString = "";
for(int i = 0; i < inputNumbers.Length; i++)
{
if(inputNumbers[i] == split)
{
numbers[numberIndex++] = Convert.ToInt32(subString);
subString = "";
}
else
{
subString += inputNumbers[i];
}
}
numbers[numberIndex] = Convert.ToInt32(subString);
return numbers;
}

void WriteArray(int[] array)
{
for(int i = 0; i < array.Length; i++)
{
Console.Write(array[i] + " ");
}
Console.WriteLine();
}
