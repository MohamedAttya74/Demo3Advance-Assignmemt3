using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3Advance_Assignmemt3
{
    internal interface ICustomComparer
    {
        bool Compare (int X , int Y );
    }

    internal class AscComparer : ICustomComparer
    {
        public bool Compare(int X, int Y) => X > Y;
       
    }
    internal class DscComparer : ICustomComparer
    {
        public bool Compare(int X, int Y) => X < Y;
       
    }
}
