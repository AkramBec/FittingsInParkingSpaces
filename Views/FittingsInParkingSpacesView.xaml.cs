using FittingsInParkingSpaces.ViewModels;

namespace FittingsInParkingSpaces.Views;

public sealed partial class FittingsInParkingSpacesView
{
    public FittingsInParkingSpacesView(FittingsInParkingSpacesViewModel viewModel)
    {
        DataContext = viewModel;
        InitializeComponent();
    }
}