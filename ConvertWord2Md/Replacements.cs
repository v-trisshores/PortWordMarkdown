using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace porting
{
    internal static class Replacements
    {
        internal static string[][] FR =
            {
            // Remove single new lines**********
                new[] {@"\r\n(?!\r\n)", " " },
            ////replace(single space) :

            //Replace single new lines with double newlines **********
                new[] { @"\r\n", "\r\n\r\n" },
            //replace: \n\n

            //Replace double spaces with single spaces: repeat until none left **********
                new[] {@"  ", " " },
            //replace(single space) :
            
            //Replace double spaces with single spaces: repeat until none left **********
                new[] {@"  ", " " },
            //replace(single space) :
            
            //Replace double spaces with single spaces: repeat until none left **********
                new[] {@"  ", " " },
            //replace(single space) :
            
            //Replace double spaces with single spaces: repeat until none left **********
                new[] {@"  ", " " },
            //replace(single space) :
            
            //Replace double spaces with single spaces: repeat until none left **********
                new[] {@"  ", " " },
            //replace(single space) :
            
            //Replace double spaces with single spaces: repeat until none left **********
                new[] {@"  ", " " },
            //replace(single space) :
            
            //Fix mdashes #1 **********
                new[] {@"---", "&mdash;" },
            //replace: &mdash;
            
            ////Remove line start single-space indent **********
                new[] {@"^\s", "" },
            ////replace(empty): 
            
            ////Fix pull quotes #2 **********
                new[] {@"###### (.*?)$", "> [!TIP]\r\n> $1" },
            ////replace: > [!TIP]\r\n> $1
            
            ////Remove curly braces: **********
                new[] {@"\s*\{.*?\}", "" },
            ////replace(empty) :

            ///Increment heading levels
            new[] {@"^(#+) ", "$1# " },
            
            ///Remove spacing in tips
            new[] {@"^> ", ">" },
            
            ///Remove escaped single quotes
            new[] {@"\\'", "'" },
            
            ///Remove escaped double quotes
            new[] {@"\\""", @"""" },
            
            ///Remove escaped angle bracket
            new[] {@"\\<", "<" },
            
            ///Remove escaped angle bracket
            new[] {@"\\>", ">" },
            
            ///Remove escaped dollar sign
            new[] {@"\\\$", "$" },
            
            ///Remove escaped asterisk
            new[] {@"\\\*", "*" },
            
            ///Remove escaped pound
            new[] {@"\\\#", "#" },
            
            ///Remove https://docs.microsoft.com
            new[] { @"https://docs.microsoft.com", "" },
            
            ///Replace /azure/synapse-analytics
            new[] { @"/azure/synapse-analytics", "../.." },
            
            ///Remove extra slash
            new[] { @"ALTER TABLE\\...", "ALTER TABLE..." },
            
            ///Remove extra slash
            new[] { @"INSERT\\...", "INSERT..." },
            
            ///Remove ``` <!-- --> ```
            new[] { @"``` <!-- --> ```", "" },
            
            ///Replace SQL*Plus
            new[] { @"SQL\*Plus", @"SQL\*Plus" },
            
            ///Replace SQL*Loader
            new[] { @"SQL\*Loader", @"SQL\*Loader" },
        };

            ////Remove line start single-space indent **********
            //    new[] {@"^\s", "" },
            ////replace(empty): 

            ////Fix pull quotes #1 *****
            //    new[] {@"###### \[\[(.*?)\].*?$", "> [!TIP]\r\n> $1" },
            ////replace: > [!TIP]\r\n> $1

            ////Heading cleanup *****
            //    new[] {@"\[\[\[\]\{.*?\}(.*?)\].*?$", "$1" },
            ////replace: $1

            ////Heading cleanup #2: *****
            //    new[] {@"\[\[(.*?)\]\(\\l\)\]\(\\l\)", "$1" },
            ////replace: $1

            ////Remove curly braces: **********
            //    new[] {@"\s*\{.*?\}", "" },
            ////replace(empty) :

            ////Remove trailing line space: **********
            //    new[] {@"\s$", "" },
            ////replace(empty) :

            ////Heading cleanup #3: *****
            //    new[] {@"# \[\[\](.*?)\]\(\\l\)", "$1" },
            ////replace: # $1

            ////Spurious link cleanup: *****
            //    new[] {@"^\[(.*?)\]\(\\l\)", "$1" },
            ////replace: $1

            ////Fix pull quotes #2 **********
            //    new[] {@"###### (.*?)$", "> [!TIP]\r\n> $1" },
            ////replace: > [!TIP]\r\n> $1

            ////Remove microsoft domain/localization from links**********
            //    new[] {@"\(https://docs.microsoft.com/en-us/", "(/" },
            ////replace: (/

            ////Fix mdashes #1 **********
            //    new[] {@""" -- """, "&mdash;" },
            ////replace: &mdash;

            ////Fix mdashes #2 **********
            //    new[] {@""" - """, "&mdash;" },
            ////replace: &mdash;

            ////Fix double brackets in link syntax ***********
            //    new[] {@"[\[]+(.*?)[\]]+", "[$1]" },
            ////replace: [$1]

            ////Remove empty headers*****
            //    new[] {@"\r\n^#+$\r\n", "" },
            ////replace(empty) :
    }
}