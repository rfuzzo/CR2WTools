using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CRandomFXEntity : CEntity
{
#region RED Properties

[REDProp("fxName")]
public Array<CName> FxName { get; set;}

[REDProp("intervalMin")]
public float IntervalMin { get; set;}

[REDProp("intervalMax")]
public float IntervalMax { get; set;}

[REDProp("fxTwiceInARow")]
public bool FxTwiceInARow { get; set;}

[REDProp("soundEvent")]
public string SoundEvent { get; set;}

[REDProp("soundDelay")]
public float SoundDelay { get; set;}

[REDProp("fxIndex")]
public Int32 FxIndex { get; set;}

[REDProp("size")]
public Int32 Size { get; set;}

[REDProp("interval")]
public float Interval { get; set;}

#endregion
}
}