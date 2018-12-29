using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SAnimationBufferBitwiseCompressedData 
{
#region RED Properties

[REDProp("dt")]
public float Dt { get; set;}

[REDProp("compression")]
public sbyte Compression { get; set;}

[REDProp("numFrames")]
public UInt16 NumFrames { get; set;}

[REDProp("dataAddr")]
public uint DataAddr { get; set;}

[REDProp("dataAddrFallback")]
public uint DataAddrFallback { get; set;}

#endregion
}
}