using Scenery.Data.Enumerations;
using System;

namespace Scenery.Data
{
    public class BaseScenery
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Colors Color { get; set; }

    }
}
