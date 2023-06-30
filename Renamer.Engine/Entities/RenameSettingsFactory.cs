using System.Collections.Generic;

namespace Renamer.Engine.Entities
{
    public class RenameSettingsFactory
    {
        public static RenameSettings SentenceCase(bool includeExtension)
        {
            var parameters = new List<string>();
            return new RenameSettings(RenameType.SentenceCase, parameters, includeExtension);
        }

        public static RenameSettings TitleCase(bool includeExtension)
        {
            var parameters = new List<string>();
            return new RenameSettings(RenameType.TitleCase, parameters, includeExtension);
        }

        public static RenameSettings UpperCase(bool includeExtension)
        {
            var parameters = new List<string>();
            return new RenameSettings(RenameType.UpperCase, parameters, includeExtension);
        }

        public static RenameSettings LowerCase(bool includeExtension)
        {
            var parameters = new List<string>();
            return new RenameSettings(RenameType.LowerCase, parameters, includeExtension);
        }

        public static RenameSettings InvertedCase(bool includeExtension)
        {
            var parameters = new List<string>();
            return new RenameSettings(RenameType.InvertedCase, parameters, includeExtension);
        }

        public static RenameSettings RemoveTildes(bool includeExtension)
        {
            var parameters = new List<string>();
            return new RenameSettings(RenameType.RemoveTildes, parameters, includeExtension);
        }

        public static RenameSettings BySimpleMatch(string matchSearch, string matchRemplacement, bool includeExtension)
        {
            var parameters = new List<string>() { matchSearch, matchRemplacement };
            return new RenameSettings(RenameType.BySimpleMatch, parameters, includeExtension);
        }

        public static RenameSettings ByPattern(string beginnigText, string startIndex, string increment, string numericPad, bool includeExtension)
        {
            var parameters = new List<string>() { beginnigText, startIndex, increment, numericPad };
            return new RenameSettings(RenameType.ByPattern, parameters, includeExtension);
        }

        public static RenameSettings PositionalReplace(string positionalReplaceIndex, string positionalReplaceText, bool includeExtension)
        {
            var parameters = new List<string>() { positionalReplaceIndex, positionalReplaceText };
            return new RenameSettings(RenameType.PositionalReplace, parameters, includeExtension);
        }

        public static RenameSettings PositionalAppend(string positionalAppendIndex, string positionalAppendText, bool includeExtension)
        {
            var parameters = new List<string>() { positionalAppendIndex, positionalAppendText };
            return new RenameSettings(RenameType.PositionalAppend, parameters, includeExtension);
        }

        public static RenameSettings Unknown()
        {
            var parameters = new List<string>();
            return new RenameSettings(RenameType.Unknown, parameters, false);
        }
    }
}
