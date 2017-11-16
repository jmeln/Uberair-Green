//Author: Jarrett Melnick
//Class to store data relating to individual passengers.
public class Passenger{
	private string _name;
	private City _cityStart;
	private City _cityEnd;
	private int _distTraveled;
	private int _priceCharged;
	//Default Constructor
	public Passenger(string fName, string lName, City locS, City locE){
		_name = lName + ", " + fName;
		_cityStart = locS;
		_cityEnd = locE;
		Distance(_cityStart)
	}
	//TODO: Build Methods necessary
	//Function to calculate the distance travel
	private static int Distance(City locS, City locE){
		return 0;	
	}
	private int CalcPrice(int distT){
		return 0;	
	}
	//Returns the name of the customer
	public string Name{
		get{return _name;}
	}
	//Returns the distance the customer is to travel.
	public int DistanceTraveled{
		get{return _distTraveled;}
	}
	//Returns the price charged to the individual customer. 
	public int Price{
		get{ return _priceCharged;}
	}
}
