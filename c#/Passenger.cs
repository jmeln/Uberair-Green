//Author: tAvg, longAvg;
//double latAvg, longAvg;
//Jarrett Melnick
//Class to store data relating to individual passengers.
using System;

public class Passenger{
	private string _fname;
    private string _lname;
	private int _passengerID;
	private City _cityStart;
	private City _cityEnd;
	private double _distTraveled;
	private double _priceCharged;

	public Passenger(string fName, string lName, int passengerID, City locS, City locE){
		//Main constructor
		_fname = fName; 	//First Name
		_lname = lName;		//Last Name
		_passengerID = passengerID; 	//passengerID of type int
		_cityStart = locS;	//Starting City of type City
		_cityEnd = locE;	//Destination City of type City
		_distTraveled = Distance(_cityStart, _cityEnd);		//Distance traveled by the customer
		_priceCharged = CalcPrice(_distTraveled);		//Price charged to the customer.s
	}
	private static double Distance(City locS, City locE){
		//Function to calculate the distance between the source and destination
		double d = 0;
		double a1 = DegreesToRadians(locS.Latitude);
		double a2 = DegreesToRadians(locE.Latitude);
		double b1 = DegreesToRadians(locS.Longitude);
		double b2 = DegreesToRadians(locE.Longitude);
		d = ((1 - Math.Cos(2*((a2-a1)/2)))/2) + Math.Cos(a1)*Math.Cos(a2)*((1 - Math.Cos(2*((b2-b1)/2)))/2);
		d = ((2*6373)*(Math.Asin(Math.Sqrt(d))));
		return d;
	}
	private static double DegreesToRadians(double num){
		//Converts a number in degrees to radians
		return ((Math.PI/180)*num);
	}
	private static double RadiansToDegrees(double num){
		//Converts a number in radians to degrees
		return ((num*180)/Math.PI);
	}
	private static double CalcPrice(double distT){
        //Calculates the price per mile between source and destination.
		return (distT*1.25);	
	}
	public string FirstName{
		//Returns the first name of the customer.
		get{return _fname;}
	}
	public string LastName{
		//Returns the last name of the customer.
		get{return _lname;}
	}
	public int PassengerID{
		//Returns the PassengerID
		get{return _passengerID;}
	}
	public double DistanceTraveled{
		//Returns the distance the customer is to travel.
		get{return _distTraveled;}
	}
	public double Price{
		//Returns the price charged to the customer
		get{return _priceCharged;}
	}
}
