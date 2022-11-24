using System;
class Program
{
    static void Main(string[] args)
    {
        
       Queue<int>Q1 = new Queue<int>();
       Queue<int>Q2 = new Queue<int>();
       Queue<int>Q3 = new Queue<int>(); 
       Char Size = 'L';
       Console.Write("Input: ");
       
    while(Size == 'L'||Size == 'M'||Size=='S')
    {
        Size = Char.Parse(Console.ReadLine());
       
        if (Size == 'L' )
        {
            Q1.Push(1);
            int i= 0;
            while (i<2)
            {
                Q2.Push(2);
                i++;
            }
            int x = 0;
            while (x<6)
            {
                Q3.Push(3);
                x++;
            }
        }
        else if(Size == 'M' )
        {
            Q1.Push(2);
            int x = 0;
            while(x<3)
            {
                Q2.Push(3);
                x++;
            }
        }
        else if(Size == 'S' )
        {
            Q1.Push(3);
        }
       Output(Q1,Q2,Q3);
    }

   static void Output(Queue<int> Q1,Queue<int> Q2,Queue<int> Q3)
    {
    Console.Write("Output:"); 
    for(int n =0;n<Q1.GetLength();n++)
    {
    Console.Write("{0}",Q1.Get(n));
    }   
    for(int n =0;n<Q2.GetLength();n++)
    {
    Console.Write("{0}",Q2.Get(n));
    }   
    for(int n =0;n<Q3.GetLength();n++)
    {
    Console.Write("{0}",Q3.Get(n));
    }   
    Console.WriteLine("");
    Console.Write("Input: ");
    }
}
}