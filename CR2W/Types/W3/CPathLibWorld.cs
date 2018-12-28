using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CPathLibWorld : CObject
{
#region RED Properties

[REDProp("globalSettings")]
public CPathLibSettings GlobalSettings { get; set;}

#endregion
}
}