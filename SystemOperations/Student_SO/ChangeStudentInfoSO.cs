using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.Student_SO
{
    public class ChangeStudentInfoSO : SystemOperationBase
    {
        private int idStudent;
        private string address;
        private string phoneNumber;
        private int classgroupId;
        public int Result { get; private set; }
        Student s = new Student();

        public ChangeStudentInfoSO(int idStudent, string address, string phoneNumber, int classgroupId)
        {
            this.idStudent = idStudent;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.classgroupId = classgroupId;
        }

        protected override void Execute()
        {
            //$"update student set Address='{address}',PhoneNumber='{phoneNumber}',IdClassGroup={classgroupId} where IdStudent={idStudent}";
            try
            {
                repository.Change3valWhere(s, "address", address, "phonenumber", phoneNumber, "idclassgroup", classgroupId, "idstudent", idStudent);
                Result = 1;
            }
            catch (Exception)
            {
                Result = 0;
            }
        }
    }
}
