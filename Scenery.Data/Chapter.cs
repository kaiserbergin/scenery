using System.Collections.Generic;

namespace Scenery.Data
{
    public class Chapter : BaseScenery
    {
        public int SequenceNumber { get; set; }
        public List<Scene> Scenes { get; set; }
    }
}
