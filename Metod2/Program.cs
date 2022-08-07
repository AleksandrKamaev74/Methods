//  Напишите метод, которая принимает на вход число и 
//выдаёт сумму цифр в числе.
void Summa()
{
Console.Write("число N:");
int N=Convert.ToInt32(Console.ReadLine());
int res=0;
while(N>0)
{
  int x=N%10;
  N=N/10;
  res=res+x;   
}
  Console.WriteLine("сумма цифр=" +res);
}
Summa();

