namespace Vazifa19._09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileSearcher fileSearcher = new FileSearcher();
            fileSearcher.GetPathOfFile("");

            //data yozib olish uchun
            using (FileStream file = new FileStream(@"fizika\baza.txt", FileMode.Open))
            {
                using (StreamWriter writer = new StreamWriter(file))
                {
                    for (int i = 0; i < 100; i++)
                    {
                        writer.WriteLine(i);
                    }
                }
            }
        }
    }
}
