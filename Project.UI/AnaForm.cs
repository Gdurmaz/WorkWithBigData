using Project.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.UI
{
    public partial class FormPerson : Form
    {
        private Core.BusinessLayer.PersonServices personServices;
        private Image image;
        private Image imageData;
        private MemoryStream memoryStream;
        private int result;
        public FormPerson()
        {
            InitializeComponent();
            personServices = new Core.BusinessLayer.PersonServices();
            memoryStream = new MemoryStream();
            cmbKisiListesi.DataSource = personServices.Select();
        }
        private void btnResimEkle_Click(object sender, EventArgs e)
        {
            ofdResim.ShowDialog();
            image = Image.FromFile(ofdResim.FileName);
            picResim.SizeMode = PictureBoxSizeMode.StretchImage;
            picResim.Image = image;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbAd.Text) && !string.IsNullOrEmpty(tbSoyad.Text) && !string.IsNullOrEmpty(tbTel.Text) && !string.IsNullOrEmpty(tbEmail.Text) && picDataResim.Image != null)
            {
                image.Save(memoryStream, ImageFormat.Jpeg);
                result = personServices.Insert(new Core.Entities.Persons()
                {
                    Name = tbAd.Text,
                    Surname = tbSoyad.Text,
                    Phone = tbTel.Text,
                    EMail = tbEmail.Text,
                    Photo = memoryStream.ToArray(),
                });
                if (result > 0)
                {
                    MessageBox.Show("Başarılı");
                    cmbKisiListesi.DataSource = personServices.Select();
                }
                else
                {
                    MessageBox.Show("Başarısız");
                    cmbKisiListesi.DataSource = personServices.Select();
                }
            }
            else
            {
                MessageBox.Show("Eksik bilgi doldurdunuz");
            }
        }
        private void cmbKisiListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKisiListesi.SelectedItem!=null)
            {
                //cmb basıldığında şeçilen kaydı person nesnesini atıyoruz.Bu nesnenin ID'sini bulup gereken listeleme işlemini gösteriyoruz;
                var person = (Persons)((sender as ComboBox).SelectedItem);
                Persons findPerson = personServices.Find(person.ID);
                tbDataAd.Text = findPerson.Name;
                tbDataSoyad.Text = findPerson.Surname;
                tbDataEmail.Text = findPerson.EMail;
                tbDataTel.Text = findPerson.Phone;
                memoryStream = new MemoryStream(findPerson.Photo);
                image = Image.FromStream(memoryStream);
                picDataResim.SizeMode = PictureBoxSizeMode.StretchImage;
                picDataResim.Image = image;
            }
        }

        private void tbAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar);
        }
    }
}
