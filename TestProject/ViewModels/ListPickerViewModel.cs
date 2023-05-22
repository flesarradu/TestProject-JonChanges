using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.ViewModels;

/// <summary>
/// Represent the "List picker" view-model.
/// </summary>
public partial class ListPickerViewModel : BaseViewModel
{
    [ObservableProperty]
    private ObservableCollection<ListPickerItemViewModel> _availableValues;

    [ObservableProperty]
    private bool _isLoading = true;

    /// <inheritdoc/>
    public override void OnAppearing()
    {
        base.OnAppearing();
    }

    /// <inheritdoc />
    public override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);


        List<ListPickerItemViewModel> availableValues = new List<ListPickerItemViewModel>();
        for (int i = 0; i < 12; i++)
        {
            availableValues.Add(new ListPickerItemViewModel { Value = i, Label = i.ToString(), IsSelected = i == 3 });
        }

        AvailableValues = new ObservableCollection<ListPickerItemViewModel>(availableValues);

        IsLoading = false;
    }
}
