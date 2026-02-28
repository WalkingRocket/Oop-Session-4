// what is the difference between static binding and dynamic binding in C#? when does each occur?
/* Q1:
    Static binding occurs at compile time, where the method to be called is determined based
        on the type of the reference variable. This is typical for methods that are known at
        compile time
    Dynamic binding occurs at runtime. Dynamic binding is used when the method to be called
        is determined at runtime, such as when using virtual methods or interfaces. This allows for
        polymorphism, where the actual method that gets executed depends on the object instance
        rather than the reference type
*/


/* Q2:
    Method overloading occurs when multiple methods in the same class have the same name
        but different signeture. It is a compile-time
        polymorphism feature that allows methods to be called based on the argument types passed

    Method overriding occurs when a derived class provides a specific implementation of a method
        that is already defined in its base class. It is a runtime polymorphism feature that allows
        the derived class to change the behavior of the base class method
*/


/* Q3:
    the keywords used for method overriding in C# are:
    1. virtual: This keyword is used in the base class to indicate that a method can be overridden
        in a derived class
    2. override: This keyword is used in the derived class to indicate that a method is overriding
*/

