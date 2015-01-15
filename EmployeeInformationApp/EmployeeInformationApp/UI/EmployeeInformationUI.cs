using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using EmployeeInformationApp.BLL;
using EmployeeInformationApp.DAL.DAO;
using EmployeeInformationApp.DAL.DBGateway;

namespace EmployeeInformationApp.UI
{

    public partial class EmployeeInformationUI : Form
    {
        
        public EmployeeInformationUI()
        {
            InitializeComponent();
        }
        Manager aManager = new Manager();

        public void saveButton_Click(object sender, EventArgs e)
        {
            Employee aEmployee = new Employee();
            aEmployee.Name = nameTextBox.Text;
            aEmployee.Email = emailTextBox.Text;
            aEmployee.Address = addressTextBox.Text;
            Designation selectedDesignation = (Designation)designationComboBox.SelectedItem;
            
            
            string msg = aManager.SaveEmployee(aEmployee, selectedDesignation);
            MessageBox.Show(msg);
        }

        private void EmployeeInformationUI_Load(object sender, EventArgs e)
        {
            designationComboBox.DataSource = aManager.LoadAllDesignationList();
            designationComboBox.DisplayMember = "Title";
            designationComboBox.ValueMember = "DesId";

        }

        public void ShowEmployee(ListViewItem selectedItem)
        {
            Employee selectedEmployee = (Employee)selectedItem.Tag;
            nameTextBox.Text = selectedEmployee.Name;
            emailTextBox.Text = selectedEmployee.Email;
            addressTextBox.Text = selectedEmployee.Address;
        }
    }
}
