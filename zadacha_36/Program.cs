﻿Console.Write($"Введите количество элементов массива:  ");
int numberElements = Convert.ToInt32(Console.ReadLine());

int RandomNumbers(int numberElements,int min,int max)
{
      int[] randomNumbers = new int[ numberElements];
      int sumElements = 0;
      Console.Write("Массив: "); 

            for(int i = 0;i < numberElements;i++)
            {
                  randomNumbers[i] = new Random().Next(min,max);
                  Console.Write(randomNumbers[i]+ " ");

                  if(i % 2 !=1)
                  {
                        sumElements = sumElements + randomNumbers[i];
                  }
            }
            return sumElements;
      
}
int randomNumbers = RandomNumbers(numberElements,1,10);
Console.WriteLine($"Сумма элементов стоящих на не четных позициях {randomNumbers}");