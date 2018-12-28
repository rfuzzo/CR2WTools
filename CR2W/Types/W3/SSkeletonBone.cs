using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SSkeletonBone 
{
#region RED Properties

[REDProp("name")]
public StringAnsi Name { get; set;}

[REDProp("nameAsCName")]
public CName NameAsCName { get; set;}

[REDProp("flags")]
public ESkeletonBoneFlags Flags { get; set;}

#endregion
}
}