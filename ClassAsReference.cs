using System;

//A type that is defined as a class is a reference type.
//
//At run time, when you declare a variable of a reference type, the variable contains the value null until you create an instance of the class by using the *new* operator, or assign it to an object of a compatible type created elsewhere, as shown in the following example.


//Declaring an object of type MyClass
MyClass mc = new MyClass();

//Declaring another object of the same type, assigning it the value of the first object

MyClass mc2 = mc;

mc.MyMethod();


//MyClass.MyMethod(); //this will not compile as it says that 'An object reference is required for the non-static field method, or property 'MyClass.MyMethod', meaning that I need to create an object (instantiate it)'

//Creating MyClass (after declaring the object because those lines above count as top level statements)
class MyClass 
{
    public  void MyMethod()
    {
        Console.WriteLine("My text from MyMethod method from MyClass class");
    }
}