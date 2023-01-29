using System.Text;

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

        /// <summary>
        /// Converts Turkish characters to English
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ToEng(this string str)
        {
            if (str.IsNullOrEmpty()) return string.Empty;

            if (str.Length == 0)
            {
                return string.Empty;
            }

            StringBuilder res = new StringBuilder();

            foreach (char c in str)
            {
                switch (c.ToString())
                {
                    case "ı":
                        res.Append("i");
                        break;

                    case "ğ":
                        res.Append("g");
                        break;

                    case "ü":
                        res.Append("u");
                        break;

                    case "ş":
                        res.Append("s");
                        break;

                    case "ö":
                        res.Append("o");
                        break;

                    case "ç":
                        res.Append("c");
                        break;

                    case "İ":
                        res.Append("I");
                        break;

                    case "Ğ":
                        res.Append("G");
                        break;

                    case "Ü":
                        res.Append("U");
                        break;

                    case "Ş":
                        res.Append("S");
                        break;

                    case "Ö":
                        res.Append("O");
                        break;

                    case "Ç":
                        res.Append("C");
                        break;

                    default:
                        res.Append(c.ToString());
                        break;

                }
            }

            return res.ToString();
        }
    }
}
