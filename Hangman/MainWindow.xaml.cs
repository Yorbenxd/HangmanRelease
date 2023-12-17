using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Hangman
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{

		private string currentUser = "";
		public MainWindow()
		{
			InitializeComponent();
		}

		private void LoginButton_Click(object sender, RoutedEventArgs e)
		{
			// Handle login logic here
			string username = txtUsername.Text;
			string password = pwbPasswordBox1.Password;

			using (UserDataContext context = new UserDataContext()) 
			{ 
				bool userFound = context.Users.Any(user => user.Name == username);
				bool passwordCorrect = context.Users.Any(user => user.Password == password);

                if (userFound && passwordCorrect)
                {
					currentUser = username;
					GrantAccess();
					Close();
                }
				else if (!userFound) MessageBox.Show("User not found.", "Error!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
				else if (userFound && !passwordCorrect) MessageBox.Show("Wrong password!", "Error!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
			}
		}

		private void GrantAccess()
		{
			Headmenu headmenu = new Headmenu(currentUser);
			headmenu.Show();
		}

		private void RegisterButton_Click(object sender, RoutedEventArgs e)
		{
			// Handle register logic here
			string username = txtUsername.Text;
			string password = pwbPasswordBox1.Password;
			string password2 = pwbPasswordBox2.Password;

			using (UserDataContext context = new UserDataContext())
			{
				bool userFound = context.Users.Any(user => user.Name == username);
				if (userFound) MessageBox.Show("This user already exists, try logging in!", "Error!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
				else //create new user
				{
					if(password == password2) //check if passwords are the same
					{
						context.Users.Add(new User
						{
							Name = username,
							Password = password
						});
						context.SaveChanges();
						MessageBox.Show("Created new account! Please try logging in.", "Succeeded!", MessageBoxButton.OK, MessageBoxImage.Information);
					}
					else MessageBox.Show("Passwords are not the same!", "Error!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
				}
			}
		}

		private void ToggleView_Click(object sender, RoutedEventArgs e)
		{
			// Toggle between Login and Register views
			bool isRegisterView = pwbPasswordBox2.Visibility == Visibility.Visible;
			txtLogin.Visibility = Visibility.Visible;
			txtRegister.Visibility = Visibility.Collapsed;
			btnLogin.Visibility = Visibility.Visible;

			if (isRegisterView)
			{
				// Switch to Login view
				pwbPasswordBox2.Visibility = Visibility.Collapsed;
				lblConfirmPw.Visibility = Visibility.Collapsed;
				btnRegister.Visibility = Visibility.Collapsed;
				((ToggleButton)sender).Content = "Switch to Register";
			}
			else
			{
				// Switch to Register view
				pwbPasswordBox2.Visibility = Visibility.Visible;
				lblConfirmPw.Visibility = Visibility.Visible;

				txtLogin.Visibility = Visibility.Collapsed;
				txtRegister.Visibility = Visibility.Visible;

				btnLogin.Visibility = Visibility.Collapsed;
				btnRegister.Visibility = Visibility.Visible;
				((ToggleButton)sender).Content = "Switch to Login";
			}
		}
	}
}
