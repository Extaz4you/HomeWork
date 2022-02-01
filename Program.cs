// найти максимальное и минимальное среди 2 чисел

int NumberA = new Random().Next(1,100);
int NumberB = new Random().Next(1,100);

if(NumberA > NumberB) 
{
    Console.Write(NumberA);
    Console.Write(" Максимальное");
    Console.WriteLine(NumberB);
    Console.WriteLine(" Минимальное");
}
else if (NumberA == NumberB)
{
     Console.Write("Числа равны");
}
else
{
    Console.Write(NumberA);
    Console.Write(" Минимальное");
    Console.Write(NumberB);
    Console.Write(" Максимальное");
}
