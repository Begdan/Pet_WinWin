namespace WinWin.Models;

public class TeamModel
{
    public TeamModel(string name, string description, string image)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
        Description = description ?? throw new ArgumentNullException(nameof(description));
        Image = image ?? throw new ArgumentNullException(nameof(image));
    }

    private string Name { get; set; }
    private string Description { get; set; }
    private string Image { get; set; }
}