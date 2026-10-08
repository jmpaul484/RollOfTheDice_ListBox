//Jonathan Paul
//RCET2265
//Fall 2026
//https://github.com/jmpaul484/RollOfTheDice_ListBox.git
using System.Text;

namespace RollOfTheDice_ListBox
{
    public partial class RollOfTheDiceForm : Form
    {
        public RollOfTheDiceForm()
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

        private void RollButton_Click(object sender, EventArgs e)
        {
            OutcomeListBox.Items.Clear();
            Random rnd = new();
            int choice = 0;
            int[] rolls = new int[13];
           
            for (int i = 0; i < 1000; i++)
            {
                choice = rnd.Next(1, 7) + rnd.Next(1, 7);

                switch (choice)
                {
                    case 2:
                        rolls[2]++;
                        break;
                    case 3:
                        rolls[3]++;
                        break;
                    case 4:
                        rolls[4]++;
                        break;
                    case 5:
                        rolls[5]++;
                        break;
                    case 6:
                        rolls[6]++;
                        break;
                    case 7:
                        rolls[7]++;
                        break;
                    case 8:
                        rolls[8]++;
                        break;
                    case 9:
                        rolls[9]++;
                        break;
                    case 10:
                        rolls[10]++;
                        break;
                    case 11:
                        rolls[11]++;
                        break;
                    case 12:
                        rolls[12]++;
                        break;

                }
            }

            // Build horizontal display: title, separator, header row (2..12), counts row, separator
            var headers = new StringBuilder();
            var counts = new StringBuilder();
            for (int i = 2; i <= 12; i++)
            {
                headers.AppendFormat("{0,7}|", i);
                counts.AppendFormat("{0,7}|", rolls[i]);
            }

            string numbersLine = headers.ToString();
            string countsLine = counts.ToString();
            string separator = new string('-', Math.Max(numbersLine.Length, 0));

            string title = "Roll of The Dice";
            int padding = (numbersLine.Length - title.Length) / 3;
            if (padding < 0) padding = 0;
            string titleLine = title.PadLeft(title.Length + padding);

            OutcomeListBox.Items.Add(titleLine);
            OutcomeListBox.Items.Add(separator);
            OutcomeListBox.Items.Add(numbersLine);
            OutcomeListBox.Items.Add(separator);
            OutcomeListBox.Items.Add(countsLine);
            OutcomeListBox.Items.Add(separator);
        }

    }
}
