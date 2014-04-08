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
    public partial class BaseForm : Form
    {
        protected string filepath = "words.xml";
        protected XDocument _doc;
        protected List<Word> _listWord = new List<Word>();
        public BaseForm()
        {
            InitializeComponent();
            _doc = XDocument.Load(filepath);
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {

        }
        /// <summary> 
        /// xml dosyası içerisindeki kelimeleri okumak için tasarlanmıştır.
        /// </summary>
        protected void ReadXml()
        {

            _listWord = (from w in _doc.Descendants("word").ToList()
                         select new Word()
                         {
                             WordId = new Guid(w.Elements("WordId").FirstOrDefault().Value),
                             WordEng = w.Elements("WordEng").FirstOrDefault().Value,
                             WordTur = w.Elements("WordTur").FirstOrDefault().Value,
                             Sentences = w.Elements("Sentences").FirstOrDefault().Value
                         }).ToList<Word>();
        }
    }
}
