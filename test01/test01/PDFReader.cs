using DevExpress.XtraEditors;
using iTextSharp.text.pdf.parser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace test01
{
    public partial class PDFReader : Form
    {
        public PDFReader()
        {
            InitializeComponent();
        }
        string pdftext = "";
        string filename = "";
        string result = string.Empty;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            ofd.Filter = "PDF Files|*.pdf";
            if (ofd.ShowDialog()==DialogResult.OK)
            {
                txtFile.Text = ofd.FileName;
            }
        }
        private void getpdftext(string fileName)
        {
            if (filename != fileName)
            {
                StringBuilder sb = new StringBuilder();
                iTextSharp.text.pdf.PdfReader r = new iTextSharp.text.pdf.PdfReader(txtFile.Text);
                for (int i = 1; i <= r.NumberOfPages; i++)
                {
                    sb.AppendLine(PdfTextExtractor.GetTextFromPage(r, i));
                }

                pdftext = sb.ToString();
                filename = fileName;
            }
        }
        private void btnGetText_Click(object sender, EventArgs e)
        {
            getpdftext(txtFile.Text);
            txtResult.Text = pdftext;
        }

        private void btnSelectText_Click(object sender, EventArgs e)
        {
            getpdftext(txtFile.Text);
            //Regex r = new Regex($"(?i)(?<={Regex.Escape(txtStart.Text)})[^{Regex.Escape(txtEnd.Text)[0]}]*(?={Regex.Escape(txtEnd.Text)})", RegexOptions.Singleline);
            //MatchCollection mc = r.Matches(pdftext);
            //StringBuilder sb = new StringBuilder();
            //foreach (Match a in mc)
            //{
            //    sb.AppendLine(a.Value);
            //}
            txtResult.Text=MidStrEx(pdftext, txtStart.Text, txtEnd.Text);
            //txtResult.Text = sb.ToString();
        }

        private string MidStrEx(string sourse, string startstr, string endstr)
        {
            
            int startindex, endindex;
            try
            {
                string[] splitStr = {startstr, endstr };
                //string[] splitResult = sourse.Split(splitStr,100);
                //startindex = sourse.IndexOf(startstr);
                //if (startindex == -1)
                //    return result;
                //string tmpstr = sourse.Substring(startindex + startstr.Length);
                //endindex = tmpstr.IndexOf(endstr);
                //if (endindex == -1)
                //    return result;
                //result+=tmpstr.Remove(endindex)+"/";
                //tmpstr = tmpstr.Substring(endindex + endstr.Length);
                //MidStrEx(tmpstr, startstr, endstr);
            }
            catch (Exception ex)
            {
                MessageBox.Show("错误");
            }
            return result;
        }

    }
}
