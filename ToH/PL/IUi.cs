using ToH.PL.Screens;

namespace ToH.PL;

public interface IUi
{
    Screen Screen { set; }
    Type _previousScreen { set; get; }
    IScreenFactory ScreenFactory { get; }
}