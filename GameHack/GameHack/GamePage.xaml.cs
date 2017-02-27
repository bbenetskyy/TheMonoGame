﻿using GameHack.Setting;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace GameHack
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class GamePage : Page
    {
		readonly GameLevel _game;
        Setup setup;
		public GamePage()
        {
            this.InitializeComponent();
            setup = Setup.GetInstance();
            //this.Frame.Navigate(typeof(MenuPage));
			// Create the game.
			var launchArguments = string.Empty;
            _game = MonoGame.Framework.XamlGame<GameLevel>.Create(launchArguments, Window.Current.CoreWindow, swapChainPanel);
        }
    }
}
