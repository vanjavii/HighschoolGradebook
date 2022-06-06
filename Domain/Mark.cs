using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Mark : IDomainObject
    {
        //primarni kljucevi
        [Required]
        public Class Class { get; set; }
        [Required]
        public Student Student { get; set; }
        [Required]
        [Range (1,5)]
        public int Value { get; set; }
        [Required]
        public ExaminationType ExaminationType { get; set; }
        [Required]
        public string DateOfExamination { get; set; }        
        public int IsFinal { get; set; }

        public string TableName => "Mark";

        public string InsertValues => $"{Student.IdStudent},{Class.IdClass},{Value},{ExaminationType},{DateOfExamination},{IsFinal}";

        public IDomainObject ReadObjectNoJoin(SqlDataReader reader)
        {
            Mark m = new Mark();
            m.Value = (int)reader["Value"];
            m.Class = new Class
            {
                Teacher = new Teacher
                {
                    Subject = new Subject
                    {
                        SubjectName = (string)reader["SubjectName"]
                    }
                }
            };
            return m;
        }

        public IDomainObject ReadObjectRow(SqlDataReader reader)
        {
            Mark m = new Mark();           
            m.Value = (int)reader["Value"];         
            m.ExaminationType = (ExaminationType)reader["ExaminationType"];
            m.DateOfExamination =((DateTime)reader["DateOfExamination"]).ToString();            
            return m;
        }
    }
}
