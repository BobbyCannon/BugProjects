using Avalonia.Controls;
using AvaloniaBindingIssues.ViewModels;

namespace AvaloniaBindingIssues.Views;

public partial class MainView : UserControl
{
	public MainView()
	{
		InitializeComponent();
	}

	public MainViewModel ViewModel => (MainViewModel)DataContext;

	private void DataGridOnSelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		//ViewModel.Selected.Clear();

		//foreach (Person item in DataGrid.SelectedItems)
		//{
		//	ViewModel.Selected.Add(item);
		//}

		foreach (Person item in e.AddedItems)
		{
			ViewModel.Selected.Add(item);
		}
		
		foreach (Person item in e.RemovedItems)
		{
			ViewModel.Selected.Remove(item);
		}
	}
}