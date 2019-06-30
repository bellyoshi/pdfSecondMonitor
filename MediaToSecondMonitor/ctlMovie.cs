using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaToSecondMonitor
{
    public partial class ctlMovie : UserControl
    {
        public ctlMovie()
        {
            InitializeComponent();
        }
        private FormDispacher _dispacher = FormDispacher.Instance;


        private AxWMPLib.AxWindowsMediaPlayer player;

        private FileViewParam _fileViewParam;

        public void SetFileInfo(FileViewParam f)
        {
            this._fileViewParam = f;
            if (_fileViewParam == null)
                return;
            player = _dispacher.GetPlayer();

            player.URL = _fileViewParam.FileName;
            player.uiMode = "none";
            player.stretchToFit = true;
        }


        private bool inPlay = false;


        private void btnStartStop_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.play();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.pause();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.fastForward();
        }

        private void btnFastReverse_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.fastReverse();
        }


        public void ControlEnabled()
        {
            this.Enabled = !(_fileViewParam == null);
        }
    }
}

