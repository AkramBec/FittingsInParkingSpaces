using Nice3point.Revit.Toolkit.External;
using FittingsInParkingSpaces.Commands;

namespace FittingsInParkingSpaces;

/// <summary>
///     Application entry point
/// </summary>
[UsedImplicitly]
public class Application : ExternalApplication
{
    public override void OnStartup()
    {
        CreateRibbon();
    }

    private void CreateRibbon()
    {
        var panel = Application.CreatePanel("Машиноместо", "ТЗ Бешшар");

        panel.AddPushButton<StartupCommand>("Поиск арматуры")
            .SetImage("/FittingsInParkingSpaces;component/Resources/Icons/RibbonIcon16.png")
            .SetLargeImage("/FittingsInParkingSpaces;component/Resources/Icons/RibbonIcon32.png");
    }
}