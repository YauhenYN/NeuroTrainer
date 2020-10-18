using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NeuroTrainer.Classes
{
    public delegate void standart_Delegate();
    public class StandartMethods
    {
        public event standart_Delegate Closing_Event;
        public event standart_Delegate CompleteSize_Event;
        public event standart_Delegate RollUp_Event;
        public void closing()
        {
            Closing_Event?.Invoke();
        }
        public void CompleteSize()
        {
            CompleteSize_Event?.Invoke();
        }
        public void rollUp()
        {
            RollUp_Event?.Invoke();
        }
    }
}
