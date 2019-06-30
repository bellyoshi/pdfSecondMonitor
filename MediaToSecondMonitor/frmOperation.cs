using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaToSecondMonitor
{
    public partial class frmOperation : Form
    {
        public frmOperation()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     ''' 開ける動画の拡張子
        ///     ''' </summary>
        private string[] movieExts =
        {
        "avi",
        "mpeg",
        "mp4",
        "wmv",
        "mov"
    };

        /// <summary>
        ///     ''' 開ける画像の拡張子
        ///     ''' </summary>
        private string[] ImageExts =
        {
        "jpeg",
        "jpg",
        "bmp",
        "png",
        "gif",
        "tiff",
        "tif"
    };

        /// <summary>
        ///     ''' PDFの拡張子
        ///     ''' </summary>
        private string[] PDFExts =
        {
        "pdf"
    };


        private void ControlEnable()
        {
            ctlPDF1.ControlEnabled();
            ctlMovie1.ControlEnabled();
            ctlImage1.ControlEnabled();
        }
        private void frmOperation_Load(object sender, EventArgs e)
        {
            screenDetect();
            AppSettingLoad();
            ActivateForm();
            ControlEnable();
        }

        private void ActivateForm()
        {
            Timer1.Interval = 100;
            Timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            this.Activate();
            Timer1.Stop();
        }

        private bool loading;
        private void AppSettingLoad()
        {
            loading = true;
            cmbDisplay.SelectedIndex = My.Settings.cmbDisplaySelectedIndex;
            try
            {
                List<FileViewParam> fvinfos = new List<FileViewParam>();

                // XmlSerializerオブジェクトを作成
                System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(List<FileViewParam>));
                // 読み込むファイルを開く
                var filename = "lstPDFFiles.xml";
                if (!System.IO.File.Exists(filename))
                    return;
                using (System.IO.StreamReader sr = new System.IO.StreamReader(filename, new System.Text.UTF8Encoding(false)))
                {
                    // XMLファイルから読み込み、逆シリアル化する
                    fvinfos = (List<FileViewParam>)serializer.Deserialize(sr);
                }
                foreach (var info in fvinfos)
                    lstPDFFiles.Items.Add(info);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            loading = false;
        }

        private void AppSettingSave()
        {
            My.Settings.cmbDisplaySelectedIndex = cmbDisplay.SelectedIndex;
            My.Settings.Save();

            List<FileViewParam> fvinfos = new List<FileViewParam>();
            foreach (var info in lstPDFFiles.Items)
                fvinfos.Add(info);
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(List<FileViewParam>));
            // 書き込むファイルを開く（UTF-8 BOM無し）
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter("lstPDFFiles.xml", false, new System.Text.UTF8Encoding(false)))
            {
                // シリアル化し、XMLファイルに保存する
                serializer.Serialize(sw, fvinfos);
            }
        }


        private void screenDetect()
        {
            // デバイス名が表示されるようにする
            this.cmbDisplay.DisplayMember = "DeviceName";
            this.cmbDisplay.DataSource = Screen.AllScreens;
        }


        private void frmOperation_FormClosed(object sender, FormClosedEventArgs e)
        {
            AppSettingSave();
        }

        private void cmbDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDisplay.SelectedIndex < 0)
                return;
            if (cmbDisplay.SelectedItem == null)
                return;
            // 'フォームを表示するディスプレイのScreenを取得する
            Screen s = (Screen)this.cmbDisplay.SelectedItem;
            // 'フォームの開始位置をディスプレイの左上座標に設定する
            _dispacher.SetSecondScreen(s);
        }



        private FormDispacher _dispacher = FormDispacher.GetInstance;






        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstPDFFiles.SelectedItem == null)
                return;
            FileViewParam fileviewinfo;
            fileviewinfo = lstPDFFiles.SelectedItem;
            lstPDFFiles.Items.Remove(fileviewinfo);
        }





        private void lstFiles_Click(object sender, EventArgs e)
        {
            FileViewParam fileviewinfo;
            fileviewinfo = lstPDFFiles.SelectedItem;
            if (fileviewinfo == null)
                return;
            var path = fileviewinfo.FileName;
            if (!System.IO.File.Exists(path))
            {
                var ret = MessageBox.Show("ファイルが見つかりません。リストから削除しますか？", "ファイルがありません", MessageBoxButtons.YesNo);
                if (ret == DialogResult.Yes)
                    lstPDFFiles.Items.Remove(fileviewinfo);
                return;
            }
            txtPDFFileName.Text = fileviewinfo.FileName;
            var ext = System.IO.Path.GetExtension(fileviewinfo.FileName);
            FileViewParam imageFileViewInfo = null/* TODO Change to default(_) if this is not a reference type */;
            FileViewParam pdfFileViewInfo = null/* TODO Change to default(_) if this is not a reference type */;
            FileViewParam movieFileViewInfo = null/* TODO Change to default(_) if this is not a reference type */;
            if (IsPDFExt(ext))
            {
                tbcFileOpes.SelectTab(tpAdobePDF.TabIndex);
                pdfFileViewInfo = fileviewinfo;
            }
            else if (IsImageExt(ext))
            {
                tbcFileOpes.SelectTab(tpImage.TabIndex);
                imageFileViewInfo = fileviewinfo;
            }
            else if (IsMovieExt(ext))
            {
                tbcFileOpes.SelectTab(tpMediaPlayer.TabIndex);
                movieFileViewInfo = fileviewinfo;
            }
            CtlImage1.SetFileInfo(imageFileViewInfo);
            CtlMovie1.SetFileInfo(movieFileViewInfo);
            CtlPdf1.SetFileInfo(pdfFileViewInfo);
            ControlEnable();
        }


        private bool IsContain(string ext, string[] exts)
        {
            foreach (var target in exts)
            {
                if (string.Compare($".{target}", ext, true) == 0)
                    return true;
            }
            return false;
        }


        private bool IsPDFExt(object ext)
        {
            return IsContain(ext, PDFExts);
        }

        private bool IsImageExt(object ext)
        {
            return IsContain(ext, ImageExts);
        }

        private bool IsMovieExt(object ext)
        {
            return IsContain(ext, movieExts);
        }

        private string CreateFilter()
        {
            System.Text.StringBuilder buf = new System.Text.StringBuilder();
            buf.Append("画像、動画、PDFファイル");
            buf.Append("|");
            buf.Append(CreateExtsOfFilter(PDFExts));
            buf.Append(CreateExtsOfFilter(ImageExts));
            buf.Append(CreateExtsOfFilter(movieExts));
            buf.Append("|");
            buf.Append("All Files(*.*)");
            buf.Append("|");
            buf.Append("*.*");
            return buf.ToString();
        }

        private string CreateExtsOfFilter(string[] exts)
        {
            var buf = new System.Text.StringBuilder();
            foreach (var ext in exts)
            {
                buf.Append("*.");
                buf.Append(ext);
                buf.Append(";");
            }
            return buf.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog1.Multiselect = true;
            OpenFileDialog1.Filter = CreateFilter();
            OpenFileDialog1.FileName = txtPDFFileName.Text;
            var ret = OpenFileDialog1.ShowDialog();
            if (ret == Windows.Forms.DialogResult.Cancel)
                return;

            var items = lstPDFFiles.Items;

            foreach (var filename in OpenFileDialog1.FileNames)
                items.Add(new FileViewParam() { FileName = filename });
        }

        private void btnUnSelect_Click(object sender, EventArgs e)
        {
            lstPDFFiles.SelectedItem = null;
            _dispacher.CloseViewers();
            ControlEnable();
        }

        private void lstPDFFiles_DragEnter(object sender, DragEventArgs e)
        {
            // コントロール内にドラッグされたとき実行される
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                // ドラッグされたデータ形式を調べ、ファイルのときはコピーとする
                e.Effect = DragDropEffects.Copy;
            else
                // ファイル以外は受け付けない
                e.Effect = DragDropEffects.None;
        }

        private void lstPDFFiles_DragDrop(object sender, DragEventArgs e)
        {
            var items = lstPDFFiles.Items;
            string[] fileName = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            foreach (var f in fileName)
                items.Add(new FileViewParam(f));
        }
    }
}
