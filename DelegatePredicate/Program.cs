class Program
{
    public static bool isValid(int n)
    {
        if(n < 10)
            return false;
        return true;
    }

    public static void Main(String[] args)
    {
        Predicate<int> pre = isValid;

        Console.WriteLine(pre(11));
    }
}