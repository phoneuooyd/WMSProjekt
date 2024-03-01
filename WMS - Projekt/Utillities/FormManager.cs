using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMS___Projekt.Utillities
{

    public static class FormManager
    {
        

        private static List<Form> openForms = new List<Form>();

        public static void ShowForm(Form form)
        {
            // Add the form to the list of open forms
            openForms.Add(form);

            // Show the form
            form.FormClosed += (s, e) => openForms.Remove(form); // Remove the form from the list when it's closed
            form.Show();
        }
    }
}
