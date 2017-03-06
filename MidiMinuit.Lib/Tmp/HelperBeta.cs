using System;
using System.Collections.Generic;
using System.Linq;

namespace MidiMinuit.Lib.Tmp
{
    public static class HelperBeta
    {
        public static List<List<T>> GetCombinaisons<T>(List<T> list)
        {
            var result = new List<List<T>>();

            var count = Math.Pow(2, list.Count);
            for (var i = 1; i <= count - 1; i++)
            {
                var tmp = new List<T>();
                var str = Convert.ToString(i, 2).PadLeft(list.Count, '0');
                for (var j = 0; j < str.Length; j++)
                {
                    if (str[j] == '1')
                    {
                        tmp.Add(list[j]);
                    }
                }

                result.Add(tmp);
            }

            result = result
                .Where(x => x.Count == 3)
                .ToList();

            return result;
        }
    }
}