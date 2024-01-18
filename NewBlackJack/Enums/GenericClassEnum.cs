using System.ComponentModel;
using System.Reflection;

namespace NewBlackJack.Enums
{
    public static class GenericClassEnum
    {
        public static List<string> ObterListaEnumDescription<TEnum>() where TEnum : Enum
        {
            List<string> descriptions = new List<string>();

            Type enumType = typeof(TEnum);

            if (enumType.IsEnum)
            {
                Array enumValues = Enum.GetValues(enumType);

                foreach (var value in enumValues)
                {
                    FieldInfo field = enumType.GetField(value.ToString());

                    // Tenta obter o atributo Description
                    if (Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) is DescriptionAttribute attribute)
                    {
                        descriptions.Add(attribute.Description);
                    }
                    else
                    {
                        // Se não houver atributo Description, adiciona o próprio valor do enum como descrição
                        descriptions.Add(value.ToString());
                    }
                }
            }

            return descriptions;
        }

        public static string ObterEnumDescription(this Enum value)
        {
            Type type = value.GetType();
            MemberInfo[] memberInfo = type.GetMember(value.ToString());

            if (memberInfo != null && memberInfo.Length > 0)
            {
                object[] attrs = memberInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);

                if (attrs != null && attrs.Length > 0)
                    return ((DescriptionAttribute)attrs[0]).Description;
            }

            return value.ToString();
        }

    }
}
