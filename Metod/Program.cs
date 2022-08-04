// Напишите метод, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
void Stepen ()
{
Console.Write("Число А=");
double A=Convert.ToDouble(Console.ReadLine());
Console.Write("Число B=");
double B=Convert.ToDouble(Console.ReadLine());
double result=Math.Pow(A,B);
Console.WriteLine("A^B="+result);
}    
Stepen ();
