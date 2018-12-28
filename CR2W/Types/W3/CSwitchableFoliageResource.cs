using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CSwitchableFoliageResource : CResource
{
#region RED Properties

[REDProp("entries")]
public Array<SSwitchableFoliageEntry> Entries { get; set;}

#endregion
}
}