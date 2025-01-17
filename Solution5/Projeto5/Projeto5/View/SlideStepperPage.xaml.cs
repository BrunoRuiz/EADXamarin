﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Projeto5.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SlideStepperPage : ContentPage
    {
        public SlideStepperPage()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lblSlider.Text = e.NewValue.ToString();
        }

        private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lblStepper.Text = e.NewValue.ToString();
        }
    }
}