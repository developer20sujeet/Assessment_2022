using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_OOD_Solid_SysDesign.Solid.SingleResponsibilityPrinciple.Avoid_Tight_Coupling
{
    // [2] Avoid Tight Coupling
    //Coupling is defined as the level of inter dependency between various software components
    //** Before Refactoring **/
    // Tightly Coupled - Two responsibility
    // Responsibility: Handle core student profile data
    // Responsibility: Handle Database Operations 
    internal class Student
    {

        private String studentId;
        private DateTime studentDOB;
        private String address;

        public void save()
        {
            // Serialize object into a string representation
            
            //String objectStr = MyUtils.serialzieIntoAString(this);
            //Connection connection = null;
            //Statement stmt = null;

            // We are using MYSQL
            // What if I want to use another database?
            // This is why Tight Coupling is bad practices for prgramming 
            try
            {
                //Class.forName("com.mysql.jdbc.Driver");
                //connection = DriverManager.getConnection("jdbc:mysql://localhost:3306/MyDb", "root", "password");
                //stmt = connection.createStatement();
                //stmt.execute("INSERT INTO STUDENTS VALUES (" + objectStr + ")");
            }
            catch (Exception e)
            {
                //e.printStackTrace();
            }

        }

        public String getStudentId()
        {
            return studentId;
        }

        public void setStudentId(String studentId)
        {
            this.studentId = studentId;
        }

    }
}
