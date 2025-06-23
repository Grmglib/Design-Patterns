using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandExampleB
{
    public interface IRobotCommand
    {
        void Execute();
        void Undo();
    }
}
