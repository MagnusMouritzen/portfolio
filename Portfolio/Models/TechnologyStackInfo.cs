namespace Portfolio.Models;

public class TechnologyStackInfo {
    public string Source { get; private set; }
    public string Name { get; private set; }

    public static readonly TechnologyStackInfo Cs = new("Cs.svg", "C#");
    public static readonly TechnologyStackInfo Cpp = new("Cpp.svg", "C++");
    public static readonly TechnologyStackInfo Python = new("Python.svg", "Python");
    public static readonly TechnologyStackInfo Sql = new("SQL.svg", "SQL");
    public static readonly TechnologyStackInfo Git = new("Git.svg", "Git");
    public static readonly TechnologyStackInfo Unity = new("Unity.svg", "Unity");

    public TechnologyStackInfo(string source, string name) {
        Source = source;
        Name = name;
    }
}