using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EnglishTerms
{
    public partial class Form1 : BaseForm
    {
       
        Word _curent;
        bool add = false;
        public Form1()
        {
            _doc = XDocument.Load(filepath);
            InitializeComponent();
        }
        /// <summary> 
        /// xml dosyasına yeni kelime ekleme işlemi
        /// </summary>
        private void btnadd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtword.Text) && !string.IsNullOrEmpty(txtanswear.Text))
            {
                try
                {
                    Word w = new Word();
                    w.WordId = Guid.NewGuid();
                    w.WordTur = txtanswear.Text;
                    w.WordEng = txtword.Text;
                    w.Sentences = txtsentence.Text;
                    /// <summary> 
                    /// xml dosyasına yeni kelime ekleme
                    /// </summary>
                    _doc.Root.Add(new XElement("word", new XElement("WordId", w.WordId), new XElement("WordTur", w.WordTur), new XElement("WordEng", w.WordEng), new XElement("Sentences", w.Sentences)));
                    _doc.Save(filepath);
                    MessageBox.Show("işlem atamamlandı");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                ReadXml();
                CleanAddParameter();
            }
        }
        /// <summary> 
        /// form içerisindeki text alanları temizlemek için kullanılır.
        /// </summary>
        private void CleanAddParameter()
        {
            txtanswear.Text = "";
            txtsentence.Text = "";
            txtword.Text = "";
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            Default();
        }
        /// <summary> 
        /// program başlangıcında yapılacak işlemler
        /// </summary>
        private void Default()
        {
            ReadXml();
            _curent = _listWord.FirstOrDefault();
            if (_curent != null)
            {
                lblid.Text = _curent.WordId.ToString();
                lblword.Text = _curent.WordEng;
            }
        }
        /// <summary> 
        /// cevabı sorulan kelime ile ilgili bilgilerin ekrana yazılması
        /// </summary>
        private void btncevap_Click(object sender, EventArgs e)
        {
            if (_curent != null)
            {
                txtDetail.Text = " Word : " + _curent.WordEng + "\n Word Answear : " + _curent.WordTur + "\n Word Sentences : \n" + _curent.Sentences;

            }
        }
        /// <summary> 
        /// bir sonraki kelimeye geçmek için kullanılır.
        /// </summary>
        private void btnnext_Click(object sender, EventArgs e)
        {
            int find = 0;
            for (int i = 0; i < _listWord.Count; i++)
            {
                if (_listWord[i].WordId == _curent.WordId)
                    find = i + 1;
            }
            if (find >= 0 && find<_listWord.Count)
            {
                _curent = _listWord[find];
            }
            if (_curent != null)
            {
                lblid.Text = _curent.WordId.ToString();
                lblword.Text = _curent.WordEng;
            }
            CleanShowParameter();
        }
        /// <summary> 
        /// detaylar temizlenir
        /// </summary>
        private void CleanShowParameter()
        {
            txtDetail.Text = "";
        }
        /// <summary> 
        /// aktif kelimeden önceki kelimeye geçmek için kullanılır.
        /// </summary>
        private void btnpre_Click(object sender, EventArgs e)
        {
            int find = 0;
            for (int i = 0; i < _listWord.Count; i++)
            {
                if (_listWord[i].WordId == _curent.WordId)
                    find = i - 1;
            }
            if (find >= 0)
            {
                _curent = _listWord[find];
            }
            if (_curent != null)
            {
                lblid.Text = _curent.WordId.ToString();
                lblword.Text = _curent.WordEng;
            }
            CleanShowParameter();
        }
        /// <summary> 
        /// kelime giriş kısmının gösterilip gizlenmesi işlemi
        /// </summary>
        private void btnShowHide_Click(object sender, EventArgs e)
        {
            if (add == false)
            {
                pnlEkle.Visible = add = true;
                btnShowHide.Text = "Kelime Ekle Gizle";
            }
            else
            {
                pnlEkle.Visible = add = false;
                btnShowHide.Text = "Kelime Ekle Göster";
            }
        }

        /// <summary> 
        /// kelime listesi gösterme işlemi
        /// </summary>
        private void btnlist_Click(object sender, EventArgs e)
        {
            WordListForm form = new WordListForm();
            //form._listWord = _listWord;
            form.Show();
        }
    }
}
