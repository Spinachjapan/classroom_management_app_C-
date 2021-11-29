using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomManagement
{
    class Cell: IComparable<Cell>
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public string BGC { get; set; }
        public string Name{ get; set; }

       





    public int CompareTo(Cell other)
    {
       if  (String.Compare(this.Name, other.Name, true) == 0)
        {
            return 0;
        }
       else if (String.Compare(this.Name, other.Name, true) == -1)
        {
            return -1;
        }
       else
        {
            return 1;
        }



    }


    public override string ToString()
        {

            return this.Column + "," + this.Row + "," + this.Name + "," + this.BGC;
        }








    }
}
