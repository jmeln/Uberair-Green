//Author: Jarrett Melnick
//Class to store data relating to individual passengers.
public class Passenger{
	private string firstName;
	private string lastName;
	private int locationStart;
	private int locationEnd;
	private int distTravel;
	private int priceCharged;
	//Default Constructor
	public Passenger(string fName, string lName, int locS, int locE){
		firstName = fName;
		lastName = lName;
	}
	//TODO: Build Methods necessary
	//Function to calculate the distance travel
	private int Distance(int locS, int locE){
		return 0;	
	}
	private int CalcPrice(int distT){
		return 0;	
	}
	//Returns the name of the customer
	public string getName(){
		return firstName + " " + lastName;
	}
	//Returns the distance the customer is to travel.
	public int getDistanceTraveled(){
		return distTravel;
	}
	//Returns the price charged to the individual customer. 
	public int getPrice(){
		return priceCharged;
	}
}
