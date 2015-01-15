using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using EmployeeInformationApp.BLL;
using EmployeeInformationApp.DAL.DAO;
using EmployeeInformationApp.DAL.DBGateway;

namespace EmployeeInformationApp.UI
{
    public partial class SearchEmployeeUI : Form
    {
        public SearchEmployeeUI()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string enterName = enterNameTextBox.Text;
            Manager aManager = new Manager();
            var employeeList = aManager.GetAllEmployeeList(enterName);

            searchResultListView.Items.Clear();
            foreach (Employee aEmployees in employeeList)
            {
                ListViewItem aListViewItem = new ListViewItem();
                aListViewItem.Text = aEmployees.EmpId.ToString();
                aListViewItem.SubItems.Add(aEmployees.Name);
                aListViewItem.SubItems.Add(aEmployees.Email);
                aListViewItem.SubItems.Add(aEmployees.Address);

                searchResultListView.Items.Add(aListViewItem);
                aListViewItem.Tag = aEmployees;
            }
        }

        private void searchResultListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem selectedItem = searchResultListView.SelectedItems[0];
            EmployeeInformationUI aEmployeeInformationUI = new EmployeeInformationUI();
            aEmployeeInformationUI.ShowEmployee(selectedItem);
            aEmployeeInformationUI.ShowDialog();
        }
    }
}
