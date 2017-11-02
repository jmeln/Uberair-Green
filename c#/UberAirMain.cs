using System; 
using System.IO;
public class UberAirMain
{
    public static void Main()
    {
        // To be filled in at a later date
        //
        //
        //
        //
    }

    public static void CreateUsableAorportFile()
    {
        try
        {
            //Url to be accessed
            var url = "http://theochem.mercer.edu/csc330/data/airports.csv";
            //Pushes contents of the file to textFromFile
            var textFromFile = (new System.Net.WebClient()).DownloadString(url);
            Console.WriteLine(textFromFile);
        }
        catch (IOException e)
        {
            Console.WriteLine("WEB URL NOT FOUND.");
        }
    }
}
