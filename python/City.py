#Class for City object
#By: Matt Schnider
#
#By nature of python, the member vars are accessible without getter functions. This class, as is 
#allows getting and setting using the .member notation.
class City:
    def __init__(self,cityName,state,latitude,longitude,timeZone, sunSet, passengersWaiting):
        self.CityName = cityName
        self.State = state
        self.Latitude = latitude
        self.Longitude = longitude
        self.TimeZone = timeZone
        self.SunSet = sunSet
        self.PassengersWaiting = passengersWaiting

