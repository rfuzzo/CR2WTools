using System;


namespace CR2W.Types.W3
{
    public class CMenuRenderBackgroundParam : CObject, IMenuDisplayParam
    {
        [REDProp("renderGameWorld")]
        public bool RenderGameWrold { get; set; }
    }
}