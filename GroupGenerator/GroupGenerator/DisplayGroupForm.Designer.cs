namespace GroupGenerator
{
    partial class DisplayGroupForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DisplayListBox = new ListBox();
            CloseButton = new Button();
            SuspendLayout();
            // 
            // DisplayListBox
            // 
            DisplayListBox.FormattingEnabled = true;
            DisplayListBox.Location = new Point(23, 19);
            DisplayListBox.Name = "DisplayListBox";
            DisplayListBox.Size = new Size(359, 364);
            DisplayListBox.TabIndex = 0;
            // 
            // CloseButton
            // 
            CloseButton.Location = new Point(145, 398);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(94, 29);
            CloseButton.TabIndex = 1;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // DisplayGroupForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 450);
            Controls.Add(CloseButton);
            Controls.Add(DisplayListBox);
            Name = "DisplayGroupForm";
            Text = "DisplayGroupForm";
            ResumeLayout(false);
        }

        #endregion
        private Button CloseButton;
        public ListBox DisplayListBox;
    }
}