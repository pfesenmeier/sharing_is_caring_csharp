// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/file-system/how-to-read-from-a-text-file
class ReadFromFile
{
    static void Main()
    {
        string text = "";
        try
        {
            // https://docs.microsoft.com/en-us/dotnet/api/system.io.file.readalltext?view=net-6.0
            text = System.IO.File.ReadAllText(@"./file");
        }
        catch
        {
            System.Console.WriteLine("Something went wrong reading the file");
        }

        System.Console.WriteLine("Contents of files.txt = {0}", text);
    }
}