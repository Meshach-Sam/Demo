
class Program
{
    delegate int Calculator(int a,int b);
    static int addition(int a,int b)
    {
        Console.WriteLine($"Addition - {a+b}");
        return a+b;
    }
    static int subtraction(int a,int b)
    {
        Console.WriteLine($"Subtraction - {a-b}");
        return a-b;
    }
    static int multiplication(int a,int b)
    {
        Console.WriteLine($"Multiplication {a*b}");
        return a*b;
    }
    public static void Main(String[] args)
    {
        
        // int j = Program.add(10,20);
        Calculator c;

        Calculator c1 = new Calculator(addition);
        Calculator c2 = new Calculator(subtraction);
        Calculator c3 = new Calculator(multiplication);

        c = c1;
        c += c2;
        c += c3;

        c(5,5);
    }
}