namespace WinFormsApp1;

public class MyEventArgs : EventArgs
{
    public string? Msg { get; set; }
}

public class SomeSrvice
{
    public static event EventHandler<MyEventArgs> MyEvent;

    public async Task DoStuff()
    {
        for (var i = 0; i < 20; i++)
        {
            MyEvent?.Invoke(this, new MyEventArgs() { Msg = $"stuff {i}"});

            await Task.Delay(1000);
        }
    }
}
