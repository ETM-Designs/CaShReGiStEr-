using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CashRegister
{
    class ItemRecordRA : ItemRecord
    {
        public ItemRecordRA()
            : base()
        {
            //No arg parent (base) constructor called
        }

        public ItemRecordRA(int id, string desc, double price)
            : base(id, desc, price)
        {
            //With arg parent (base) constructor called
        }

        public void write(FileStream raFile)
        {
            BinaryWriter bw = new BinaryWriter(raFile);
            //Write record data in field order
            bw.Write(Id);
            formatDesc(bw, Desc);
            bw.Write(Price);
        }

        private void formatDesc(BinaryWriter bw, string s)
        {
            StringBuilder sb = new StringBuilder(s);
            sb.Length = 15;
            bw.Write(sb.ToString());
        }

        public void read(FileStream raFile)
        {
            BinaryReader br = new BinaryReader(raFile);
            Id = br.ReadInt32();
            Desc = br.ReadString().Replace('\0', ' ');
            Price = br.ReadDouble();
        }
    }
}


