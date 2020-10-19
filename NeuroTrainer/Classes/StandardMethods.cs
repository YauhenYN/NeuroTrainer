using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuroTrainer.Classes
{
    public delegate void standard_Delegate();
    public class StandardMethods
    {
        Form form;
        public StandardMethods(DrawForm form)
        {
            this.form = form;
        }
        public event standard_Delegate Closing_Event;
        public event standard_Delegate CompleteSize_Event;
        public event standard_Delegate RollUp_Event;
        public event standard_Delegate Dragging_Event;
        public void closing()
        {
            Closing_Event?.Invoke();
        }
        public void completeSize()
        {
            CompleteSize_Event?.Invoke();
            if (form.WindowState != FormWindowState.Maximized) form.WindowState = FormWindowState.Maximized;
            else form.WindowState = FormWindowState.Normal;
        }
        public void rollUp()
        {
            RollUp_Event?.Invoke();
            form.WindowState = FormWindowState.Minimized;
        }
        public void dragging()
        {
            Dragging_Event?.Invoke();
        }
    }
}
