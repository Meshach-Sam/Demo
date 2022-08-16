class Program
{
    public static void add(int a,int b)
    {
        Console.WriteLine(a+b);
    }

    public static void Main(String[] args)
    {
        // Assigning Directly
        // Action<int,int> act = add;

        // Using new Keyword
        // Action<int,int> act = new Action<int, int>(add);    

        // Using Lamda Function 
        Action<int,int> act = (int a,int b) => Console.WriteLine(a+b);

        act(10,20);
    }
}