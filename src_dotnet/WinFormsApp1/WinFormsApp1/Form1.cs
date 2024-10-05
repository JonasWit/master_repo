namespace WinFormsApp1;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

        SomeSrvice.MyEvent += SomeSrvice_MyEvent;
    }

    private void SomeSrvice_MyEvent(object? sender, MyEventArgs e) => textBox1.Text = e.Msg;

    private async void button1_Click(object sender, EventArgs e)
    {
        var sv = new SomeSrvice();
        await sv.DoStuff();
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e) => SomeSrvice.MyEvent -= SomeSrvice_MyEvent;
}
