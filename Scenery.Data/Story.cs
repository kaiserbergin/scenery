using System;
using System.Collections.Generic;

namespace Scenery.Data
{
    public class Story
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Colors Color { get; set; }
        public Dictionary<Guid, Scene> Scenes { get; set; }
    }
}
