using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Cafe.Data
{
    [DataContract]
    public class Staff : Base<Staff>
    {
        //  public static List<Staff> Staffs = new List<Staff>();
        [DataMember]
        public string Name
        {
            get { if (_row["NAME"] != DBNull.Value) { return Convert.ToString(_row["NAME"]); } else return ""; }
            set { _row["NAME"] = value; }
        }
        public Staff():base()
        {

        }

        public Staff(DataRow dr):base(dr)
        {

        }
        [JsonIgnore]
        public List<Worker> Workers
        {
            get { return Worker.Items.Where(w => w.Staff.Id == this.Id).ToList(); }
            set { }
        }
        [JsonIgnore]
        public int NumberOfWorkers { get { return Workers.Count(); } }
        [DataMember]
        public String Description {
            get { if (_row["DESCRIPTION"] != DBNull.Value) { return Convert.ToString(_row["DESCRIPTION"]); } else return ""; }
            set { _row["DESCRIPTION"] = value; }

    }

        public override string ToString()
        {
            return Name  + " (" + NumberOfWorkers +")";
        }

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
