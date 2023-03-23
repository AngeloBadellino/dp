# Advantages

- You can be sure the you will working always with the same instance object.
- Provide a global access point to the object static instance.

# Notes

- Require a special treatment in a multithreading scenario since needs be taken into account the possibility that different threads cretes different instances.
- It can be hard to test since testing frameworks rely in inheritance and it has a static constructor.

# Class diagram

<img src="./classdiagram.svg" width="400" height="350">
