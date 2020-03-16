using System;
using System.Collections.Generic;

namespace Scenery.Data
{
    public class State
    {
        public Guid Id { get; set; }
        public Dictionary<Guid, Story> Stories { get; set; }
    }
}
