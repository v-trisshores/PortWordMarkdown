using System.Text.RegularExpressions;
using System.Diagnostics;

namespace porting
{
    class Program
    {
        static void Main(string[] args)
        {
            var docxPath = @"D:\Repos\azure-synapse\oracle\word-doc\Oracle migration to Azure Synapse Analytics.docx";
            var mdPath = @"D:\Repos\azure-synapse\oracle\final-articles\articles1-7-from-word.md";

            var res = Process.Start("pandoc", $"-f docx -t markdown \"{docxPath}\" -o \"{mdPath}\"");
            res.WaitForExit();
            var ec = res.ExitCode;

            var content = File.ReadAllText(mdPath);
            content = content[content.IndexOf("Migration to Azure Synapse Analytics")..];

            foreach (var fr in Replacements.FR)
            {
                var find = fr[0];
                var replace = fr[1];
                content = Regex.Replace(content, find, replace, RegexOptions.Multiline | RegexOptions.Singleline);
                File.WriteAllText(mdPath, content);
            }
        }
    }
}