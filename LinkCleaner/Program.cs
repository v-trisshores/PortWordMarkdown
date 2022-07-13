using System.Diagnostics;

namespace LinkCleaner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var links = File.ReadAllLines(@"C:\Users\Tris Shores\Desktop\links.txt");
            var cleanLinks = links.Where(x => x.Length > 0).Distinct().OrderBy(x => x).ToArray();
            File.WriteAllLines(@"C:\Users\Tris Shores\Desktop\links-clean.txt", cleanLinks);
            foreach (var link in cleanLinks)
            {
                Process.Start(new ProcessStartInfo { FileName = link, UseShellExecute = true });
                Thread.Sleep(1000);
                //Process.Start(link);
            }
        }
    }
}