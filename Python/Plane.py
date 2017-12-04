class Plane:

    # Constructor
    def __init__(self, fuel, numPass, timezone):
        self._fuel = fuel               # Amount of fuel
        self._numPass = numPass         # Number of pass
        self._timezone = timezone       # The timezone the plane is in
    
    # Recharge the Fuel
    def incFuel(self, x):
        self_fuel += x
   
    # Decrease the Fuel by x
    def decFuel(self, x):
        self._fuel -= x

    # Increase numPpass by x
    def incPass(self, x):
        self._numPass += x
    
    # Decrease numPass by x
    def decPass(self, x):
        self._numPasss -= x
    
    
    # Increase timeZone by x
    def incTimezone(self, x):
        self._timezone += x

    # Decrease timeZone by x
    def decTimezone(self, x):
        self._timezone -= x

    
