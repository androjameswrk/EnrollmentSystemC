using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrollmentSystemProject
{
    public class AssessmentController
    {
        private readonly AssessmentForm assessmentForm;
        private readonly AssessmentModel assessmentModel;

        public AssessmentController(AssessmentForm form)
        {
            assessmentForm = form;
            assessmentModel = new AssessmentModel();
        }     
    }
}