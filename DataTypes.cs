using System;
class DataTypes
{
    public static void Main()
    {
        int num = 12345;
        Console.WriteLine("num : "+num+"type of num : "+num.GetType());

        //value of long datatype should be ended with 'L'
        long longnum = 1234566788988888L;
        Console.WriteLine("Long Num is : "+longnum+"Type of long num is : "+longnum.GetType());

        //Value of float datatype should be ended with 'F'
        float fnum = 12.5F;
        Console.WriteLine("FloatNum is : "+fnum+"Type is : "+fnum.GetType());

        //Value of double datatype should be ended with 'D'
        double doubleNum = 20.20D;
        Console.WriteLine("DoubleNum is : "+doubleNum+"Type is : "+doubleNum.GetType());

        //Scientific Numbers
        float f1=35e3F;
        double d1 = 12E4D;
        Console.WriteLine(f1);
        Console.WriteLine(d1);

        bool isFun = true;
        Console.WriteLine("iFun : "+isFun+" Type of isFun : "+isFun.GetType());
        
        char ch='A';
        Console.WriteLine("Ch : "+ch+" Type of ch : "+ch.GetType());

        string name = "Anuradha";
        Console.WriteLine("Name is : "+name+" Type of Name : "+name.GetType());

    }
}