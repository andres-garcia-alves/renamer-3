namespace Renamer.Engine.Helpers
{
    internal static class ExtensionMethods
    {
        public static string Truncate(this string text, int maxLenght)
        {
            return (text.Length <= maxLenght) ? text : text.Substring(0, maxLenght);
        }

        /// <summary>
        /// Verify if a text is numeric.
        /// </summary>
        /// <param name="text">Text to validate.</param>
        /// <param name="zeroIsValid">Include zero as valid number.</param>
        /// <returns>Returns true if the text is a valid number, otherwise false.</returns>
        public static bool IsNumeric(this string text, bool zeroIsValid)
        {
            if (zeroIsValid == false && text == "0") { return false; }

            try
            {
                Int32.Parse(text);
                return true;
            }
            catch (Exception) { return false; }
        }

        /// <summary>
        /// Verify if a text is valid as filename.
        /// </summary>
        /// <param name="text">Text to validate.</param>
        /// <returns>Returns true if the text is a valid filename, otherwise false.</returns>
        public static bool IsValidFileName(this string text)
        {
            if (text.Contains('\\') || text.Contains('/') || text.Contains(':') ||
                text.Contains('*') || text.Contains('?') || text.Contains('"') ||
                text.Contains('<') || text.Contains('>') || text.Contains('|'))
                return false;

            return true;
        }
    }
}
