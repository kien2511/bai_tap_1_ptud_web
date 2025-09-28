using System;
using System.Collections.Generic;

namespace DLL
{
    public class Class1
    {
        // Bảng ánh xạ số -> "ngôn ngữ côn trùng"
        private static readonly Dictionary<char, string> mapping = new Dictionary<char, string>()
        {
            { '0', "🐞 Bọ rùa" },
            { '1', "🐜 Kiến" },
            { '2', "🦗 Dế" },
            { '3', "🐝 Ong" },
            { '4', "🦋 Bướm" },
            { '5', "🐛 Sâu" },
            { '6', "🦂 Bọ cạp" },
            { '7', "🪲 Bọ hung" },
            { '8', "🕷️ Nhện" },
            { '9', "🦟 Muỗi" }
        };

        /// <summary>
        /// Chuyển số (dưới dạng chuỗi) thành "ngôn ngữ côn trùng".
        /// </summary>
        public static string ToBugLanguage(string number)
        {
            if (string.IsNullOrEmpty(number))
                return "";

            List<string> result = new List<string>();

            foreach (char c in number)
            {
                if (mapping.ContainsKey(c))
                {
                    result.Add(mapping[c]);
                }
                else
                {
                    // Nếu nhập ký tự không phải số thì giữ nguyên
                    result.Add(c.ToString());
                }
            }

            // Chuyển List<string> sang string[] cho .NET 2.0
            return string.Join(" ", result.ToArray());
        }
    }
}
