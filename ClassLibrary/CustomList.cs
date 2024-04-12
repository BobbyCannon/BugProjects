using System.Collections.ObjectModel;

namespace ClassLibrary;

public class CustomList<T> : ObservableCollection<T>
{
	public CustomList()
	{
		Filtered = new ReadOnlyObservableCollection<T>(this);
	}

	/// <summary>
	///     The filter items if this list is being filtered.
	/// </summary>
	public ReadOnlyObservableCollection<T> Filtered { get; }
}