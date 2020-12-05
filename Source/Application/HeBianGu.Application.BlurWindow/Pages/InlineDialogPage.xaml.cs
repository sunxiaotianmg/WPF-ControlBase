﻿using HeBianGu.General.WpfControlLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfControlDemo.View
{
    /// <summary>
    /// InlineDialogPage.xaml 的交互逻辑
    /// </summary>
    public partial class InlineDialogPage : Page
    {
        public InlineDialogPage()
        {
            InitializeComponent();
        }
        private readonly Random _rng = new Random();


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new InlineModalDialog
            {
                Owner = this,
                Content = new DialogSampleContent(),
                Width = _rng.Next(100, (int)ActualWidth),
                Height = _rng.Next(100, (int)ActualHeight),
                ShowBlurrer = true
            };
            dialog.InputBindings.Add(new KeyBinding { Key = Key.Escape, Command = InlineModalDialog.CloseCommand });
            dialog.Show();
        }

        private void Button_CP_Click(object sender, RoutedEventArgs e)
        {
            ContentControl content = new ContentControl();
            content.Width = _rng.Next(100, (int)ActualWidth);
            content.Height = _rng.Next(100, (int)ActualHeight);
          

            content.Content = new ContainPanelSampleContent();

            this.cp.Add(content);
        }

        private void Button_CP_Click_Close(object sender, RoutedEventArgs e)
        {
            this.cp.Remove();
        }
    }

    internal class DialogSampleContent
    {

    }

    internal class ContainPanelSampleContent
    {

    }
}
