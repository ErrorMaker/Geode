﻿using System;

namespace Geode.Extension
{
    [AttributeUsage(AttributeTargets.Property)]
    public abstract class MessageAttribute : Attribute
    {
        public bool IsOutgoing { get; }
        public string Identifier { get; }

        public MessageAttribute(string identifier, bool isOutgoing)
        {
            Identifier = identifier;
            IsOutgoing = isOutgoing;
        }
    }
}