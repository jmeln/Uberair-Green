using System; 
using System.IO;
public class WebProcess
{
    public static void Main()
    {
        try
        {
        	var url = "http://theochem.mercer.edu/csc330/data/airports.csv";       //Url to be accessed
        	var textFromFile = (new System.Net.WebClient()).DownloadString(url);	//Pushes contents of the file to textFromFile
        	Console.WriteLine(textFromFile);
        }
        catch (IOException e)
        {
            Console.WriteLine("WEB URL NOT FOUND.");
        }
    }
}
