using Scenery.Data;
using Scenery.Data.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Scenery.Blazor.Temp
{
    public static class ExampleGenerator
    {
        public static Story GenerateSimpleStory() => new Story { Acts = GenerateSimpleActs(), Color = Colors.DEFAULT, Id = Guid.NewGuid(), Title = "My First Scenery", Description = "Really great story" };

        public static List<Act> GenerateSimpleActs()
        {
            var chapters = GenerateSimpleChapters();
            var (act1Chapters, act2Chapters, act3Chapters) = (chapters.Where(x => x.SequenceNumber < 4).ToList(), chapters.Where(x => x.SequenceNumber > 3 && x.SequenceNumber < 7).ToList(), chapters.Where(x => x.SequenceNumber > 6).ToList());
            return new List<Act>()
            {
                GenerateAct(title: "Act I", sequenceNumber: 1, chapters: act1Chapters),
                GenerateAct(title: "Act II", sequenceNumber: 2, chapters: act2Chapters),
                GenerateAct(title: "Act III", sequenceNumber: 3, chapters: act3Chapters)
            };
        }

        public static List<Chapter> GenerateSimpleChapters() => new List<Chapter>
        {
            GenerateChapter(title: "Chapter One", sequenceNumber: 1, scenes: GenerateSimpleScenes()),
            GenerateChapter(title: "Chapter Two", sequenceNumber: 2, scenes: GenerateSimpleScenes()),
            GenerateChapter(title: "Chapter Three", sequenceNumber: 3, scenes: GenerateSimpleScenes()),
            GenerateChapter(title: "Chapter Four", sequenceNumber: 4, scenes: GenerateSimpleScenes()),
            GenerateChapter(title: "Chapter Five", sequenceNumber: 5, scenes: GenerateSimpleScenes()),
            GenerateChapter(title: "Chapter Six", sequenceNumber: 6, scenes: GenerateSimpleScenes()),
            GenerateChapter(title: "Chapter Seven", sequenceNumber: 7, scenes: GenerateSimpleScenes()),
            GenerateChapter(title: "Chapter Eight", sequenceNumber: 8, scenes: GenerateSimpleScenes()),
            GenerateChapter(title: "Chapter Nine", sequenceNumber: 9, scenes: GenerateSimpleScenes())
        };

        public static List<Scene> GenerateSimpleScenes() => new List<Scene> {
            GenerateScene(
                title: "First Scene",
                sequenceNumber: 1,
                sceneFocus: GenerateSimpleSceneFocus(),
                essentialElements: new List<EssentialElements> {EssentialElements.CHARACTER_GOAL, EssentialElements.TENSION_ACTION},
                importantElements: new List<ImportantElements> {ImportantElements.CHARACTER_MOTIVATION, ImportantElements.STEAKS_RAISED, ImportantElements.CONFLICT_EFFECT},
                bonusElements: new List<BonusElements> {BonusElements.TONE, BonusElements.FORESHADOWING}
                ),
            GenerateScene(
                title: "Second Scene", 
                sequenceNumber: 2, 
                sceneFocus: GenerateSimpleSceneFocus(),               
                essentialElements: new List<EssentialElements> {EssentialElements.CHARACTER_GOAL, EssentialElements.TENSION_ACTION},
                importantElements: new List<ImportantElements> {ImportantElements.CHARACTER_MOTIVATION, ImportantElements.STEAKS_RAISED, ImportantElements.CONFLICT_EFFECT},
                bonusElements: new List<BonusElements> {BonusElements.TONE, BonusElements.FORESHADOWING}
                ),
        };

        public static SceneFocus GenerateSimpleSceneFocus() => new SceneFocus
        {
            CharacterFocus = "Character focus is going to focus on the character!",
            PlotFocus = "Plot focus centers on what happened.",
            ThemeFocus = "What themes did we include?",
            SuspenseFocus = "OMG LIKE WHAT IS GOING TO HAPPEN NOW?"
        };

        public static Story GenerateStory(
            Guid? id = null,
            string title = "Story Title",
            string description = "This _description_, though",
            Colors color = Colors.DEFAULT,
            List<Act> acts = null) =>
            new Story() { Id = id == null ? Guid.NewGuid() : id.Value, Title = title, Description = description, Color = color, Acts = acts };

        public static Act GenerateAct(
            Guid? id = null,
            string title = "Act Title",
            string description = "This *description*, though",
            Colors color = Colors.DEFAULT,
            int sequenceNumber = 0,
            List<Chapter> chapters = null) => new Act() { Id = id == null ? Guid.NewGuid() : id.Value, Title = title, Description = description, Color = color, SequenceNumber = sequenceNumber, Chapters = chapters };


        public static Chapter GenerateChapter(
           Guid? id = null,
           string title = "Chapter Title",
           string description = "This _chapter_ *description*, though",
           Colors color = Colors.DEFAULT,
           int sequenceNumber = 0,
           List<Scene> scenes = null) => new Chapter() { Id = id == null ? Guid.NewGuid() : id.Value, Title = title, Description = description, Color = color, SequenceNumber = sequenceNumber, Scenes = scenes };

        public static Scene GenerateScene(
          Guid? id = null,
          string title = "Scene Title",
          string description = "This **scene** *description*, though",
          Colors color = Colors.DEFAULT,
          int sequenceNumber = 0,
          SceneFocus sceneFocus = null,
          List<EssentialElements> essentialElements = null,
          List<ImportantElements> importantElements = null,
          List<BonusElements> bonusElements = null
          ) => new Scene() { Id = id == null ? Guid.NewGuid() : id.Value, Title = title, Description = description, Color = color, SequenceNumber = sequenceNumber, SceneFocus = sceneFocus, EssentialElements = essentialElements, ImportantElements = importantElements, BonusElements = bonusElements };
    }
}
