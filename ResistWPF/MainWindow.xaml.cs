﻿using System;
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

namespace ResistWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ViewControl viewCtr;

        public MainWindow()
        {
            InitializeComponent();
            viewCtr = new ViewControl(this);
            this.SetView(viewCtr.Menu);
        }

        public void SetView(UserControl aView)
        {
            ContentArea.Content = aView;
        }
    }

    /// <summary>
    /// Controller for navigation between views
    /// </summary>
    public class ViewControl
    {
        private MainWindow _main;
        private Views.MainMenuView _menu;
        private Views.HelpView _help;
        private Views.GameView _game;
        private Views.ScoreboardView _score;

        public ViewControl(MainWindow mW)
        {
            _main = mW;
        }

        public void SetView(UserControl aView)
        {
            _main.ContentArea.Content = aView;
        }

        public void GameSelect(Button sender)
        {
            if (sender.Name == "StartGame_btn")
            {
                this.SetView(NewGame);
            }
            else if (sender.Name == "CtnGame_btn")
            {
                this.SetView(Game);
            }
        }

        public UserControl Menu
        {
            get
            {
                if (_menu == null)
                    _menu = new Views.MainMenuView(this);
                return _menu;
            }
        }

        public UserControl Help
        {
            get
            {
                if (_help == null)
                    _help = new Views.HelpView(this);
                return _help;
            }
        }

        public UserControl NewGame
        {
            get
            {
                _game = new Views.GameView(this);

                if (_menu.CtnGame_btn.IsEnabled == false)
                    _menu.CtnGame_btn.IsEnabled = true;

                return _game;
            }
        }

        public UserControl Game
        {
            get
            {
                if (_game == null)
                {
                    _game = new Views.GameView(this);

                    if (_menu.CtnGame_btn.IsEnabled == false)
                        _menu.CtnGame_btn.IsEnabled = true;
                }
                return _game;
            }
        }
        
        public UserControl Score
        {
            get
            {
                if (_score == null)
                    _score = new Views.ScoreboardView(this);
                return _score;
            }
        }
    }
}
