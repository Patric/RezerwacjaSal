using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RezerwacjaSal
{

    public static class Navigator
    {
        private static Form currentRoot
        {
            get;
            set;
        }


        public static void navigateRoot()
        {

            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {   

                if (Application.OpenForms[i].Name.ToString().Equals("Login"))
                {
                    Application.OpenForms[i].Hide();

                }
                else
                {
                    Application.OpenForms[i].Close();
                }
            }



            switch (Int32.Parse(Authenticator.currentUser.role))
            {
                //ordyantor
                case 0:
                    {
                        // Powinien otwieraæ panel ordynatora, którego nie robimy
                        currentRoot = new ReservePatientRoom();
                        break;
                    }
                case 1:
                    {
                        // Powinien otwieraæ panel lekarza, który robimy
                        currentRoot = new DoctorsPanel();
                        break;
                    }
                  
            }

            currentRoot.Show();

        }
        // Closes all forms without main form and opens new one
        public static void navigateTo(Form form)
        {
            // Close all forms
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {

                if (Application.OpenForms[i].Name.ToString().Equals("Login"))
                {
                    Application.OpenForms[i].Hide();

                }
                else
                {
                    Application.OpenForms[i].Close();
                }
            }
            // Show current form
            form.Show();

        }

        // Hides parent and opens child
        public static void navigateToChild(Form child, Form parent)
        {
           
            parent.Hide();

            // Close all forms
            foreach (Form form_ in Application.OpenForms)
            {
                if (currentRoot.Name.ToString().Equals(form_.Name.ToString()) &&
                    !currentRoot.Name.ToString().Equals(form_.Name.ToString()))
                {
                    form_.Close();
                }

            }

            // Show current form
            child.Show();

        }

        // Closes child and unhides parent
        public static void navigateBack(Form child)
        {
            for (int i = Application.OpenForms.Count - 2; i >= 0; i--)
            {

                if (Application.OpenForms[i].IsAccessible == false)
                {
                    child.Hide();
                    Application.OpenForms[i].Show();
                    break;
                }
            }

         
            child.Close();

        }

        public static void newLogin()
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {

                if (Application.OpenForms[i].Name.ToString().Equals("Login"))
                {
                    Application.OpenForms[i].Show();
                    

                }
                else
                {
                    Application.OpenForms[i].Close();
                }
            }
           
        }








    }
  



   
}
   


