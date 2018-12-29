using CR2W.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CAIStorageRiderData : IScriptable
{
#region RED Properties

[REDProp("sharedParams")]
public Handle<CHorseRiderSharedParams> SharedParams { get; set;}

[REDProp("ridingManagerMountError")]
public bool RidingManagerMountError { get; set;}

[REDProp("ridingManagerCurrentTask")]
public ERidingManagerTask RidingManagerCurrentTask { get; set;}

[REDProp("horseScriptedActionTree")]
public Handle<IAIActionTree> HorseScriptedActionTree { get; set;}

[REDProp("ridingManagerDismountType")]
public EDismountType RidingManagerDismountType { get; set;}

[REDProp("ridingManagerInstantMount")]
public bool RidingManagerInstantMount { get; set;}

        #endregion

        //FIXME abstract classes
        public override UInt16 Flags { get; set; }
        public override UInt32 Template { get; set; }

        public override event SerializeEventHandler Serialize;
        public override event DeSerializeEventHandler DeSerialize;

        public override void OnSerialize(IFile source, REDEventArgs e) { }
        public override void OnDeSerialize(IFile source, REDEventArgs e) { }
    }
}