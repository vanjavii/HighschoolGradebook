using Domain;
using KorisnickiInterfejs.Exceptions;
using KorisnickiInterfejs.ServerCommunication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows;
using System.Windows.Forms;

namespace KorisnickiInterfejs.GUIController
{
    public class _AddClassController
    {
        BindingList<Mark> assignedMarks = new BindingList<Mark>();
        public Student CurrentStudent { get; set; }
      
        #region InitData
        public void InitData(FrmAddClass f)
        {
            try
            {
                f.CbSubjects.DataSource = Communication.Instance.GetAllSubjects();
                //Subject s = (Subject)cbSubjects.SelectedItem;
                //cbTeachersOnSubject.DataSource = Controller.Instance.GetAllTeachersOnSubject(s.IdSubject);
                f.TxtDateTime.Text = DateTime.Now.ToString("dd.MM.yyyy");
                f.TxtDateTime.Enabled = false;
                //txtGeneratedClassID.Enabled = false;
                //txtGeneratedClassID.Text = Controller.Instance.GenerateClassId();
                //txtGeneratedClassID.Text = "623";
                f.DgvAssignedMarks.DataSource = assignedMarks;
                f.DgvAssignedMarks.Columns["TableName"].Visible = false;
                f.DgvAssignedMarks.Columns["InsertValues"].Visible = false;
                f.DgvAssignedMarks.Columns[0].Visible = false;                
                f.DgvAssignedMarks.Columns["IsFinal"].Visible = false;
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

        #region public void GetStudents(FrmAddClass frmAddClass)
        public void GetStudents(FrmAddClass f)
        {
            try
            {
                if (string.IsNullOrEmpty(f.TxtClassGroupID.Text))
                {
                    MessageBox.Show("Enter ClassGroupID!");
                    f.TxtClassGroupID.BackColor = Color.PowderBlue;
                    return;
                }
                f.TxtClassGroupID.BackColor = Color.White;
                //int selectedCg = int.Parse(txtClassGroupID.Text);
                bool IsInt = int.TryParse(f.TxtClassGroupID.Text, out int result);
                if (result == 0)
                {
                    MessageBox.Show("ClassGroupID you entered is not numeric! Enter valid classGroupID!");
                    return;
                }

                f.DgvStudentsFromSelectedClassGroup.DataSource = Communication.Instance.GetStudentsFromSelectedClassGroup(int.Parse(f.TxtClassGroupID.Text));
                f.DgvAssignedMarks.Columns["TableName"].Visible = false;
                f.DgvAssignedMarks.Columns["InsertValues"].Visible = false;
                f.DgvStudentsFromSelectedClassGroup.Columns["TableName"].Visible = false;
                f.DgvStudentsFromSelectedClassGroup.Columns["InsertValues"].Visible = false;
                f.BtnGetStudents.Enabled = false;
                f.CbSubjects.Enabled = false;
                f.CbTeachersOnSubject.Enabled = false;
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Server stopped running, you have to restart the server if you want to continue!", "SERVER STOPPED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }
        #endregion

        #region public void cbSubjects_SelectedValueChanged(FrmAddClass frmAddClass)
        public void cbSubjects_SelectedValueChanged(FrmAddClass f)
        {
            Subject s = (Subject)f.CbSubjects.SelectedItem;
            f.CbTeachersOnSubject.DataSource = Communication.Instance.GetAllTeachersOnSubject(s.IdSubject);
        }
        #endregion

        #region public void SaveAll(FrmAddClass frmAddClass)
        public void SaveAll(FrmAddClass f)
        {
            try
            {
                Domain.Class schoolClass = new Domain.Class();
                if (string.IsNullOrEmpty(f.TxtClassGroupID.Text))
                {
                    MessageBox.Show("Enter ClassGroupID!");
                    f.TxtClassGroupID.BackColor = Color.PowderBlue;
                    return;
                }
                f.TxtClassGroupID.BackColor = Color.White;
                bool IsInt = int.TryParse(f.TxtClassGroupID.Text, out int result);
                if (result == 0)
                {
                    MessageBox.Show("ClassGroupID you entered is not numeric! Enter valid classGroupID!");
                    return;
                }
                schoolClass.ClassGroup = new ClassGroupDatabase
                {
                    IdClassGroup = int.Parse(f.TxtClassGroupID.Text)
                };
                schoolClass.Teacher = (Teacher)f.CbTeachersOnSubject.SelectedItem;
                schoolClass.DateAndTime = DateTime.Now.ToString("yyyyMMdd HH:mm:ss");

                Subject selectedSubject = (Subject)f.CbSubjects.SelectedItem;
                bool checkExistence = Communication.Instance.ClassGroupAlreadyHadClassOfThatSubjectOnThatDay(int.Parse(f.TxtClassGroupID.Text), selectedSubject.IdSubject);
                if (checkExistence)
                {
                    MessageBox.Show("One ClassGroup is allowed to have only one Class of the Subject per day!");
                    return;
                }
                try
                {
                    DialogResult res = MessageBox.Show("Are you sure you want to save this Class?", "Saving confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes && !checkExistence)
                    {
                        int check = Communication.Instance.SaveClassAndAssignedMarks(schoolClass, assignedMarks);
                        if (check == 1)
                        {
                            MessageBox.Show("Class added successfully!");
                        }
                        else if (check == 2)
                        {
                            MessageBox.Show("Class and assigned marks added successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Problem!");
                        }
                    }
                    else { return; }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving Class! Check if ClassGroupID is valid!");
                    //throw;
                }
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Server stopped running, you have to restart the server if you want to continue!", "SERVER STOPPED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }
        #endregion

        #region public void dgvStudentsFromSelectedClassGroup_CellDoubleClick(FrmAddClass frmAddClass)
        public void dgvStudentsFromSelectedClassGroup_CellDoubleClick(FrmAddClass f)
        {
            Student s = (Student)f.DgvStudentsFromSelectedClassGroup.SelectedRows[0].DataBoundItem;
            Subject selectedSubject = (Subject)f.CbSubjects.SelectedItem;
            FrmAddMark frmAddMark = new FrmAddMark(s,selectedSubject.IdSubject);
            _AddMarkController cont = new _AddMarkController(frmAddMark,s,selectedSubject.IdSubject);            
            if (frmAddMark.ShowDialog() == DialogResult.OK)
            {
                cont.SaveMark(frmAddMark);
                Mark m = cont.AssignedMark;
                foreach (Mark item in assignedMarks)
                {
                    if (item.Student.IdStudent == cont.AssignedMark.Student.IdStudent)
                    {
                        MessageBox.Show("Mark was already given to this Student!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    } 
                }
                assignedMarks.Add(m);                
            }
            frmAddMark.Dispose();
        }
        #endregion

        #region public void RemoveSelectedRow(FrmAddClass frmAddClass)
        public void RemoveSelectedRow(FrmAddClass f)
        {
            try
            {
                if (f.DgvAssignedMarks.SelectedRows.Count == 0)
                {
                    MessageBox.Show("You haven't selected row to delete!");
                }
                Mark selectedMark = (Mark)f.DgvAssignedMarks.SelectedRows[0].DataBoundItem;
                assignedMarks.Remove(selectedMark);
            }
            catch (Exception)
            {
                //throw;
            }
        }
        #endregion

        #region public void txtClassGroupID_TextChanged(FrmAddClass frmAddClass)
        public void txtClassGroupID_TextChanged(FrmAddClass f)
        {
            f.TxtClassGroupID.BackColor = Color.White;
            try
            {
                if ((int.Parse(f.TxtClassGroupID.Text) < 1 && f.TxtClassGroupID.Text.Length == 1) || (int.Parse(f.TxtClassGroupID.Text) > 4) && f.TxtClassGroupID.Text.Length == 1)
                {
                    throw new Exception();
                }
                if (string.IsNullOrEmpty(f.TxtClassGroupID.Text) || f.TxtClassGroupID.Text.Length == 1)
                {
                    f.CbSubjects.DataSource = Communication.Instance.GetAllSubjects();
                }
                else
                {
                    FillComboBox(f);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Classgroup with this Id doesn't exist!");
                f.TxtClassGroupID.BackColor = Color.PowderBlue;
                return;
                //throw;
            }
        }
        #endregion

        #region private void FillComboBox(FrmAddClass f)
        public void FillComboBox(FrmAddClass f)
        {
            int idClassGroup = int.Parse(f.TxtClassGroupID.Text);
            int length = idClassGroup.ToString().Length;
            bool isMath = Communication.Instance.GetStreamFromClassGroup(idClassGroup);
            #region length=2 i social
            if (!isMath && length == 2 && (idClassGroup / 10 == 1 || idClassGroup / 10 == 2))
            {
                f.CbSubjects.DataSource = Communication.Instance.GetAllSubjects_1st_2nd_Social();
            }
            if (!isMath && length == 2 && (idClassGroup / 10 == 3))
            {
                f.CbSubjects.DataSource = Communication.Instance.GetAllSubjects_3rd_Social();
            }
            if (!isMath && length == 2 && (idClassGroup / 10 == 4))
            {
                f.CbSubjects.DataSource = Communication.Instance.GetAllSubjects_4th_Social();
            }
            #endregion
            #region length=3 i social
            if (!isMath && length == 3 && (idClassGroup / 100 == 1 || idClassGroup / 100 == 2))
            {
                f.CbSubjects.DataSource = Communication.Instance.GetAllSubjects_1st_2nd_Social();
            }
            if (!isMath && length == 3 && (idClassGroup / 100 == 3))
            {
                f.CbSubjects.DataSource = Communication.Instance.GetAllSubjects_3rd_Social();
            }
            if (!isMath && length == 3 && (idClassGroup / 100 == 4))
            {
                f.CbSubjects.DataSource = Communication.Instance.GetAllSubjects_4th_Social();
            }
            #endregion
            #region length=2 i mathematical
            if (isMath && length == 2 && (idClassGroup / 10 == 1))
            {
                f.CbSubjects.DataSource = Communication.Instance.GetAllSubjects_1st_2nd_Social();
            }
            if (isMath && length == 2 && (idClassGroup / 10 == 2))
            {
                f.CbSubjects.DataSource = Communication.Instance.GetAllSubjects_2nd_Math();
            }
            if (isMath && length == 2 && (idClassGroup / 10 == 3))
            {
                f.CbSubjects.DataSource = Communication.Instance.GetAllSubjects_3rd_Math();
            }
            if (isMath && length == 2 && (idClassGroup / 10 == 4))
            {
                f.CbSubjects.DataSource = Communication.Instance.GetAllSubjects_4th_Math();
            }
            #endregion
            #region length=3 i mathematical
            if (isMath && length == 3 && (idClassGroup / 100 == 1))
            {
                f.CbSubjects.DataSource = Communication.Instance.GetAllSubjects_1st_2nd_Social();
            }
            if (isMath && length == 3 && (idClassGroup / 100 == 2))
            {
                f.CbSubjects.DataSource = Communication.Instance.GetAllSubjects_2nd_Math();
            }
            if (isMath && length == 3 && (idClassGroup / 100 == 3))
            {
                f.CbSubjects.DataSource = Communication.Instance.GetAllSubjects_3rd_Math();
            }
            if (isMath && length == 3 && (idClassGroup / 100 == 4))
            {
                f.CbSubjects.DataSource = Communication.Instance.GetAllSubjects_4th_Math();
            }
            #endregion
        }
        #endregion
        
    }
}
