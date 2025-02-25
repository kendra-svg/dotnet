Console.WriteLine("Hello, World!");

//Strings

string aFriend = "Bill";
Console.WriteLine("Hello " + aFriend);

aFriend = "Maira";
Console.WriteLine("Hello " + aFriend);

Console.WriteLine($"Hello {aFriend}"); //String interpolation

string firstFriend = "Maira";
string secondFriend = "Sage";

Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");

//Lenght is a property of a string, it returns the number of chracters in that string.

Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters. ");
Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters. ");


//CompareTo compares two strings based on based on alphabetical (lexicographical) order, or using the Unicode values of the characters. However, C# performs culture-senstive comparison meaning that in some cultures, A (65) is greater than a (97). 

//When considering just unicode values (using StringComparison.Ordinal), it returns a negative number if the calling string comes before the argument, a positive number if it comes after, and 0 if they are equal.

//Since CompareTo is culture-sensitive, it considers more than just the unicode values. In many cultures, when sorting strings, uppercase letters are considered "lesser" than lowercase letters, particularly when comparing the same characters in different cases. For example, when comparing "apple" (calling string) to "Apple" (argument), the system treats the uppercase "A" as coming before the lowercase "a," resulting in -1 (since "Apple" comes before "apple" in the order of comparison).

//However, this principle applies to comparisons of the same characters in different cases, while comparisons involving different characters are determined by their Unicode values.


//Calling string: firstFriend
//Argument: secondFriend
var firstComparison = firstFriend.CompareTo(secondFriend);

//Since "Maira" (M) comes before "Sage" (S) in lexicographical order, CompareTo returns a negative number
Console.WriteLine($"The comparison is {firstFriend} against {secondFriend} and the result is {firstComparison}");



//Calling string: firstFriend
//Argument: secondFriend
var secondComparison = secondFriend.CompareTo(firstFriend);

//Since "Sage" (S) comes after "Maira" (M) in lexicographical order, CompareTo returns a positive number
Console.WriteLine($"The comparison is {secondFriend} against {firstFriend} and the result is {secondComparison}");

//CompareTo does not implicitly uses ignore case. Upper and lower characters have different unicode values even if the character is the same, meaning A ≠ a.

Console.WriteLine($"apple compared to Apple is { "apple".CompareTo("Apple")}"); // In many cultures, uppercase letters come before lowercase letters when sorting strings. Therefore, when you compare "apple" to "Apple", it may consider the uppercase "A" as coming before the lowercase "a", which would result in -1 (because "apple" comes after "Apple").

string apple = "apple";
string upperApple = "Apple";
var appleAsTheCallingStringAndAppleAsTheArgument = apple.CompareTo(upperApple);
var appleUpperCaseAsTheCallingStringAndAppleLowerCaseAsTheArgument = upperApple.CompareTo(apple);

Console.WriteLine($"apple as the calling string and Apple as the argument equals: {appleAsTheCallingStringAndAppleAsTheArgument}");
Console.WriteLine($"Apple as the calling string and apple as the argument equals: {appleUpperCaseAsTheCallingStringAndAppleLowerCaseAsTheArgument}");

string banana = "banana";
string upperBanana = "Banana";

var bananaAsTheCallingStringAndBananaAsTheArgument = banana.CompareTo(upperBanana);
var bananaUpperCaseAsTheCallingStringAndBananaLowerCaseAsTheArgument = upperBanana.CompareTo(banana);

Console.WriteLine($"banana as the calling string and Banana as the argument equals: {bananaAsTheCallingStringAndBananaAsTheArgument}");
Console.WriteLine($"Banana as the calling string and banana as the argument equals: {bananaUpperCaseAsTheCallingStringAndBananaLowerCaseAsTheArgument}");

char firstLetter = 'A';
char lastLetter = 'z';

var firstletterAsTheCallingStringAndLastLetterAsTheArgument = firstLetter.CompareTo(lastLetter);
var lastLetterAsTheCallingStringAndLastLetterAsTheArgument = lastLetter.CompareTo(firstLetter);

//The comparison yields -57 because "A" (65) is much less than "z" (122). Here, the result is based on their Unicode values, not just case
Console.WriteLine($"{firstLetter} as the calling string and {lastLetter} as the argument equals {firstletterAsTheCallingStringAndLastLetterAsTheArgument}");

//The comparison yields 57, indicating that "z" is greater than "A."
Console.WriteLine($"{lastLetter} as the calling string and {firstLetter} as the argument equals {lastLetterAsTheCallingStringAndLastLetterAsTheArgument}");

/*Line 87. 
 * If " " are used instead of '', line 88 throws an "Input string not in a correct format error" because it is just one character, which is essentially a char type. 
 * If the type is not replaced from string to char, line 53 throws an "cannot implicitly compare char to string error". 
 * Which is why it changed from string higherUnicodeValue = "a"; ----> to char higherUnicodeValue = 'a'; 
 */
char higherUnicodeValue = 'a'; 
int lowerLetter = Convert.ToInt32(higherUnicodeValue);
Console.WriteLine(lowerLetter);


