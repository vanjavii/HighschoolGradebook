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
    public class Subject : IDomainObject
    {
        public int IdSubject { get; set; }
        [Required, RegularExpression(@"[A-Z][A-Z a-z]*", ErrorMessage = "Please enter valid Subject name!")]
        public string SubjectName { get; set; }
        [Required]
        public string Description { get; set; }
        //spolnji kljuc
        //public Teacher Teacher { get; set; }  OVO SAM SKINULA , TEACHER IMA SPOLJNI KLUC KA SUBJECTU

        public override string ToString()
        {
            return SubjectName;
        }

        public IDomainObject ReadObjectRow(SqlDataReader reader)
        {
            Subject s = new Subject();
            s.IdSubject = (int)reader["IdSubject"];
            s.SubjectName = (string)reader["SubjectName"];
            s.Description = (string)reader["Description"];
            return s;
        }

        public IDomainObject ReadObjectNoJoin(SqlDataReader reader)
        {
            Subject s = new Subject();
            s.IdSubject = (int)reader["IdSubject"];
            s.SubjectName = (string)reader["SubjectName"];
            s.Description = (string)reader["Description"];
            return s;
        }

        #region predmeti po godinama
        public string SubjY1SS => $"IdSubject=666 or IdSubject=667 or IdSubject=668 or IdSubject=669 or IdSubject=670 or IdSubject=671 or IdSubject=672 or IdSubject=673 or IdSubject=674 or IdSubject=675 or IdSubject=676 or IdSubject=677 or IdSubject=678 or IdSubject=679 order by subjectname asc";

        public string SubjY3SS => $" IdSubject=666 or IdSubject=667 or IdSubject=668 or IdSubject=669 or IdSubject=670 or IdSubject=671 or IdSubject=672 or IdSubject=673 or IdSubject=674 or IdSubject=16682 or IdSubject=676 or IdSubject=16679 or IdSubject=678 or IdSubject=679 order by subjectname asc";

        public string SubjY4SS => $"IdSubject=666 or IdSubject=667 or IdSubject=668 or IdSubject=669 or IdSubject=670 or IdSubject=671 or IdSubject=672 or IdSubject=673 or IdSubject=674 or IdSubject=16681 or IdSubject=676 or IdSubject=16680 or IdSubject=678 or IdSubject=679 order by subjectname asc";

        public string SubjY2SM => $"IdSubject=666 or IdSubject=667 or IdSubject=668 or IdSubject=669 or IdSubject=670 or IdSubject=671 or IdSubject=672 or IdSubject=673 or IdSubject=674 or IdSubject=16682 or IdSubject=676 or IdSubject=677 or IdSubject=678 or IdSubject=679 order by subjectname asc";

        public string SubjY3SM => $"IdSubject=666 or IdSubject=667 or IdSubject=668 or IdSubject=669 or IdSubject=670 or IdSubject=671 or IdSubject=672 or IdSubject=673 or IdSubject=674 or IdSubject=16680 or IdSubject=676 or IdSubject=677 or IdSubject=678 or IdSubject=679 order by subjectname asc";

        public string SubjY4SM => $"IdSubject=666 or IdSubject=667 or IdSubject=670 or IdSubject=671 or IdSubject=672 or IdSubject=673 or IdSubject=674 or IdSubject=16680 or IdSubject=676 or IdSubject=677 or IdSubject=678 or IdSubject=679 or idsubject=16681 order by subjectname asc";
        #endregion

        public Subject Self { get { return this; } }

        public string TableName => "Subject";

        public string InsertValues => $"'{SubjectName}','{Description}'";
    }
}
