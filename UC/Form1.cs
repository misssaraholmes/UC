namespace UC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetState_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("State id = {0}, State name = {1}", usState1.SelectedState.ID, usState1.SelectedState.Name), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}