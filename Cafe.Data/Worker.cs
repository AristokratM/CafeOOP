using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.Data
{
    public class Worker : BaseClass<Worker>
    {
      //  public static List<Worker> Workers = new List<Worker>();
        private Guid _staffId;
        public Staff Staff
        {
            get { return Staff.Items.Where(s=>s.Id == _staffId).FirstOrDefault(); }
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

        public bool Validate_Name()
        {
            return !this.SName.Equals("") && this.SName.Length < 50;
        }

        public bool Validate_SName()
        {
            return !this.SName.Equals("") && this.SName.Length < 50;
        }

        public bool Validate_PName()
        {
            return !this.PName.Equals("") && this.PName.Length < 50;
        }

        public static Worker Worker_With_The_Highest_Salary()
        {
            Worker worker_With_The_Highest_Salary = null;
            foreach (var worker in Worker.Items)
            {
                if(worker_With_The_Highest_Salary == null)
                {
                    worker_With_The_Highest_Salary = worker;
                } else
                {
                    if(worker.Salary > worker_With_The_Highest_Salary.Salary) { worker_With_The_Highest_Salary = worker; }
                }
            }
            return worker_With_The_Highest_Salary;
        }
    }

}
