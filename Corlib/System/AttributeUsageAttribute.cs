/*
 * Copyright(c) 2022 nifanfa, This code is part of the Moos licensed under the MIT licence.
 */

namespace System
{
    public sealed class AttributeUsageAttribute : Attribute
    {
        public AttributeTargets ValidOn { get; set; }
        public bool AllowMultiple { get; set; }
        public bool Inherited { get; set; }

        public AttributeUsageAttribute(AttributeTargets validOn)
        {
            ValidOn = validOn;
            Inherited = true;
        }

        public AttributeUsageAttribute(AttributeTargets validOn, bool allowMultiple, bool inherited)
        {
            ValidOn = validOn;
            AllowMultiple = allowMultiple;
            Inherited = inherited;
        }
    }

    public enum AttributeTargets
    {
        Assembly = 0x0001,
        Module = 0x0002,
        Class = 0x0004,
        Struct = 0x0008,
        Enum = 0x0010,
        Constructor = 0x0020,
        Method = 0x0040,
        Property = 0x0080,
        Field = 0x0100,
        Event = 0x0200,
        Interface = 0x0400,
        Parameter = 0x0800,
        Delegate = 0x1000,
        ReturnValue = 0x2000,
        GenericParameter = 0x4000,

        All = Assembly | Module | Class | Struct | Enum | Constructor |
                        Method | Property | Field | Event | Interface | Parameter |
                        Delegate | ReturnValue | GenericParameter
    }
}