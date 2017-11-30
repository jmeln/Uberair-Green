/* Airport Class
 * Bret Wilson
 */

using System;

namespace UberAir
{
	public class Airport
	{
		/* Private Members */
		private int _id;
		private double _latitude, _longitude;
		private string _ident, _name, _type;
		private bool _hasUnlitRunway, _hasLitRunway;
		private City _nearestCity;
		
		/* Constructor */	
		public Airport (int id, double latitude, double longitude,
		                string ident, string name, string type,
		                bool hasUnlitRunway, bool hasLitRunway, City nearestCity)
		{
			_id = id;
			_latitude = latitude;
			_longitude = longitude;
			_ident = ident;
			_name = name;
			_type = type;
			_hasUnlitRunway = hasUnlitRunway;
			_hasLitRunway = hasLitRunway;
			_nearestCity = nearestCity;
		}
		public int Id
		{
			get{return _id;}
		}
		public double Latitude
		{
			get{return _latitude;}
		}
		public double Longitude
		{
			get{return _longitude;}
		}
		public string Ident
		{
			get{return _ident;}
		}
		public string Name
		{
			get{return _name;}
		}
		public string Type 
		{
			get{return _type;}
		}
		public bool HasUnlitRunway
		{
			get{return _hasUnlitRunway;}
		}
		public bool HasLitRunway
		{
			get{return _hasLitRunway;}
		}
		public City NearestCity
		{
			get{return _nearestCity;}
		}
	}
}
