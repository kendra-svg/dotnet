//Declare and initialize an array of integers
int[] nums = [1, 2, 3, 4, 5];

//Access an instance property of System.Array
int len = nums.Length;

string x = "The answer is " + 5.ToString();
Console.WriteLine(x);

Type type = 12345.GetType();
Console.WriteLine(type);

//
List<string> stringList = new List<string>();
stringList.Add("string example");

//stringList.Add(4); //compile time error for adding a type other than a string. Error: "cannot convert from 'int' to 'string'"

//Compile-time type and run-time type {
string message = "This is a string of characters";

//different compile-time type:

object anotherMessage = "This is a string of characters";
IEnumerable<char> someCharacters = "abcdefgfgasjfshdfjksdhf";