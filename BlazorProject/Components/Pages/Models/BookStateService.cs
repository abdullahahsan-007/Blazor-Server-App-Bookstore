
public class BookStateService
{
    public string SearchTerm { get; private set; } = "";
    public string SelectedGenre { get; private set; } = "";

    public event Action? OnChange;

    public void UpdateSearchTerm(string term)
    {
        SearchTerm = term;
        NotifyStateChanged();
    }

    public void UpdateGenre(string genre)
    {
        SelectedGenre = genre;
        NotifyStateChanged();
    }

    private void NotifyStateChanged() => OnChange?.Invoke();
}
