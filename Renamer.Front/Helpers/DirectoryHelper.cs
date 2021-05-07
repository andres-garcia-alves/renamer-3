using System;
using System.IO;

namespace Renamer.Front.Helpers
{
    internal class DirectoryHelper
    {
        public static string GetPath(Enums.QuickAccess quickAccess)
        {
            if (quickAccess == Enums.QuickAccess.UserFolder)
                return Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            
            else if (quickAccess == Enums.QuickAccess.Desktop)
                return Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            
            else if (quickAccess == Enums.QuickAccess.Documents)
                return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            
            else if (quickAccess == Enums.QuickAccess.Downloads)
                return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
            
            else if (quickAccess == Enums.QuickAccess.Music)
                return Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            
            else if (quickAccess == Enums.QuickAccess.Pictures)
                return Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            
            else if (quickAccess == Enums.QuickAccess.Videos)
                return Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
            
            else throw new ArgumentException("Unknown QuickAccess", nameof(quickAccess));
        }
    }
}
