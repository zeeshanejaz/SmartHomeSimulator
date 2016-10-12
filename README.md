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



Example of feature can be the following:

* Security
    * User authentication and encryption
    * Activity logs
* Safety
    * Safety enabled devices with safe/unsafe states
* Functionality
    * Turning devices On/Off and status updates
    * Status messages i.e., *Current temperature = 20° C*
    * Offline devices e.g., for manual control or malfunction


## Architecture
The architecture of the system is a simple Client-Server model. A server (simulator) accepts an incoming connection made by a user from his machine. The functionality of making the connection is handled by the **SmartHome SDK**. This SDK contains functions for interfacing with the simulator by issuing various types of commands and recieving responses. The SDK is implemented as a shared object (SO) on Linux and as dynamic linked library (DLL) on windows. This allows swapping the SDK by a variant, which talks to an actually physical smart home instead of the simulator.

![System Architecture](/architecture.png)
