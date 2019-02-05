using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RED.Core
{
    /// <summary>
    /// Represents a custom .reddlc file used to mount custom assests for dlc.
    /// </summary>
    public class CDLCDefinition : CResource
    {
        #region RED Fields
        [RED] private protected CName id;
        [RED] private protected string localizedNameKey;
        [RED] private protected string localizedDescriptionKey;
        [RED(2, 0)] private protected TDynArray<Pointer<IGameplayDLCMounter>> mounters;
        [RED(2, 0)] private protected TDynArray<SDLCLanguagePack> languagePacks;
        [RED] private protected bool initiallyEnabled;
        [RED] private protected bool visibleInDLCMenu;
        [RED] private protected bool requiredByGameSave;
        #endregion

        public CName Id
        {
            get => id;
            set => id = value;
        }
        public string LocalizedNameKey
        {
            get => localizedNameKey;
            set => localizedNameKey = value;
        }
        public string LocalizedDescriptionKey
        {
            get => localizedDescriptionKey;
            set => localizedDescriptionKey = value;
        }
        public TDynArray<Pointer<IGameplayDLCMounter>> Mounters
        {
            get => mounters;
            set => mounters = value;
        }
        public TDynArray<SDLCLanguagePack> LanguagePacks
        {
            get => languagePacks;
            set => languagePacks = value;
        }
        public bool InitiallyEnabled
        {
            get => initiallyEnabled;
            set => initiallyEnabled = value;
        }
        public bool VisibleInDLCMenu
        {
            get => visibleInDLCMenu;
            set => visibleInDLCMenu = value;
        }
        public bool RequiredByGameSave
        {
            get => requiredByGameSave;
            set => requiredByGameSave = value;
        }
    }
}