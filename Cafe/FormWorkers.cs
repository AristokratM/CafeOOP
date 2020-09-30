using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cafe.Data;
namespace Cafe
{
    public partial class FormWorkers : Form
    {

        public FormWorkers()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddWorker_Click(object sender, EventArgs e)
        {
            Worker.Workers.Add(new Worker
            {
                Name = tbWorkerName.Text,
                SName = tbWorkerSName.Text,
                PName = tbWorkerPName.Text,
                Birthday = dtpWorkerBirthday.Value,
                Gender = (Gender)cbWorkerGender.SelectedItem,
                Salary = float.Parse(tbWorkerSalary.Text),
                Staff = (Staff) lbStaffs.SelectedItem
            }) ;
            LBWorkersRefresh();
            LBStaffsRefresh();
        }

        private void LBWorkersRefresh()
        {
            lbWorkers.DataSource = null;
            lbWorkers.DataSource = Worker.Workers;
        }

        private void LBStaffsRefresh()
        {
            lbStaffs.DataSource = null;
            lbStaffs.DataSource = Staff.Staffs;
        }

        private void FormWorker_Load(object sender, EventArgs e)
        {
            Staff staff1 = new Staff { Name = "Kitchen", Description = "Some info" };
            Staff staff2 = new Staff { Name = "Accounting", Description = "Some another info" };
            Staff.Staffs.Add(staff1);
            Staff.Staffs.Add(staff2);
            Worker.Workers.Add(new Worker { Name = "Oleh", SName = "Tonkoshkur", PName = "Ruslanovych", Birthday = new DateTime(2002, 5, 13), Gender = Gender.Male, Staff = staff1, Salary = 1500 }) ;
            Worker.Workers.Add(new Worker { Name = "Ivan", SName = "Ivanov", PName = "Ivanovych", Birthday = new DateTime(2000, 5, 13), Gender = Gender.Male, Staff = staff2, Salary = 1000 });
            
            LBWorkersRefresh();
            LBStaffsRefresh();
            cbWorkerGender.DataSource = Enum.GetValues(typeof(Gender));
            cbWorkerGender.SelectedItem = Gender.NoData;
        }

   

   

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            Staff.Staffs.Add(new Staff { Name = tbStaffName.Text, Description = tbStaffDescription.Text }) ;
            LBStaffsRefresh();
        }

        private void btnStaffInfo_Click(object sender, EventArgs e)
        {
            new FormStaff((Staff)lbStaffs.SelectedItem).ShowDialog();
        }

        private void btnWorkerInfo_Click(object sender, EventArgs e)
        {
            new FormWorker((Worker)lbWorkers.SelectedItem).ShowDialog();
        }

    }
}
