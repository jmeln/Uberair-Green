class Plane:

    # Constructor
    def __init__(self, fuel, numPass, timezone, passenger)
        self.fuel = fuel               # Amount of fuel
        self.numPass = numPass         # Number of pass
        self.timezone = timezone       # The timezone the plane is in
        self.passe = passenger
    
    # Recharge the Fuel
    def incFuel(self, x):
        self.fuel += x
   
    # Decrease the Fuel by x
    def decFuel(self, x):
        self.fuel -= x

    # Add passenger x
    def addPass(self, x):
        passe.append(x)
        numPass += 1
    
    # Find and remove passenger x 
    def removePass(self, x):
        for i,o in enumerate(passe):
            if o.PassengerID == x.PassengerID:
                del passe[i]
        self.numPasss -= 1
    
    # Increase timeZone by x
    def incTimezone(self, x):
        self.timezone += x

    # Decrease timeZone by x
    def decTimezone(self, x):
        self.timezone -= x
    
    # Check if the plan is full or not
    def full(self):
        if (self.numPass == 10):
            return 0
        else:
            return 1
    
    
