using System;
using System.Collections.Generic;
using System.Text;

namespace CM.SendBrick.Library.Core
{
    internal class SystemTypes
    {
        // All the systems that can send Orders through this system.
        public enum SourceSystemType
        {
            BrickLink,
            BrickOwl
        }

        // All the systems that can be used to Post Orders through this system.
        public enum PostageSystemType
        {
            RoyalMail
        }
    }
}
