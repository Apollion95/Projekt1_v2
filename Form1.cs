using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projekt1_v5.Models;

namespace Projekt1_v5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void Clear()
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = "";
        }

      
        
        private void Form1_Load(object sender, EventArgs e)
        {
        
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;//
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;//
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;//
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;//
            button19.Visible = false;
            button20.Visible = false;
            button21.Visible = false;//
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //wyswietlanie
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //klienci
            using var db = new WypozyczalniaFilmowDBContext();
            var klienci = from p in db.KontaktKlients
                          select new
                          {
                              id = p.IdKlienta,
                              Numer_Telefonu = p.NumerTelefonu,
                              Imie = p.Imie,
                              Nazwisko = p.Nazwisko,
                              Nazwa = p.Nazwa
                          };
            dataGridView1.DataSource = klienci.ToList();
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = false;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;//
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;//
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;//
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;//
            button19.Visible = false;
            button20.Visible = false;
            button21.Visible = false;//

            Clear();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //dostepnosc
            using var db = new WypozyczalniaFilmowDBContext();
            var dostepnosc = from p in db.Dostepnoscs
                          select new
                          {
                          Nosnik=p.IdNosnika,
                          IloscDostepnychNosnikow=p.IlośćDostępnychKopii,
                          TypNosnika=p.TypNosnika
                          };
            dataGridView1.DataSource = dostepnosc.ToList();
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;//
            button10.Visible = true;
            button11.Visible = true;
            button12.Visible = true;//
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;//
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;//
            button19.Visible = false;
            button20.Visible = false;
            button21.Visible = false;//
            Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //filmy

            using var db = new WypozyczalniaFilmowDBContext();
            var filmy = from p in db.Films
                             select new
                             {
                                 FilmID=p.IdFilmu,
                                 Nazwa=p.Nazwa,
                                 Gatunek=p.Gatunek,
                                 Wydawca=p.Wydawca,
                                 CenaZaDobe=p.CenaZaDobe,
                                 NosnikID=p.IdNosnika
                             };
            dataGridView1.DataSource = filmy.ToList();
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;//
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;//
            button13.Visible = true;
            button14.Visible = true;
            button15.Visible = true;//
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;//
            button19.Visible = false;
            button20.Visible = false;
            button21.Visible = false;//
            Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //pracownicy
            using var db = new WypozyczalniaFilmowDBContext();
            var pracownik = from p in db.Pracowniks
                             select new
                             {
                                 PracownikID=p.IdPracownik,
                                 Nazwisko=p.NazwiskoPracownik,
                                 Imie=p.ImiePracownik,
                                 Telefon=p.Telefon,
                                 Wiek=p.Wiek
                             };
            dataGridView1.DataSource = pracownik.ToList();
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;//
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;//
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;//
            button16.Visible = true;
            button17.Visible = true;
            button18.Visible = true;//
            button19.Visible = false;
            button20.Visible = false;
            button21.Visible = false;//
            Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Wynajem
            using var db = new WypozyczalniaFilmowDBContext();
            var wynajem = from p in db.Wynajems
                            select new
                            {
                                Wypozyczenie=p.IdWypozyczenia,
                                KlientId=p.IdKlienta,
                                FilmID=p.IdFilmu,
                                DataWypozyczenia=p.DataWypozyczenia,
                                DataZwrotu=p.DataZwrotu
                            };
            dataGridView1.DataSource = wynajem.ToList();
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;//
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;//
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;//
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;//
            button19.Visible = true;
            button20.Visible = true;
            button21.Visible = true;//
            Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //zmiana klienci
            using var db = new WypozyczalniaFilmowDBContext();
            db.KontaktKlients.Update(new KontaktKlient() { IdKlienta = textBox1.Text, NumerTelefonu = textBox2.Text, Imie = textBox3.Text, Nazwisko = textBox4.Text, Nazwa = textBox5.Text });
            db.SaveChanges();
            Clear();
            button2.PerformClick();
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;

        }
        private void button8_Click(object sender, EventArgs e)
        {
            //dodanie klienci
            using var db = new WypozyczalniaFilmowDBContext();
            db.KontaktKlients.Add(new KontaktKlient() { IdKlienta = textBox1.Text, NumerTelefonu = textBox2.Text, Imie = textBox3.Text, Nazwisko = textBox4.Text, Nazwa = textBox5.Text });
            db.SaveChanges();
            Clear();
            button2.PerformClick();
           
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            //usuniecie klienci
            using var db = new WypozyczalniaFilmowDBContext();
            db.KontaktKlients.Remove(new KontaktKlient() { IdKlienta = textBox1.Text, NumerTelefonu = textBox2.Text, Imie = textBox3.Text, Nazwisko = textBox4.Text, Nazwa = textBox5.Text });
            db.SaveChanges();
            Clear();
            button2.PerformClick();
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //dostepnosc zmien
            using var db = new WypozyczalniaFilmowDBContext();
            db.Dostepnoscs.Update(new Dostepnosc() {IdNosnika=textBox1.Text, IlośćDostępnychKopii=textBox2.Text, TypNosnika=textBox3.Text });
            db.SaveChanges();
            Clear();
            button6.PerformClick();
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //dostepnosc dodaj
            using var db = new WypozyczalniaFilmowDBContext();
            db.Dostepnoscs.Add(new Dostepnosc() { IdNosnika = textBox1.Text, IlośćDostępnychKopii = textBox2.Text, TypNosnika = textBox3.Text });
            db.SaveChanges();
            Clear();
            button6.PerformClick();
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //dostepnosc usun
            using var db = new WypozyczalniaFilmowDBContext();
            db.Dostepnoscs.Remove(new Dostepnosc() { IdNosnika = textBox1.Text, IlośćDostępnychKopii = textBox2.Text, TypNosnika = textBox3.Text });
            db.SaveChanges();
            Clear();
            button6.PerformClick();
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //Filmy zmien
            using var db = new WypozyczalniaFilmowDBContext();
            db.Films.Update(new Film() {  IdFilmu=textBox1.Text,Nazwa=textBox2.Text,Gatunek=textBox3.Text,Wydawca=textBox4.Text,CenaZaDobe=textBox5.Text,IdNosnika=textBox6.Text});
            db.SaveChanges();
            Clear();
            button5.PerformClick();
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //Filmy dodaj
            using var db = new WypozyczalniaFilmowDBContext();
            db.Films.Add(new Film() { IdFilmu = textBox1.Text, Nazwa = textBox2.Text, Gatunek = textBox3.Text, Wydawca = textBox4.Text, CenaZaDobe = textBox5.Text, IdNosnika = textBox6.Text });
            db.SaveChanges();
            Clear();
            button5.PerformClick();
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //Filmy usun
            using var db = new WypozyczalniaFilmowDBContext();
            db.Films.Remove(new Film() { IdFilmu = textBox1.Text, Nazwa = textBox2.Text, Gatunek = textBox3.Text, Wydawca = textBox4.Text, CenaZaDobe = textBox5.Text, IdNosnika = textBox6.Text });
            db.SaveChanges();
            Clear();
            button5.PerformClick();
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //Pracownicy zmien
            using var db = new WypozyczalniaFilmowDBContext();
            db.Pracowniks.Update(new Pracownik() {IdPracownik=textBox1.Text,NazwiskoPracownik=textBox2.Text,ImiePracownik=textBox3.Text,Telefon=textBox4.Text,Wiek=textBox5.Text });
            db.SaveChanges();
            Clear();
            button4.PerformClick();
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
        }





        private void button17_Click_1(object sender, EventArgs e)
        {
            //Pracownicy dodaj
            using var db = new WypozyczalniaFilmowDBContext();
            db.Pracowniks.Add(new Pracownik() { IdPracownik = textBox1.Text, NazwiskoPracownik = textBox2.Text, ImiePracownik = textBox3.Text, Telefon = textBox4.Text, Wiek = textBox5.Text });
            db.SaveChanges();
            Clear();
            button4.PerformClick();
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            //Pracownicy usun
            using var db = new WypozyczalniaFilmowDBContext();
            db.Pracowniks.Remove(new Pracownik() { IdPracownik = textBox1.Text, NazwiskoPracownik = textBox2.Text, ImiePracownik = textBox3.Text, Telefon = textBox4.Text, Wiek = textBox5.Text });
            db.SaveChanges();
            Clear();
            button4.PerformClick();
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            //Wynajem Zmien
            using var db = new WypozyczalniaFilmowDBContext();
            db.Wynajems.Update(new Wynajem() { IdWypozyczenia = textBox1.Text, IdKlienta = textBox2.Text, IdFilmu = textBox3.Text, DataWypozyczenia = DateTime.Parse(textBox4.Text), DataZwrotu = DateTime.Parse(textBox5.Text) });
            db.SaveChanges();
            Clear();
            button3.PerformClick();
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
        }

        private void button20_Click_1(object sender, EventArgs e)
        {
            //Wynajem Dodaj
            using var db = new WypozyczalniaFilmowDBContext();
            db.Wynajems.Add(new Wynajem() { IdWypozyczenia = textBox1.Text, IdKlienta = textBox2.Text, IdFilmu = textBox3.Text, DataWypozyczenia = DateTime.Parse(textBox4.Text), DataZwrotu = DateTime.Parse(textBox5.Text) });
            db.SaveChanges();
            Clear();
            button3.PerformClick();
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
        }

        private void button21_Click_1(object sender, EventArgs e)
        {
            //Wynajem usun
            using var db = new WypozyczalniaFilmowDBContext();
            db.Wynajems.Remove(new Wynajem() { IdWypozyczenia = textBox1.Text, IdKlienta = textBox2.Text, IdFilmu = textBox3.Text, DataWypozyczenia = DateTime.Parse(textBox4.Text), DataZwrotu = DateTime.Parse(textBox5.Text) });
            db.SaveChanges();
            Clear();
            button3.PerformClick();
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
        }
    }
}

