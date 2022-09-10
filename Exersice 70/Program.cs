// Программа на языке C#
string[] A1 = new string[7] { "123", "23", "hello", "world", "res", "Russia", ":-)" };
string[] A2 = new string[A1.Length];
InitialNewArray(A1, A2);
PrintArray(A2);
void InitialNewArray(string[] A1, string[] A2)
{
    int k = 0;
    for (int i = 0; i < A1.Length; i++)
    {
        if (A1[i].Length <= 3)
        {
            A2[k] = A1[i];
            k++;
        }
    }
}
void PrintArray(string[] A)
{
    for (int i = 0; i < A.Length; i++)
    {
        Console.Write($"{A[i]} " + "  ");
    }
    Console.WriteLine();
}

Console.WriteLine("Hello, World!");
