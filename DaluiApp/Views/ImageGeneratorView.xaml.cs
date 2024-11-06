using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaluiApp.Views;

public partial class ImageGeneratorView : ContentPage
{
    public ImageGeneratorView()
    {
        InitializeComponent();
    }

    private void BtnFinish_OnClicked(object? sender, EventArgs e)
    {
        StopGeneration();
    }

    private void StopGeneration()
    {
        lottie.IsAnimationEnabled = false;
        lottie.IsVisible = false;
        imageBorder.IsVisible = true;
    }
}