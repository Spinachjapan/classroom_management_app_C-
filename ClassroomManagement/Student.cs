using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomManagement
{
   public class Student : IComparable<Student>
    {
        public int Row { get; set; }
        public int Column { get; set; }

        //Back bround coulor
        public string BGC { get; set; }

        public string Name { get; set; }






        /// <summary>
        /// For comparing and sorting by name
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(Student other)
        {
            if (String.Compare(this.Name, other.Name, true) == 0)
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

        /// <summary>
        /// return texts for saving
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {

            return this.Column + "," + this.Row + "," + this.Name + "," + this.BGC;
        }








    }
}
