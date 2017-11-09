public class Passenger{
	//TODO: Declare class variables. Set to private
	private string firstName;
	private string lastName;
	private int locationStart;
	private int locationEnd;
	private int distTravel;
	private int priceCharged;
	//TODO: Build Constructors
	//Default Constructor
	public Passenger(string fName, string lName, int locS, int locE){
		firstName = fName;
		lastName = lName;
	}
	//Intermediate constructors
	//Full field constructor
	
	//TODO: Build Methods necessary
	//Function to calculate the distance travel
	private void Distance(int locS, int locE){
		
	}
	private int CalcPrice(int distT){
		
	}
	//TODO: Build Getters and Setters for each variable
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
