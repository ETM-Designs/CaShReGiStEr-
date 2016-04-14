using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegister
{
    class ItemRecord
    {
        //private fields
        private int _id;
        private string _desc;
        private double _price;

        public ItemRecord()
        {
            Id = 0;
            Desc = "";
            Price = 0.0;
        }

        public ItemRecord(int id, string desc, double price)
        {
            Id = id;
            Desc = desc;
            Price = price;

        }

        //create public properties
        public int Id
        {
            get
            {
                return _id;
            }
            
            set
            {
                _id = value;
            }
        }

        public string Desc
        {
            get
            {
                return _desc;
            }

            set
            {
                _desc = value;
            }
        }

        public double Price
        {
            get
            {
                return _price;
            }

            set
            {
                _price = value;
            }
        }
    }
}
