//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1
/*
int CutNumber(int number)
{
    int num = number / 10 % 10;

    int result = num;
    return result;
}

Console.Write ("Input a number: ");
int num = Convert.ToInt32 (Console.ReadLine());


int newNum = CutNumber(num);

Console.WriteLine ($"new version of {num} is {newNum}");
_____________________________________________________________
*/

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа.
//645 -> 5
//32679 -> 6
//21 -> -1

/*int CutNumber(int num)

{ int result = -1;
   if (num >=100)
   {
     while (num > 999)
     {
      num = num /10;
     }
     result = num % 10;
   }
   return result;

}


Console.Write ("ВВедите число: ");
int num = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine(CutNumber(num));
*?

_____________________________________________________________________
//Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

/*
bool Day (int number)
{
  bool result = true;

      if (number <=5 || number >7)
  {
    result = false;
  }     

   return result;
   
}  



Console.Write ("ВВедите число от 1 до 7: ");
int num = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine(Day (num));
*/






