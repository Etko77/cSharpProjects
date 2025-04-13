using System.Collections.ObjectModel;

namespace SimpleTodoApp;

public partial class MainPage : ContentPage
{
	private ObservableCollection<TodoItem> _todoItems = new ObservableCollection<TodoItem>();

	public MainPage()
	{
		InitializeComponent();
		TodoList.ItemsSource = _todoItems;
	}

	private void OnAddClicked(object sender, EventArgs e)
	{
		AddTodoItem();
	}

	private void OnEntryCompleted(object sender, EventArgs e)
	{
		AddTodoItem();
	}

	private void AddTodoItem()
	{
		if (string.IsNullOrWhiteSpace(TodoEntry.Text))
			return;

		_todoItems.Add(new TodoItem { Title = TodoEntry.Text });
		TodoEntry.Text = string.Empty;
	}

	private void OnItemCheckedChanged(object sender, CheckedChangedEventArgs e)
	{
		if (sender is CheckBox checkBox && checkBox.BindingContext is TodoItem item)
		{
			item.IsCompleted = e.Value;
		}
	}
}

