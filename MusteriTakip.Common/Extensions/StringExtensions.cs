namespace MusteriTakip.Common.Extensions
{
    /// <summary>
    /// Author: Can DOĞU
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Checks if string is null or empty
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsNullOrEmpty(this string str)
        {
            return string.IsNullOrEmpty(str);
        }

        /// <summary>
        /// Checks if string is not null or empty
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsNotNullOrEmpty(this string str)
        {
            return !string.IsNullOrEmpty(str);
        }
    }
}
