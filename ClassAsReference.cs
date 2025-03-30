using System;

//A type that is defined as a class is a reference type.
//
//At run time, when you declare a variable of a reference type, the variable contains the value null until you create an instance of the class by using the *new* operator, or assign it to an object of a compatible type created elsewhere, as shown in the following example.


//Declaring an object of type MyClass
MyClass mc = new MyClass();

//Declaring another object of the same type, assigning it the value of the first object

MyClass mc2 = mc;

mc.MyMethod();


Customer object2; //This creates an object reference but since is not using the new keyrod, it doesnt create the object itself

//A reference can refer to an object, either by creating a new object

Customer object3 = new Customer();

//or by assigning it an existing object:
Customer object4 = object3;

//The code above creates two objects that both refer to the same object. Therefore anychanges made thorugh object3 are reflected in subsequent uses of object4. Because objects that are based on classes are referred to by reference, classess are known as reference types.



//MyClass.MyMethod(); //this will not compile as it says that 'An object reference is required for the non-static field method, or property 'MyClass.MyMethod', meaning that I need to create an object (instantiate it)'

//Creating MyClass (after declaring the object because those lines above count as top level statements)
class MyClass
{
    public void MyMethod()
    {
        Console.WriteLine("My text from MyMethod method from MyClass class");
    }
}

//[access modifier] - [class] - [identifier]
public class Customer
{
    //Fields, properties, methods and events go here
}

