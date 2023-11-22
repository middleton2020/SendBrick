using System;
using System.Collections.Generic;
using System.Text;

namespace CM.SendBrick.Library.Core
{
    public class SystemTypes
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
