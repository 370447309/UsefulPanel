using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x804 上介绍了“空白页”项模板

namespace NegativeScreen
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class ViewPage : Page
    {
        public ViewPage()
        {
            this.InitializeComponent();

            DispatcherTimer timer = new DispatcherTimer()
            {
                Interval = new TimeSpan(0, 0, 1)
                
            };
            timer.Tick += (sender, e) =>
            {
                tbTime.Text = DateTime.Now.ToString("t");
            };
            timer.Start();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var plugins = PluginManager.GetInstance().LoadedPlugins;

            foreach (var plugin in plugins)
            {
                var components = plugin.GetAllComponent();
                Expander expander = new Expander 
                { 
                    Header = "Test",
                    ExpandDirection = ExpandDirection.Down
                };
                StackPanel stackPanel = new StackPanel();
                foreach (var item in components)
                {
                    stackPanel.Children.Add(item.ComponentView as UIElement);
                }
                expander.Content = stackPanel;
                mainView.Children.Add(expander);
            }
        }
    }
}
