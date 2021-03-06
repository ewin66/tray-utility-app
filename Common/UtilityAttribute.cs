﻿using System;

namespace Common
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class UtilityAttribute : Attribute
    {
        public UtilityAttribute(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
    }
}
