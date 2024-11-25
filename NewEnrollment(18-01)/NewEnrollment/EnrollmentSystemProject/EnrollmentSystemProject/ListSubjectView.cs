using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EnrollmentSystemProject.ListSubjectModel;

namespace EnrollmentSystemProject
{
    internal class ListSubjectView
    {
        private ListSubjectForm form;

        public ListSubjectView(ListSubjectForm form)
        {
            this.form = form;
        }
        public void updateData(List<Subjects> subjlist)
        {
            form.SubjectDataGridView.DataSource = subjlist;
        }
    }
}
