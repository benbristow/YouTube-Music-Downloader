using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MusicDownloader.Lib;

namespace MusicDownloader
{
    public partial class frm_Main : Form
    {

        public frm_Main()
        {
            InitializeComponent();

            //Init DataGridView
            BindingSource searchSource = new BindingSource();
            searchSource.DataSource = Client.videos;
            dgv_Videos.DataSource = searchSource;
        }


        #region Toolbar
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var s = new frm_Settings();
            s.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Video Searching

        private void btn_Search_Click(object sender, EventArgs e)
        {
            search();            
        }

        private void txt_Search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == ((Char)13))
            {
                search();
                e.Handled = true;
            }
        }

        private void search()
        {
            Client.search(txt_Search.Text);
        }


        #endregion

        #region Video Downloading
        private void dgv_Videos_DoubleClick(object sender, EventArgs e)
        {
            //Download On Double Click
            foreach(DataGridViewRow srow in dgv_Videos.SelectedRows)
            {
                var video = (Video)srow.DataBoundItem;
                video.download();
            }
        }
        #endregion

    }
}
