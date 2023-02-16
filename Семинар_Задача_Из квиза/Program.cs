int[] arr = { 1,2,3,4,5 };
int i = 0;
while (i < arr.Length)
{
    arr[i] *= i * 2;
    Console.WriteLine($"i = {i}");
    Console.WriteLine($"arr i = {arr[i]}");
    Console.WriteLine($"arr[i++] = {arr[i++]}");
    Console.WriteLine($"i++ = {i++}");
}
