using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.Student_SO
{
    public class FindStudentByJmbgSO : SystemOperationBase
    {
        private readonly string jmbg;

        public Student Result { get; set; }
        Student s = new Student();
        ClassGroupDatabase cg = new ClassGroupDatabase();

        public FindStudentByJmbgSO(string jmbg)
        {
            this.jmbg = jmbg;
        }

        protected override void Execute()
        {
            //Result = (Student)repository.FindByStringCriteria(s, $"jmbg='{jmbg}'");
            Result = (Student)repository.FindJoinStringWhere(s, cg, "IdClassGroup", "IdClassGroup", $"jmbg='{jmbg}'");
        }
    }
}
