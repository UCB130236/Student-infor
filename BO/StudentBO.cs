using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BO
{
  public  class StudentBO
    {
        StudentDataAccess sda = new StudentDataAccess();

        public bool keepStudentInfo(Student s)
        {
            return sda.keepStudentInfo(s);
        }
        public Student[] getStudentinfo()
        {
            return sda.getStudentInfo();
        }

       

        

    }
}
