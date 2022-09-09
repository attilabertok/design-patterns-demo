# Strategy
## Intent
Strategy is a behavioral design pattern that defines a family of algorithms, encapsulates each one, and makes them interchangeable. Strategy lets the algorithm vary independently from the clients that use it.

## Applicability
Use Strategy when...
* ... many related classes differ only in their behavior.
* ... different variants of an algorithm are required (and it is necessary to switch from one to another during runtime).
* ... business logic needs to be separated from implementation details of some algorithm that is not that important in the context of the business logic.
* ... an algorithm uses data that clients shouldn't know about.
* ... a class defines many behaviors, and these appear as multiple conditional statements in its operations.

## Participants
* **Strategy**: declares an interface common to all supported algorithms. The **Context** uses this interface to call the algorithm defined by a **ConcreteStrategy**.
* **ConcreteStrategy**: implements an algorithm using the interface defined by **Strategy**.
* **Context**: forwards the request from the **Client** to a **ConcreteStrategy** via the **Strategy** interface. It is configured with a **ConcreateStrategy** object, it maintins a reference to a **Strategy** object, and it may define an interface that lets **Strategy** access its data. It does not know what type of **ConcreteStrategy** it works with or how the algorithm is executed.
* **Client**: the destination of the data computed by the **Strategy**. It creates a **ConcreteStrategy** and passes it to the **Context**.

## Collaborations
* **Strategy** and **Context** interact to implement the algorithm.
* A **Context** forwards the request from the **Client** to a **ConcreteStrategy** via the **Strategy** interface.

## Consequences
* Hierarchies of **Strategy** classes define a family of algorithms or behaviors for **Context**s to reuse.
* Encapsulating the algorithm in separate **ConcreateStrategy** classes lets you vary the algorithm independently of its **Context**, making it easier to switch, understand, and extend than if the algorithm was hard-wired into sublcasses of **Context**.
* The algorithm can be varied dynamically, at runtime.
* Strategies eliminate conditional statements. (See the "Replace Conditional with Polymorphism" refactoring.)
* Strategies can provide different implementations to the same behavior, letting the **Client** chose among them.
* **Client**s must be aware of different **ConcreteStrategies** to select the proper one.
* Some data needed by some **ConcreteStrategy** objects might not be necessary for all other implementations, but the data must be defined in the **Strategy** interface even if only one **ConcreteStrategy** uses it; this might introduce some communication overhead between the **Strategy** and the **Context**.
* Strategy promotes Composition over Inheritance.
* Strategy helps to maintain the Open-Closed Principle.
