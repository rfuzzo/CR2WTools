using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CExtAnimEventsFile : CResource
{
#region RED Properties

[REDProp("requiredSfxTag")]
public CName RequiredSfxTag { get; set;}

#endregion
}
}