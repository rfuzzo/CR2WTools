using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RED.Core
{
    public class CSwfTexture : CBitmapTexture
    {
        #region RED fields
        [RED] private protected string linkageName;
        #endregion

        public string LinkageName
        {
            get => linkageName;
            set => linkageName = value;
        }
    }
}