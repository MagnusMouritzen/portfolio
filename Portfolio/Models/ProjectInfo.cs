using Microsoft.AspNetCore.Components;
using Portfolio.Components;

namespace Portfolio.Models;

public class ProjectInfo {
    public RenderFragment ModalView { get; set; }
    public string Title { get; set; }
    public string Id { get; set; }
    public string ShortDescription { get; set; }
    public string ImageSource { get; set; }
    public string TeamSize { get; set; }
    public string TechnologiesDescription { get; set; }
    public string Role { get; set; }
    public string Duration { get; set; }
    public ActionButton.ButtonLink[] Buttons { get; set; }
    public int Technologies { get; set; }

    private static readonly TagInfo[] TagInfos = [
        new TagInfo("AI", "#CF0F5C"),
        new TagInfo("C#", "#68217A"),
        new TagInfo("Unity", "#8D8D8D"),
        new TagInfo("C++", "#00599C"),
        new TagInfo("Python", "#3776AB"),
        new TagInfo("Flask", "#000000"),
        new TagInfo("CUDA", "#76B900"),
        new TagInfo("CI/CD", "#FF5733"),
        new TagInfo("SQL", "#2E8B57"),
        new TagInfo(".NET", "#512BD4"),
        new TagInfo("Java", "#F89820")
    ];
    
    public IEnumerable<TagInfo> GetTags() {
        List<TagInfo> tagInfos = new();
        foreach (Technology technology in Enum.GetValues(typeof(Technology))) {
            int index = (int)technology;
            if ((Technologies & (1 << index)) != 0) {
                tagInfos.Add(TagInfos[index]);
            }
        }

        return tagInfos;
    }

    public static int TechnologyMask(IEnumerable<Technology> technologies) {
        int mask = 0;
        foreach (Technology technology in technologies) {
            mask += (1 << ((int)technology));
        }

        return mask;
    }
    
    public enum Technology {
        Ai,
        Cs,
        Unity,
        Cpp,
        Python,
        Flask,
        CUDA,
        CICD,
        SQL,
        NET,
        Java
    }

    public class TagInfo(string text, string colour) {
        public string Text { get; private set; } = text;
        public string Colour { get; private set; } = colour;
    }
}