namespace WinFormsApp1
{
    partial class nomatter
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
            LABEL1 = new Label();
            textBoxWord = new TextBox();
            EncryptButton = new Button();
            label2 = new Label();
            textBoxSlide = new TextBox();
            labelResult = new Label();
            SuspendLayout();
            // 
            // LABEL1
            // 
            LABEL1.BackColor = SystemColors.GradientActiveCaption;
            LABEL1.Font = new Font("Snap ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LABEL1.ForeColor = Color.Peru;
            LABEL1.Location = new Point(-6, -2);
            LABEL1.Name = "LABEL1";
            LABEL1.Size = new Size(1002, 25);
            LABEL1.TabIndex = 0;
            LABEL1.Text = "\"Hello, you are welcome to Caesar encryption!  Please enter the words!";
            // 
            // textBoxWord
            // 
            textBoxWord.Location = new Point(2, 43);
            textBoxWord.Name = "textBoxWord";
            textBoxWord.Size = new Size(994, 27);
            textBoxWord.TabIndex = 1;
            // 
            // EncryptButton
            // 
            EncryptButton.Font = new Font("Snap ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EncryptButton.ForeColor = Color.Peru;
            EncryptButton.Location = new Point(367, 205);
            EncryptButton.Name = "EncryptButton";
            EncryptButton.Size = new Size(122, 53);
            EncryptButton.TabIndex = 2;
            EncryptButton.Text = "OK";
            EncryptButton.UseVisualStyleBackColor = true;
            EncryptButton.Click += EncryptButton_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Snap ITC", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Peru;
            label2.Location = new Point(2, 97);
            label2.Name = "label2";
            label2.Size = new Size(947, 25);
            label2.TabIndex = 3;
            label2.Text = "Please write how much you slide?";
            // 
            // textBoxSlide
            // 
            textBoxSlide.Location = new Point(2, 161);
            textBoxSlide.Name = "textBoxSlide";
            textBoxSlide.Size = new Size(951, 27);
            textBoxSlide.TabIndex = 4;
            // 
            // labelResult
            // 
            labelResult.BackColor = SystemColors.GradientActiveCaption;
            labelResult.Font = new Font("Snap ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelResult.ForeColor = Color.Peru;
            labelResult.Location = new Point(144, 287);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(569, 166);
            labelResult.TabIndex = 5;
            labelResult.TextAlign = ContentAlignment.TopCenter;
            // 
            // nomatter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(947, 462);
            Controls.Add(labelResult);
            Controls.Add(textBoxSlide);
            Controls.Add(label2);
            Controls.Add(EncryptButton);
            Controls.Add(textBoxWord);
            Controls.Add(LABEL1);
            ForeColor = SystemColors.ActiveCaption;
            Name = "nomatter";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Click += EncryptButton_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LABEL1;
        private TextBox textBoxWord;
        private Button EncryptButton;
        private Label label2;
        private TextBox textBoxSlide;
        private Label labelResult;
    }
}
