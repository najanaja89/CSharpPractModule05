using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractModule05
{
    public class Method1
    {
        public void GetMethod2()
        {
            try
            {
                Method2 m2 = new Method2();
                m2.GetMethod2();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
