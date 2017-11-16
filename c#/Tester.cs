using System;

public class Tester{
	public static void Main(){
		City atlanta = new City("Atlanta", "GA", 155.2, 700.3, 5, 7, 2);
		City Athens = new City("Athens", "GA", 157.3, 690.3, 5, 7, 2);
		Passenger Pass = new Passenger("Jarrett", "Melnick", atlanta, Athens);

		Console.WriteLine(Pass.Price);
	}

}
