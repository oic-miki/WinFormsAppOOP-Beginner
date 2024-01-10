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
            personPanel = new Panel();
            personName = new PersonNameLabel();
            personNameLabel = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            personPanel.SuspendLayout();
            SuspendLayout();
            // 
            // personPanel
            // 
            personPanel.Controls.Add(personName);
            personPanel.Controls.Add(personNameLabel);
            personPanel.Location = new Point(67, 41);
            personPanel.Name = "personPanel";
            personPanel.Size = new Size(422, 302);
            personPanel.TabIndex = 0;
            // 
            // personName
            // 
            personName.AutoSize = true;
            personName.Location = new Point(106, 34);
            personName.Name = "personName";
            personName.Size = new Size(77, 15);
            personName.TabIndex = 1;
            personName.Text = "Person Name";
            // 
            // personNameLabel
            // 
            personNameLabel.AutoSize = true;
            personNameLabel.Location = new Point(43, 34);
            personNameLabel.Name = "personNameLabel";
            personNameLabel.Size = new Size(38, 15);
            personNameLabel.TabIndex = 0;
            personNameLabel.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(520, 75);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "Name";
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
            button1.Text = "Save";
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
            Controls.Add(label1);
            Controls.Add(personPanel);
            Name = "PersonForm";
            Text = "Person";
            personPanel.ResumeLayout(false);
            personPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel personPanel;
        private Label personNameLabel;
        private Label label1;
        private PersonNameLabel personName;
        private TextBox textBox1;
        private Button button1;
    }
}
