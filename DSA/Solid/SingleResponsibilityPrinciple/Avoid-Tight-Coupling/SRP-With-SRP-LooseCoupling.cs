using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_OOD_Solid_SysDesign.Solid.SingleResponsibilityPrinciple.Avoid_Tight_Coupling
{
    // [2] Avoid Tight Coupling
    //Coupling is defined as the level of inter dependency between various software components
    
    //** After Refactoring **/
    // Responsibility: Handle Database Operations  
    public class Students
    {

        private String studentId;
        private DateTime studentDOB;
        private String address;

        //save() is tightly coupled to MYSQL
        public void save()
        {
            new StudentRepository().save(this);
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

    public class StudentRepository
    {

        public void save(Students student)
        {
            // Serialize object into a string representation

            //String objectStr = MyUtils.serializeIntoAString(this);
            //Connection connection = null;
            //Statement stmt = null;
            try
            {
                //Class.forName("com.mysql.jdbc.Driver");
                //connection = DriverManager.getConnection("jdbc:mysql://localhost:3306/MyDB", "root", "password");
                //stmt = connection.createStatement();
                //stmt.execute("INSERT INTO STUDENT VALUES (" + objectStr + ")");
            }
            catch (Exception e)
            {
                //e.printStackTrace();
            }
        }

    }
}
