using System.Diagnostics;

namespace porting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var path in Paths.article)
            {
                List<string> lineList = new();

                var isStartPoint = false;

                var lines = File.ReadAllLines(path);
                for (var i = 0; i < lines.Length; i++)
                {
                    var line = lines[i];

                    if (!isStartPoint && !line.StartsWith("##")) continue;
                    isStartPoint = true;

                    if (line.StartsWith("## Next steps"))
                    {
                        break;
                    }

                    if (line.StartsWith("#"))
                    {
                        line = line[1..];
                    }

                    lineList.Add(line);
                }

                var filename = Path.GetFileNameWithoutExtension(path);
                var mdPath = $@"D:\Repos\azure-synapse\oracle\final-articles\{filename}.md";
                var docxPath = $@"D:\Repos\azure-synapse\oracle\final-articles\{filename}.docx";

                File.WriteAllText(mdPath, string.Join("\r\n", lineList));

                var res = Process.Start("pandoc", $"-f markdown -t docx \"{mdPath}\" -o \"{docxPath}\"");
                res.WaitForExit();
            }
        }
    }
}