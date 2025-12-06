using Xunit;
using TodoApp;

namespace TodoApp.Tests;

public class TodoItemTests
{
    [Fact]
    public void NewItem_IsNotCompleted()
    {
        TodoItem item = new("Test Task");
        Assert.False(item.IsCompleted);
    }

    [Theory]
    [InlineData("Task A")]
    [InlineData("Task B")]
    public void Title_IsRequired(string title)
	{
		TodoItem item = new(title);
        Assert.Equal(title, item.Title);
	}
}
