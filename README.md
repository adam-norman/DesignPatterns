# DesignPatterns
1- Strategy Pattern
Definition:
Strategy is a behavioral design pattern that lets you define a family of algorithms, put each of them into a separate class, and make their objects interchangeable.

  If a part of your application is going to process the same type of inputs and return the same type of output but with many implementations
   you should use the Strategy Pattern.
   For Example, you need to implement an application to make basic calculations (+,-,*,/) then each operation should have a different implementation and for sake of consistency, they all should implement the same interface which contains a method to be implemented.
   The last thing is to make a context class that composes the interface that will provide us with the suitable implementations(concrete classes that implemented the interface).
   
   In your program, you define inputs, outputs, and the required strategy i.e. one of the implemented concrete classes and instance for the context class.
   
The context class is going to accept an argument represents an instance of a strategy, then it can execute seamlessly.
   
   the pros of this strategy:
    your code can extend seamlessly.
    you can add more strategies or implementations seamlessly.
    your code is clean and readable.
