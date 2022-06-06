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
    public class Student : IDomainObject
    {
        public int IdStudent { get; set; }
        [Required, RegularExpression(@"[A-Z][a-z]*", ErrorMessage = "Please enter valid Firstname!")]
        public string FirstName  { get; set; }
        [Required, RegularExpression(@"[A-Z][a-z]*", ErrorMessage = "Please enter valid Lastname!")]
        public string LastName { get; set; }
        [Range(typeof(DateTime), "1/1/1950", "11/4/2022",
        ErrorMessage = "Value for {0} must be between {1} and {2}")]
        public DateTime BirthDate { get; set; }
        [Required]
        public string Address { get; set; }
        [Required, RegularExpression(@"0[1-3][0-9]{8}", ErrorMessage = "Please enter a valid Phonenumber!")]
        public string PhoneNumber { get; set; }       
        public ClassGroupDatabase ClassGroup { get; set; }
        public string JMBG { get; set; }

        public string TableName => "Student";

        public string InsertValues => $"'{FirstName}','{LastName}','{BirthDate.ToString("yyyyMMdd HH:mm:ss")}','{Address}','{PhoneNumber}',{ClassGroup.IdClassGroup},'{JMBG}'";

        public IDomainObject ReadObjectNoJoin(SqlDataReader reader)
        {
            Student s = new Student();
            s.IdStudent = (int)reader["IdStudent"];
            s.FirstName = (string)reader["FirstName"];
            s.LastName = (string)reader["LastName"];
            s.BirthDate = (DateTime)reader["BirthDate"];
            s.Address = (string)reader["Address"];
            s.PhoneNumber = (string)reader["PhoneNumber"];
            s.ClassGroup = new ClassGroupDatabase
            {
                IdClassGroup = (int)reader["IdClassGroup"],
                //Name = (string)reader["ClassGroupName"],
                //Stream = (int)reader["Stream"]
            };
            s.JMBG = (string)reader["JMBG"];
            return s;
        }

        public IDomainObject ReadObjectRow(SqlDataReader reader)
        {
            Student s = new Student();
            s.IdStudent = (int)reader["IdStudent"];
            s.FirstName = (string)reader["FirstName"];
            s.LastName = (string)reader["LastName"];
            s.BirthDate = (DateTime)reader["BirthDate"];
            s.Address = (string)reader["Address"];
            s.PhoneNumber = (string)reader["PhoneNumber"];
            s.ClassGroup = new ClassGroupDatabase
            {
                IdClassGroup=(int)reader["IdClassGroup"],
                Name = (string)reader["ClassGroupName"],
                Stream=(int)reader["Stream"]
            };
            s.JMBG = (string)reader["JMBG"];
            return s;
        }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
