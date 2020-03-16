using System.ComponentModel;

namespace Scenery.Data
{
    public enum EssentialElements
    {
        [Description("Plot Point")]
        PLOT_POINT,
        [Description("Character Goal")]
        CHARACTER_GOAL,
        [Description("Plot Action")]
        PLOT_ACTION,
        [Description("Tension Action")]
        TENSION_ACTION
    }

    public enum ImportantElements
    {
        [Description("Character Development")]
        CHARACTER_DEVELOPMENT,
        [Description("Cause of Conflict")]
        CONFLICT_CAUSE,
        [Description("Effect of Conflict")]
        CONFLICT_EFFECT,
        [Description("Raised Stakes")]
        STEAKS_RAISED,
        [Description("Reinforcement of Stakes")]
        STEAKS_REINFORCED,
        [Description("Character Motivation")]
        CHARACTER_MOTIVATION
    }

    public enum BonusElements
    {
        [Description("Character Backstory")]
        CHARACTER_BACKSTORY,
        [Description("World Building")]
        WORLD_BUILDING,
        [Description("Tone or Mood")]
        TONE,
        [Description("Theme")]
        THEME,
        [Description("Foreshadowing")]
        FORESHADOWING
    }

    public enum Colors
    {
        DEFAULT,
        YELLOW,
        ORANGE,
        RED,
        PINK,
        PURPLE,
        BLUE,
        AQUA,
        GREEN,
        WHITE,
        BLACK
    }
}
