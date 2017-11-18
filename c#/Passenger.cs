//Author: Jarrett Melnick
//Class to store data relating to individual passengers.
using System;

//namespace MathClassCs{
public class Passenger{
	private string _name;
	private City _cityStart;
	private City _cityEnd;
	private double _distTraveled;
	private double _priceCharged;
	//Main Constructor
	public Passenger(string fName, string lName, City locS, City locE){
		_name = lName + ", " + fName;
		_cityStart = locS;
		_cityEnd = locE;
		_distTraveled = Distance(_cityStart, _cityEnd);
		_priceCharged = CalcPrice(_distTraveled);
	}
	//Function to calculate the distance between the source and the destination
	private static double Distance(City locS, City locE){
		double d = 0;
		double a1 = DegreesToRadians(locS.Latitude);
		double a2 = DegreesToRadians(locE.Latitude);
		double b1 = DegreesToRadians(locS.Longitude);
		double b2 = DegreesToRadians(locE.Longitude);
		d = Math.Sin((a2-a1)/2) + Math.Cos(a1)*Math.Cos(a2)*Math.Sin((b2-b1)/2);
		d = ((2*6373)/(Math.Sin(Math.Sqrt(d))));
		return d;
	}
	//Converts a number in degrees to radians
	private static double DegreesToRadians(double num){
		return ((Math.PI/180)*num);
	}
	//Converts a number in radians to degrees
	private static double RadiansToDegrees(double num){
		return ((num*180)/Math.PI);
	}
	//Calculates the price per mile between source and destination.
	private static double CalcPrice(double distT){
		return (distT*1.25);	
	}
	//Returns the name of the customer
	public string Name{
		get{return _name;}
	}
	//Returns the distance the customer is to travel.
	public double DistanceTraveled{
		get{return _distTraveled;}
	}
	//Returns the price charged to the individual customer. 
	public double Price{
		get{return _priceCharged;}
	}
}
//}
