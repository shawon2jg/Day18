using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using EmployeeInformationApp.DAL.DAO;
using EmployeeInformationApp.DAL.DBGateway;

namespace EmployeeInformationApp.BLL
{
    public class Manager
    {
        private const int MIN_LENGTH_OF_CODE = 2;
        DBGateway aDBGateway = new DBGateway();
        public string SaveDesignation(Designation aDesignation)
        {
            if (aDesignation.Code.Length >= MIN_LENGTH_OF_CODE)
            {
                Designation designationFound = aDBGateway.FindDesignationCode(aDesignation.Code);
                if (designationFound == null)
                {
                    aDBGateway.SaveDesignation(aDesignation);
                    return "Successfully Saved!"; 
                }
                else
                {
                    return "The code already exsist";
                }
            }
            else
            {
                return "Code must be "+ MIN_LENGTH_OF_CODE +" char long";
            }
        }
        public string SaveEmployee(Employee aEmployee, Designation selecteDesignation)
        {
            Employee emailFound = aDBGateway.FindEmail(aEmployee.Email);
            if (emailFound == null)
            {
                if (isValidEmail(aEmployee.Email))
                {
                    aDBGateway.SaveEmployee(aEmployee, selecteDesignation);
                    return "Successfully Saved!";
                }
                else
                {
                    return "Please Type Valid Email..!!!!!!!";
                }
              }
              else
              {
                  return "The Email Already Exsits...!!!!!!";
              }
        }

        public bool isValidEmail(string inputEmail)
        {
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }

        public List<Designation> LoadAllDesignationList()
        {
            return aDBGateway.GetAllDesignationList();
        }
        public List<Employee> GetAllEmployeeList(string enterName)
        {
            return aDBGateway.GetEmployeeList(enterName);
        }
    }
}
