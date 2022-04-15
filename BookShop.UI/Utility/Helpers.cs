using BookShop.Core.Models;
using BookShop.Core.Other;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace BookShop.UI.Utility
{
    internal static class Helpers
    {
        internal static bool IsAnyEmpty<T>(Predicate<T> predicate, params T[] values) where T : class
        {
            if (values is string[])
                return values.Cast<string>().Any(value => predicate(value.Trim() as T));

            return values.Any(value => predicate(value));
        }

        internal static byte[] CreateHash(string value)
        {
            if (string.IsNullOrEmpty(value)) throw new ArgumentNullException(nameof(value));

            var provider = MD5.Create();
            return provider.ComputeHash(Encoding.Default.GetBytes(value.Trim()));
        }

        internal static string UserTypeToString(this Employee emp)
        {
            switch ((UserType)emp.UserType)
            {
                case UserType.Admin: return "Адміністратор";
                case UserType.Employee: return "Робітник";
                case UserType.None: return "Тимчасовий";
                default: return "Не встановлений";
            }
        }

        internal class GenreComparer : IEqualityComparer<Genre>
        {
            public bool Equals(Genre x, Genre y)
            {
                return x.Id == y.Id ? true : false;
            }

            public int GetHashCode(Genre obj)
            {
                return obj.GetHashCode();
            }
        }
    }
}
