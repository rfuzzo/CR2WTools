using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CMenuBackgroundVideoFileParam : IMenuBackgroundVideoParam
{
#region RED Properties

[REDProp("videoFile")]
public string VideoFile { get; set;}

#endregion
}
}