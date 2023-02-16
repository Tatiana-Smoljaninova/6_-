// факториал 5! = 1*2*3*4*5
//              = 5*4!
//              =   4!*3!
//              =      3!*2
// используем РЕКУРСИЮ:

double Factorial (int n) // функция определния факториала
{
    if(n == 1) return 1; // 1! = 1; 0! = 1
    else return n * Factorial(n-1);
}
for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}"); // 1*2*3 = 6
}
