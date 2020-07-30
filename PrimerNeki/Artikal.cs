using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerNeki
{
	public class Artikal : IRadiNesto
	{
		public static ObservableCollection<Artikal> listaArtikala = new ObservableCollection<Artikal>();

		public string Naziv { get; set; }
		public decimal UlaznaCena { get; set; }
		public int MarzaProc { get; set; }

		public decimal IzlaznaCena
		{
			get =>
				UlaznaCena * ((decimal)MarzaProc / 100 + 1);
		}
		public int x { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		public Artikal() => listaArtikala.Add(this);

		public void Bla()
		{
			throw new NotImplementedException();
		}
	}

	public interface IRadiNesto
	{
		int x { get; set; }
		void Bla();
	}
}
