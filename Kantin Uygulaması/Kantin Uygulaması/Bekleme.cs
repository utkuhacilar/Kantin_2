    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Data.OleDb;
    using System.IO;
    using System.IO.Ports;
    using System.Windows.Forms;

    namespace Kantin_Uygulaması
    {
        public partial class Bekleme : Form
        {
            public OleDbConnection baglanti = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\\Users\\furki\\OneDrive\\Masaüstü\\siparis.accdb");
            public int gecensure;
            public int gecensure2;

            public Bekleme()
            {
                InitializeComponent();
                serialPort1 = new SerialPort("COM3", 9600);
           
            }

            private void timer1_Tick(object sender, EventArgs e)
            {
                    gecensure++;
                    if (gecensure == 20)
                    {
                        timer1.Stop();
                        MessageBox.Show("20 saniyedir işlem yapılmadı işlem iptal ediliyor.");
                        SecilenUrun.Instance.fiyat = 0;
                        SecilenUrun.Instance.kactaneayran = 0;
                        SecilenUrun.Instance.kactanecay = 0;
                        SecilenUrun.Instance.kactanecorba = 0;
                        SecilenUrun.Instance.kactanedoner = 0;
                        SecilenUrun.Instance.kactanekahve = 0;
                        SecilenUrun.Instance.kactanekarisik = 0;
                        SecilenUrun.Instance.kactanekasarli = 0;
                        SecilenUrun.Instance.kactanemakarna = 0;
                        SecilenUrun.Instance.kactanepatso = 0;
                        SecilenUrun.Instance.kactanepogaca = 0;
                        SecilenUrun.Instance.kactanesandvic = 0;
                        SecilenUrun.Instance.kactanesu = 0;
                        SecilenUrun.Instance.kahve = false;
                        SecilenUrun.Instance.karisik = false;
                        SecilenUrun.Instance.kasarli = false;
                        SecilenUrun.Instance.makarna = false;
                        SecilenUrun.Instance.patso = false;
                        SecilenUrun.Instance.pogaca = false;
                        SecilenUrun.Instance.sandvic = false;
                        SecilenUrun.Instance.su = false;
                        SecilenUrun.Instance.ayran = false;
                        SecilenUrun.Instance.cay = false;
                        SecilenUrun.Instance.corba = false;
                        SecilenUrun.Instance.doner = false;
                        siparis siparis = new siparis();
                        siparis.Show();
                        this.Hide();
                    return;
                    }
                if (label1.Text == "Kart bekleniyor.....")
                {
                    label1.Text = "Kart bekleniyor";
                }
                label1.Text = label1.Text + ".";
            }

            private void Bekleme_Shown(object sender, EventArgs e)
            {
                try
                {
                    serialPort1.Open();
                    serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Seri port bağlantısı başarısız: " + ex.Message);
                    Application.Exit();
                    return;
                }
                timer1.Start();
                label1.Visible = true;
                label2.Visible = false;
                label4.Visible = true;
                gecensure = 0;
                label4.Text = "Toplam " + SecilenUrun.Instance.fiyat.ToString() + "TL tuttu.";
            }

            private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (!(gecensure >= 20))
            {
                SerialPort sp = (SerialPort)sender;
                this.Invoke((MethodInvoker)delegate
                {
                    string rfid = sp.ReadLine();
                    OleDbCommand komut = new OleDbCommand("SELECT * FROM Profiles WHERE RFID = @RFID", baglanti);
                    komut.Parameters.AddWithValue("@RFID", rfid);
                    try
                    {
                        baglanti.Open();
                        OleDbDataReader okuyucu = komut.ExecuteReader();
                        if (okuyucu.Read())
                        {
                            int suankibakiye = Convert.ToInt32(okuyucu["Bakiye"]);
                            int fiyat = SecilenUrun.Instance.fiyat;
                            int guncelbakiye = suankibakiye - fiyat;
                            if (guncelbakiye < 0)
                            {
                                timer1.Stop();
                                baglanti.Close();
                                label1.Text = ("Yetersiz bakiye. İşlem yapılamadı.");
                                timer2.Start();
                                guncelbakiye = suankibakiye;
                                return;
                            }
                            komut = new OleDbCommand("UPDATE Profiles SET Bakiye = @GuncelBakiye WHERE RFID = @RFID", baglanti);
                            komut.Parameters.AddWithValue("@GuncelBakiye", guncelbakiye);
                            komut.Parameters.AddWithValue("@RFID", rfid);
                            komut.ExecuteNonQuery();
                            timer1.Stop();
                            label1.Visible = false;
                            label2.Visible = true;
                            label3.Visible = true;
                            label2.Text = "Kart okundu. Hoşgeldin " + okuyucu["Isim"].ToString() + " " + okuyucu["Soyisim"].ToString();
                            label3.Text = "Kalan bakiye " + guncelbakiye;
                            timer2.Start();
                        }
                        else
                        {
                            timer1.Stop();
                            label1.Text = ("RFID veritabanında bulunamadı!");
                            baglanti.Close();
                            timer2.Start();
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        timer1.Stop();
                       label1.Text = ("Veritabanına kaydedilirken hata oluştu: " + ex.Message);
                        baglanti.Close();
                        timer2.Start();
                    }
                });
            }
        }

        private void VeritabanıKontrol(string gelenUID)
            {

                /*baglanti.Open();
                OleDbCommand komut = new OleDbCommand($"SELECT * FROM Profiles WHERE RFID = '{gelenUID}'", baglanti);
                OleDbDataReader okuyucu = komut.ExecuteReader();
                if (okuyucu.HasRows)
                {
                    int eskibakiye = Convert.ToInt32(okuyucu["Bakiye"]);
                    int yenibakiye = eskibakiye - SecilenUrun.Instance.fiyat;
                    if (yenibakiye >= 0)                {
                        okuyucu.Close();
                        OleDbCommand bakiyeGuncelle = new OleDbCommand($"UPDATE Profiles SET Bakiye = {yenibakiye} WHERE RFID = '{gelenUID}'", baglanti);
                        bakiyeGuncelle.ExecuteNonQuery();
                        baglanti.Close();
                        timer1.Stop();
                        label1.Visible = false;
                        label2.Visible = true;
                        label3.Visible = true;
                        label2.Text = "Kart okundu. Hoşgeldin" + okuyucu["Isim"].ToString();
                        label3.Text = "Kalan bakiye" + okuyucu["Bakiye"].ToString();
                        timer2.Start();
                    }
                    else
                    {
                        okuyucu.Close();
                        baglanti.Close();
                        MessageBox.Show("Yetersiz bakiye. İşlem yapılamadı.");
                        SecilenUrun.Instance.fiyat = 0;
                        SecilenUrun.Instance.kactaneayran = 0;
                        SecilenUrun.Instance.kactanecay = 0;
                        SecilenUrun.Instance.kactanecorba = 0;
                        SecilenUrun.Instance.kactanedoner = 0;
                        SecilenUrun.Instance.kactanekahve = 0;
                        SecilenUrun.Instance.kactanekarisik = 0;
                        SecilenUrun.Instance.kactanekasarli = 0;
                        SecilenUrun.Instance.kactanemakarna = 0;
                        SecilenUrun.Instance.kactanepatso = 0;
                        SecilenUrun.Instance.kactanepogaca = 0;
                        SecilenUrun.Instance.kactanesandvic = 0;
                        SecilenUrun.Instance.kactanesu = 0;
                        SecilenUrun.Instance.kahve = false;
                        SecilenUrun.Instance.karisik = false;
                        SecilenUrun.Instance.kasarli = false;
                        SecilenUrun.Instance.makarna = false;
                        SecilenUrun.Instance.patso = false;
                        SecilenUrun.Instance.pogaca = false;
                        SecilenUrun.Instance.sandvic = false;
                        SecilenUrun.Instance.su = false;
                        SecilenUrun.Instance.ayran = false;
                        SecilenUrun.Instance.cay = false;
                        SecilenUrun.Instance.corba = false;
                        SecilenUrun.Instance.doner = false;
                        siparis siparis = new siparis();
                        siparis.Show();
                        this.Hide();
                    }
                }
                else
                {
                    okuyucu.Close();
                    baglanti.Close();
                    MessageBox.Show("Böyle bir kart bulunamadı.");
                    SecilenUrun.Instance.fiyat = 0;
                    SecilenUrun.Instance.kactaneayran = 0;
                    SecilenUrun.Instance.kactanecay = 0;
                    SecilenUrun.Instance.kactanecorba = 0;
                    SecilenUrun.Instance.kactanedoner = 0;
                    SecilenUrun.Instance.kactanekahve = 0;
                    SecilenUrun.Instance.kactanekarisik = 0;
                    SecilenUrun.Instance.kactanekasarli = 0;
                    SecilenUrun.Instance.kactanemakarna = 0;
                    SecilenUrun.Instance.kactanepatso = 0;
                    SecilenUrun.Instance.kactanepogaca = 0;
                    SecilenUrun.Instance.kactanesandvic = 0;
                    SecilenUrun.Instance.kactanesu = 0;
                    SecilenUrun.Instance.kahve = false;
                    SecilenUrun.Instance.karisik = false;
                    SecilenUrun.Instance.kasarli = false;
                    SecilenUrun.Instance.makarna = false;   
                    SecilenUrun.Instance.patso = false;
                    SecilenUrun.Instance.pogaca = false;
                    SecilenUrun.Instance.sandvic = false;
                    SecilenUrun.Instance.su = false;
                    SecilenUrun.Instance.ayran = false;
                    SecilenUrun.Instance.cay = false;
                    SecilenUrun.Instance.corba = false;
                    SecilenUrun.Instance.doner = false;
                    siparis siparis = new siparis();
                    siparis.Show();
                    this.Hide();
                }*/
            }

            private void Bekleme_KeyDown(object sender, KeyEventArgs e)
            {
               /* if (e.KeyCode == Keys.CapsLock)
                {
                    timer1.Stop();
                    label1.Visible = false;
                    label2.Visible = true;
                    label3.Visible = true;
                    label2.Text = "Kart okundu. Hoşgeldin" + " Null";
                    label3.Text = "Kalan bakiye" + " NoN";
                    timer2.Start();
                }*/
            }

            private void Bekleme_KeyPress(object sender, KeyPressEventArgs e)
            {
            
            }

            private void timer2_Tick(object sender, EventArgs e)
            {
               
                gecensure2++;
                if (gecensure2 == 3)
                {
                SecilenUrun.Instance.fiyat = 0;
                SecilenUrun.Instance.kactaneayran = 0;
                SecilenUrun.Instance.kactanecay = 0;
                SecilenUrun.Instance.kactanecorba = 0;
                SecilenUrun.Instance.kactanedoner = 0;
                SecilenUrun.Instance.kactanekahve = 0;
                SecilenUrun.Instance.kactanekarisik = 0;
                SecilenUrun.Instance.kactanekasarli = 0;
                SecilenUrun.Instance.kactanemakarna = 0;
                SecilenUrun.Instance.kactanepatso = 0;
                SecilenUrun.Instance.kactanepogaca = 0;
                SecilenUrun.Instance.kactanesandvic = 0;
                SecilenUrun.Instance.kactanesu = 0;
                SecilenUrun.Instance.kahve = false;
                SecilenUrun.Instance.karisik = false;
                SecilenUrun.Instance.kasarli = false;
                SecilenUrun.Instance.makarna = false;
                SecilenUrun.Instance.patso = false;
                SecilenUrun.Instance.pogaca = false;
                SecilenUrun.Instance.sandvic = false;
                SecilenUrun.Instance.su = false;
                SecilenUrun.Instance.ayran = false;
                SecilenUrun.Instance.cay = false;
                SecilenUrun.Instance.corba = false;
                SecilenUrun.Instance.doner = false;
                timer2.Stop();
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                }
                siparis siparis = new siparis();
                    siparis.Show();
                    this.Hide();    
                }

            }

            private void button1_Click(object sender, EventArgs e)
            {
           
            }

            private void Bekleme_Load(object sender, EventArgs e)
            {

            }
        }
    }
