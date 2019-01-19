# Zoo

Developer: Ryna Truong

Contributors: Deziree Teague

Actual Time to complete: 10 hours

A hierarchical class structure of a zoo that contains 3 layers of inheritance with 5 concrete animals. OOP principles are being used by returning strings in the console to show the implementation and inheritance of methods and properties

![Digital Drawing](https://github.com/rynnnaa/Zoo/blob/master/Screenshot%20(12).png)

OOP Principles:

INHERITANCE: enables the ability to pass on properties and methods of a class to its derived classes
Example: The methods and properties are passed down from the Animal Class to its derived classes: warm blooded and cold blooded.

ABSTRACTION: a template for future classes that will be derived and instantiated. There are two types:
concrete- can be instantiated, the default
abstract- cannot be instantiated
Example: Guppy, Sockeye, Chinook, and Owl are concrete which means they are instantiated objects of a class.

POLYMORPHISM: targets methods using concrete, abstract, and virtual.
concrete- the default method type
abstract- only exists in abstract classes and requires override in derived classes
virtual- optional to override in derived classes
Example: Swims and CanFly are abstract methods that are later overridden in dervied classes by requirement.

ENCAPSULATION: allow access control through access modifiers which can be private, public, or protected.
public- all access
private- only accessed by the class itself
protected - access given to a class and its derived classes
Example: All animal properties and methods are public, so that derived classes have all access to them.

Interfaces:

An interface describes what actions a class can do; whereas, inheritance is about what a class has.

Examples: My interfaces are IHunt and ISwim. IHunt is implemented in the Salmon class because it inherently hunts and is derived from the animal class. ISwim is implmented in the Sockeye class because it swims and is derived from the Fish class.

User must create a new project in Visual Studio. User must push project to Github. User must create a README.md User must create abstract and virtual methods, with 3 layers of inheritance. User must have at least 3 different abstract classes, 5 concrete animals, 2 abstract methods, 2 abstract Properties, 2 virtual methods, 2 virtual properties, and 2 interfaces.

Purpose of the program is to undertsand how to use classes and interfaces 

To Run the program, user must click the start button (Green arrow) in Visual Studio.

![Program](https://github.com/rynnnaa/Zoo/blob/RYNA-LAB06/ZooProgram.PNG)
