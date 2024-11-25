using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EnrollmentSystemProject.ListSubjectModel;

namespace EnrollmentSystemProject
{
    class ListSubjectController
    {
        private ListSubjectData listSubjectData;
        private ListSubjectView listSubjectView;

        public ListSubjectController(ListSubjectForm form)
        {
            listSubjectData = new ListSubjectData();
            listSubjectView = new ListSubjectView(form);
        }

        public ListSubjectController()
        {
        }

        public void registerSubject(Subjects subjects)
        {
            listSubjectData.insertSubject(subjects);
            listSubjectView.updateData(listSubjectData.getSubjectList());
        }
        public void deleteSubject(string id)
        {
            listSubjectData.deleteSubject(id);
            listSubjectView.updateData(listSubjectData.getSubjectList());
        }
    }
}
