﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Reflection;

namespace _07_AssemblyAndReflection
{
    class _02_CultureInfo
    {
        void ThisIsMain()
        {
            Assembly assemblyObject = Assembly.GetEntryAssembly();
            AssemblyName assemblyName = assemblyObject.GetName();

            Console.WriteLine(assemblyName.CultureName);

            CultureInfo culture = new CultureInfo("en-GB");
            assemblyName.CultureInfo = culture;
            Console.WriteLine(assemblyName.CultureInfo.Name);
            Console.WriteLine(assemblyName.CultureInfo.NativeName);
        }
    }
}
