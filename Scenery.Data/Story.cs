using System.Collections.Generic;

namespace Scenery.Data
{
    public class Story : BaseScenery
    {
        public List<Act> Acts { get; set; }
        public List<Chapter> Chapters { get; set; }
        public List<Scene> Scenes { get; set; }
    }
}
