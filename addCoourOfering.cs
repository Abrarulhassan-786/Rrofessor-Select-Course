using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Assignment
{
    public class addCoourOfering
    {
        string professor;
        string course;
        string cours1;
        string cours2;
        string cours3;
        public addCoourOfering(string p, string c) 
        {
            professor = p;
            course = c;
        }
        public addCoourOfering(string c1, string c2, string c3) 
        {
            cours1 = c1;
            cours2 = c2;
            cours3 = c3;
         }
        public string getoffering() 
        {
            string getoffering;
            getoffering = course;
            return getoffering;
        }
        public string setProfessor() 
        {
            string addprofessor;
            addprofessor = professor;
            return addprofessor;
        }

    }
}
