namespace WinFormsAppOOP
{
    partial class PersonForm
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
            personPanel = new PersonPanel();
            personNameLabel = new PersonNameLabel();
            personNameTitleLabel1 = new PersonNameTitleLabel();
            personNameTitleLabel2 = new PersonNameTitleLabel();
            textBox1 = new TextBox();
            button1 = new Button();
            personPanel.SuspendLayout();
            SuspendLayout();
            // 
            // personPanel
            // 
            personPanel.Controls.Add(personNameLabel);
            personPanel.Controls.Add(personNameTitleLabel1);
            personPanel.Location = new Point(67, 41);
            personPanel.Name = "personPanel";
            personPanel.Size = new Size(422, 302);
            personPanel.TabIndex = 0;
            // 
            // personNameLabel
            // 
            personNameLabel.AutoSize = true;
            personNameLabel.Location = new Point(106, 34);
            personNameLabel.Name = "personNameLabel";
            personNameLabel.Size = new Size(128, 15);
            personNameLabel.TabIndex = 1;
            personNameLabel.Text = "ここに名前が表示されます";
            // 
            // personNameTitleLabel1
            // 
            personNameTitleLabel1.AutoSize = true;
            personNameTitleLabel1.Location = new Point(43, 34);
            personNameTitleLabel1.Name = "personNameTitleLabel1";
            personNameTitleLabel1.Size = new Size(43, 15);
            personNameTitleLabel1.TabIndex = 0;
            personNameTitleLabel1.Text = "名　前";
            // 
            // personNameTitleLabel2
            // 
            personNameTitleLabel2.AutoSize = true;
            personNameTitleLabel2.Location = new Point(520, 75);
            personNameTitleLabel2.Name = "personNameTitleLabel2";
            personNameTitleLabel2.Size = new Size(43, 15);
            personNameTitleLabel2.TabIndex = 1;
            personNameTitleLabel2.Text = "名　前";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(574, 72);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(171, 23);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(670, 320);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "変　更";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // PersonForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(personNameTitleLabel2);
            Controls.Add(personPanel);
            Name = "PersonForm";
            Text = "Person";
            personPanel.ResumeLayout(false);
            personPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PersonPanel personPanel;
        private PersonNameLabel personNameLabel;
        private TextBox textBox1;
        private Button button1;
        private PersonNameTitleLabel personNameTitleLabel1;
        private PersonNameTitleLabel personNameTitleLabel2;
    }
}
