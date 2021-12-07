using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using AmirMrkonjicBHPe.Models;

namespace AmirMrkonjicBHPe
{
    public partial class MainPage : ContentPage
    {
        public IList<DodatneUsluge> dodatneUsluge { get; set; }
        public IList<Mjesto> lokacijaPrimaoca { get; set; }
        public IList<VrstaPosiljke> vrstaPosiljke { get; set; }
        public MainPage()
        {
            InitializeComponent();

            dodatneUsluge = new List<DodatneUsluge>();
            dodatneUsluge.Add(new DodatneUsluge { Id = 1, NazivUsluge = "Hitna pošiljka", Cijena = 30 });
            dodatneUsluge.Add(new DodatneUsluge { Id = 2, NazivUsluge = "Dostava vikendom", Cijena = 35 });
            dodatneUsluge.Add(new DodatneUsluge { Id = 3, NazivUsluge = "Povrat otpremnice", Cijena = 40 });
            dodatneUsluge.Add(new DodatneUsluge { Id = 4, NazivUsluge = "Lomljivo", Cijena = 45 });
            dodatneUsluge.Add(new DodatneUsluge { Id = 5, NazivUsluge = "Otvaranje pošiljke", Cijena = 50 });
            dodatneUsluge.Add(new DodatneUsluge { Id = 6, NazivUsluge = "Naplata pouzećem", Cijena = 55 });
            dodatneUsluge.Add(new DodatneUsluge { Id = 7, NazivUsluge = "Pakovanje", Cijena = 60 });
            dodatneUsluge.Add(new DodatneUsluge { Id = 8, NazivUsluge = "Dodatno osiguranje", Cijena = 65 });

            lokacijaPrimaoca = new List<Mjesto>();
            lokacijaPrimaoca.Add(new Mjesto { Id = 1, Naziv = "Zenica", Udaljenost = 10 });
            lokacijaPrimaoca.Add(new Mjesto { Id = 2, Naziv = "Sarajevo", Udaljenost = 100 });
            lokacijaPrimaoca.Add(new Mjesto { Id = 3, Naziv = "Travnik", Udaljenost = 50 });
            lokacijaPrimaoca.Add(new Mjesto { Id = 4, Naziv = "Tešanj", Udaljenost = 70 });

            vrstaPosiljke = new List<VrstaPosiljke>();
            vrstaPosiljke.Add(new VrstaPosiljke { Id = 1, Vrsta = "Paket", FaktorCijene = 5, slika = "box.png" });
            vrstaPosiljke.Add(new VrstaPosiljke { Id = 2, Vrsta = "Dokument", FaktorCijene = 1, slika = "documents.png" });

            PaketIMG.Source = vrstaPosiljke[0].slika;
            PaketLB.Text = vrstaPosiljke[0].Vrsta.ToUpper();
            DokumentIMG.Source = vrstaPosiljke[1].slika;
            DokumentLB.Text = vrstaPosiljke[1].Vrsta.ToUpper();

        }
    }
}
