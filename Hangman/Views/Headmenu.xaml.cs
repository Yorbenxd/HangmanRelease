using Hangman.Models;
using Hangman.Views;
using Microsoft.EntityFrameworkCore.ValueGeneration;
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
using System.Windows.Shapes;

namespace Hangman
{
    /// <summary>
    /// Interaction logic for Headmenu.xaml
    /// </summary>
    public partial class Headmenu : Window
    {
		string currentUser = "";
        public Headmenu(string _currentUser)
        {
            InitializeComponent();
			currentUser = _currentUser;
        }

		private void mnuNewGame_Click(object sender, RoutedEventArgs e)
		{
			StartNewGame();
			Close();
		}

		private void StartNewGame()
		{
			NewGame newGame = new NewGame(currentUser);
			newGame.Show();
		}


		private void mnuAllHighscore_Click(object sender, RoutedEventArgs e)
		{
			// when bool true: show all highscores
			bool score = true;
			ShowScores(score);
			Close();
        }

		private void mnuHighscore_Click(object sender, RoutedEventArgs e)
		{
			// when bool false: show personal highscores
			bool score = false;
			ShowScores(score);
			Close();
		}

		private void ShowScores(bool score)
		{
			Highscores highscore = new Highscores(currentUser, score);
			highscore.Show();
		}

		private void mnuQuit_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}
	}
}
