using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoidBloodBank.TonmoyUserControl
{
    public partial class TUC_Employee : UserControl
    {
        public TUC_Employee()
        {
            InitializeComponent();
            G_dgvEmployeeShow.ClearSelection();
        }
        private static Panel mother;
        public static void initializePanel(Panel a)
        {
            mother = a;
        }
        private void Employee_Load(object sender, EventArgs e)
        {
            string query = "Select Employee_Info.empID, User_Info.userFullName, User_Info.userGender, User_Info.userEmail, User_Info.userPhone, Employee_Info.empJoiningDate, Employee_Info.empSalary from User_Info  inner join Employee_Info on User_Info.userID = Employee_Info.empID";

            string error;
            DataTable dt = DataAccess.GetDataTable(query, out error);

            if (string.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show(error);
                return;
            }

            G_dgvEmployeeShow.DataSource = dt;
            G_dgvEmployeeShow.Refresh();
            G_dgvEmployeeShow.ClearSelection();
            AdminPanel.GeidViewInitialize(G_dgvEmployeeShow);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            mother.Controls.Clear();
            var userControl = new Add_Employee();
            mother.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            // Check if any cell is selected
            if (G_dgvEmployeeShow.SelectedCells.Count <= 0)
            {
                MessageBox.Show("Please select an employee.");
                return;
            }

            // Retrieve the content of the selected cell
            int selectedRowIndex = G_dgvEmployeeShow.SelectedCells[0].RowIndex;
            int selectedColumnIndex = G_dgvEmployeeShow.SelectedCells[0].ColumnIndex;
            object cellValue = G_dgvEmployeeShow[selectedColumnIndex, selectedRowIndex].Value;

            DialogResult result = MessageBox.Show("Do you want to Delete Employee " + cellValue + "", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return;
            }
            var query = "delete from Employee_Info where empID=" + cellValue;

            DataAccess.ExecuteQuery(query, out string error);
            if (string.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show(error);
                return;
            }

            MessageBox.Show("Employee Successfuly Deleted!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);



            query = "Select Employee_Info.empID, User_Info.userFullName, User_Info.userGender, User_Info.userEmail, User_Info.userPhone, Employee_Info.empJoiningDate, Employee_Info.empSalary from User_Info  inner join Employee_Info on User_Info.userID = Employee_Info.empID";


            DataTable dt = DataAccess.GetDataTable(query, out error);

            if (string.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show(error);
                return;
            }

            G_dgvEmployeeShow.DataSource = dt;
            G_dgvEmployeeShow.Refresh();
            G_dgvEmployeeShow.ClearSelection();



        }
    }
}
