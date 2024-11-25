using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrollmentSystemProject
{
    internal class SubjectLoadController
    {
        private readonly SubjectLoadModel subjectLoadModel;
        public SubjectLoadController()
        {
            subjectLoadModel = new SubjectLoadModel();
        }
        public void UpdateView(SubjectLoadForm form)
        {
            var subjectList = subjectLoadModel.GetSubjects(form.txtProgram.Text, form.txtYear.Text, form.txtTerm.Text);
            form.SLsubjectDGV.DataSource = subjectList;
        }
        public void SelectSubjects(DataGridView SLsubjectDGV, DataGridView SubjectLoadDGV, TextBox txtNoOfSubjects, TextBox txtNoOfUnits)
        {
            subjectLoadModel.SubjectLoadDGVData.Rows.Clear();
            int totalUnits = 0;
            for (int i = 0; i < SLsubjectDGV.Rows.Count; i++)
            {
                if (Convert.ToBoolean(SLsubjectDGV.Rows[i].Cells[0].Value) == true)
                {
                    DataRow row = subjectLoadModel.SubjectLoadDGVData.NewRow();
                    row["_id"] = SLsubjectDGV.Rows[i].Cells[1].Value.ToString();
                    row["Program"] = SLsubjectDGV.Rows[i].Cells[2].Value.ToString();
                    row["YearLevel"] = SLsubjectDGV.Rows[i].Cells[3].Value.ToString();
                    row["Term"] = SLsubjectDGV.Rows[i].Cells[4].Value.ToString();
                    row["CourseCode"] = SLsubjectDGV.Rows[i].Cells[5].Value.ToString();
                    row["Subject"] = SLsubjectDGV.Rows[i].Cells[6].Value.ToString();
                    row["Units"] = Convert.ToInt32(SLsubjectDGV.Rows[i].Cells[7].Value);
                    subjectLoadModel.SubjectLoadDGVData.Rows.Add(row);

                    totalUnits += Convert.ToInt32(SLsubjectDGV.Rows[i].Cells[7].Value);
                }      
            }
            SubjectLoadDGV.DataSource = subjectLoadModel.SubjectLoadDGVData;
            txtNoOfSubjects.Text = (SubjectLoadDGV.Rows.Count - 1).ToString();
            txtNoOfUnits.Text = totalUnits.ToString();
        }
    }
}
