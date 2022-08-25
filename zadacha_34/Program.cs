int[] numbers = new int[10];

static void FillArray (int [] array, int min,int max);
{
      for(int i = 0;i < array.Length;i++)
      {
      int array[i] = new Random().Next(1,10);
      }
}
void WriteArray(int[]array)
{
      for(int i = 0;i < array.Length;i++)
            {
             Console.Write(array[i]+ " ");
            }
      Console.WriteLine();
}
int even (int[]array)
{
      int quantity = 0;
      for(int i = 0;i < array.Length;i++)
      {
            if(array[i] % 2 == 1)
            {
                  quantity++;
            }
      }
      return quantity;
}

FillArray(numbers,100,1000);
WriteArray(numbers);
Console.WriteLine();
int quantity = even (numbers);
Console.WriteLine($"количество четных чисел : {even}");
