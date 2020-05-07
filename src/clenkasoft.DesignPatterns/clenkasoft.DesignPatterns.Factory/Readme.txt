The Factory Design Pattern
####################################################################
- It is a creational pattern (Used to create an object)
- Use it to create an object without exposing the logic of creating it to a client. Concrete classes will use interface in creation
- Imagine wanting to create a limousine, tractor, truck etc which are all vehicles. We could have a vehicle factory. The Vehicle will then be the
interface and concrete classes will implement it in creating their objects. So in a program, we will ask the Vehicle Factory to create the 
specific vehicle

CONCLUSION
The Factory pattern is a creational design pattern that provides an interface for creating objects without specifying the concrete classes.
YOU USE A METHOD DEFINED IN THE PATTERN TO CREATE THE OBJECT AND NOT USING THE CONSTRUCTOR::: Therefore, sub classes override this method to create
their objects
