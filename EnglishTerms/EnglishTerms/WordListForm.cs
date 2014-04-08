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
    public partial class WordListForm : BaseForm
    {

        public WordListForm()
        {
            InitializeComponent();
            _doc = XDocument.Load(filepath);
            grdWordList.AutoGenerateColumns = false;
        }

        private void Words_Load(object sender, EventArgs e)
        {
            ReloadDataSource();
          
        }

        private void ReloadDataSource()
        {
            ReadXml();
            grdWordList.DataSource = _listWord;
        }

        private void grdWordList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /// <summary> 
            /// Save
            /// </summary>
            if (e.ColumnIndex == 3)
            {

                XElement edit = _doc.Descendants("word").ToList().Where(a => a.Descendants("WordId").FirstOrDefault().Value == grdWordList.Rows[e.RowIndex].Cells[5].Value.ToString()).FirstOrDefault();
                if(edit!=null){
                    edit.Descendants("WordTur").FirstOrDefault().Value = grdWordList.Rows[e.RowIndex].Cells[1].Value.ToString();
                    edit.Descendants("WordEng").FirstOrDefault().Value = grdWordList.Rows[e.RowIndex].Cells[0].Value.ToString();
                    edit.Descendants("Sentences").FirstOrDefault().Value = grdWordList.Rows[e.RowIndex].Cells[2].Value.ToString();
                    _doc.Save(filepath);
                    MessageBox.Show("İşlem tamamlandı");
                }
            }

            /// <summary> 
            /// delete
            /// </summary>
            if (e.ColumnIndex == 4)
            {
                XElement edit = _doc.Descendants("word").ToList().Where(a => a.Descendants("WordId").FirstOrDefault().Value == grdWordList.Rows[e.RowIndex].Cells[5].Value.ToString()).FirstOrDefault();
                if (edit != null)
                {
                    edit.Remove();
                    _doc.Save(filepath);
                    ReloadDataSource();
                    MessageBox.Show("İşlem tamamlandı");
                }
            }
        }
    }
}
