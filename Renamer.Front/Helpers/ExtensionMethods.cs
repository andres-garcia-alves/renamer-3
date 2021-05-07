namespace Renamer.Front.Helpers
{
    internal static class ExtensionMethods
    {
        /// <summary>
        /// Truncates this text to the desired MaxLenght.
        /// </summary>
        /// <param name="text">Text to truncate.</param>
        /// <param name="maxLenght">Desired maximum leght.</param>
        public static string Truncate(this string text, int maxLenght)
        {
            return (text.Length <= maxLenght) ? text : text.Substring(0, maxLenght);
        }
    }
}
