using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_1_TASK_3
{
    public class Caretaker
    {
        private Originator Originator;

        private Memento[] histoy;


        public void doSomething()
        {

            var m = histoy[0];

            Originator.restore(m);
        }

        public void undo() {

            var m = Originator;

            histoy.SetValue(m, 0);

        }

    }
}
