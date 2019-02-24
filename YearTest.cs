using System;

using static Year;

public class HelloWorld
{
    static public void Main ()
    {
        Year[] years = new Year[3];

        for(int y = 0 ; y < 3 ; y ++)
        {
            years[y] = new Year(2005+y);

            for(int m = 0; m<12;m++)
            {
                years[y].MonthObjs[m] = new Month(1+m);

                for(int d = 0 ; d<5; d++)
                {
                    years[y].MonthObjs[m].addDay(new Day(2+3*y+d%3,new float[3]{1.2f,2.3f,3.4f}));
                }
            }
        }

        Console.WriteLine ("Hello Mono World");

        for(int y = 0 ; y < 3 ; y ++)
        {
            Console.WriteLine ("Years["+y+"] = ");
            years[y].printInfo();
        }
    }
}
