using ClassLibrary;

namespace AvaloniaBindingIssues.ViewModels;

public class MainViewModel : ViewModelBase
{
	public MainViewModel()
	{
		Selected = new CustomList<Person>();
		List = new CustomList<Person>
		{
			new() { Name = "foo" },
			new() { Name = "bar" },
			new() { Name = "world" }
		};
	}

	public CustomList<Person> List { get; }

	public CustomList<Person> Selected { get; }
}