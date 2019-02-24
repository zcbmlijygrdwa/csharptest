//  mcs -out:MonthTest.exe MonthTest.cs Month.cs Day.cs MetaData.cs


using System;

using static Month;

public class HelloWorld
{
    static public void Main ()
    {
        Month m = new Month();
        m.month = 8;


        //add data into month

        for(int i = 0 ; i < 28 ; i++)
        {
            m.addDay(new Day(i*i+2,new float[3]{i,2*i,3}));
        }



        Console.WriteLine ("Hello Mono World");
        m.printInfo();
    }
}
