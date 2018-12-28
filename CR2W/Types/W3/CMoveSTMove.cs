using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CMoveSTMove : CMoveSTRotate
{
#region RED Properties

[REDProp("headingImportance")]
public float HeadingImportance { get; set;}

[REDProp("speedImportance")]
public float SpeedImportance { get; set;}

#endregion
}
}