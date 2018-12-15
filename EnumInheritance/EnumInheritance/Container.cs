using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumInheritance
{
    public class Container
    {
        /// <summary>
        /// enum which is succeding Food
        /// </summary>
        public enum Fish
        {
            Tuna = Food.Tuna,
            Salmon = Food.Salmon
        }

        /// <summary>
        /// enum which is succeding Food
        /// </summary>
        public enum Fruit
        {
            Orange = Food.Orange,
            Apple = Food.Apple
        }

        /// <summary>
        /// based enum
        /// </summary>
        public enum Food
        {
            Tuna,
            Salmon,
            Orange,
            Apple
        }

        public static string ParseStuff(string input)
        {
            return Enum.IsDefined(typeof(Food), input) ?
                Enum.Parse(typeof(Food), input).ToString() : "error";
        }
    }
}
