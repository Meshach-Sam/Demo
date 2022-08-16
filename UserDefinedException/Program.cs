
public class IntegerIsZero : Exception
{
    public IntegerIsZero(string message) : base(message){

    }
}

class Valid
{
    int temp = 0;

    public void isValid()
    {
        if(temp == 0){
            throw(new IntegerIsZero("Zero Integer Value Found"));
        }else{
            Console.WriteLine(temp);
        }
    }
}

class Program
{
    public static void Main(String[] args)
    {
        Valid v = new Valid();
        try{
            v.isValid();
        }catch(IntegerIsZero e){
             Console.WriteLine(e.Message);
        }
    }
}