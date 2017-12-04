#Author: Jarrett Melnick
#Class to stroe data relating to individual passengers.
import math
def Distance(locS, locE):
	#fucntion to calculate the distance the passenger will travel.
	d = 0.0
	a1 = math.radians(locS.Latitude)
	a2 = math.radians(locE.Latitude)
	b1 = math.radians(locS.Longitude)
	b2 = math.radians(locE.Longitude)
	d = ((1 - math.cos(2*((a2-a1)/2)))/2) + math.cos(a1)*math.cos(a2)*((1 - math.cos(2*((b2-b1)/2)))/2)
	d = ((2*6373)*(math.asin(math.sqrt(d))))
	return d

def CalcPrice(distT):
	#Calculates the price the passenger will pay
	return (distT*1.25)
class Passenger:
	def __init__(self, fname, lname,passengerID, locS, locE):
		self.Fname = fname	#Passenger's firstname
		self.Lname = lname	#Passenger's lastname
		self.PassengerID = passengerID #A unique ID to differentiate passenger obejects.
		self.LocS = locS	#starting location of class City
		self.LocE = locE	#ending location of class City
		distanceTraveled = Distance(self.locS, self.locE)	#Total distance traveled by the passenger
		self.Distance = distanceTraveled
		self.Price = CalcPrice(distanceTraveled)	#Price the passenger will pay


