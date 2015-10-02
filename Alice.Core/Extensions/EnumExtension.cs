using System.ComponentModel;

namespace System
{
    public static class EnumExtension
    {
        public static string GetDescription(this Enum value)
        {
            var fieldInfo = value.GetType().GetField(value.ToString());
            if (fieldInfo == null)
                return default(string);

            var attributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);
            if (attributes.Length > 0)
                return attributes[0].Description;

            return value.ToString();
        }
    }
}
