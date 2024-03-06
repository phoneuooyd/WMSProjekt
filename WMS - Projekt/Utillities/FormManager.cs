using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMS___Projekt.Forms;

namespace WMS___Projekt.Utillities
{

    public static class FormManager
    {
        
        public static List<Form> openForms = new List<Form>();

        public static void ShowForm(Form form)
        {
            openForms.Add(form);
            form.FormClosed += (s, e) => openForms.Remove(form);
            form.Show();
        }


        public static void CloseAllForms()
        {
            foreach (Form form in Application.OpenForms)
            {
                form.Dispose();
            }
        }
    }
}
