using System;

public delegate void PName(int x);

public delegate void SName(int x, int y);

public class Program
{
    static void print(int q) // type 1
    {
        Console.WriteLine(q);
    }
    static void sum(int x, int y)// type 2
    {
        Console.WriteLine(x + y);
    }
    static void mul(int x, int y)// type 2
    {
        Console.WriteLine(x * y);
    }

     static void test(object? sender, EventArgs e)
     {

     }
    static void Main(string[] args)
    {
        EventHandler e = new EventHandler(test);


        PName p = new PName(print); // 2 assgin , refre 


        //calling 

        p(1);  // calling print(1)


        SName s = new SName(sum);

        s += mul;
        s += mul;

        s(2, 3); // calling sum (2,3) then mul(2,3) then mul(2,3) 

        s -= sum;

        s(2, 3); //  mul(2,3) then mul(2,3) 

        Console.ReadKey();
    }
}
