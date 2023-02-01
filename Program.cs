// Задача 1
// Console.Write("Input number N: ");
// int N = int.Parse(Console.ReadLine()!);
// if(N >= 1)
//     Console.WriteLine(PrintNumbersRec(N,1));
// else
//     Console.WriteLine("Number must be greater than one!!");

// Задача 2
// Console.Write("Input number M: ");
// int M = int.Parse(Console.ReadLine()!);
// Console.Write("Input number N: ");
// int N = int.Parse(Console.ReadLine()!);
// if(M <= N) 
// {
//     int sum = NumSumRec(M,N);
//     Console.WriteLine($"The sum is {sum}");
// }
// else 
//     Console.WriteLine("M must be less than N!");

// Задача 3
Console.Write("Input number N: ");
int N = int.Parse(Console.ReadLine()!);
Console.Write("Input number M: ");
int M = int.Parse(Console.ReadLine()!);
if(N >= 0 && M >= 0) 
{
    // int sum = NumSumRec(M,N);
    Console.WriteLine($"The value of the Ackerman function is {Ackerman(N,M)}");
}
else 
    Console.WriteLine("Numbers must be greater than 0!!");

// ---------------Methods----------------
string PrintNumbersRec(int start, int end)
{
    if(start == end) return start.ToString();
    return (start + ", " + PrintNumbersRec(start - 1, end));
}

int NumSumRec(int a, int b)
{
    int res = a;
    if(a == b) return a;
    return (res += NumSumRec(a+1, b));
}

int Ackerman(int n, int m)
{
    if(n == 0) return m + 1;
    else if(m == 0) return(Ackerman(n - 1, 1));
    else return(Ackerman(n - 1, Ackerman(n, m - 1)));
}