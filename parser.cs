using System;
using System.Collections.Generic;
using System.Text;

namespace Assembler
{
    public class Parser
    {
        public string[] RemoveWhitespacesAndComments(string[] asmLines)
        {
            List<string> cleanedLines = new List<string>();
            
            foreach (string line in asmLines)
            {
                int commentIndex = line.IndexOf("//");
                string content = commentIndex >= 0 ? line.Substring(0, commentIndex) : line;
                
                StringBuilder sb = new StringBuilder();
                foreach (char c in content)
                {
                    if (!char.IsWhiteSpace(c))
                    {
                        sb.Append(c);
                    }
                }
                
                string cleanedLine = sb.ToString();
                if (!string.IsNullOrEmpty(cleanedLine))
                {
                    cleanedLines.Add(cleanedLine);
                }
            }
            
            return cleanedLines.ToArray();
        }
    }
}
