int[] array = new int[100];

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
   while (index < length)
   {
        collection[index] = new Random().Next(1, 100);
        index++;
   }
}
FillArray(array);

foreach (int i in array)
{
    Console.WriteLine(i);
}