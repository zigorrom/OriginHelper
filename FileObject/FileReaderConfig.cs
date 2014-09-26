using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FileObjectProject
{
    public class FileReaderConfig
    {
        //private int m_NameLine;
        //private int m_CommentLine;
        //private int m_UnitLine;
        //private int m_FirstDataLine;
        //private int m_LinesToRead;
        public int NameLine { get; private set; }
        public int CommentLine { get; private set; }
        public int UnitLine { get; private set; }
        public int FirstDataLine { get; private set; }
        public int LinesToRead { get; private set; }
        public string SplitString { get; private set; }

        public FileReaderConfig(int NameLine,int CommentLine,int UnitLine,int FirstDataLine, int LinesToRead, string SplitString )
        {
            this.NameLine = NameLine;
            this.CommentLine = CommentLine;
            this.UnitLine = UnitLine;
            this.FirstDataLine = FirstDataLine;
            this.LinesToRead = LinesToRead;
            this.SplitString = SplitString;
        }
        
    }
}
