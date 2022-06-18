# Smart-Garden

This project is a smart agricultural system based on C# using MSP430 microcontroller.

-Data coming from 3 sensors gets sent serially using bluetooth module from msp430 to computer and displayed at the
screen.

-Devices connected to msp430 which are lamp, fan, heater and 2 water pumps can be controlled from the
computer. Each button sends a different character and msp430 does operations acording to character it 
receives. Msp430 generates 3 different pwm signals to control fan and lamp for each setting which are 
low, medium and high. Heater can be oppened and closed. 2 water pumps can be oppened for 3 different 
amount times which are 3 seconds, 7 seconds and 10 seconds.

-Pin connections and circuit design/PCB of the project can be found at the 
"C# Based Smart Gardener Final PCB" folder.

Orhun Dabak

