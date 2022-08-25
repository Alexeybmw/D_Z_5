double [] arrayRealNumbers = new double[10];
      for(int i = 0;i < arrayRealNumbers.Length;i++)
      {
            arrayRealNumbers[i] = new Random().Next(1,10);
            Console.Write(arrayRealNumbers[i]+ " ");
      }
double maxNumbers = arrayRealNumbers[0];
double minNumbers = arrayRealNumbers[0];
      for(int i = 1;i < arrayRealNumbers.Length;i++)
      {
            if(maxNumbers < arrayRealNumbers[i])
            {
                  maxNumbers = arrayRealNumbers[i];
            }
            if(minNumbers > arrayRealNumbers [i])
            {
                  minNumbers = arrayRealNumbers[i];
            }
      }
double decision = maxNumbers - minNumbers;
Console.WriteLine($"Разница между максимальным ({maxNumbers}) и минимальнымны({minNumbers})элементами : {decision}");