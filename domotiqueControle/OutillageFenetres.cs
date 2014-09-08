using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace domotiqueControle
{
    public class MdiDirector<T> : Form where T : Form, new()
    {
        private static WeakReference<T> _instance = null;

        public static void ShowUnique(index parent)
        {
            GC.Collect();
            T formulaire;
            if (_instance == null)
            {
                formulaire = new T();
                formulaire.MdiParent = parent;
                formulaire.Show();
                formulaire.WindowState = FormWindowState.Maximized;
                _instance = new WeakReference<T>(formulaire);
            }
            else
            {
                if (!_instance.TryGetTarget(out formulaire))
                {
                    formulaire = new T();
                    formulaire.MdiParent = parent;
                    formulaire.Show();
                    formulaire.WindowState = FormWindowState.Maximized;
                    _instance.SetTarget(formulaire);
                }
                else
                {
                    formulaire.Focus();
                    formulaire.Show();
                    //parent.ActivateMdiChild(formulaire);
                    formulaire.WindowState = FormWindowState.Maximized;
                }
            }
        }
    }
}
