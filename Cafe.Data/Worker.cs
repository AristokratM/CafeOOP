using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.Data
{
    public class Worker : BaseClass
    {
        public static List<Worker> Workers = new List<Worker>();
        private Guid _staffId;
        public Staff Staff
        {
            get { return Staff.Staffs.Where(s=>s.Id == _staffId).FirstOrDefault(); }
            set { _staffId = value.Id; }
        }
        public string SName { get; set; }
        public string PName { get; set; }
        public int Age {
            get {
                DateTime zeroTime = new DateTime(1, 1, 1);



                // Because we start at year 1 for the Gregorian
                // calendar, we must subtract a year here.
                int years = (zeroTime + (DateTime.Now-Birthday)).Year - 1;
                return years;
            } 
        } 
        public DateTime Birthday { get; set; }

        public Gender Gender { get; set; }

        public float Salary { get; set; }

        public override string ToString()
        {
            return SName + " " + Name[0] + ". " + PName[0] + ". (" + Age + ") ";
        }

    }

}
