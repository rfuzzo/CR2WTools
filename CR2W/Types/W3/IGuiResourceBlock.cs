
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public interface IGuiResourceBlock
	{
		Array<Ptr<CGraphSocket>> Sockets { get; set; }

	}
}
