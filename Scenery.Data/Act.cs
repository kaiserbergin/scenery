using System;
using System.Collections.Generic;

namespace Scenery.Data
{
    public class Act : Story
    {
        public int SequenceNumber { get; set; }
        public List<Scene> Scenes { get; set; }
    }
}
