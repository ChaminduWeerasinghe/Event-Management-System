using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.supportiveClasses
{
    class Employee
    { 
        public string empId { get; set; } //Employee ID
        public string nicNo { get; set; } //Employee NIC no
        public string empFName { get; set; } //Employee First Name
        public string empLName { get; set; } //Employee Last Name
        public string empGender { get; set; } //Employee Gender
        public string empEmail { get; set; } //Employee Email
        public string empAddress { get; set; } //Employee Address
        public string empRecruitedDate { get; set; } //Employee Recruited Date.
        public string empContact { get; set; } //Employee Contact Number
        public double empSalary { get; set; } //Employee Total Salary
        public string dob { get; set; } //Employee Date of Birth
        public int noOfEvets { get; set; } //Number of Events a particular Employee Covered
        public double basicSal { get; set; } //Employee Basic Salary
        public double otRate { get; set; } //Event Rate
        public string sDate { get; set; } //Starting Date
        public string eDate { get; set; } //Ending Date
        public int noOfDays { get; set; } //Number of Days
        public string inTime { get; set; } //In time
        public string outTime { get; set; } //Out Time
        public string month { get; set; } //Month
        public string leaveType { get; set; } //Leave Type
        public string reason { get; set; } //Leave Reason
        public string status { get; set; } //Attendance Status
        public double etf { get; set; }
    }
}
