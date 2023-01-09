using ListaUczestnikow.ModelDanych;
using WinFormsApp1.ModelDanych;

namespace WinFormsApp1
{
	public partial class Form1 : Form
	{
		Pobieracz pobieracz;
		public Form1()
		{
			InitializeComponent();
			pobieracz = new Pobieracz();
			pobieracz.PobierzDaneZBazy();
			PokazDane();

		}
		public void PokazDane()
		{
			TextBoxLista.Clear();
			foreach(Osoba osoba in pobieracz.ListaOsob)
			{
				TextBoxLista.Text = osoba.ToString();
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			pobieracz.ListaOsob.Sort();
			PokazDane();
		}
	}
}