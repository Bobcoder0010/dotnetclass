using system;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.common;
using System.Data.SqlClient;


namespace crud_operations
{
    public class DataAccess    
    {
        private sqlConnection con = new sqlConnection;
        public bool AddStudent(Student s)
        {
            return true;
        }
        public list<student>GetstudentList()
        {
            List<student> students = new List<Student>();
        }
       
        
    }
}