namespace ExtensionMethods
{
    public static class ExtensionMethods
    {
        public static int GetSquare(this int value)
        {
            return value * value;
        }

        public static char NextChar(this Random random, bool isUpper = false)
        {
            return isUpper ? (char)random.Next(97, 123) : (char)random.Next(65, 91);

        }

        public static bool NextBool(this Random random)
        {
            return Convert.ToBoolean(random.Next(0, 2));
        }

        public static string NextString(this Random random, int length)
        {
            string output = string.Empty;
            for (int i = 0; i < length; i++)
            {
                output += random.NextChar(random.NextBool());
            }
            return output;
        }

        public static string TrimMiddleWhiteSpace(this string value)
        {
            return value.Replace(" ", string.Empty);
        }

    }
}
