using System.Collections.Generic;
namespace Unpacker.Utils
{
    public class EtbFileHeader
    {
        public int RowCount;
        public int Unknow1;
        public int Unknow2;
        public int ColumnCount;
        public List<string[]> HeaderColumn = new List<string[]>();
        public List<int> HeaderType = new List<int>();
    }

}
