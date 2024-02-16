using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kantin_Uygulaması
{
    public partial class siparis : Form
    {
        public siparis()
        {
            InitializeComponent();
        }
        public int karisikfiyat = 25;
        public int kasarlifiyat = 20;
        public int donerfiyat = 30;
        public int patsofiyat = 25;
        public int pogacafiyat = 10;
        public int sandvicfiyat = 20;
        public int sufiyat = 5;
        public int cayfiyat = 5;
        public int kahvefiyat = 7;
        public int ayranfiyat = 10;
        public int corbafiyat = 25;
        public int makarnafiyat = 25;

        private void button1_Click(object sender, EventArgs e)
        {
            SecilenUrun.Instance.karisik = true;
            SecilenUrun.Instance.kactanekarisik += 1;
            button10.Enabled =true;
            label1.Text = SecilenUrun.Instance.kactanekarisik.ToString();
            label2.Text = SecilenUrun.Instance.kactanekasarli.ToString();
            label3.Text = SecilenUrun.Instance.kactanesandvic.ToString();
            label4.Text = SecilenUrun.Instance.kactanedoner.ToString();
            label5.Text = SecilenUrun.Instance.kactanepatso.ToString();
            label6.Text = SecilenUrun.Instance.kactanepogaca.ToString();
            label8.Text = SecilenUrun.Instance.kactanesu.ToString();
            label9.Text = SecilenUrun.Instance.kactanecay.ToString();
            label10.Text = SecilenUrun.Instance.kactanekahve.ToString();
            label11.Text = SecilenUrun.Instance.kactaneayran.ToString();
            label12.Text = SecilenUrun.Instance.kactanecorba.ToString();
            label13.Text = SecilenUrun.Instance.kactanemakarna.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SecilenUrun.Instance.kactanekasarli += 1;
            SecilenUrun.Instance.kasarli = true;
            button15.Enabled = true;
            label1.Text = SecilenUrun.Instance.kactanekarisik.ToString();
            label2.Text = SecilenUrun.Instance.kactanekasarli.ToString();
            label3.Text = SecilenUrun.Instance.kactanesandvic.ToString();
            label4.Text = SecilenUrun.Instance.kactanedoner.ToString();
            label5.Text = SecilenUrun.Instance.kactanepatso.ToString();
            label6.Text = SecilenUrun.Instance.kactanepogaca.ToString();
            label8.Text = SecilenUrun.Instance.kactanesu.ToString();
            label9.Text = SecilenUrun.Instance.kactanecay.ToString();
            label10.Text = SecilenUrun.Instance.kactanekahve.ToString();
            label11.Text = SecilenUrun.Instance.kactaneayran.ToString();
            label12.Text = SecilenUrun.Instance.kactanecorba.ToString();
            label13.Text = SecilenUrun.Instance.kactanemakarna.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SecilenUrun.Instance.kactanesandvic += 1;
            SecilenUrun.Instance.sandvic = true;
            button16.Enabled = true;
            label1.Text = SecilenUrun.Instance.kactanekarisik.ToString();
            label2.Text = SecilenUrun.Instance.kactanekasarli.ToString();
            label3.Text = SecilenUrun.Instance.kactanesandvic.ToString();
            label4.Text = SecilenUrun.Instance.kactanedoner.ToString();
            label5.Text = SecilenUrun.Instance.kactanepatso.ToString();
            label6.Text = SecilenUrun.Instance.kactanepogaca.ToString();
            label8.Text = SecilenUrun.Instance.kactanesu.ToString();
            label9.Text = SecilenUrun.Instance.kactanecay.ToString();
            label10.Text = SecilenUrun.Instance.kactanekahve.ToString();
            label11.Text = SecilenUrun.Instance.kactaneayran.ToString();
            label12.Text = SecilenUrun.Instance.kactanecorba.ToString();
            label13.Text = SecilenUrun.Instance.kactanemakarna.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SecilenUrun.Instance.kactanedoner += 1;
            SecilenUrun.Instance.doner = true;
            button17.Enabled = true;
            label1.Text = SecilenUrun.Instance.kactanekarisik.ToString();
            label2.Text = SecilenUrun.Instance.kactanekasarli.ToString();
            label3.Text = SecilenUrun.Instance.kactanesandvic.ToString();
            label4.Text = SecilenUrun.Instance.kactanedoner.ToString();
            label5.Text = SecilenUrun.Instance.kactanepatso.ToString();
            label6.Text = SecilenUrun.Instance.kactanepogaca.ToString();
            label8.Text = SecilenUrun.Instance.kactanesu.ToString();
            label9.Text = SecilenUrun.Instance.kactanecay.ToString();
            label10.Text = SecilenUrun.Instance.kactanekahve.ToString();
            label11.Text = SecilenUrun.Instance.kactaneayran.ToString();
            label12.Text = SecilenUrun.Instance.kactanecorba.ToString();
            label13.Text = SecilenUrun.Instance.kactanemakarna.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SecilenUrun.Instance.kactanepatso += 1;
            SecilenUrun.Instance.patso = true;
            button18.Enabled = true;
            label1.Text = SecilenUrun.Instance.kactanekarisik.ToString();
            label2.Text = SecilenUrun.Instance.kactanekasarli.ToString();
            label3.Text = SecilenUrun.Instance.kactanesandvic.ToString();
            label4.Text = SecilenUrun.Instance.kactanedoner.ToString();
            label5.Text = SecilenUrun.Instance.kactanepatso.ToString();
            label6.Text = SecilenUrun.Instance.kactanepogaca.ToString();
            label8.Text = SecilenUrun.Instance.kactanesu.ToString();
            label9.Text = SecilenUrun.Instance.kactanecay.ToString();
            label10.Text = SecilenUrun.Instance.kactanekahve.ToString();
            label11.Text = SecilenUrun.Instance.kactaneayran.ToString();
            label12.Text = SecilenUrun.Instance.kactanecorba.ToString();
            label13.Text = SecilenUrun.Instance.kactanemakarna.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SecilenUrun.Instance.kactanepogaca += 1;
            SecilenUrun.Instance.pogaca = true;
            button19.Enabled = true;
            label1.Text = SecilenUrun.Instance.kactanekarisik.ToString();
            label2.Text = SecilenUrun.Instance.kactanekasarli.ToString();
            label3.Text = SecilenUrun.Instance.kactanesandvic.ToString();
            label4.Text = SecilenUrun.Instance.kactanedoner.ToString();
            label5.Text = SecilenUrun.Instance.kactanepatso.ToString();
            label6.Text = SecilenUrun.Instance.kactanepogaca.ToString();
            label8.Text = SecilenUrun.Instance.kactanesu.ToString();
            label9.Text = SecilenUrun.Instance.kactanecay.ToString();
            label10.Text = SecilenUrun.Instance.kactanekahve.ToString();
            label11.Text = SecilenUrun.Instance.kactaneayran.ToString();
            label12.Text = SecilenUrun.Instance.kactanecorba.ToString();
            label13.Text = SecilenUrun.Instance.kactanemakarna.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SecilenUrun.Instance.kactanesu += 1;
            SecilenUrun.Instance.su = true;
            button20.Enabled = true;
            label1.Text = SecilenUrun.Instance.kactanekarisik.ToString();
            label2.Text = SecilenUrun.Instance.kactanekasarli.ToString();
            label3.Text = SecilenUrun.Instance.kactanesandvic.ToString();
            label4.Text = SecilenUrun.Instance.kactanedoner.ToString();
            label5.Text = SecilenUrun.Instance.kactanepatso.ToString();
            label6.Text = SecilenUrun.Instance.kactanepogaca.ToString();
            label8.Text = SecilenUrun.Instance.kactanesu.ToString();
            label9.Text = SecilenUrun.Instance.kactanecay.ToString();
            label10.Text = SecilenUrun.Instance.kactanekahve.ToString();
            label11.Text = SecilenUrun.Instance.kactaneayran.ToString();
            label12.Text = SecilenUrun.Instance.kactanecorba.ToString();
            label13.Text = SecilenUrun.Instance.kactanemakarna.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SecilenUrun.Instance.kactanecay += 1;
            SecilenUrun.Instance.cay = true;
            button21.Enabled = true;
            label1.Text = SecilenUrun.Instance.kactanekarisik.ToString();
            label2.Text = SecilenUrun.Instance.kactanekasarli.ToString();
            label3.Text = SecilenUrun.Instance.kactanesandvic.ToString();
            label4.Text = SecilenUrun.Instance.kactanedoner.ToString();
            label5.Text = SecilenUrun.Instance.kactanepatso.ToString();
            label6.Text = SecilenUrun.Instance.kactanepogaca.ToString();
            label8.Text = SecilenUrun.Instance.kactanesu.ToString();
            label9.Text = SecilenUrun.Instance.kactanecay.ToString();
            label10.Text = SecilenUrun.Instance.kactanekahve.ToString();
            label11.Text = SecilenUrun.Instance.kactaneayran.ToString();
            label12.Text = SecilenUrun.Instance.kactanecorba.ToString();
            label13.Text = SecilenUrun.Instance.kactanemakarna.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SecilenUrun.Instance.kactanekahve += 1;
            SecilenUrun.Instance.kahve = true;
            button22.Enabled = true;
            label1.Text = SecilenUrun.Instance.kactanekarisik.ToString();
            label2.Text = SecilenUrun.Instance.kactanekasarli.ToString();
            label3.Text = SecilenUrun.Instance.kactanesandvic.ToString();
            label4.Text = SecilenUrun.Instance.kactanedoner.ToString();
            label5.Text = SecilenUrun.Instance.kactanepatso.ToString();
            label6.Text = SecilenUrun.Instance.kactanepogaca.ToString();
            label8.Text = SecilenUrun.Instance.kactanesu.ToString();
            label9.Text = SecilenUrun.Instance.kactanecay.ToString();
            label10.Text = SecilenUrun.Instance.kactanekahve.ToString();
            label11.Text = SecilenUrun.Instance.kactaneayran.ToString();
            label12.Text = SecilenUrun.Instance.kactanecorba.ToString();
            label13.Text = SecilenUrun.Instance.kactanemakarna.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SecilenUrun.Instance.fiyat = (ayranfiyat * SecilenUrun.Instance.kactaneayran) + (cayfiyat * SecilenUrun.Instance.kactanecay) + (corbafiyat * SecilenUrun.Instance.kactanecorba) + (donerfiyat * SecilenUrun.Instance.kactanedoner) + (kahvefiyat * SecilenUrun.Instance.kactanekahve) + (karisikfiyat * SecilenUrun.Instance.kactanekarisik) + (kasarlifiyat * SecilenUrun.Instance.kactanekasarli) + (makarnafiyat * SecilenUrun.Instance.kactanemakarna) + (patsofiyat * SecilenUrun.Instance.kactanepatso) + (pogacafiyat * SecilenUrun.Instance.kactanepogaca) + (sandvicfiyat * SecilenUrun.Instance.kactanesandvic) + (sufiyat * SecilenUrun.Instance.kactanesu);
            if (SecilenUrun.Instance.fiyat == 0)
            {
                MessageBox.Show("Hiç bir ürün eklenmedi");
                return;
            }
            DialogResult result = MessageBox.Show(SecilenUrun.Instance.fiyat.ToString(), "Sipariş", MessageBoxButtons.OKCancel);
            if (result == DialogResult.Cancel)
            {
                return;
            }
            
            Bekleme bekleme = new Bekleme();
            bekleme.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            SecilenUrun.Instance.kactaneayran += 1;
            SecilenUrun.Instance.ayran = true;
            button23.Enabled = true;
            label1.Text = SecilenUrun.Instance.kactanekarisik.ToString();
            label2.Text = SecilenUrun.Instance.kactanekasarli.ToString();
            label3.Text = SecilenUrun.Instance.kactanesandvic.ToString();
            label4.Text = SecilenUrun.Instance.kactanedoner.ToString();
            label5.Text = SecilenUrun.Instance.kactanepatso.ToString();
            label6.Text = SecilenUrun.Instance.kactanepogaca.ToString();
            label8.Text = SecilenUrun.Instance.kactanesu.ToString();
            label9.Text = SecilenUrun.Instance.kactanecay.ToString();
            label10.Text = SecilenUrun.Instance.kactanekahve.ToString();
            label11.Text = SecilenUrun.Instance.kactaneayran.ToString();
            label12.Text = SecilenUrun.Instance.kactanecorba.ToString();
            label13.Text = SecilenUrun.Instance.kactanemakarna.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            SecilenUrun.Instance.kactanecorba += 1;
            SecilenUrun.Instance.corba = true;
            button25.Enabled = true;
            label1.Text = SecilenUrun.Instance.kactanekarisik.ToString();
            label2.Text = SecilenUrun.Instance.kactanekasarli.ToString();
            label3.Text = SecilenUrun.Instance.kactanesandvic.ToString();
            label4.Text = SecilenUrun.Instance.kactanedoner.ToString();
            label5.Text = SecilenUrun.Instance.kactanepatso.ToString();
            label6.Text = SecilenUrun.Instance.kactanepogaca.ToString();
            label8.Text = SecilenUrun.Instance.kactanesu.ToString();
            label9.Text = SecilenUrun.Instance.kactanecay.ToString();
            label10.Text = SecilenUrun.Instance.kactanekahve.ToString();
            label11.Text = SecilenUrun.Instance.kactaneayran.ToString();
            label12.Text = SecilenUrun.Instance.kactanecorba.ToString();
            label13.Text = SecilenUrun.Instance.kactanemakarna.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            SecilenUrun.Instance.kactanemakarna += 1;
            SecilenUrun.Instance.makarna = true;
            button24.Enabled = true;
            label1.Text = SecilenUrun.Instance.kactanekarisik.ToString();
            label2.Text = SecilenUrun.Instance.kactanekasarli.ToString();
            label3.Text = SecilenUrun.Instance.kactanesandvic.ToString();
            label4.Text = SecilenUrun.Instance.kactanedoner.ToString();
            label5.Text = SecilenUrun.Instance.kactanepatso.ToString();
            label6.Text = SecilenUrun.Instance.kactanepogaca.ToString();
            label8.Text = SecilenUrun.Instance.kactanesu.ToString();
            label9.Text = SecilenUrun.Instance.kactanecay.ToString();
            label10.Text = SecilenUrun.Instance.kactanekahve.ToString();
            label11.Text = SecilenUrun.Instance.kactaneayran.ToString();
            label12.Text = SecilenUrun.Instance.kactanecorba.ToString();
            label13.Text = SecilenUrun.Instance.kactanemakarna.ToString();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            if (SecilenUrun.Instance.kactanekarisik != 0)
            {
                SecilenUrun.Instance.kactanekarisik -= 1;
            }
            if (SecilenUrun.Instance.kactanekarisik == 0)
            {
                button10.Enabled = false;
            }
            label1.Text = SecilenUrun.Instance.kactanekarisik.ToString();
            label2.Text = SecilenUrun.Instance.kactanekasarli.ToString();
            label3.Text = SecilenUrun.Instance.kactanesandvic.ToString();
            label4.Text = SecilenUrun.Instance.kactanedoner.ToString();
            label5.Text = SecilenUrun.Instance.kactanepatso.ToString();
            label6.Text = SecilenUrun.Instance.kactanepogaca.ToString();
            label8.Text = SecilenUrun.Instance.kactanesu.ToString();
            label9.Text = SecilenUrun.Instance.kactanecay.ToString();
            label10.Text = SecilenUrun.Instance.kactanekahve.ToString();
            label11.Text = SecilenUrun.Instance.kactaneayran.ToString();
            label12.Text = SecilenUrun.Instance.kactanecorba.ToString();
            label13.Text = SecilenUrun.Instance.kactanemakarna.ToString();
        }

        private void siparis_Shown(object sender, EventArgs e)
        {
            SecilenUrun.Instance.kactanekarisik = 0;
            SecilenUrun.Instance.kactanekasarli = 0;
            SecilenUrun.Instance.kactanesandvic = 0;
            SecilenUrun.Instance.kactanedoner = 0;
            SecilenUrun.Instance.kactanepatso = 0;
            SecilenUrun.Instance.kactanepogaca = 0;
            SecilenUrun.Instance.kactanecay = 0;
            SecilenUrun.Instance.kactanesu = 0;
            SecilenUrun.Instance.kactanekahve = 0;
            SecilenUrun.Instance.kactaneayran = 0;
            SecilenUrun.Instance.kactanemakarna = 0;
            SecilenUrun.Instance.kactanecorba = 0;
            label1.Text = SecilenUrun.Instance.kactanekarisik.ToString();
            label2.Text = SecilenUrun.Instance.kactanekasarli.ToString();
            label3.Text = SecilenUrun.Instance.kactanesandvic.ToString();
            label4.Text = SecilenUrun.Instance.kactanedoner.ToString();
            label5.Text = SecilenUrun.Instance.kactanepatso.ToString();
            label6.Text = SecilenUrun.Instance.kactanepogaca.ToString();
            label8.Text = SecilenUrun.Instance.kactanesu.ToString();
            label9.Text = SecilenUrun.Instance.kactanecay.ToString();
            label10.Text = SecilenUrun.Instance.kactanekahve.ToString();
            label11.Text = SecilenUrun.Instance.kactaneayran.ToString();
            label12.Text = SecilenUrun.Instance.kactanecorba.ToString();
            label13.Text = SecilenUrun.Instance.kactanemakarna.ToString();
            button10.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button20.Enabled = false;
            button21.Enabled = false;
            button22.Enabled = false;
            button23.Enabled = false;
            button24.Enabled = false;
            button25.Enabled = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (SecilenUrun.Instance.kactanekasarli != 0)
            {
                SecilenUrun.Instance.kactanekasarli -= 1;
            }
            if (SecilenUrun.Instance.kactanekasarli == 0)
            {
                button15.Enabled = false;
            }
            label1.Text = SecilenUrun.Instance.kactanekarisik.ToString();
            label2.Text = SecilenUrun.Instance.kactanekasarli.ToString();
            label3.Text = SecilenUrun.Instance.kactanesandvic.ToString();
            label4.Text = SecilenUrun.Instance.kactanedoner.ToString();
            label5.Text = SecilenUrun.Instance.kactanepatso.ToString();
            label6.Text = SecilenUrun.Instance.kactanepogaca.ToString();
            label8.Text = SecilenUrun.Instance.kactanesu.ToString();
            label9.Text = SecilenUrun.Instance.kactanecay.ToString();
            label10.Text = SecilenUrun.Instance.kactanekahve.ToString();
            label11.Text = SecilenUrun.Instance.kactaneayran.ToString();
            label12.Text = SecilenUrun.Instance.kactanecorba.ToString();
            label13.Text = SecilenUrun.Instance.kactanemakarna.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (SecilenUrun.Instance.kactanesandvic != 0)
            {
                SecilenUrun.Instance.kactanesandvic -= 1;
            }
            if (SecilenUrun.Instance.kactanesandvic == 0)
            {
                button16.Enabled = false;
            }
            label1.Text = SecilenUrun.Instance.kactanekarisik.ToString();
            label2.Text = SecilenUrun.Instance.kactanekasarli.ToString();
            label3.Text = SecilenUrun.Instance.kactanesandvic.ToString();
            label4.Text = SecilenUrun.Instance.kactanedoner.ToString();
            label5.Text = SecilenUrun.Instance.kactanepatso.ToString();
            label6.Text = SecilenUrun.Instance.kactanepogaca.ToString();
            label8.Text = SecilenUrun.Instance.kactanesu.ToString();
            label9.Text = SecilenUrun.Instance.kactanecay.ToString();
            label10.Text = SecilenUrun.Instance.kactanekahve.ToString();
            label11.Text = SecilenUrun.Instance.kactaneayran.ToString();
            label12.Text = SecilenUrun.Instance.kactanecorba.ToString();
            label13.Text = SecilenUrun.Instance.kactanemakarna.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (SecilenUrun.Instance.kactanedoner != 0)
            {
                SecilenUrun.Instance.kactanedoner -= 1;
            }
            if (SecilenUrun.Instance.kactanedoner == 0)
            {
                button17.Enabled = false;
            }
            label1.Text = SecilenUrun.Instance.kactanekarisik.ToString();
            label2.Text = SecilenUrun.Instance.kactanekasarli.ToString();
            label3.Text = SecilenUrun.Instance.kactanesandvic.ToString();
            label4.Text = SecilenUrun.Instance.kactanedoner.ToString();
            label5.Text = SecilenUrun.Instance.kactanepatso.ToString();
            label6.Text = SecilenUrun.Instance.kactanepogaca.ToString();
            label8.Text = SecilenUrun.Instance.kactanesu.ToString();
            label9.Text = SecilenUrun.Instance.kactanecay.ToString();
            label10.Text = SecilenUrun.Instance.kactanekahve.ToString();
            label11.Text = SecilenUrun.Instance.kactaneayran.ToString();
            label12.Text = SecilenUrun.Instance.kactanecorba.ToString();
            label13.Text = SecilenUrun.Instance.kactanemakarna.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (SecilenUrun.Instance.kactanepatso != 0)
            {
                SecilenUrun.Instance.kactanepatso -= 1;
            }
            if (SecilenUrun.Instance.kactanepatso == 0)
            {
                button18.Enabled = false;
            }
            label1.Text = SecilenUrun.Instance.kactanekarisik.ToString();
            label2.Text = SecilenUrun.Instance.kactanekasarli.ToString();
            label3.Text = SecilenUrun.Instance.kactanesandvic.ToString();
            label4.Text = SecilenUrun.Instance.kactanedoner.ToString();
            label5.Text = SecilenUrun.Instance.kactanepatso.ToString();
            label6.Text = SecilenUrun.Instance.kactanepogaca.ToString();
            label8.Text = SecilenUrun.Instance.kactanesu.ToString();
            label9.Text = SecilenUrun.Instance.kactanecay.ToString();
            label10.Text = SecilenUrun.Instance.kactanekahve.ToString();
            label11.Text = SecilenUrun.Instance.kactaneayran.ToString();
            label12.Text = SecilenUrun.Instance.kactanecorba.ToString();
            label13.Text = SecilenUrun.Instance.kactanemakarna.ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (SecilenUrun.Instance.kactanepogaca != 0)
            {
                SecilenUrun.Instance.kactanepogaca -= 1;
            }
            if (SecilenUrun.Instance.kactanepogaca == 0)
            {
                button19.Enabled = false;
            }
            label1.Text = SecilenUrun.Instance.kactanekarisik.ToString();
            label2.Text = SecilenUrun.Instance.kactanekasarli.ToString();
            label3.Text = SecilenUrun.Instance.kactanesandvic.ToString();
            label4.Text = SecilenUrun.Instance.kactanedoner.ToString();
            label5.Text = SecilenUrun.Instance.kactanepatso.ToString();
            label6.Text = SecilenUrun.Instance.kactanepogaca.ToString();
            label8.Text = SecilenUrun.Instance.kactanesu.ToString();
            label9.Text = SecilenUrun.Instance.kactanecay.ToString();
            label10.Text = SecilenUrun.Instance.kactanekahve.ToString();
            label11.Text = SecilenUrun.Instance.kactaneayran.ToString();
            label12.Text = SecilenUrun.Instance.kactanecorba.ToString();
            label13.Text = SecilenUrun.Instance.kactanemakarna.ToString();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (SecilenUrun.Instance.kactanesu != 0)
            {
                SecilenUrun.Instance.kactanesu -= 1;
            }
            if (SecilenUrun.Instance.kactanesu == 0)
            {
                button20.Enabled = false;
            }
            label1.Text = SecilenUrun.Instance.kactanekarisik.ToString();
            label2.Text = SecilenUrun.Instance.kactanekasarli.ToString();
            label3.Text = SecilenUrun.Instance.kactanesandvic.ToString();
            label4.Text = SecilenUrun.Instance.kactanedoner.ToString();
            label5.Text = SecilenUrun.Instance.kactanepatso.ToString();
            label6.Text = SecilenUrun.Instance.kactanepogaca.ToString();
            label8.Text = SecilenUrun.Instance.kactanesu.ToString();
            label9.Text = SecilenUrun.Instance.kactanecay.ToString();
            label10.Text = SecilenUrun.Instance.kactanekahve.ToString();
            label11.Text = SecilenUrun.Instance.kactaneayran.ToString();
            label12.Text = SecilenUrun.Instance.kactanecorba.ToString();
            label13.Text = SecilenUrun.Instance.kactanemakarna.ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (SecilenUrun.Instance.kactanecay != 0)
            {
                SecilenUrun.Instance.kactanecay -= 1;
            }
            else if (SecilenUrun.Instance.kactanecay == 0)
            {
                button21.Enabled = false;
            }
            label1.Text = SecilenUrun.Instance.kactanekarisik.ToString();
            label2.Text = SecilenUrun.Instance.kactanekasarli.ToString();
            label3.Text = SecilenUrun.Instance.kactanesandvic.ToString();
            label4.Text = SecilenUrun.Instance.kactanedoner.ToString();
            label5.Text = SecilenUrun.Instance.kactanepatso.ToString();
            label6.Text = SecilenUrun.Instance.kactanepogaca.ToString();
            label8.Text = SecilenUrun.Instance.kactanesu.ToString();
            label9.Text = SecilenUrun.Instance.kactanecay.ToString();
            label10.Text = SecilenUrun.Instance.kactanekahve.ToString();
            label11.Text = SecilenUrun.Instance.kactaneayran.ToString();
            label12.Text = SecilenUrun.Instance.kactanecorba.ToString();
            label13.Text = SecilenUrun.Instance.kactanemakarna.ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (SecilenUrun.Instance.kactanekahve != 0)
            {
                SecilenUrun.Instance.kactanekahve -= 1;
            }
            if (SecilenUrun.Instance.kactanekahve == 0)
            {
                button22.Enabled = false;
            }
            label1.Text = SecilenUrun.Instance.kactanekarisik.ToString();
            label2.Text = SecilenUrun.Instance.kactanekasarli.ToString();
            label3.Text = SecilenUrun.Instance.kactanesandvic.ToString();
            label4.Text = SecilenUrun.Instance.kactanedoner.ToString();
            label5.Text = SecilenUrun.Instance.kactanepatso.ToString();
            label6.Text = SecilenUrun.Instance.kactanepogaca.ToString();
            label8.Text = SecilenUrun.Instance.kactanesu.ToString();
            label9.Text = SecilenUrun.Instance.kactanecay.ToString();
            label10.Text = SecilenUrun.Instance.kactanekahve.ToString();
            label11.Text = SecilenUrun.Instance.kactaneayran.ToString();
            label12.Text = SecilenUrun.Instance.kactanecorba.ToString();
            label13.Text = SecilenUrun.Instance.kactanemakarna.ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (SecilenUrun.Instance.kactaneayran != 0)
            {
                SecilenUrun.Instance.kactaneayran -= 1;
            }
            if (SecilenUrun.Instance.kactaneayran == 0)
            {
                button23.Enabled = false;
            }
            label1.Text = SecilenUrun.Instance.kactanekarisik.ToString();
            label2.Text = SecilenUrun.Instance.kactanekasarli.ToString();
            label3.Text = SecilenUrun.Instance.kactanesandvic.ToString();
            label4.Text = SecilenUrun.Instance.kactanedoner.ToString();
            label5.Text = SecilenUrun.Instance.kactanepatso.ToString();
            label6.Text = SecilenUrun.Instance.kactanepogaca.ToString();
            label8.Text = SecilenUrun.Instance.kactanesu.ToString();
            label9.Text = SecilenUrun.Instance.kactanecay.ToString();
            label10.Text = SecilenUrun.Instance.kactanekahve.ToString();
            label11.Text = SecilenUrun.Instance.kactaneayran.ToString();
            label12.Text = SecilenUrun.Instance.kactanecorba.ToString();
            label13.Text = SecilenUrun.Instance.kactanemakarna.ToString();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (SecilenUrun.Instance.kactanecorba != 0)
            {
                SecilenUrun.Instance.kactanecorba -= 1;
            }
            if (SecilenUrun.Instance.kactanecorba == 0)
            {
                button25.Enabled = false;
            }
            label1.Text = SecilenUrun.Instance.kactanekarisik.ToString();
            label2.Text = SecilenUrun.Instance.kactanekasarli.ToString();
            label3.Text = SecilenUrun.Instance.kactanesandvic.ToString();
            label4.Text = SecilenUrun.Instance.kactanedoner.ToString();
            label5.Text = SecilenUrun.Instance.kactanepatso.ToString();
            label6.Text = SecilenUrun.Instance.kactanepogaca.ToString();
            label8.Text = SecilenUrun.Instance.kactanesu.ToString();
            label9.Text = SecilenUrun.Instance.kactanecay.ToString();
            label10.Text = SecilenUrun.Instance.kactanekahve.ToString();
            label11.Text = SecilenUrun.Instance.kactaneayran.ToString();
            label12.Text = SecilenUrun.Instance.kactanecorba.ToString();
            label13.Text = SecilenUrun.Instance.kactanemakarna.ToString();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (SecilenUrun.Instance.kactanemakarna != 0)
            {
                SecilenUrun.Instance.kactanemakarna -= 1;
            }
            if (SecilenUrun.Instance.kactanemakarna == 0)
            {
                button24.Enabled = false;
            }
            label1.Text = SecilenUrun.Instance.kactanekarisik.ToString();
            label2.Text = SecilenUrun.Instance.kactanekasarli.ToString();
            label3.Text = SecilenUrun.Instance.kactanesandvic.ToString();
            label4.Text = SecilenUrun.Instance.kactanedoner.ToString();
            label5.Text = SecilenUrun.Instance.kactanepatso.ToString();
            label6.Text = SecilenUrun.Instance.kactanepogaca.ToString();
            label8.Text = SecilenUrun.Instance.kactanesu.ToString();
            label9.Text = SecilenUrun.Instance.kactanecay.ToString();
            label10.Text = SecilenUrun.Instance.kactanekahve.ToString();
            label11.Text = SecilenUrun.Instance.kactaneayran.ToString();
            label12.Text = SecilenUrun.Instance.kactanecorba.ToString();
            label13.Text = SecilenUrun.Instance.kactanemakarna.ToString();
        }
    }
}
