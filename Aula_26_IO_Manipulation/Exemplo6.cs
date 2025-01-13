namespace Aula_26_IO_Manipulation
{
    public class Exemplo6
    {
        static void Main(string[] args)
        {
            string initialPath = @"C:\Users\valberoliveira\Desktop\Exemplo.txt";
            System.Console.WriteLine("Directory Separator Char:" + Path.DirectorySeparatorChar);
            System.Console.WriteLine("Path Separator Char:" + Path.DirectorySeparatorChar);
            System.Console.WriteLine("Return archive directory:" + Path.GetDirectoryName(initialPath) );
            System.Console.WriteLine("Return only the archive extension:" + Path.GetExtension(initialPath));
        }
    }
}