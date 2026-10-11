


using CodeWalker.Properties;

namespace CodeWalker.GameFiles
{

    public static class GameFileCacheFactory
    {

        public static GameFileCache Create()
        {
            var s = Settings.Default;
            var gfc = new GameFileCache(s.CacheSize, s.CacheTime, GTAFolder.CurrentGTAFolder, GTAFolder.IsGen9, s.DLC, s.EnableMods, s.ExcludeFolders);
            gfc.EnableDlc = s.EnableDLC;
            return gfc;
        }

    }

}