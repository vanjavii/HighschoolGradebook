using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Class : IDomainObject
    {
        public int IdClass { get; set; }
        public string DateAndTime { get; set; }
        public Teacher Teacher { get; set; }
        public ClassGroupDatabase ClassGroup { get; set; }

        public string TableName => "Class";

        public string InsertValues => $"'{DateAndTime}',{Teacher.IdTeacher},{ClassGroup.IdClassGroup}";

        public IDomainObject ReadObjectNoJoin(SqlDataReader reader)
        {
            Class c = new Class();
            c.IdClass = (int)reader["idclass"];
            c.DateAndTime = ((DateTime)reader["dateandtime"]).ToString();
            c.Teacher = new Teacher
            {
                IdTeacher = (int)reader["idteacher"]
            };
            c.ClassGroup = new ClassGroupDatabase
            {
                IdClassGroup = (int)reader["idclassgroup"]
            };
            return c;
        }

        public IDomainObject ReadObjectRow(SqlDataReader reader)
        {
            Class c = new Class();
            c.Teacher = new Teacher
            {
                Subject = new Subject
                {
                    SubjectName = (string)reader["SubjectName"]
                }
            };
            return c;
        }

        public override string ToString()
        {
            return Teacher.Subject.SubjectName/*e+" - "+Teacher.FirstName+" "+Teacher.LastName*/;
        }

    }
}
