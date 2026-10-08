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

        private void RollButton_Click(object sender, EventArgs e)
        {
            OutcomeListBox.Items = DiceRolls();
        }

        static List<string> DiceRolls()
        {
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

            Console.WriteLine("                 Roll of the Dice");
            Console.WriteLine("-------------------------------------------------------");
            // Print results in two rows: header (2-12) and counts below each header
            for (int i = 2; i < rolls.Length; i++)
            {
                Console.Write($"{i,4}|");
            }
            Console.WriteLine();

            Console.WriteLine("-------------------------------------------------------");
            for (int i = 2; i < rolls.Length; i++)
            {
                Console.Write($"{rolls[i],4}|");
            }
        }
    }
}
