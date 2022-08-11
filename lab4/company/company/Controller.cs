

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;


namespace company
{
    class Controller
    {
        
          DBManager dbMan;

        public Controller()
        {
            dbMan = new DBManager();
        }

        public int InsertDepartment(string Dname, int Dnumber, int Mgr_SSN, string Mgr_Start_Date)
        {
            string query = "INSERT INTO Department (Dname, Dnumber,  Mgr_SSN,  Mgr_Start_Date ) " +
                              "Values ('" + Dname + "','" + Dnumber + "','" + Mgr_SSN + "',' " + Mgr_Start_Date + "');";
            return dbMan.ExecuteNonQuery(query);
        }

        public int DeleteProject(string Proname)
        {
            string query = "DELETE FROM  Project WHERE Pname='" + Proname + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public int UpdateEmployee(int ssn, int salary)
        {
            string query = "UPDATE Employee SET Salary='" + salary + "' WHERE SSN='" + ssn + "';";
            return dbMan.ExecuteNonQuery(query);
        }

       /* public void SelectManegername(int Dnumber)
        {
            string query = "SELECT  Fname FROM  Employee,Department  WHERE Dnumber='" + Dnumber + "' and Mgr_SSN=SSN  ;";
            return dbMan.ExecuteNonQuery(query);

        }*/

        public DataTable SelectManegername(int Dnumber)
        {
            string query = "SELECT  Fname FROM  Employee,Department  WHERE Dnumber='" + Dnumber + "' and Mgr_SSN=SSN  ;";
            return dbMan.ExecuteReader(query);
        }
      

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    











    }
}
