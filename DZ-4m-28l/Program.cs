internal class Program
{
    //Директории файлов
    static string path = "c:\\Otus\\TestDir1";
    static string path2 = "c:\\Otus\\TestDir2";



    private static void Main(string[] args)
    {
        Start(path);
        Start(path2);
    }

    public static void Start(string pathIn)
    {
        
        DirectoryInfo createDir = new DirectoryInfo(pathIn);
        createDir.Create();
        for (int i = 0; i < 10; i++)
        {
            string pathFile = $"{pathIn}\\File{i+1}.txt";
            
            using (StreamWriter sw = File.CreateText(pathFile))
            {
                sw.WriteLine("Hello");
                sw.WriteLine("And");
                sw.WriteLine("Welcome");
            }
            
        }
    }



}