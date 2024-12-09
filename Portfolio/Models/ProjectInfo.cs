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

    private static readonly TagInfo[] _tagInfos = [
        new TagInfo() {
            Text = "AI",
            Colour = "#CF0F5C"
        },
        new TagInfo() {
            Text = "C#",
            Colour = "#68217A"
        },
        new TagInfo() {
            Text = "Unity",
            Colour = "#8D8D8D"
        },
        new TagInfo() {
            Text = "C++",
            Colour = "#00599C"
        },
        new TagInfo() {
            Text = "Python",
            Colour = "#3776AB"
        },
        new TagInfo() {
            Text = "Flask",
            Colour = "#000000"
        },
        new TagInfo() {
            Text = "CUDA",
            Colour = "#76B900"
        },
        new TagInfo() {
            Text = "CI/CD",
            Colour = "#FF5733"
        },
        new TagInfo() {
            Text = "SQL",
            Colour = "#2E8B57"
        },
        new TagInfo() {
            Text = ".NET",
            Colour = "#512BD4"
        },
        new TagInfo() {
            Text = "Java",
            Colour = "#F89820"
        }
    ];
    
    public IEnumerable<TagInfo> GetTags() {
        List<TagInfo> tagInfos = new();
        foreach (Technology technology in Enum.GetValues(typeof(Technology))) {
            int index = (int)technology;
            if ((Technologies & (1 << index)) != 0) {
                tagInfos.Add(_tagInfos[index]);
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

    public class TagInfo {
        public string Text { get; set; }
        public string Colour { get; set; }
    }
}