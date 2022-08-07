// Напишите метод(ы), которай задаёт массив из 8 элементов и 
//выводит их на экран.
void Massive()
{
  int[]array=new int[8];
  Random rnd=new Random();
  for (int i=0;i<array.Length;i=i+1)
  { 
    array[i]=rnd.Next(1,101);
    if(i==array.Length-1)
    {
     Console.Write(array[i]+" ");   
    }
    else 
     Console.Write(array[i]+","); 
       
  }
}
Massive();




