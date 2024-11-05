using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaluiApp.Views;

public partial class GenerationOptionsView : ContentPage
{
    public List<string> Options { get; set; }
    public GenerationOptionsView()
    {
        InitializeComponent();
        FillOptions();
        BindingContext = this;
    }

    private void FillOptions()
    {
        Options = new List<string>
        {
            "World",
            "Winter",
            "Trees"
        };
    }
}