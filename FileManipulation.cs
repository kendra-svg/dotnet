string path = "C:\\Users\\Kendra\\Desktop\\foldertoread\\file1.txt";


var readFile = File.ReadLines(path);



Console.ReadKey();

foreach (var file in readFile)
{
    Console.WriteLine(file);
}


//fx later