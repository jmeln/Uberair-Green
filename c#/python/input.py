#!/usr/bin/python

# user input function 
# returns add_passenger boolean and passenger info

def user_input(add_passenger, first_name, last_name, origin_city, origin_state, destination_city, destination_state):

    result = 'x'
    while(result !=  'y' or result != 'n') 
        result = lower(raw_input("Add passenger (Y/N)? "))
    if(result == 'y'):
        
        add_passenger = True
        
        first_name = lower(raw_input('First Name: '))
    
        last_name = lower(raw_input('Last Name: '))

        origin_city = lower(raw_input('Origination City: '))

        origin_state = lower(raw_input('Origination State: '))
    
        destination_city = lower(raw_input("Destination City: "))

        destination_state = lower(raw_input("Destination State: "))

    else:
        add_passenger = False       

     
        
    

