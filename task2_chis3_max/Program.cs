Console.Write("Введите число a и нажмите Enter ");
int FirstA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b и нажмите Enter ");
int SecondB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число c и нажмите Enter ");
int ThirdC = Convert.ToInt32(Console.ReadLine());

int max = FirstA;

if (SecondB > max)
  {  
    max = SecondB;
  }
if ( ThirdC > max)
 {
   max = ThirdC;
 }
  Console.Write("Максимальное число ");
  Console.Write(max); 


