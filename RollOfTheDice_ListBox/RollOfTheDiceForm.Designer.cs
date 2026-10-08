namespace RollOfTheDice_ListBox
{
    partial class RollOfTheDiceForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ExitButton = new Button();
            ClearButton = new Button();
            RollButton = new Button();
            OutcomeListBox = new ListBox();
            SuspendLayout();
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(649, 362);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(139, 76);
            ExitButton.TabIndex = 0;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(531, 362);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(112, 76);
            ClearButton.TabIndex = 1;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // RollButton
            // 
            RollButton.Location = new Point(413, 362);
            RollButton.Name = "RollButton";
            RollButton.Size = new Size(112, 76);
            RollButton.TabIndex = 2;
            RollButton.Text = "Roll";
            RollButton.UseVisualStyleBackColor = true;
            RollButton.Click += RollButton_Click;
            // 
            // OutcomeListBox
            // 
            OutcomeListBox.FormattingEnabled = true;
            OutcomeListBox.Location = new Point(12, 71);
            OutcomeListBox.Name = "OutcomeListBox";
            OutcomeListBox.Size = new Size(776, 279);
            OutcomeListBox.TabIndex = 4;
            // 
            // RollOfTheDiceForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(OutcomeListBox);
            Controls.Add(RollButton);
            Controls.Add(ClearButton);
            Controls.Add(ExitButton);
            Name = "RollOfTheDiceForm";
            Text = "Roll of The Dice";
            ResumeLayout(false);
        }

        #endregion

        private Button ExitButton;
        private Button ClearButton;
        private Button RollButton;
        private ListBox OutcomeListBox;
    }
}
