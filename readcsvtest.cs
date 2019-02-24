using System;

public class HelloWorld
{
    static public void Main ()
    {
        int counter = 0;  
        string line;  

        // Read the file and display it line by line.  
        System.IO.StreamReader file = new System.IO.StreamReader(@"sw.csv");  
        while((line = file.ReadLine()) != null)  
        {  
            System.Console.WriteLine(line);  
            counter++;  
        }  

        file.Close();  
        System.Console.WriteLine("There were {0} lines.", counter);  
        // Suspend the screen.  
        System.Console.ReadLine();  
    }
}
