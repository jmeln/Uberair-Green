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
		private bool _hasunlitRunway, _hasLitRunway;
	//	private City _nearestCity;
		
		/* Constructor */	
		public Airport (int id, double latitude, double longitude,
		                string ident, string name, string type,
		                bool hasUnlitRunway, bool hasLitRunway)
		{
			_id = id;
			_latitude = latitude;
			_longitude = longitude;
			_ident = ident;
			_name = name;
			_type = type;
			_hasUnlitRunway = hasUnlitRunway;
			_hasLitRunway = hasLitRunway;
		}
	}
}
