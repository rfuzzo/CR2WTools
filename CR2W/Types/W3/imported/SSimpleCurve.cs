using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using CR2W.IO;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SSimpleCurve 
{
#region RED Properties

[REDProp("CurveType")]
public ESimpleCurveType CurveType { get; set;}

[REDProp("ScalarEditScale")]
public float ScalarEditScale { get; set;}

[REDProp("ScalarEditOrigin")]
public float ScalarEditOrigin { get; set;}

[REDProp("dataCurveValues")]
public Array<SCurveDataEntry> DataCurveValues { get; set;}

[REDProp("dataBaseType")]
public ECurveBaseType DataBaseType { get; set;}

#endregion
}
}