using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.Data
{
    public class Staff : BaseClass<Staff>
    {
      //  public static List<Staff> Staffs = new List<Staff>();
        public List<Worker> Workers
        {
            get { return Worker.Items.Where(w => w.Staff == this).ToList(); }
            set { }
        }
        public int NumberOfWorkers { get { return Workers.Count(); } }

        public String Description { get; set; }

        public override string ToString()
        {
            return Name  + " (" + NumberOfWorkers +")";
        }
        public Staff() { }

        public bool Validate_Name()
        {
            return !this.Name.Equals("") && this.Name.Length < 50;
        }

        public bool Validate_Description()
        {
            return !this.Description.Equals("") && this.Description.Length < 1000;
        }
    }
}
