using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternCompositeConsoleApp
{
    class Composite : Component
    {
        Component composite;
        Component leaf;
        public ArrayList nodes = new ArrayList();
        public Composite (string name) :base(name) { }
        public override void Add(Component component)
        {
            nodes.Add(component);
        }

        public override Component GetCild(int index)
        {
            throw new NotImplementedException();
        }

        public override void Interpret(Contex contex)
        {
            if (contex.PositionRow == 5)
            {
                contex.PositionRow = 0;
                return;
            }
            if (contex.PositionRow < contex.RowCount)
            {
                Event ev = new Event(contex.nodes[contex.PositionRow, 0]);
                this.Add(ev);
                ev.Interpret(contex);
                contex.PositionRow++;
                this.Interpret(contex);
            }
        }

        public override void Operation()
        {
            Console.WriteLine(Name);
            foreach (Component component in nodes)
                component.Operation();
        }

        public override void Remove(Component component)
        {
            throw new NotImplementedException();
        }
    }
}
