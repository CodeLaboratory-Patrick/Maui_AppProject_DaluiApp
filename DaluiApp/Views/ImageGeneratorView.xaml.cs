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

    private async void StopGeneration()
    {
        await Task.Delay(2000);
        
        lottie.IsAnimationEnabled = false;
        lottie.IsVisible = false;
        imageBorder.IsVisible = true;
        imageAnimation.IsVisible = true;
        
        await Task.WhenAny(
            imageAnimation.ScaleTo(1.1, 1000),
            imageAnimation.FadeTo(0, 1000),
            borderTime.ScaleTo(1, 1000),
            borderTime.FadeTo(1, 1000)
            );

        await borderTime.FadeTo(0, 300);
        await btnFinish.ScaleTo(1, 1000);
    }
}