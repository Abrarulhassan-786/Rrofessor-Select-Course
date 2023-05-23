using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment2ByAbrar
{
    class course
    {
        pco professorCourseManager = new pco();
        loGinProfessor log = new loGinProfessor();
        addCoourOfering courseoffering;
        string coourse;
        string professor;

        public course()
        {
            coourse = professorCourseManager.addoffersing;
            professor = log.UserName;
            courseoffering = new addCoourOfering(coourse, professor);
        }
        public string getooffering()
        {
            string getoffering;
            getoffering = coourse + " " + courseoffering.getoffering();
            return getoffering;
        }
        public string setOffering() 
        {
            string setoffering;
            setoffering = professor + " " + courseoffering.setProfessor() + " " + coourse + courseoffering.getoffering();
            return setoffering;
        }
    }
}
