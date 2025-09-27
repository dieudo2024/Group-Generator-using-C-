namespace GroupGenerator
{
    partial class Form1
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
            AddButton = new Button();
            ModifyButton = new Button();
            PickOneRandomlyButton = new Button();
            ShuffleButton = new Button();
            SplitButton = new Button();
            UserInputTextBox = new TextBox();
            InstructionLabel = new Label();
            FirstNameLastshortRadioButton = new RadioButton();
            FirstLastnameRadioButton = new RadioButton();
            LastFirstnameIDRadioButton = new RadioButton();
            NumberOfMembersTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            NumberOfGroupsTextBox = new TextBox();
            ImportButton = new Button();
            ModifyTextBox = new TextBox();
            ModifyLabel = new Label();
            SuspendLayout();
            // 
            // AddButton
            // 
            AddButton.Location = new Point(156, 415);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(78, 29);
            AddButton.TabIndex = 1;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // ModifyButton
            // 
            ModifyButton.Location = new Point(280, 415);
            ModifyButton.Name = "ModifyButton";
            ModifyButton.Size = new Size(75, 29);
            ModifyButton.TabIndex = 2;
            ModifyButton.Text = "Modify";
            ModifyButton.UseVisualStyleBackColor = true;
            ModifyButton.Click += ModifyButton_Click;
            // 
            // PickOneRandomlyButton
            // 
            PickOneRandomlyButton.Location = new Point(144, 473);
            PickOneRandomlyButton.Name = "PickOneRandomlyButton";
            PickOneRandomlyButton.Size = new Size(159, 29);
            PickOneRandomlyButton.TabIndex = 5;
            PickOneRandomlyButton.Text = "Pick One Randomly";
            PickOneRandomlyButton.UseVisualStyleBackColor = true;
            PickOneRandomlyButton.Click += PickOneRandomlyButton_Click;
            // 
            // ShuffleButton
            // 
            ShuffleButton.Location = new Point(325, 473);
            ShuffleButton.Name = "ShuffleButton";
            ShuffleButton.Size = new Size(79, 29);
            ShuffleButton.TabIndex = 4;
            ShuffleButton.Text = "Shuffle";
            ShuffleButton.UseVisualStyleBackColor = true;
            ShuffleButton.Click += ShuffleButton_Click;
            // 
            // SplitButton
            // 
            SplitButton.Location = new Point(25, 473);
            SplitButton.Name = "SplitButton";
            SplitButton.Size = new Size(94, 29);
            SplitButton.TabIndex = 1;
            SplitButton.Text = "Split";
            SplitButton.UseVisualStyleBackColor = true;
            SplitButton.Click += SplitButton_Click;
            // 
            // UserInputTextBox
            // 
            UserInputTextBox.BorderStyle = BorderStyle.FixedSingle;
            UserInputTextBox.Location = new Point(12, 12);
            UserInputTextBox.Multiline = true;
            UserInputTextBox.Name = "UserInputTextBox";
            UserInputTextBox.ScrollBars = ScrollBars.Both;
            UserInputTextBox.Size = new Size(326, 383);
            UserInputTextBox.TabIndex = 6;
            // 
            // InstructionLabel
            // 
            InstructionLabel.AutoSize = true;
            InstructionLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InstructionLabel.Location = new Point(372, 12);
            InstructionLabel.Name = "InstructionLabel";
            InstructionLabel.Size = new Size(151, 28);
            InstructionLabel.TabIndex = 7;
            InstructionLabel.Text = "Display Modes";
            // 
            // FirstNameLastshortRadioButton
            // 
            FirstNameLastshortRadioButton.AutoSize = true;
            FirstNameLastshortRadioButton.Location = new Point(372, 59);
            FirstNameLastshortRadioButton.Name = "FirstNameLastshortRadioButton";
            FirstNameLastshortRadioButton.Size = new Size(111, 24);
            FirstNameLastshortRadioButton.TabIndex = 10;
            FirstNameLastshortRadioButton.TabStop = true;
            FirstNameLastshortRadioButton.Text = "FirstName L.";
            FirstNameLastshortRadioButton.UseVisualStyleBackColor = true;
            FirstNameLastshortRadioButton.CheckedChanged += FirstNameLastshortRadioButton_CheckedChanged;
            // 
            // FirstLastnameRadioButton
            // 
            FirstLastnameRadioButton.AutoSize = true;
            FirstLastnameRadioButton.Location = new Point(372, 99);
            FirstLastnameRadioButton.Name = "FirstLastnameRadioButton";
            FirstLastnameRadioButton.Size = new Size(161, 24);
            FirstLastnameRadioButton.TabIndex = 10;
            FirstLastnameRadioButton.TabStop = true;
            FirstLastnameRadioButton.Text = "Firstname Lastname";
            FirstLastnameRadioButton.UseVisualStyleBackColor = true;
            FirstLastnameRadioButton.CheckedChanged += FirstLastnameRadioButton_CheckedChanged;
            // 
            // LastFirstnameIDRadioButton
            // 
            LastFirstnameIDRadioButton.AutoSize = true;
            LastFirstnameIDRadioButton.Location = new Point(372, 139);
            LastFirstnameIDRadioButton.Name = "LastFirstnameIDRadioButton";
            LastFirstnameIDRadioButton.Size = new Size(193, 24);
            LastFirstnameIDRadioButton.TabIndex = 10;
            LastFirstnameIDRadioButton.TabStop = true;
            LastFirstnameIDRadioButton.Text = "Lastname, Firstname (ID)";
            LastFirstnameIDRadioButton.UseVisualStyleBackColor = true;
            LastFirstnameIDRadioButton.CheckedChanged += LastFirstnameIDRadioButton_CheckedChanged;
            // 
            // NumberOfMembersTextBox
            // 
            NumberOfMembersTextBox.Location = new Point(575, 206);
            NumberOfMembersTextBox.Name = "NumberOfMembersTextBox";
            NumberOfMembersTextBox.Size = new Size(100, 27);
            NumberOfMembersTextBox.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F);
            label1.Location = new Point(372, 206);
            label1.Name = "label1";
            label1.Size = new Size(174, 46);
            label1.TabIndex = 12;
            label1.Text = "Number of members \r\nper group:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F);
            label2.Location = new Point(372, 269);
            label2.Name = "label2";
            label2.Size = new Size(160, 23);
            label2.TabIndex = 12;
            label2.Text = "Number of groups: ";
            // 
            // NumberOfGroupsTextBox
            // 
            NumberOfGroupsTextBox.Location = new Point(585, 265);
            NumberOfGroupsTextBox.Name = "NumberOfGroupsTextBox";
            NumberOfGroupsTextBox.Size = new Size(79, 27);
            NumberOfGroupsTextBox.TabIndex = 11;
            // 
            // ImportButton
            // 
            ImportButton.Location = new Point(25, 415);
            ImportButton.Name = "ImportButton";
            ImportButton.Size = new Size(94, 29);
            ImportButton.TabIndex = 14;
            ImportButton.Text = "Import";
            ImportButton.UseVisualStyleBackColor = true;
            ImportButton.Click += ImportButton_Click;
            // 
            // ModifyTextBox
            // 
            ModifyTextBox.Location = new Point(463, 329);
            ModifyTextBox.Name = "ModifyTextBox";
            ModifyTextBox.Size = new Size(212, 27);
            ModifyTextBox.TabIndex = 15;
            // 
            // ModifyLabel
            // 
            ModifyLabel.AutoSize = true;
            ModifyLabel.Location = new Point(375, 336);
            ModifyLabel.Name = "ModifyLabel";
            ModifyLabel.Size = new Size(59, 20);
            ModifyLabel.TabIndex = 16;
            ModifyLabel.Text = "Modify:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 540);
            Controls.Add(ModifyLabel);
            Controls.Add(ModifyTextBox);
            Controls.Add(ImportButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(NumberOfGroupsTextBox);
            Controls.Add(NumberOfMembersTextBox);
            Controls.Add(LastFirstnameIDRadioButton);
            Controls.Add(FirstLastnameRadioButton);
            Controls.Add(FirstNameLastshortRadioButton);
            Controls.Add(InstructionLabel);
            Controls.Add(UserInputTextBox);
            Controls.Add(PickOneRandomlyButton);
            Controls.Add(ShuffleButton);
            Controls.Add(ModifyButton);
            Controls.Add(SplitButton);
            Controls.Add(AddButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button AddButton;
        private Button ModifyButton;
        private Button PickOneRandomlyButton;
        private Button ShuffleButton;
        private Button SplitButton;
        private TextBox UserInputTextBox;
        private Label InstructionLabel;
        private RadioButton FirstNameLastshortRadioButton;
        private RadioButton FirstLastnameRadioButton;
        private RadioButton LastFirstnameIDRadioButton;
        private TextBox NumberOfMembersTextBox;
        private Label label1;
        private Label label2;
        private TextBox NumberOfGroupsTextBox;
        private Button ImportButton;
        private TextBox ModifyTextBox;
        private Label ModifyLabel;
    }
}
