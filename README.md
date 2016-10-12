#Smart Home Simulator
```See Also``` [SmartHomeSDK repo](https://github.com/zeeshanejaz/SmartHomeSDK)

This project is inspired by one of my favorite shows the **Big Bang Theory**, to be specific, the lamp switch gag.

[![Smart Home Automation](/title.png)](//www.youtube.com/watch?v=mqp8_ROAIJY "Smart Home Automation")


> Howard: Gentlemen, I am now about to send a signal from this laptop through our local ISP, racing down fiber-optic cable at the speed of light to San Francisco, bouncing off a satellite in geosynchronous orbit to Lisbon, Portugal, where the data packets will be handed off to submerged transatlantic cables terminating in Halifax, Nova-Scotia, and transferred across the continent via microwave relays back to our ISP and the X10 receiver attached to this (clicks mouse, lamp switches on) lamp.

So I decided to make a visual simulator for a course on UML / OOP and C\++. Usually, courses like these are dull and full information dump, which students find boring can't keep up with. Student at this stage have little C/C++ background to make anything interesting by themselves, so why not make it easy for them. Having an interesting example to practice on will give them a huge morale boost.

## Objective
The objective of this project to give UML/OOP and C\++ beginners an interesting yet easy example to grasp the core ideas. We assume that students will have basic C\++ skills like making a program, compilation, header files, variables, loops, accepting using inputs and showing outputs etc. This project will give student a rich playground to practice concepts like inheritance, polymorphism, overloading, composition and aggregation etc.

![Simulator Screenshot](/screenshot.png)

## Introduction
Home automation (also called domotics) is the residential extension of building automation. Examples of such systems include automation for centralized and/or remote control of lighting, HVAC (heating, ventilation and air conditioning), appliances, and other systems. The primary benefits of home automation systems is the increased convenience, comfort, energy efficiency and security. Also, home automation for the elderly and disabled can provide increased quality of life.

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
The architecture of the system is a simple Client-Server model. A server (simulator) accepts an incoming connection made by a user from his machine. The functionality of making the connection is handled by the **Smart Home SDK**. This SDK contains functions for interfacing with the simulator by issuing various types of commands and receiving  responses. The SDK is implemented as a shared object (SO) on Linux and as dynamic linked library (DLL) on windows. This allows swapping the SDK by a variant, which talks to an actually physical smart home instead of the simulator.

![System Architecture](/architecture.png)

## Smart Home Layout
The layout of the Smart Home simulator can be modified by editing the ```layout.xml``` file. This layout file describes the home configuration i.e., how many floors are in the house, how many rooms on each floor, and which devices are located on which floor. It also contains information about the types of supported devices and their pair-links with other devices. Consider the following layout xml data. It tell us that there is a **Bulb** with a Device ID 1 in the garage on the first floor.

```xml
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
The simulator supports various devices: bulb, air conditioner, powered windows, and CD player. Some capabilities are common between all devices, whereas other capabilities are device-specific. For example, a bulb can be simply powered on or off, whereas a CD player can be controlled by issues next-track or previous-track commands.

### Common Features
Any device can be set offline, which disables any remote access to these devices. However, you can still use the UI to operate these devices. This feature is useful for devices that malfunctioning or currently in private use. Another common feature is that all devices can have associated devices, which can powered on or off together. Furthermore, each device has a Device ID, which can be used to send commands and read status messages.

### Bulb
A bulb is the simplest device, which can just be powered on or off.

### Window
```CommandEnabled``` ```TextEnabled``` ```SafetyRelated```

A powered window is a safety-enabled device. When online and in safe-mode, it can be opened or closed by sending it simple commands. The accepted commands are open and close, mapped to integers values 0 and 1. Window can also return a text status representing it current state e.g., opened or closed.

### Air Conditioner
```CommandEnabled``` ```TextEnabled```

Air conditioner accepts commands to increase or decrease the desired temperature. When turned on, the air conditioner tries to achieve the desired temperature by cooling or heating. The status and current temperature of the room can be retrieved from the device.

### CD Player
```CommandEnabled``` ```TextEnabled```

A CD player is simple media player with a few built in tracks. When powered on, it can forward, reverse seek a track, or go to next or previous track. Current track can be paused or resumed as well. The text status of the CD player returns the current track being played.

## Smart Home SDK

Smart Home SDK is written in C++ and is provided to students as pre-compiled libraries for 32-bit, 64-bit Linux and Windows. The source code for the SDK is available on a separate GitHub repo. To fulfill the objective of this project, I have made is very simple for the student to consume the SDKs and interface with the simulator e.g., the following code connects with the simulator and powers on a bulb.

```c++
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

Further information on the various methods offered in the SDK and their usage is available on the [SmartHomeSDK repo](https://github.com/zeeshanejaz/SmartHomeSDK).