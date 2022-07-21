using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace VMirror
{
    public class CppParser
    {
        static List<ReflectedClass> Parse(string file)
        {
            List<ReflectedClass> Classes = new List<ReflectedClass>();
            string FC = File.ReadAllText(file);
            List<String> Lines = new List<string>();
            foreach(string L in FC.Split(';', '\n'))
            {
                if (L.Replace(" ", "").Replace("	", "").Length == 0)
                    continue;
                Lines.Append(L);
            }

            for (int x = 0; x <= Lines.Count; x++)
            {
                if (Lines[x].Contains("VClass()"))
                {
                   Lines[x]
                }
            }

            return Classes;
        }
    }
}