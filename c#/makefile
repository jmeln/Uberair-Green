# Makefile for use with mono with multiple compilation targets
# 
#

CSHARP = mcs
MAIN_CLASS = UberAirMain.cs
OBJECT_CLASSES = Airport.cs City.cs Passenger.cs Plane.cs
OPT = -optimize+

all:
	$(CSHARP) $(OPT) $(MAIN_CLASS) $(OBJECT_CLASSES)

clean:
	rm *.exe
