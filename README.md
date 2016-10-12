#Smart Home Simulator

This project is inspired by one of my most favourite shows the **Big Bang Theory**, to be specific, the lamp switch gag.

[![Smart Home Automation](/title.png)](//www.youtube.com/watch?v=mqp8_ROAIJY "Smart Home Automation")


> Howard: Gentlemen, I am now about to send a signal from this laptop through our local ISP, racing down fibre-optic cable at the speed of light to San Francisco, bouncing off a satellite in geosynchronous orbit to Lisbon, Portugal, where the data packets will be handed off to submerged transatlantic cables terminating in Halifax, Nova-Scotia, and transferred across the continent via microwave relays back to our ISP and the X10 receiver attached to this (clicks mouse, lamp switches on) lamp.

So I decided to make a visual simulator for a course on UML / OOP and C\++. Usually, courses like these are dull and full information dump, which students find boring can't keep up with. Student at this stage have little C/C++ background to make anything interesting by themselves, so why not make it easy for them. Having an interesting example to practice on will give them a huge moral boost.

## Objective
The objective of this project to give UML/OOP and C\++ beginners an interesting yet easy example to grasp the core ideas. We assume that students will have basic C\++ skills like making a program, compilation, header files, variables, loops, accepting using inputs and showing outputs etc. This project will give student a rich playground to practice concepts like inheritence, polymorphism, overloading, composition and aggregation etc.

![Simulator Screenshot](/screenshot.png)

## Introduction
Home automation (also called domotics) is the residential extension of building automation. Examples of such systems include automation for centralized and/or remote control of lighting, HVAC (heating, ventilation and air conditioning), appliances, and other systems. The primary benefits of home automation systems is the icreased convenience, comfort, energy efficiency and security. Also, home automation for the elderly and disabled can provide increased quality of life.

The smart home automation example offers a sufficiently sized domain model containing reference and inheritance type relationships for a class-room discussion a course project. For example, consider the following hierarchy of objects in the systems.

* A Smart Home has multiple Floors
    * Each floor has multiple Rooms
        * Each room has multiple Devices
            * Each device can have multiple Features
			    * Each device can be paired with multiple devices



Example of feature can be the following:

* Security
    * User authentication and encryption
    * Activity logs
* Safety
    * Safety enabled devices with safe/unsafe states
* Functionality
    * Turning devices On/Off and status updates
    * Status messages e.g., *Current temperature = 20° C*
    * Offline devices e.g., for manual control or malfunction
	* Pairing of devices for powering on/off together


## Architecture
The architecture of the system is a simple Client-Server model. A server (simulator) accepts an incoming connection made by a user from his machine. The functionality of making the connection is handled by the **SmartHome SDK**. This SDK contains functions for interfacing with the simulator by issuing various types of commands and recieving responses. The SDK is implemented as a shared object (SO) on Linux and as dynamic linked library (DLL) on windows. This allows swapping the SDK by a variant, which talks to an actually physical smart home instead of the simulator.

![System Architecture](/architecture.png)

## SmartHome Layout
The layout of the Smart Home simulator can be modified by editting the ```layout.xml``` file. This layout file describes the home configuration i.e., how many floors are in the house, how many rooms on each floor, and which devices are located on which floor. It also contains information about the types of supported devices and their pair-links with other devices. Consider the following layout xml data. It tell us that there is a **Bulb** with a Device ID 1 in the garage on the first floor.

```
<?xml version="1.0" encoding="UTF-8"?>
<Building StreetAddress="36 Symonds Street">
	<Floor Name="Ground Floor">
		<Room Name="Garage">
			<Device Id="1" Type="Bulb">
				<Association Id="2" />
				<Association Id="3" />
			</Device>
			<Device Id="2" Type="Bulb" />
		</Room>
		<Room Name="Lobby">
			<Device Id="3" Type="Bulb" />
			<Device Id="4" Type="Window" />
		</Room>
	</Floor>	
	<Floor Name="1st Floor">
		<Room Name="Dining Room">
			<Device Id="15" Type="Bulb"/>
			<Device Id="14" Type="Window" />
		</Room>
		<Room Name="Living Room">
			<Device Id="16" Type="Bulb">
				<Association Id="19" />
				<Association Id="15" />
			</Device>
			<Device Id="19" Type="CD Player" />
			<Device Id="20" Type="Air Conditioner" />
		</Room>
	</Floor>
</Building>
```

## Supported Devices
The simulator supports various devices: bulb, air conditioner, powered windows, and CD player. Each of these devices have various built-in features. For example, a bulb can be simply powered on or off, whereas a CD player can be controlled by issues next-track or previous-track commands. We describe the capabilities of these devices as follows.

### Bulb

### Window

### Air Conditioner

### CD Player


## SmartHome SDK

SmartHome SDK is written in C++ and is provided to students as pre-compiled libraries for 32-bit, 64-bit Linux and Windows. The source code for the SDK is available on a separate GitHub repo. To fulfill the objective of this project, I have made is very simple for the student to consume the SDKs and interface with the simulator e.g., the following code connects with the simualtor and powers on a bulb.

```
#include <iostream>
#include "SmartHomeSDK.h"

using namespace std;

int main()
{	
	//Smart Home API must be initialized before any calls
	SHAPI_Initialize();
		
	bool result = SHAPI_SetDevicePoweredOn(1, true);
		
	//ask user to press enter before exiting
	cout << "\nPress ENTER to continue...";	
	cin.get();

	//Smart Home API must be shutdown at the end of the execution
	SHAPI_Dispose();
}
```
