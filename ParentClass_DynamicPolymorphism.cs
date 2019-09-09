using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jay_7_OOPS_windows_forms
{
    class ParentClass
    {
        public virtual void Display()
        {
            MessageBox.Show("Parent class structure executed");
        }
    }
    class childClass : ParentClass
    {
        public override void Display()
        {
            //base.Display();
            MessageBox.Show("child class structure exicuted");
        }
    }
}
