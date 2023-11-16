using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // ERRE NINCS SZÜKSÉG, VÉLETLEN KERÜLT BEHÍVÁSRA!
        private void textBox1_Forrasfajl_TextChanged(object sender, EventArgs e)
        {

        }//

        // BETÖLTÉS GOMBBAL BETÖLTI A KIVÁLASZTOTT FÁJLT //
        private void button_Betoltes_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "vesszővel tagolt csv|*.csv|txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.Title = "Adatfájl neve";
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.FileName = "pizza.csv";
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                Adatbetoltes(openFileDialog1.FileName);
            }
            else
            {
                return;
            }
        }
        // BETÖLTI AZ ADATOKAT A LISTABOXBA //
        private void Adatbetoltes(string file)
        {
            listBox_Pizzaklista.Items.Clear();
            try
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    sr.ReadLine();
                    while (!sr.EndOfStream)
                    {
                        listBox_Pizzaklista.Items.Add(new Pizza(sr.ReadLine()));
                    }
                }

            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // ÁTLAG GOMBBAL KISZÁMOLJA A PIZZÁK ÁTLAGÁT //
        private void button_TeruletekAtlaga_Click(object sender, EventArgs e)
        {
            double atlag = 0;
            foreach (Pizza item in listBox_Pizzaklista.Items)
            {
                atlag += item.PizzaAr;
            }
            atlag = atlag / listBox_Pizzaklista.Items.Count;

            MessageBox.Show("A pizzák átlagos ára: " + atlag.ToString("#,##0") + "Ft", "Átlagár", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
      
        // MEGRENDELÉS GOMBBAL LÉTREHOZ EGY TXT FÁJLT AHOL TÁROLJA A MEGRENDELÉS ADATAIT //
        private void button1_Megrendeles_Click(object sender, EventArgs e)
        {
            try
            {
                int darabszam = int.Parse(textBox1_PizzaDarabSzam.Text);

            }
            catch (Exception)
            {
                MessageBox.Show("Kérjük számmal adja meg a darabszámot!", "Hiba", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }
        // ERRE NINCS SZÜKSÉG, VÉLETLEN KERÜLT BEHÍVÁSRA!
        private void textBox1_PizzaKivalasztasa_TextChanged(object sender, EventArgs e)
        {
            
            
        }
        //Belvasott pizza kijelölése
        private void listBox_Pizzaklista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Pizzaklista.SelectedIndex >= 0)
            {
                textBox1_PizzaKivalasztasa.Text = ((Pizza)listBox_Pizzaklista.SelectedItem).PizzaNev.ToString();
            }
        }
    }
}
