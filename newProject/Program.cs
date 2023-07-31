/*Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
 Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
 При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
 Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

void printArr(string[] arr)
{
System.Console.Write("[ ");
  foreach (string result in arr)
  {
    System.Console.Write(result + " ");
  }
System.Console.WriteLine(" ]");
}
int countArr(string[] arr)
{
  int count = 0;
for (int i = 0; i < arr.Length; i++)
{
  if (arr[i].Length <= 3)
  {
    count++;
  }
}
return count;
}


Console.Write("Пожалуйста введите через пробел, строки которые хотите проверить на количество символов: ");
string str = Console.ReadLine();  

string[] strArr = str.Split(' ', StringSplitOptions.RemoveEmptyEntries); 

int count = countArr(strArr);  
if (count == 0)
{
System.Console.WriteLine("[]");
return;
}  

string[] newStrArr = new string[count];

int k = 0;
for (int j = 0; j < strArr.Length; j++)
{
  if (strArr[j].Length <= 3)
  {
    newStrArr[k] = strArr[j];
    k++;
  }
  
}

printArr(newStrArr);
