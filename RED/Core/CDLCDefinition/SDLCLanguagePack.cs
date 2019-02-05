namespace RED.Core
{
    public class SDLCLanguagePack : REDClass
    {
        [RED(2, 0)] protected TDynArray<string> textLanguages;
        [RED(2, 0)] protected TDynArray<string> speechLanguages;
    }
}