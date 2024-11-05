using Microsoft.AspNetCore.Components;

namespace Portfolio.Models;

public class FragmentService(NavigationManager navigationManager) {
    public string GetFragment() {
        string fragment = new Uri(navigationManager.Uri).Fragment;
        return string.IsNullOrEmpty(fragment) ? string.Empty : fragment[1..];
    }
}