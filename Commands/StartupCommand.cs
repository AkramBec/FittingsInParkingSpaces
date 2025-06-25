using Autodesk.Revit.Attributes;
using Nice3point.Revit.Toolkit.External;
using FittingsInParkingSpaces.ViewModels;
using FittingsInParkingSpaces.Views;

namespace FittingsInParkingSpaces.Commands;

/// <summary>
///     External command entry point
/// </summary>
[UsedImplicitly]
[Transaction(TransactionMode.Manual)]
public class StartupCommand : ExternalCommand
{
    public override void Execute()
    {
        var viewModel = new FittingsInParkingSpacesViewModel(UiDocument);
        var view = new FittingsInParkingSpacesView(viewModel);
        view.ShowDialog();
    }
}