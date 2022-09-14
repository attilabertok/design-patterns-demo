# Simple Factory

The simple factory isn't actually a design pattern, it's more of a programming idiom.

## Intent
Simple Factory encapsulates object creation and separates the responsibility of creating objects from the responsibility of using the created objects.

## Participants
* **Factory**: provides a *Create* method that creates instances of **ConcreteProduct**. The only part of the application that refers to **ConcreteProduct** classes. Might be a static class with a static method, or a regular class with an instance method.
* **Product**: defines the interface of objects the **Factory** creates.
* **ConcreteProduct**: implements the **Product** interface.
* **Client**: uses the **Product**s the **Factory** creates.

## Collaborations
* **Factory** creates an instance of the appropriate **ConcreteProduct** to its **Client**.
