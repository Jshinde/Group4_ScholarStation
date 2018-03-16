using ScholarStation;
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

namespace Scholar_Station
{
	/// <summary>
	/// Interaction logic for userHome.xaml
	/// </summary>
	/// 


	public partial class userHome : Page
	{
		private User user;

		public userHome(User user)
		{
			this.user = user;
			InitializeComponent();
			welcomeMsg.Content = ("Welcome, " + user.Email + "!").ToString();
		}

		private void createNew_Click(object sender, RoutedEventArgs e)
		{
			this.NavigationService.Navigate(new tutorPage(user));
		}

		private void joinExisting_Click(object sender, RoutedEventArgs e)
		{
			this.NavigationService.Navigate(new joinSessionFrame(user));
		}
	}
}
