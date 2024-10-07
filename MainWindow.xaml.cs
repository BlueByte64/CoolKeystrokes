using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.


namespace KeystrokesByQByte64
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        Type pageType;
        public MainWindow()
        {
            //Intialize window and change TitleBar's and Extend its content to the title bar
            this.InitializeComponent();
            ExtendsContentIntoTitleBar = true;
            this.Title = "Cool Keystrokes";
        }
        private void navViewChanged(NavigationView sender, NavigationEventArgs e)
        {
            switch (sender.Tag)
            {
                case "KeybindsMenu":
                    //pagetype = typeof(//o coiso ali);
                    break;
            }
        }
    }
}