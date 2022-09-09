# Decorator
## Intent
Decorator is a behavioral design pattern that attaches additional responsibilites to an object dynamically, thus provides a flexible alternative to subclassing for extending functionality.

## Applicability
Use decorator...
* ... to add responsibilities to individual objects dynamically and transparently.
* ... for responsibilities that can be withdrawn.
* ... when extension by subclassing is impractical (e.g. class definition is hidden or otherwise unavailable for subclassing; or a large number of independent extensions are possible and would produce an explosion of subclasses to support every combination).

## Participants
* **Component**: defines the interface for objects that can have responsibilities added to them dinamically. Because of transparency, this is the common interface for both the decorated object and the decorator.
* **ConcreteComponent**: defines an object to which additional responsibilities can be attached.
* **Decorator**: maintains a reference to a **Component** object and defines an interface that conforms to **Component**'s interface. It delegates all operations to the **Component** object.
* **ConcreteDecorator**: adds responsibilites to the **Component**. It overrides the methods of the **Decorator** and executes its own behavior either before or after calling the method of the referenced **Component**.

## Collaborations
* **Decorator** forwards requests to its **Component** object. It may optionally perform additional operations before and after forwarding the request.

## Consequences
* The decorator pattern provides a more flexible way to add responsibilities to objects than can be had with static inheritance. With decorators, responsibilities can be added and removed at run-time simply by attaching and detaching them. Decorators also make it easy to add a property twice, as opposed to inheriting from the same class twice.
* Decorators avoid feature-laden classes high up in the hierarchy. Decorator offers a pay-as-you-go approach to adding responsibilites. Instead of trying to support all forseeable features in a complex, customizble class, you can define a simple class and add functionality incrementally with decorator objects.
* A decorator and its component aren't identical. Hence you shouldn't rely on object identity when you use decorators.
* Decorators use inheritance to achieve type matching but thay are not using it to get behavior.
* Decorators are typically created by *Factories* or *Builders*.
* Decorators help to maintain the Single Responsibility Principle.
* Decorators help to maintain the Open-Closed Principle.
* Decorators promote Composition over Inheritance.
* Removing a specific decorator from a stack of decorators layered onto an object might be difficult.
