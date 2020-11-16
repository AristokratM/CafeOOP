using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.Data
{
    public class Worker : Base<Worker>
    {
      //  public static List<Worker> Workers = new List<Worker>();
        private Guid _staffId;
        public string Name
        {
            get { if (_row["NAME"] != DBNull.Value) { return Convert.ToString(_row["NAME"]); } else return ""; }
            set { _row["NAME"] = value; }
        }
        public Worker():base()
        {

        }
        public Worker(DataRow dr):base(dr)
        {

        }
        public Staff Staff
        {
            get { if (_row["IDSTAFF"] != DBNull.Value) { 
                    _staffId = new Guid(_row["IDSTAFF"].ToString()); 
                     return Staff.GetById(_staffId); 
                } else { return null; } }
            set { if (value != null) { _row["IDSTAFF"] = _staffId = value.Id; } else { _row["IDSTAFF"] = DBNull.Value; } }
        }
        public string SName {
            get { if (_row["SNAME"] != DBNull.Value) { return Convert.ToString(_row["SNAME"]); } else return ""; }
            set { _row["SNAME"] = value; }
        }
        public string PName {
            get { if (_row["PNAME"] != DBNull.Value) { return Convert.ToString(_row["PNAME"]); } else return ""; }
            set { _row["PNAME"] = value; }
        }
        public int Age {
            get {
                DateTime zeroTime = new DateTime(1, 1, 1);



                // Because we start at year 1 for the Gregorian
                // calendar, we must subtract a year here.
                int years = (zeroTime + (DateTime.Now-Birthday)).Year - 1;
                return years;
            } 
        } 
        public DateTime Birthday {
            get { if (_row["BIRTHDAY"] != DBNull.Value) { return Convert.ToDateTime(_row["BIRTHDAY"]); } else return DateTime.Now; }
            set { _row["BIRTHDAY"] = value; }
        }

        public Gender Gender {
            get { if (_row["GENDER"] != DBNull.Value) { return (Gender) Enum.Parse(typeof(Gender), Convert.ToString(_row["GENDER"])); } else return Gender.NoData; }
            set { _row["GENDER"] = value; }
        }

        public double Salary {
            get { if (_row["SALARY"] != DBNull.Value) { return Convert.ToDouble(_row["SALARY"]); } else return 0d; }
            set { _row["SALARY"] = Math.Round(value, 2); }
        }

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
