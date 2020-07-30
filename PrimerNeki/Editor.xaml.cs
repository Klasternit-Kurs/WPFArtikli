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

namespace PrimerNeki
{
	/// <summary>
	/// Interaction logic for Editor.xaml
	/// </summary>
	public partial class Editor : Window
	{
		public Editor()
		{
			InitializeComponent();
			DataContext = new Artikal();
			BindingGroup = new BindingGroup();
		}

		private void OK(object sender, RoutedEventArgs e)
		{
			if (BindingGroup.CommitEdit())
			{
				DialogResult = true;
				this.Close();
			}
		}

		private void PromenaDT(object sender, DependencyPropertyChangedEventArgs e)
		{
			if (e.OldValue is Artikal a)
				Artikal.listaArtikala.Remove(a);
		}
	}
}
