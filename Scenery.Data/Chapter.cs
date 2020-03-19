using System.Collections.Generic;

namespace Scenery.Data
{
    public class Chapter : Story
    {
        public int SequenceNumber { get; set; }
        public List<Scene> Scenes { get; set; }
    }
}
