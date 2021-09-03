# DesignPatterns
1- Strategy Pattern<br/>
<em>Definition:</em><br/>
Strategy is a behavioral design pattern that lets you define a family of algorithms, put each of them into a separate class, and make their objects interchangeable.<br/>

  If a part of your application is going to process the same type of inputs and return the same type of output but with many implementations
   you should use the Strategy Pattern.<br/>
   For Example, you need to implement an application to make basic calculations (+,-,*,/) then each operation should have a different implementation and for sake of consistency, they all should implement the same interface which contains a method to be implemented.<br/>
   The last thing is to make a context class that composes the interface that will provide us with the suitable implementations(concrete classes that implemented the interface).<br/>
   
   In your program, you define inputs, outputs, and the required strategy i.e. one of the implemented concrete classes and instance for the context class.<br/>
   
The context class is going to accept an argument represents an instance of a strategy, then it can execute seamlessly.<br/>
   
   the pros of this strategy:<br/>
    your code can extend seamlessly.<br/>
    you can add more strategies or implementations seamlessly.<br/>
    your code is clean and readable.<br/>
