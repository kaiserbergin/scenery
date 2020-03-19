using Scenery.Data.Enumerations;
using System;
using System.Collections.Generic;

namespace Scenery.Data
{
    public class Scene : BaseScenery
    {
        public int SequenceNumber { get; set; }
        public SceneFocus SceneFocus { get; set; }
        public List<EssentialElements> EssentialElements { get; set; }
        public List<ImportantElements> ImportantElements { get; set; }
        public List<BonusElements> BonusElements { get; set; }
    }
}
