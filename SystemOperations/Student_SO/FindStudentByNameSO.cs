using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.Student_SO
{
    public class FindStudentByNameSO : SystemOperationBase
    {    

        public Student Result { get; set; }
        Student s = new Student();
        ClassGroupDatabase cg = new ClassGroupDatabase();
        private readonly string name;

        public FindStudentByNameSO(string name)
        {
            this.name = name;
        }

        protected override void Execute()
        {
            //Result = (Student)repository.FindByStringCriteria(s, $"jmbg='{jmbg}'");
            string[] separated = name.Split(' ');
            Result = (Student)repository.FindJoinStringWhere(s, cg, "IdClassGroup", "IdClassGroup", $"firstname='{separated[0]}' and lastname='{separated[1]}'");
        }
    }
}
