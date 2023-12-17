using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection.Emit;
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

namespace Hangman.Views
{
	/// <summary>
	/// Interaction logic for NewGame.xaml
	/// </summary>
	public partial class NewGame : Window
	{
		private readonly HttpClient httpClient = new HttpClient();
		string currentUser = "";

		public NewGame(string _currentUser)
		{
			InitializeComponent();
			currentUser = _currentUser;
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

		private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			// Update the Label content with the current value of the slider

			if (sender is Slider slider && lblLetters != null)
			{
				lblLetters.Content = slider.Value.ToString();
			}
		}

		private async void BtnPlayAsync_Click(object sender, RoutedEventArgs e)
		{
			var wordLenght = lblLetters.Content;
			try
			{
				// Make the API call
				string apiUrl = $"https://random-word-api.herokuapp.com/word?length={wordLenght}";
				string word = await GetRandomWord(apiUrl);
				string cleanWord = word.Trim('[', ']').Replace("\"", "");

				// Display the retrieved word or handle it as needed
				// MessageBox.Show($"Random word: {cleanWord}");

				// Go to next window
				StartGame(cleanWord);
				Close();

			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message}");
			}
		}

		private void StartGame(string cleanWord)
		{
			Game game = new Game(cleanWord, currentUser);
			game.Show();
		}

		private async Task<string> GetRandomWord(string apiUrl)
		{
			HttpResponseMessage response = await httpClient.GetAsync(apiUrl);

			if (response.IsSuccessStatusCode)
			{
				return await response.Content.ReadAsStringAsync();
			}
			else
			{
				throw new HttpRequestException($"Failed to retrieve random word. Status code: {response.StatusCode}");
			}
		}
	}
}
