

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

        public DataTable SelectAllemployees()
        {
            string query = "SELECT * FROM employees;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectAlldependents()
        {
            string query = "SELECT * FROM dependents;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectAlldepartments()
        {
            string query = "SELECT * FROM departments;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectAlljobs()
        {
            string query = "SELECT * FROM jobs;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectAlllocations()
        {
            string query = "SELECT * FROM locations;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectAllcountries()
        {
            string query = "SELECT * FROM countries;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectAllregions()
        {
            string query = "SELECT * FROM regions;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectAll1(int v)
        {
            string query = "SELECT employee_id, first_name, last_name, salary FROM employees where  salary > '" +v+ "' ;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectAll2(int v)
        {
            string query = "SELECT  first_name, salary,job_title,min_salary, max_salary FROM employees e,jobs s  where  e.job_id=s.job_id and employee_id= '" + v + "' ;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectAll3()
        {
            string query = "SELECT  d.department_id ,count(*) FROM departments d,employees e where d.department_id=e.department_id group by d.department_id   ;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectAll4(string s)
        {
            string query = "SELECT d.department_id,d.department_name,d.location_id FROM departments d,locations s where s.location_id=d.location_id and s.city  = '" + s + "'  ;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectAllid()
        {
            string query = "SELECT employee_id FROM employees;";
            return dbMan.ExecuteReader(query);
        }

     
      

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    











    }
}
