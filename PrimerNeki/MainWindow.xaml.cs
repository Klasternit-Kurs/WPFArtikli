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

namespace PrimerNeki
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			dg.ItemsSource = Artikal.listaArtikala;
		}

		private void Unos(object sender, RoutedEventArgs e)
		{
			Editor ed = new Editor();
			ed.Owner = this;
			if (ed.ShowDialog().Value)
			{
				//dg.ItemsSource = Artikal.listaArtikala.ToList();
			}else
			{
				Artikal.listaArtikala.Remove
					(ed.DataContext as Artikal);
			}
		}
		private void Izmena(object zk, RoutedEventArgs abc)
		{ 
			if (dg.SelectedItem is Artikal a)
			{
				Editor ed = new Editor();
				ed.Owner = this;

				ed.DataContext = a;
				ed.ShowDialog();
				//dg.ItemsSource = Artikal.listaArtikala.ToList();
			}
		}
		private void Brisanje(object ooo, RoutedEventArgs rrr)
		{
			if (dg.SelectedItem is Artikal a)//!= null)
			{
				Artikal.listaArtikala.Remove
					(a);
				//dg.ItemsSource = Artikal.listaArtikala.ToList();
			}
		}
	}
}
