namespace RollOfTheDice_ListBox
{
    public partial class RoolOfTheDiceForm : Form
    {
        public RoolOfTheDiceForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            // Clear the list box
            OutcomeListBox.Items.Clear();
        }

        }

        private void RollButton_Click(object sender, EventArgs e)
        {

        }
    }
}
