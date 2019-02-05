using RED.IO;
using RED.Reflection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RED.Core
{
    public struct Vector
    {
        [RED] public float X;
        [RED] public float Y;
        [RED] public float Z;
        [RED] public float W;

        public override string ToString()
        {
            return String.Format("(X:{0},Y:{1},Z:{2},W:{3})", X, Y, Z, W);
        }
    }
}