//Author: Jarrett Melnick
//Class to store data relating to individual passengers.
using System.Math

namespace MathClassCs{
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
			_distTraveled = Distance(_cityStart, _cityEnd);
		}
	//TODO: Build Methods necessary
	//Function to calculate the distance travel
		private static int Distance(City locS, City locE){
			double d = 0;
			double a1 = locS.latitude;
			double a2 = locE.latitude;
			double b1 = locS.longitude;
			dobule b2 = locE.longitude;

			d = Math.sin((a2-a1)/2) + Math.cos(a1)*Math.cos(a2)*Math.sin((b2-b1)/2);
			d = ((2*6373)/(Math.sin(Math.Sqrt(d))));
			return d;
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
}