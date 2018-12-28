using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SDismembermentEffect 
{
#region RED Properties

[REDProp("name")]
public CName Name { get; set;}

[REDProp("typeMask")]
public EDismembermentEffectTypeFlag TypeMask { get; set;}

#endregion
}
}