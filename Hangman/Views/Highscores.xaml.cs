using System.Linq;
using System.Windows;

namespace Hangman.Views
{
    /// <summary>
    /// Interaction logic for Highscores.xaml
    /// </summary>
    public partial class Highscores : Window
    {
        string currentUser = "";
        bool score = false;
        public Highscores(string _currentUser, bool _score)
        {
            InitializeComponent();

            currentUser = _currentUser;
            score = _score;
			Scoreboard();
		}

		private void Scoreboard()
		{
			if (score == true)  // when score == true show all highscores on scoreboard
			{
				lblhighscores.Content = "All highscores";
				using (UserDataContext context = new UserDataContext())
				{
					var allScores = context.Scores.ToList();
					scoreDataGrid.ItemsSource = allScores;
				}
			}
			else // when score == false show personal highscores on scoreboard
			{
				lblhighscores.Content = "Personal highscores";
				using (UserDataContext context = new UserDataContext())
				{
					var personalScores = context.Scores.Where(x => x.Name == currentUser).ToList();
					scoreDataGrid.ItemsSource = personalScores;
				}
			}
		}

		private void mnuHeadmenu_Click(object sender, RoutedEventArgs e)
		{
			BackToHeadmenu();
			Close();
		}

		private void BackToHeadmenu()
		{
			Headmenu headmenu = new Headmenu(currentUser);
			headmenu.Show();
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
			Close();
		}
	}
}
