using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CMenuFlashSwfParam : IMenuFlashParam
{
#region RED Properties

[REDProp("flashSwfHandle")]
public Soft<CSwfResource> FlashSwfHandle { get; set;}

#endregion
}
}