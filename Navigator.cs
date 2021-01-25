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

            switch (Int32.Parse(Authenticator.currentUser.role))
            {
                case 0:
                    {
                        currentRoot = new ReservePatientRoom();
                       
                    }
                    break;
            }

            foreach (Form form in Application.OpenForms)
            {
                form.Hide();
            }
            currentRoot.Show();

            for (int i = Application.OpenForms.Count; i >= 0; i--)
            {
                if (!Application.OpenForms[i].IsAccessible)
                {
                    Application.OpenForms[i].Close();
                }
            }

        }
        public static void navigateTo(Form form)
        {
            currentRoot.Hide();

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
            form.Show();

        }






    }
  



   
}
   


