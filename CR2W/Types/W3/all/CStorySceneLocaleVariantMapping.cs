using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CStorySceneLocaleVariantMapping 
{
#region RED Properties

[REDProp("localeId")]
public uint LocaleId { get; set;}

[REDProp("variantId")]
public uint VariantId { get; set;}

#endregion
}
}