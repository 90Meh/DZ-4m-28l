using System.IO;

internal class Program
{
    //Директории файлов
    static string path = "c:\\Otus\\TestDir1";
    static string path2 = "c:\\Otus\\TestDir2";



    private static void Main(string[] args)
    {
        Create(path);
        Create(path2);
        Addon(path, DateTime.Now.ToString());
        Addon(path2, DateTime.Now.ToString());
        Read(path);
        Read(path2);
    }

    //Метод создания директории и файлов
    public static void Create(string pathIn)
    {
        
        DirectoryInfo createDir = new DirectoryInfo(pathIn);
        createDir.Create();
        for (int i = 0; i < 10; i++)
        {
            string pathFile = $"{pathIn}\\File{i+1}.txt";
            
            using (StreamWriter sw = File.CreateText(pathFile))
            {
                sw.WriteLine($"File{i + 1}.txt");
            }
            
        }
    }

    //Метод дополнения файлов
    public static void Addon(string pathIn,string add)
    {
        string[] fileArr = Directory.GetFiles(pathIn);

        foreach (var item in fileArr)
        {
            File.AppendAllText(item, add);
        }
    }

    //Метод для вывода в консоль информации

    public static void Read (string pathIn)
    {
        string[] fileArr = Directory.GetFiles(pathIn);

        foreach (var item in fileArr)
        {
            Console.WriteLine(File.ReadAllText(item));
        }
    }

}