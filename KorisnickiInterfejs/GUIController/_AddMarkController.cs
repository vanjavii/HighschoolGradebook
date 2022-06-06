using Domain;
using KorisnickiInterfejs.Exceptions;
using KorisnickiInterfejs.ServerCommunication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows;
using System.Windows.Forms;

namespace KorisnickiInterfejs.GUIController
{
    public class _AddMarkController
    {
        private FrmAddMark frmAddMark;
        private IDomainObject s;

        public _AddMarkController(FrmAddMark frmAddMark,IDomainObject s, int idSubject)
        {
            this.frmAddMark = frmAddMark;
            this.s = s;
            CurrentStudent = (Student)s;
            IdSubject = idSubject;            
        }

        public Student CurrentStudent { get; set; }
        public int CurrentClassId { get; set; }
        public int IdSubject { get; set; }
        public Mark AssignedMark { get; set; }

        #region InitData ----------------------------> + 2 parametra
        public void InitData(FrmAddMark f)
        {
            try
            {
                //Student converted = (Student)s;
                f.TxtStudentName.Text = CurrentStudent.FirstName + " " + CurrentStudent.LastName;
                //lblClassID.Text = classId.ToString();
                f.CbExaminationType.DataSource = Enum.GetValues(typeof(ExaminationType));
                f.TxtDateOfExamination.Text = DateTime.Now.ToString("dd.MM.yyyy hh:mm");
                f.TxtDateOfExamination.Enabled = false;
                f.TxtStudentName.Enabled = false;
                //CurrentStudent = converted;
                //CurrentClassId = classId;
                //IdSubject = idSubject;
            }
            catch (ServerCommunicationException)
            {
                throw;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region public void SaveMark(FrmAddMark frmAddMark)
        public void SaveMark(FrmAddMark f)
        {
            try
            {
                if (Communication.Instance.MarkIsConcluded(IdSubject, CurrentStudent.IdStudent))
                {
                    throw new Exception("You are not allowed to add Marks when Mark is already concluded!");
                }
                Mark m = new Mark();                
                m.Student = new Student
                {
                    IdStudent = CurrentStudent.IdStudent,
                    FirstName = CurrentStudent.FirstName,
                    LastName = CurrentStudent.LastName,
                    PhoneNumber=CurrentStudent.PhoneNumber,
                    Address=CurrentStudent.Address,
                    BirthDate=CurrentStudent.BirthDate,
                    ClassGroup=CurrentStudent.ClassGroup                    
                };
                if (string.IsNullOrEmpty(f.TxtValue.Text) || int.Parse(f.TxtValue.Text) < 1 || int.Parse(f.TxtValue.Text) > 5)
                {
                    MessageBox.Show("Enter valid Mark value (1-5)!");
                    return;
                }
                m.Value = int.Parse(f.TxtValue.Text);
                m.ExaminationType = (ExaminationType)f.CbExaminationType.SelectedItem;
                m.DateOfExamination = DateTime.Now.ToString("yyyyMMdd HH:mm:ss");
                AssignedMark = m;
                f.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // throw;
            }
        }
        #endregion
    }
}
