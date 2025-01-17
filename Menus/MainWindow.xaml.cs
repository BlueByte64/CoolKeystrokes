using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using Microsoft.UI.Composition;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using KeystrokesByQByte64;
// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.


namespace KeystrokesByQByte64.Menus
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        private NavigationViewItem selectedNavItem;
        public MainWindow()
        {
            //Intialize window and change TitleBar's and Extend its content to the title bar
            this.InitializeComponent();
            ExtendsContentIntoTitleBar = true;
            this.Title = "Cool Keystrokes";
            contentFrame.Navigate(typeof(Pages.Welcome));
        }
        private void navItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            var selectedNavItem = sender.SelectedItem as NavigationViewItem;
            switch (selectedNavItem.Content) { 
                case "Keys":
                    contentFrame.Navigate(typeof(Pages.KeysPage));
                    break;
            }
        }
    }
}
