# Observer
## Intent
Observer is a behavioral design pattern that defines a one-to-many dependency between objects so that when the state of one object changes state, all of its dependents are notified an updated automatically.

## Applicability
Use Observer when...
* ... an abstraction has two aspects, one dependent on the other.
* ... some object must observe other objects, but only for a limited time or in specific cases.
* ... a change to one object requires changing others, and you don't know how many objects need to be changed.
* ... an object should be able to notify other objects without making assumptions about who those (loosely coupled) objects are.

## Participants
* **Subject**/**Publisher**: knows its observers and provides an interface for attaching and detaching **Observer** objects.
* **ConcreteSubject**: stores state of interest to **ConcreteObserver**s.
* **Observer**: defines an updating interface for objects that should be notified of changes in a subject. The interface may define event details, in many cases, the **Publisher** itself is passed as a parameter, and the **Observer** can query whatever details it needs.
* **ConcreteObserver**: maintins a reference to a **ConcreteSubject** object, and stores state that should stay consistent with the subject's. It implements the updating interface defined in **Observer** to keep its state consistent with the subject's.

## Collaborations
* **ConcreteSubject** notifies its **Observer**s whenever a change occurs that could make its **Observer**s' state inconsistent with its own.
* After being notified of a change in a **ConcreteSubject**, a **ConcreteObserver** object may query the **Subject** for information that it can use to reconcile its state with that of the **Subject**.

## Consequences
* The Observer patterns allows **Subject**s and **Observer**s to be varied independently. **Subject**s can be reused without reusing their **Observer**s and vice versa.
* **Observer**s can be added without modifying the **Subject** or other **Observer**s.
* All a **Subject** knows is that it has a list of **Observer**s, each conforming to the simple interface of the abstract **Observer** component. Thus the coupling between **Subject**s and **Observer**s is abstract and minimal.
* Observer supports broadcast communication. The notification that a **Subject** sends needn't specify its receiver. The notification is broadcast automatically to all interested objects subscribed to it. This makes adding and removing **Observers** simple at any time.
* Observer helps to maintain the Open-Closed Principle.
* **Subscriber** notification order is undefined and depends on the implementation.
* Debugging is difficult.
* Notifications might be sent when the state of the **Subject** is inconsistent (e.g., between updating two related properties of the state). In these cases sending notifications from *Template Method*s can help.
* When the dependency relationship between **Subject**s and **Observer**s is particularly complex, a *Mediator*, object might be required that maintains these relationships. This is usually called **Change Manager**, and it is responsible for:
  * Mapping a **Subject** to its **Observer**s, and providing an interface to maintain this mapping.
  * Defining a particular update strategy.
  * Updating all the dependent **Observer**s at the request of a **Subject**.
