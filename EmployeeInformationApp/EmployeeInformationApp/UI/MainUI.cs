using System;
using System.Windows.Forms;

namespace EmployeeInformationApp.UI
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
        }

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            EmployeeInformationUI employeeInformationUI = new EmployeeInformationUI();
            employeeInformationUI.ShowDialog();
        }

        private void addDesignationButton_Click(object sender, EventArgs e)
        {
            AddDesignationUI addDesignationUI = new AddDesignationUI();
            addDesignationUI.ShowDialog();
        }

        private void findAndEditButton_Click(object sender, EventArgs e)
        {
            SearchEmployeeUI searchEmployeeUI = new SearchEmployeeUI();
            searchEmployeeUI.ShowDialog();
        }
    }
}
