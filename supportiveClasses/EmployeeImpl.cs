using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.supportiveClasses
{
    class EmployeeImpl
    {
        private SqlConnection con = Connect.conn();
        public bool addEmployee(Employee employee)
        {
            bool isCorrect = false;

            string employee_ID = CommonMethods.generate_Emp_ID(GetEmployeeIDs());
            employee.empId = employee_ID;

            con.Open();

            try
            {
                SqlCommand command = con.CreateCommand();
                command.CommandType = CommandType.Text;

                command.CommandText = "insert into Employee_Det(EmployeeID, NIC, FirstName, LastName, DOB, Gender, Email, Address, ContactNo, Recruited_Date, Basic_Salary, OT_Rate) Values (@EmployeeID, @NIC, @FirstName, @LastName, @DOB, @Gender, @Email, @Address, @ContactNo, @Recruited_Date, @Basic_Salary, @OT_Rate)";
                command.Parameters.AddWithValue("@EmployeeID", employee.empId);
                command.Parameters.AddWithValue("@NIC", employee.nicNo);
                command.Parameters.AddWithValue("@FirstName", employee.empFName);
                command.Parameters.AddWithValue("@LastName", employee.empLName);
                command.Parameters.AddWithValue("@DOB", employee.dob);
                command.Parameters.AddWithValue("@Gender", employee.empGender);
                command.Parameters.AddWithValue("@Email", employee.empEmail);
                command.Parameters.AddWithValue("@Address", employee.empAddress);
                command.Parameters.AddWithValue("@ContactNo", employee.empContact);
                command.Parameters.AddWithValue("@Recruited_Date", employee.empRecruitedDate);
                command.Parameters.AddWithValue("@Basic_Salary", employee.basicSal);
                command.Parameters.AddWithValue("@OT_Rate", employee.otRate);

                int rows = command.ExecuteNonQuery();

                if (rows > 0)
                {
                    isCorrect = true;
                }
                else
                {
                    isCorrect = false;
                }
            }
            /*catch (Exception e)
            {

            }*/
            finally
            {
                con.Close();                
            }
            return isCorrect;

        }

        public bool updateEmployee(Employee employee)
        {
            bool isCorrect = false;
            con.Open();

            try
            {

                SqlCommand command = con.CreateCommand();
                command.CommandType = CommandType.Text;

                command.CommandText = "Update Employee_Det set NIC = @NIC, FirstName = @FirstName, LastName = @LastName, DOB = @DOB, Gender = @Gender, Email = @Email, Address = @Address, ContactNo = @ContactNo, Recruited_Date = @Recruited_Date, Basic_Salary = @Basic_Salary, OT_Rate = @OT_Rate where EmployeeID = @EmployeeID";
                command.Parameters.AddWithValue("@NIC", employee.nicNo);
                command.Parameters.AddWithValue("@FirstName", employee.empFName);
                command.Parameters.AddWithValue("@LastName", employee.empLName);
                command.Parameters.AddWithValue("@DOB", employee.dob);
                command.Parameters.AddWithValue("@Gender", employee.empGender);
                command.Parameters.AddWithValue("@Email", employee.empEmail);
                command.Parameters.AddWithValue("@Address", employee.empAddress);
                command.Parameters.AddWithValue("@ContactNo", employee.empContact);
                command.Parameters.AddWithValue("@Recruited_Date", employee.empRecruitedDate);
                command.Parameters.AddWithValue("@Basic_Salary", employee.basicSal);
                command.Parameters.AddWithValue("@OT_Rate", employee.otRate);
                command.Parameters.AddWithValue("@EmployeeID", employee.empId);

                int rows = command.ExecuteNonQuery();

                if (rows > 0)
                {
                    isCorrect = true;
                }
                else
                {
                    isCorrect = false;
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                con.Close();
            }

            return isCorrect;
        }

        public bool removeEmployee(Employee employee)
        {
            bool isCorrect = false;

            con.Open();

            try
            {
                SqlCommand command = con.CreateCommand();

                command.CommandType = CommandType.Text;

                command.CommandText = "Delete from Employee_Det where EmployeeID = @EmployeeID";

                command.Parameters.AddWithValue("@EmployeeID", employee.empId);

                int rows = command.ExecuteNonQuery();

                if (rows > 0)
                {
                    isCorrect = true;
                }
                else
                {
                    isCorrect = false;
                }


            }
            catch (Exception e)
            {

            }
            finally
            {
                con.Close();
            }

            return isCorrect;
        }

        public DataTable selectEmployee()
        {
            con.Open();
            DataTable dataTable = new DataTable();
            try
            {
                SqlCommand command = con.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "Select * from Employee_Det";
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(command);

                sqlAdapter.Fill(dataTable);
            }
            catch (Exception e)
            {

            }
            finally
            {
                con.Close();
            }

            return dataTable;
        }

        public bool EmployeeSalary(Employee employee)
        {
            bool isCorrect = false;
            con.Open();

            try
            {
                SqlCommand command = con.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "Insert into Employee_Salary(EmployeeID, FirstName, Salary_Month, No_of_Events, Total_Salary, ETF) values (@EmployeeID, @FirstName, @Salary_Month, @No_of_Events, @Total_Salary, @ETF)";
                command.Parameters.AddWithValue("@EmployeeID", employee.empId);
                command.Parameters.AddWithValue("@FirstName", employee.empFName);
                command.Parameters.AddWithValue("@Salary_Month", employee.month);
                command.Parameters.AddWithValue("@No_of_Events", employee.noOfEvets);
                command.Parameters.AddWithValue("@Total_Salary", employee.empSalary);
                command.Parameters.AddWithValue("@ETF", employee.etf);

                int rows = command.ExecuteNonQuery();

                if (rows > 0)
                {
                    isCorrect = true;
                }
                else
                {
                    isCorrect = false;
                }

            }
            catch (Exception e)
            {

            }
            finally
            {
                con.Close();
            }

            return isCorrect;
        }

        public bool EmployeeLeave(Employee employee)
        {
            bool isCorrect = false;
            con.Open();

            try
            {
                SqlCommand command = con.CreateCommand();
                command.CommandType = CommandType.Text;

                command.CommandText = "Insert into Employee_Leave(EmployeeID, Leave_Type, Reason, Starting_Date, End_Date, No_of_days) values (@EmployeeID, @Leave_Type, @Reason, @Starting_Date, @End_Date, @No_of_days)";
                command.Parameters.AddWithValue("@EmployeeID", employee.empId);
                command.Parameters.AddWithValue("@Leave_Type", employee.leaveType);
                command.Parameters.AddWithValue("@Reason", employee.reason);
                command.Parameters.AddWithValue("@Starting_Date", employee.sDate);
                command.Parameters.AddWithValue("@End_Date", employee.eDate);
                command.Parameters.AddWithValue("@No_of_days", employee.noOfDays);

                int rows = command.ExecuteNonQuery();

                if (rows > 0)
                {
                    isCorrect = true;
                }
                else
                {
                    isCorrect = false;
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                con.Close();
            }

            return isCorrect;
        }

        public bool EmployeeAttendance(Employee employee)
        {
            bool isCorrect = false;
            con.Open();

            try
            {
                SqlCommand command = con.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "insert into Employee_Att(EmployeeID, FirstName, Attendance, Att_Date, In_Time, Out_Time) Values(@EmployeeID, @FirstName, @Attendance, @Att_Date, @In_Time, @Out_Time)";

                command.Parameters.AddWithValue("@EmployeeID", employee.empId);
                command.Parameters.AddWithValue("@FirstName", employee.empFName);
                command.Parameters.AddWithValue("@Attendance", employee.status);
                command.Parameters.AddWithValue("@Att_Date", employee.sDate);
                command.Parameters.AddWithValue("@In_Time", employee.inTime);
                command.Parameters.AddWithValue("@Out_Time", employee.outTime);

                int rows = command.ExecuteNonQuery();

                if (rows > 0)
                {
                    isCorrect = true;
                }
                else
                {
                    isCorrect = false;
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                con.Close();
            }


            return isCorrect;
        }


        public double GetEmployeeOTRate(Employee employee)
        {
            double OT = 100;
            con.Open();
            try
            {
                
                SqlCommand command = con.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "Select OT_Rate from Employee_Det where EmployeeID = @EmployeeID";
                command.Parameters.AddWithValue("@EmployeeID", employee.empId);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    OT = reader.GetDouble(0);
                }
                
            }
            catch (Exception e)
            {

            }
            finally
            {
                con.Close();
            }
            return OT;

        } 

        public double GetEmployeeBasicSal(Employee employee)
        {
            double basicSalary = 0 ;
            con.Open();

            try
            {
                SqlCommand command = con.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "Select Basic_Salary from Employee_Det where EmployeeID = @EmployeeID";
                command.Parameters.AddWithValue("@EmployeeID", employee.empId);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    basicSalary = reader.GetDouble(0);
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                con.Close();
            }


            return basicSalary;
        }

        
        public string GetEmployeeNames(Employee employee)
        {
            string fname = "";
            con.Open();

            try
            {

                SqlCommand command = con.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "Select FirstName from Employee_Det where EmployeeID = @EmployeeID";
                command.Parameters.AddWithValue("@EmployeeID", employee.empId);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    fname = reader.GetString(0);
                    
                }


            }
            catch (Exception e)
            {

            }
            finally
            {
                con.Close();
            }
            return fname;
        }





        public ArrayList GetEmployeeIDs()
        {
            ArrayList arrlist = new ArrayList();

            try
            {

                con.Open();

                SqlCommand command = con.CreateCommand();
                command.CommandType = CommandType.Text;

                command.CommandText = "Select e.EmployeeID from Employee_Det as e";

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    arrlist.Add(reader.GetString(0));
                }
            }
            catch (SqlException e)
            {

            }
            finally
            {

                con.Close();
            }

            return arrlist;
        }
    }
}
