using System.Transactions;


//ExploreStrings();
//ExploreNumbers();
//ExploreIfStatements();
ExploreIf();

void ExploreStrings()
{
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

    Console.WriteLine($"apple compared to Apple is {"apple".CompareTo("Apple")}"); // In many cultures, uppercase letters come before lowercase letters when sorting strings. Therefore, when you compare "apple" to "Apple", it may consider the uppercase "A" as coming before the lowercase "a", which would result in -1 (because "apple" comes after "Apple").

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
}
/*--------------------------------------------------------------------------------------------------------------------------------------------------------------*/
void ExploreNumbers()
{
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

    //Declaring ints will always produce an integer result, even if the expected outcome is a decimal. Integer division will truncate the result 
    int q = 7;
    int e = 4;
    int r = 3;
    int t = (q + e) / r;
    Console.WriteLine(t);

    //Even though integer division truncates the result, you can get the remainder by using the % character. Is called a remainder operator.

    int p = 7;
    int o = 4;
    int j = 3;
    int g = (p + o) / j;
    int h = (p + o) % j;

    Console.WriteLine($"quotient: {g}"); //Aka cociente
    Console.WriteLine($"remainder: {e}"); //aka residuo

    //int has min and max limits.

    int max = int.MaxValue;
    int min = int.MinValue;

    Console.WriteLine($"The range of integers is {min} to {max}");

    //Overflow and underflow condition

    int what = max + 3;
    int whatv2 = min - 3;
    Console.WriteLine($"An example of overflow: {what}");
    Console.WriteLine($"An example of underflow: {whatv2}");

    //When I add +1 to an int.MaxValue (2147483647), it will "wrap around" idk idc, and the value will turn into an int.MinValue (-2147483648), if I add 2 more to (now) int.MinValue, it will substract 2, causing the int.MinValue to change from -2147483648 to -2147483646.  That's an example of an overflow

    //The other way around happens for underflow condition

    //Doubles

    //Double-precision have twice the number of binary digits as single-precision. Single precision numbers are declared using the float keyword.

    double a1 = 5;
    double b1 = 4;
    double c1 = 2;
    double d1 = (a1 + b1) / c1;

    Console.WriteLine(d1); //Output includes the decimal portion of the cociente

    //More compliacted expression using doubles

    double a2 = 19;
    double b2 = 23;
    double c2 = 8;
    double d2 = (a2 + b2) / c2;

    Console.WriteLine(d2);

    //Range of double values is much greater than integer values

    double maxDouble = Double.MaxValue;
    double minDouble = Double.MinValue;

    Console.WriteLine($"The range of doubles is {minDouble} to {maxDouble}"); //Printed put in scientific notation

    //Rounding errors
    double third = 1.0 / 3.0;

    Console.WriteLine(third);

    //decimal type 
    //has a smaller ranger but greater precision than double

    decimal minDecimal = decimal.MinValue;
    decimal maxDecimal = decimal.MaxValue;

    Console.WriteLine($"The range of decimal is {minDecimal} to {maxDecimal}");

    //decimal vs double precision

    double aDouble = 1.0;
    double bDouble = 3.0;
    Console.WriteLine(aDouble / bDouble);

    decimal cDecimal = 1.0M; //M suffix is to indicate that a constant should use the decimal type, otherwise, the compiler asumes the double type.
    decimal dDecimal = 3.0M; //M suffix is to indicate that a constant should use the decimal type, otherwise, the compiler asumes the double type.
    Console.WriteLine(cDecimal / dDecimal);

    double radiusCircle = 2.50;
    double pi = Math.PI;
    double area = pi * Math.Pow(radiusCircle, 2); // Math.Pow is to get the result of raising x to the power of y. Or to "elevar el radio (x) a la potencia de 2 (y) (en este caso)"

    Console.WriteLine($"The answer is {area}");
}

void ExploreIfStatements()
{

    //Branching and looping

    int aIf = 5;
    int bIf = 6;
    if (aIf + bIf > 10)
    {

        Console.WriteLine("The answer is greater than 10");
    }
    else
    {
        Console.WriteLine("The answers is not greater than 10");
    }

    //More complex conditions

    int aIfElse = 5;
    int bIfElse = 3;
    int cIfElse = 4;
    if ((aIfElse + bIfElse + cIfElse > 10) && /*<-- and */ (aIfElse == bIfElse)) //Both conditions must be true to execute it
    {
        Console.WriteLine("The answer is greater than 10");
        Console.WriteLine("And the first number is equal to the second");
    }
    else
    {
        Console.WriteLine("The answer is not greater than 10");
        Console.WriteLine("Or the first number is not equal to the second");
    }

    //Or 

    if ((aIfElse + bIfElse + cIfElse > 10) || (aIfElse == bIfElse))
    {
        Console.WriteLine("The answer is greater than 10");
        Console.WriteLine("Or the first number is equal to the second");
    }
    else
    {
        Console.WriteLine("The answer is not greater than 10");
        Console.WriteLine("And the first number is not equal to the second");
    }
}

void ExploreIf()
{
    int a = 5;
    int b = 3;
    if (a + b > 10)
    {
        Console.WriteLine("The answer is greater than 10");
    }
    else
    {
        Console.WriteLine("The answer is not greater than 10");
    }

    int c = 4;
    if ((a + b + c > 10) && (a > b))
    {
        Console.WriteLine("The answer is greater than 10");
        Console.WriteLine("And the first number is greater than the second");
    }
    else
    {
        Console.WriteLine("The answer is not greater than 10");
        Console.WriteLine("Or the first number is not greater than the second");
    }

    if ((a + b + c > 10) || (a > b))
    {
        Console.WriteLine("The answer is greater than 10");
        Console.WriteLine("Or the first number is greater than the second");
    }
    else
    {
        Console.WriteLine("The answer is not greater than 10");
        Console.WriteLine("And the first number is not greater than the second");
    }
}