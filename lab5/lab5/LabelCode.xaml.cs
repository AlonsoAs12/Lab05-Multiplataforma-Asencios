﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace lab5
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LabelCode : ContentPage
    {
        public LabelCode()
        {
            InitializeComponent();
            StackLayout stack = new StackLayout();
            var underlineLabel = new Label
            {
                Text = "This is underlined text.",
                TextDecorations = TextDecorations.Underline
            };
            var strikethroughlabel = new Label
            {
                Text = "This is underlined text with strikethrough.",
                TextDecorations = TextDecorations.Strikethrough
            };
            var bothLabel = new Label
            {
                Text = "This is inderlined text with strikethrough",
                TextDecorations = TextDecorations.Underline | TextDecorations.Strikethrough
            };
            stack.Children.Add(underlineLabel);
            stack.Children.Add(strikethroughlabel);
            stack.Children.Add(bothLabel);
            Content = stack;



        }
    }
}