using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_1_TASK_3
{
    public class Memento
    {
        private string? state;


        private Memento(string? state) { this.state = state; }  

        private string getState() { return state!; }

    }
}
