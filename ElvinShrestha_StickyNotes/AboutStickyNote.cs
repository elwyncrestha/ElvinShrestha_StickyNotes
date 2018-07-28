using System.Windows.Forms;

namespace ElvinShrestha_StickyNotes
{
    public partial class AboutStickyNote : Form
    {
        public AboutStickyNote()
        {
            InitializeComponent();
        }

        private void AboutStickyNote_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            FormLoaderClass.loadStickyNotes();
            this.Close();
        }
    }
}
