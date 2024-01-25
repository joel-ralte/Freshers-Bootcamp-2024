using System;

public interface IPrintable
{
    void Print(string path);
}

public interface IScannable
{
    void Scan(string path);
}
public class Printer : IPrintable
{
    public void Print(string path)
    {
        System.Console.WriteLine($"Printing .....{path}");
    }
}
public class Scanner : IScannable
{
    public void Scan(string path)
    {
        System.Console.WriteLine($"Scanning .....{path}");
    }
}

public class PrintScanner : IPrintable, IScannable
{
    public void Print(string path)
    {
        System.Console.WriteLine($"Printing from PrintScanner.....{path}");
    }

    public void Scan(string path)
    {
        System.Console.WriteLine($"Scanning from PrintScanner.....{path}");
    }
}
public class TaskManager
{
    public static void ExecuctePrintTask(IPrintable printable, string documentPath)
    {
        printable.Print(documentPath);
    }
    public static void ExecucteScanTask(IScannable scannable, string documentPath)
    {
        scannable.Scan(documentPath);
    }
}

public class Program
{
    static void Main()
    {
        Printer printerObj = new Printer();
        Scanner scannerObj = new Scanner();
        PrintScanner printScannerObj = new PrintScanner();

        TaskManager.ExecuctePrintTask(printerObj, "Test.doc");
        TaskManager.ExecucteScanTask(scannerObj, "MyImage.png");
        TaskManager.ExecuctePrintTask(printScannerObj, "NewDoc.doc");
        TaskManager.ExecucteScanTask(printScannerObj, "YourImage.png");
    }
}
