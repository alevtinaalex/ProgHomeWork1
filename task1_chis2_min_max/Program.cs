Console.Write("Введите число a и нажмите Enter ");
int FirstA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b и нажмите Enter ");
int SecondB = Convert.ToInt32(Console.ReadLine());

int max, min;
if (FirstA > SecondB)
 { 
    max = FirstA;
    min = SecondB;
 }
else 
  {  
    max = SecondB;
    min = FirstA;
  }
  Console.Write("Максимальное число ");
  Console.WriteLine(max);
  Console.Write("Минимальное число ");
  Console.WriteLine(min);
