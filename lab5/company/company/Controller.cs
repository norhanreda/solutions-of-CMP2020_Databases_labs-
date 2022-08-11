

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

        public int InsertEmployee(string Fname, string Minit, string Lname, int SSN, int Dno)
        {
            string query = "INSERT INTO Employee (Fname ,Minit ,Lname ,SSN ,Dno ) " +
                              "Values ('" + Fname + "','" + Minit + "','" + Lname + "','" + SSN + "','" + Dno + "');";
            return dbMan.ExecuteNonQuery(query);
        }

        public int InsertProject(string Pname, int Pnumber, string Plocation, int Dnum)
        {
            string query = "INSERT INTO Project (Pname ,Pnumber ,Plocation ,Dnum ) " +
                              "Values ('" + Pname + "','" + Pnumber + "','" + Plocation + "','" + Dnum + "');";
            return dbMan.ExecuteNonQuery(query);
        }

        public int Insertwork(int Essn, int Pno, float Hours)
        {
            string query = "INSERT INTO Works_On(Essn,Pno,Hours) " +
                              "Values ('" + Essn + "','" + Pno + "','" +  Hours+ "');";
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
            string query = "SELECT  Pname FROM  Project,Department  WHERE Dnumber='" + Dnumber + "' and Dnum=Dnumber  ;";
            return dbMan.ExecuteReader(query);
        }
      

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    











    }
}
