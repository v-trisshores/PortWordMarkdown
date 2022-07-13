using System.Diagnostics;

namespace porting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> lineList = new();

            for (var fileIdx = 0; fileIdx < Paths.articles.Length; fileIdx++)
            {
                var path = Paths.articles[fileIdx];

                lineList.Add($"\r\n*** article-{fileIdx + 1} ***\r\n\r\n");

                var isStartPoint = false;

                var lines = File.ReadAllLines(path);
                for (var lineIdx = 0; lineIdx < lines.Length; lineIdx++)
                {
                    var line = lines[lineIdx];

                    if (!isStartPoint && !line.StartsWith("#")) continue;

                    if (line.StartsWith("# "))
                    {
                        lineList.Add($"Migration to Azure Synapse Analytics\r\n");
                        lineList.Add($"Section {fileIdx + 1} - ");
                    }

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
            }

            var mdPath = @"D:\Repos\azure-synapse\oracle\final-articles\articles1-7.md";
            var docxPath = @"D:\Repos\azure-synapse\oracle\final-articles\articles1-7.docx";

            File.WriteAllText(mdPath, string.Join("\r\n", lineList));

            var res = Process.Start("pandoc", $"-f markdown -t docx \"{mdPath}\" -o \"{docxPath}\"");
            res.WaitForExit();
        }
    }
}