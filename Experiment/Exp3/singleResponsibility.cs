using System;

class ReportGenerator
{
    public void GenerateReport()
    {
        Console.WriteLine("Report Generated");
    }
}

class ReportSaver
{
    public void SaveToFile()
    {
        Console.WriteLine("Report Saved to File");
    }
}

class Program
{
    static void Main()
    {
        ReportGenerator generator = new ReportGenerator();
        generator.GenerateReport();

        ReportSaver saver = new ReportSaver();
        saver.SaveToFile();
    }
}
