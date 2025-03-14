public class PrinterDriver
{
    private IInput input;
    private IPrinter printer;
    public PrinterDriver(IInput input, IPrinter printer)
    {
        this.input = input;
        this.printer = printer;
    }

    public void Print()
    {
        //buffer page = 
    }
}

public interface IInput
{
    void IsEOF();
    void Read();
    void NextPage();
}

public class Scanner : IInput
{
    public void IsEOF()
    {
        Console.WriteLine("IsEOF");
    }

    public void Read()
    {
        Console.WriteLine("Read");
    }

    public void NextPage()
    {
        Console.WriteLine("NextPage");
    }
}

public interface IPrinter
{
    void Print();
}

public class BWPrinter : IPrinter
{
    public void Print()
    {
        Console.WriteLine("Printing...");
    }
}

public class ColorPrinter : IPrinter
{
    public void Print()
    {
        Console.WriteLine("Printing...");
    }
}

public class RandomPrinter : IPrinter
{
    public void Print()
    {
        Console.WriteLine("Printing...");
    }
}