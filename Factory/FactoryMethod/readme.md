# Factory Method
## Intent
Factory Method is a creational design pattern that defines an interface for creating an object in a superclass, but lets subclasses decide which class to instantiate. Factory Method lets a class defer instantiation to subclasses.

## Applicability
Use Factory Method when...
* ... a class can't anticipate the class of objects it must create.
* ... a class wants its subclasses to specify the objects it creates.
* ... classes delegate responsiblitiy to one of several helper subclasses, and you want to localize the knowledge of which helper subclass is the delegate.

## Participants
* **Creator**: declares the factory method which returns ano object of type **Product**. **Creator** may also define a default implementation of the factory method that returns a default **ConcreteProduct** object. It may call the factory method to create a **Product** object. Despite the name, **Product** creation is not the primary responsibility of the **Creator**, as it usually already has some core business logic related to **Product**s. The factory method helps to decouple this logic from the **ConcreteProduct** classes.
* **ConcreteCreator**: overrides the factory method to return an instance of a **ConcreteProduct**.
* **Product**: defines the common interface of all objects the factory creates.
* **ConcreteProduct**: implements the **Product** interface.

## Collaborations
* **Creator** relies on its subclasses to define the factory method so that it returns an instance of the appropriate **ConcreteProduct**.

## Consequences
* Factory methods eliminate the need to bind application-specific classes into your code. The code only deals with the **Product** interface; therefore it can work with any user-defined **ConcreteProduct** classes.
* Creating objects inside a class with a factory method is always more flexible than creating an object directly. *Factory Method* gives subclasses a hook for providing an extended version of a **Product** object.
* **ConcreteCreator**s don't always have to create new **Product** objects, they can be used e.g., as object pools instead.
* Factory methods reduce coupling between the **Creator** and the **ConcreteProduct**.
* Factory methods help to maintain the Single Responsibility Principle.
* Factory methods help to maintain the Open-Closed Principle.
* Factory methods help to maintain the Dependency Inversion Principle.
* Variants:
  * The **Creator** class is an abstract class and does not provide an implementation for the factory method it declares. It *requires* subclasses to provide an implementation, because there's no reasonable default.
  * The **Creator** is a concrete class and provides a default implementation for the factory method. The factory method is primarily used for flexibility.
  * The **Creator** is an abstract class that defines a default implementation.
  * The factory method can create *multiple* kinds of **Product**s. It can take a parameter that identifies the kind of object to create. All objects the factory method creates will share the **Product** interface.
  * To avoid subclassing just to create the appropriate **Product** object, generics might be used.
