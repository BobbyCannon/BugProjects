using Avalonia.Collections;
using ClassLibrary;

namespace AvaloniaBindingIssues.ViewModels;

public class MainViewModel : ViewModelBase
{
	public MainViewModel()
	{
		List = new CustomList<Person>
		{
			new() { Name = "foo" },
			new() { Name = "bar" },
			new() { Name = "world" }
		};
	}

	public CustomList<Person> List { get; }
}