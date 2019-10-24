using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternCompositeConsoleApp
{
    class Event: Composite
    {
        public Event (string name) :base(name) { }

        public override void Interpret(Contex contex)
        {
            if (contex.PositionCollum == 5)
            {
                contex.PositionCollum = 0;
                return;
            }
            if (contex.PositionCollum < contex.CollumCount -1)
            {
                Totall totall = new Totall(contex.nodes[contex.PositionRow, contex.PositionCollum + 1]);
                this.Add(totall);
                contex.PositionCollum++;
                this.Interpret(contex);
            }
        }
    }
}
