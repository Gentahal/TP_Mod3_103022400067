using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Data;
using System.IO.Pipelines;

namespace TP_MODUL3_103022400067;

public partial class MainWindow : Window
{

    private string input = "";
    public MainWindow()
    {
        InitializeComponent();
    }

    private void OnButtonClick(object sender, RoutedEventArgs e)
    {

        var button = (Button)sender;
        string key = button.Content.ToString();

        if (key == "=")
        {
            try
            {
                var hasil = new DataTable().Compute(input, null);
                LabelInput.Text = hasil.ToString();
                input = hasil.ToString();
            }
            catch
            {
                LabelOutput.Text = "error";
                input = "";
            }
        } else
        {
            input += key;
            LabelOutput.Text = input;
        }
    }
}