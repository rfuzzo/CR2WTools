using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RED.CR2W;
using RED.IO;

namespace RED.Core
{
    public abstract class ISerializable : IReferencable
    {
        protected virtual void Serialize(Stream stream)
        {


        }

        protected virtual void DeSerialize(Stream stream)
        {


        }
    }
}