using System;

namespace ChapeauModel
{
    public class Table
    {
        public int Table_Number { get; set; } // 1 - 10
        public int Table_Capacity { get; set; } // max is 4

        public bool Table_Availability { get; set; }

        public Table(int tableNumber, bool tableAvailability)
        {
            this.Table_Number = tableNumber;
            this.Table_Availability = tableAvailability;
        }

        public Table()
        {

        }
    }
}
