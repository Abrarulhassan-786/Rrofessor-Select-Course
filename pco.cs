using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class pco
    {
        addCoourOfering course;
        public string semster;
        public string addoffersing;

        public pco(){}
        public pco(string se,string adof) 
        {
            semster = se;
            addoffersing = adof;
        }
        public string getoffering()
        {
            string getoffering;
            getoffering = course.getoffering();
            return getoffering;
        }
        public string setProfessor()
        {
            string setprofessor;
            setprofessor = course.setProfessor() + " " + course.getoffering();
            return setprofessor;
        }
    }
}
