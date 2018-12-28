using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SBehaviorGraphBoneInfo 
{
#region RED Properties

[REDProp("m_boneName")]
public string M_boneName { get; set;}

[REDProp("m_weight")]
public float M_weight { get; set;}

[REDProp("num")]
public int Num { get; set;}

#endregion
}
}