//class MainReturnValTest
//{
//    static int Main()
//    {
//        return 0;
//    }
//}

class AsyncMainReturnValTest
{
    public static int Main(string[] args)
    {
        Console.WriteLine($"{AsyncConsoleWork().GetAwaiter().GetResult()}");
        return AsyncConsoleWork().GetAwaiter().GetResult();
    }

    //public static async Task<int> Main(string[] args)
    //{
    //    return await AsyncConsoleWork();

    //}

    private static async Task<int> AsyncConsoleWork()
    {
        
        return 0;
    }

}