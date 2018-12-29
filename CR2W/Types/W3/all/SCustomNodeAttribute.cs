using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SCustomNodeAttribute 
{
#region RED Properties

[REDProp("attributeName")]
public CName AttributeName { get; set;}

[REDProp("attributeValue")]
public string AttributeValue { get; set;}

[REDProp("attributeValueAsCName")]
public CName AttributeValueAsCName { get; set;}

#endregion
}
}