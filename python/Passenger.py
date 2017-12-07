#Author: Jarrett Melnick
#Class to stroe data relating to individual passengers.
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