char lowerUnicodeValue = 'A';
int upperLetter = Convert.ToInt32(lowerUnicodeValue);
Console.WriteLine(upperLetter);

var higherComparison = higherUnicodeValue.CompareTo(lowerUnicodeValue);
var lowerComparison = lowerUnicodeValue.CompareTo(higherUnicodeValue);


Console.WriteLine($"In this case, the higher unicode value is {higherUnicodeValue} being {lowerLetter} and the lower unicode value is {lowerUnicodeValue} being {upperLetter}.");
Console.WriteLine($"Meaning that a being the calling string, compared to A being the argument is {higherComparison}.");


Console.WriteLine($"'A'.CompareTo('a'): {"A".CompareTo("a")}");
// Positive because the uppercase 'A' is considered less than the lowercase 'a' in the comparison order.
// When comparing "A" (calling string) to "a" (argument), the result is -1 because the uppercase "A" is treated as coming before the lowercase "a."

Console.WriteLine($"'a'.CompareTo('A'): {"a".CompareTo("A")}");
// Negative because the lowercase 'a' is considered greater than the uppercase 'A' in the comparison order.
// When comparing "apple" (calling string) to "Apple" (argument), the result is 1 because the lowercase 'a' is treated as coming after the uppercase 'A.'

Console.WriteLine(string.Compare("A", "a", StringComparison.Ordinal));  //Negative number because it's unicode value is before the argument
Console.WriteLine(string.Compare("a", "A", StringComparison.Ordinal));  //Positive number because it's unicode value is after the argument.

// string.Compare was used instead of CompareTo because CompareTo is an instance method and cannot take parameters directly.
// string.Compare is a static method that allows you to compare two strings and specify the comparison type StringComparison.Ordinal
// CompareTo is called on a specific string instance, while string.Compare is a static method that allows you to compare two strings directly..

/*--------------------------------------------------------------------------------------------------------------------------------------------------*/
//Trim

string greeting = "     Hello World!       ";
Console.WriteLine($"[{greeting}]");


string trimmedGreeting = greeting.TrimStart();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.TrimEnd();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.Trim();
Console.WriteLine($"[{trimmedGreeting}]");

//Replace

string sayHello = "Hello World!";
Console.WriteLine(sayHello);

sayHello = sayHello.Replace("Hello", "Greetings"); //The first parameter is what is going to be replaced. Output = Greetings World!
Console.WriteLine(sayHello);

//Caps

Console.WriteLine(sayHello.ToLower());
Console.WriteLine(sayHello.ToUpper());

//Contains for Searching

string songLyrics = "You say goodbye, and I say hello";
Console.WriteLine(songLyrics.Contains("goodbye"));
Console.WriteLine(songLyrics.Contains("greetings"));

//Contains is case sensitive
Console.WriteLine(songLyrics.Contains("Hello"));

//Contains with insensitive case
Console.WriteLine(songLyrics.Contains("Hello", StringComparison.OrdinalIgnoreCase));

//Starts with
Console.WriteLine(songLyrics.StartsWith("You"));
Console.WriteLine(songLyrics.StartsWith("hello"));

//Starts with is case sensitive
Console.WriteLine(songLyrics.StartsWith("you"));

//Starts with insensitive case
Console.WriteLine(songLyrics.StartsWith("you", StringComparison.OrdinalIgnoreCase));

//EndsWith
Console.WriteLine(songLyrics.EndsWith("hello"));
Console.WriteLine(songLyrics.EndsWith("You"));

//EndsWith is case sensitive
Console.WriteLine(songLyrics.EndsWith("Hello"));

//EndsWith insensitive case
Console.WriteLine(songLyrics.EndsWith("HELLO", StringComparison.OrdinalIgnoreCase));

/*--------------------------------------------------------------------------------------------------------------------------------------------------------------*/

//Numbers

//Addition

int a = 18;

int b = 6;

int c = a + b;

Console.WriteLine(c);

//Substraction

int aB = 10;

int bB = 5;

int cB = aB - bB;

Console.WriteLine(cB);

//Multiplication

int aBC = 100;

int bCD = 10;

int cDF = aBC * bCD;

Console.WriteLine(cDF);

//Division

int aBCD = 500;

int bCDF = 2;

int cDEF = aBCD / bCDF;

Console.WriteLine(cDEF);

//Order of operations

int x = 5;
int y = 4;
int z = 2;
int w = (x + y) * z;

Console.WriteLine(w);

//Combining many different operations

int u = (x + y) - 6 * z + (12 * 4) / 3 + 12; 
//       (5 * 4) - 6 * 2 + (12 * 4) / 3 + 12
//         (9)   - 12    +   (48)   / 3 + 12
//             -3        +   16         + 12
//                    -13      +     12
//                             25

Console.WriteLine(u);

//Declaring ints will always produce an integer result, even if the expected outcome is a decimal
int q = 7;
int e = 4;
int r = 3;
int t = (q + e) / r;
Console.WriteLine(t);