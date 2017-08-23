﻿namespace EarthWithMagicAPI.API.Registry
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Text;
    using EarthWithMagicAPI.API.Interfaces.Items;

    public static class ItemRegistry
    {
        public static List<IItem> Items = new List<IItem>();

        static ItemRegistry()
        {
            Assembly itemAssembly = Assembly.Load(new AssemblyName("EarthMagicItems"));
            Type interfaceType = typeof(IItem);

            foreach (Type item in itemAssembly.GetTypes())
            {
                if (interfaceType.IsAssignableFrom(item))
                {
                    IItem someItem = (IItem)itemAssembly.CreateInstance(item.FullName, false);
                    Items.Add(someItem);
                }
            }
        }
    }
}