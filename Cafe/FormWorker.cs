using Cafe.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe
{
    public partial class FormWorker : Form
    {
        private Worker _worker;
        public Boolean IsExist { get; private set; }
        public FormWorker(Worker worker)
        {
            InitializeComponent();
            _worker = worker;
            if(_worker !=null)
            {
                IsExist = true;
                tbWorkerName.Text = _worker.Name;
                tbWorkerPName.Text = _worker.PName;
                tbWorkerSName.Text = _worker.SName;
                tbWorkerSalary.Text = _worker.Salary.ToString();
                dtpWorkerBirthday.Value = _worker.Birthday;
            } else
            {
                _worker = new Worker();
            }
        }

        private void FormWorker_Load(object sender, EventArgs e)
        {

            cbWorkerGender.DataSource = Enum.GetValues(typeof(Gender));
            cbWorkerGender.SelectedItem = Gender.NoData;

            if(_worker.Name != null)
            {
                cbWorkerGender.SelectedItem = _worker.Gender;
                cbWorkerStaff.SelectedItem = _worker.Staff;

            }
            RTBWorkerInfoRefresh();
        }

        private void RTBWorkerInfoRefresh()
        {
            cbWorkerStaff.DataSource = Staff.Items;
            if (_worker.Name == null)
            {
                rtbWorkerInfo.Text = "No Info";
                return;
            }
            rtbWorkerInfo.Text = "Name: " + _worker.Name + "\n"
                    + "Surname: " + _worker.SName + "\n"
                    + "Parentname: " + _worker.PName + "\n"
                    + "Staff: " + _worker.Staff + "\n"
                    + "Gender: " + _worker.Gender + "\n"
                    + "Age: " + _worker.Age + "\n"
                    + "Birhday: " + _worker.Birthday.ToShortDateString() + "\n"
                    + "Salary: " + _worker.Salary + "\n";
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnApplyChanges_Click(object sender, EventArgs e)
        {
            _worker.Name = tbWorkerName.Text;
            _worker.PName = tbWorkerPName.Text;
            _worker.SName = tbWorkerSName.Text;
            _worker.Staff = (Staff)cbWorkerStaff.SelectedItem;
            _worker.Salary = float.Parse(tbWorkerSalary.Text);
            _worker.Gender = (Gender)cbWorkerGender.SelectedItem;
            _worker.Birthday = dtpWorkerBirthday.Value;

            if(!IsExist)
            {
                Worker.Items.Add(_worker);
                IsExist = true;
            }
            RTBWorkerInfoRefresh();
        }
    }
}
