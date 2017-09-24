using System;
using System.Windows.Forms;

namespace auto_update
{
    public partial class UpdateWindow : Form
    {
        private string updateFileName;
        private string updateProgName;

        public UpdateWindow()
        {
            InitializeComponent();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            var progress = new UpdateProgress();
            progress.Show(this);
            progress.StartUpdate(updateProgName, updateFileName);
            this.Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void update_change_log(string progName, string change, string filename)
        {
            textBox_changeLog.Text = change;
            updateFileName = filename;
            updateProgName = progName;
        }
    }
}
