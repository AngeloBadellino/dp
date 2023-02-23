# Advantages
* Particulary useful to create object that have a complex initialization.
* Can be used to create object of the same type.
* Gave control over object creation: dynamic initialization, instance reuse ...

# Notes
* Useful to create Composite trees.
* Can be a Singleton.
* You can use it with Bridge acting as the implementation

# Class Diagram
```mermaid
classDiagram
IComponentAbstractFactory..|>BluComponentAbstractFactory
IComponentAbstractFactory..|>GreenComponentAbstractFactory
BluLabel--|>ILabel
BluButton--|>IButton
GreenLabel--|>ILabel
GreenButton--|>IButton
BluComponentAbstractFactory..>BluButton
BluComponentAbstractFactory..>BluLabel
GreenComponentAbstractFactory..>GreenButton
GreenComponentAbstractFactory..>GreenLabel
class IComponentAbstractFactory{
    <<interface>>
GetButton()
GetLabel()
}
class BluComponentAbstractFactory{
GetButton()
GetLabel()
}
class GreenComponentAbstractFactory{
GetButton()
GetLabel()
}
class IButton{
    <<interface>>
DoSomething()
}
class GreenButton{
DoSomething()
}
class BluButton{
Create()
}
class GreenLabel{
DoSomething()
}
class BluLabel{
DoSomething()
}
class ILabel{
    <<interface>>
DoSomething()
}
```