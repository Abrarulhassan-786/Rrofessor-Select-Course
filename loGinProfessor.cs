using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Assignment
{
   public class loGinProfessor
    {
      public string UserName;
      public string Password;

       public loGinProfessor() { }
       public loGinProfessor(string u, string p) 
       {
           UserName = u;
           Password = p;
       }
       public void loggedin()
       {
           if (UserName == "faizan" && Password == "faizan")
           {
               AddCoursing addcourseProfessor = new AddCoursing();
               MessageBox.Show(UserName + " loggend Sucessfully");
               addcourseProfessor.Show();

           }
           else
           {
               MessageBox.Show(UserName + " Try again");
           }
       }
    }
    
}
