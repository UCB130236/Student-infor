using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DAL
{
   public class StudentDataAccess
    {
        public bool  keepStudentInfo(Student s)
        {
            try
            {
                StreamWriter sw = new StreamWriter("E:\\TextFile.txt", true);
                sw.WriteLine(s.roll);
                sw.WriteLine(s.name);
                sw.WriteLine(s.batch);
                sw.WriteLine(s.year);
                sw.WriteLine(s.term);
                sw.WriteLine(s.adress);
                sw.WriteLine(s.contact);
                sw.WriteLine(s.mobile);

                sw.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public Student[] getStudentInfo()
        {
            try{

            StreamReader sr=new StreamReader("E:\\TextFile.txt");
           
            Student[] sd=new Student[60];
            int b=0;
            string k=sr.ReadLine();
            while(k!=null){

                sd[b]=new Student();
                sd[b].roll=k;
                sd[b].name=sr.ReadLine();
                sd[b].batch = sr.ReadLine();
                sd[b].year=sr.ReadLine();
                sd[b].term=sr.ReadLine();
                sd[b].adress=sr.ReadLine();
                sd[b].contact=sr.ReadLine();
                k=sr.ReadLine();
                b++;
            }
                sr.Close();
               return sd;

            }
                catch(Exception e){
                    return null;
                }

        }
    }
}
