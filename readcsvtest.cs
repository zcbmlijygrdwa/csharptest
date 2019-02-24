
//https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/file-system/how-to-read-a-text-file-one-line-at-a-time

using System;

using static DataManager;

public class HelloWorld
{


    static int[] parseLine(string line)
    {
        char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
        string[] spl = line.Split(delimiterChars);
        int[] output = new int[spl.Length];
        //System.Console.WriteLine("spl.Length = "+spl.Length);
        for(int i = 0 ; i  < spl.Length ; i++)
        {
            //System.Console.WriteLine("spl[i] = "+spl[i]);
            output[i] = Int32.Parse(spl[i]);
        }
        //System.Console.WriteLine("output.Length = "+output.Length);
        return output;
    }

    static public void Main ()
    {
        int counter = 0;  
        string line;  


        DataManager dm = new DataManager();

        int yearIdx = -1;
        int monthIdx = -1;
        int borrows = -1;
        float[] position = new float[3];

        // Read the file and display it line by line.  
        System.IO.StreamReader file = new System.IO.StreamReader(@"sw.csv");  
        while((line = file.ReadLine()) != null)  
        {  

            //System.Console.WriteLine(line);
            int[] splits = parseLine(line);
            for(int movieIdx = 0 ; movieIdx<12 ; movieIdx++)
            {
                dm.addData(movieIdx,splits[0],splits[1],splits[3+movieIdx],new float[3]{1.2f,2.3f,3.4f});
            }

            System.Console.WriteLine("object at year["+splits[0]+"], mon["+splits[1]+"], day["+splits[2]+"]");
            counter++;  
        }  

        file.Close();  
        System.Console.WriteLine("There were {0} lines.", counter);  
        // Suspend the screen.  
        for(int i = 0 ;  i < 50; i++)
        {
            line = System.Console.ReadLine();  
            System.Console.WriteLine("your input: "+line);
            try
            {
                int[] splits = parseLine(line);
                MetaData mt = dm.getData(splits[0],splits[1],splits[2],splits[3]); 
                System.Console.WriteLine("you are checking movie["+splits[0]+"at year["+splits[1]+"] mon["+splits[2]+"] day["+splits[3]+"], borrows = "+mt.borrows);
            }
            catch(System.Exception e)
            {
                System.Console.WriteLine("Invalid input");
            }
        }
    }
}
