using System;
using System.Linq;
using System.Xml.Serialization;

namespace TechTalk.SpecFlow.Parser.SyntaxElements
{
    public class FilePosition
    {
        [XmlAttribute("line")]
        public int Line;
        [XmlAttribute("column")]
        public int Column;

        public FilePosition()
        {
        }

        public FilePosition(int line)
            : this(line, 1) // default if the colum is not specified/available
        {
        }

        public FilePosition(int line, int column)
        {
            Line = line;
            Column = column; 
        }
    }
}