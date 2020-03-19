using System.Collections.Generic;

namespace Scenery.Data
{
    public class Act : BaseScenery
    {
        public int SequenceNumber { get; set; }
        public List<Chapter> Chapters { get; set; }
    }
}
