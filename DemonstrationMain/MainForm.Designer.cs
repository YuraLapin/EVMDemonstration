namespace DemonstrationMain
{
    partial class MainForm
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
            aOperandTextBox = new TextBox();
            bOperandTextBox = new TextBox();
            resultTextBox = new TextBox();
            aOperandLabel = new Label();
            bOperandLabel = new Label();
            resultLabel = new Label();
            plusButton = new Button();
            equalityButton = new Button();
            zTextBox = new TextBox();
            ovTextBox = new TextBox();
            ovLabel = new Label();
            zLabel = new Label();
            SuspendLayout();
            // 
            // aOperandTextBox
            // 
            aOperandTextBox.Location = new Point(12, 27);
            aOperandTextBox.MaxLength = 16;
            aOperandTextBox.Name = "aOperandTextBox";
            aOperandTextBox.Size = new Size(143, 23);
            aOperandTextBox.TabIndex = 0;
            // 
            // bOperandTextBox
            // 
            bOperandTextBox.Location = new Point(12, 81);
            bOperandTextBox.MaxLength = 16;
            bOperandTextBox.Name = "bOperandTextBox";
            bOperandTextBox.Size = new Size(143, 23);
            bOperandTextBox.TabIndex = 1;
            // 
            // resultTextBox
            // 
            resultTextBox.Enabled = false;
            resultTextBox.Location = new Point(350, 27);
            resultTextBox.MaxLength = 16;
            resultTextBox.Name = "resultTextBox";
            resultTextBox.Size = new Size(122, 23);
            resultTextBox.TabIndex = 2;
            // 
            // aOperandLabel
            // 
            aOperandLabel.AutoSize = true;
            aOperandLabel.Location = new Point(12, 9);
            aOperandLabel.Name = "aOperandLabel";
            aOperandLabel.Size = new Size(66, 15);
            aOperandLabel.TabIndex = 3;
            aOperandLabel.Text = "Операнд A";
            // 
            // bOperandLabel
            // 
            bOperandLabel.AutoSize = true;
            bOperandLabel.Location = new Point(12, 63);
            bOperandLabel.Name = "bOperandLabel";
            bOperandLabel.Size = new Size(65, 15);
            bOperandLabel.TabIndex = 4;
            bOperandLabel.Text = "Операнд B";
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(350, 9);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(60, 15);
            resultLabel.TabIndex = 5;
            resultLabel.Text = "Результат";
            // 
            // plusButton
            // 
            plusButton.Location = new Point(174, 27);
            plusButton.Name = "plusButton";
            plusButton.Size = new Size(152, 23);
            plusButton.TabIndex = 6;
            plusButton.Text = "Сложение / вычитание";
            plusButton.UseVisualStyleBackColor = true;
            plusButton.Click += plusButton_Click;
            // 
            // equalityButton
            // 
            equalityButton.Location = new Point(174, 81);
            equalityButton.Name = "equalityButton";
            equalityButton.Size = new Size(152, 23);
            equalityButton.TabIndex = 7;
            equalityButton.Text = "Эквивалентность";
            equalityButton.UseVisualStyleBackColor = true;
            equalityButton.Click += equalityButton_Click;
            // 
            // zTextBox
            // 
            zTextBox.Enabled = false;
            zTextBox.Location = new Point(372, 85);
            zTextBox.Name = "zTextBox";
            zTextBox.Size = new Size(100, 23);
            zTextBox.TabIndex = 8;
            // 
            // ovTextBox
            // 
            ovTextBox.Enabled = false;
            ovTextBox.Location = new Point(372, 56);
            ovTextBox.Name = "ovTextBox";
            ovTextBox.Size = new Size(100, 23);
            ovTextBox.TabIndex = 9;
            // 
            // ovLabel
            // 
            ovLabel.AutoSize = true;
            ovLabel.Location = new Point(350, 59);
            ovLabel.Name = "ovLabel";
            ovLabel.Size = new Size(20, 15);
            ovLabel.TabIndex = 10;
            ovLabel.Text = "ov";
            // 
            // zLabel
            // 
            zLabel.AutoSize = true;
            zLabel.Location = new Point(354, 88);
            zLabel.Name = "zLabel";
            zLabel.Size = new Size(12, 15);
            zLabel.TabIndex = 11;
            zLabel.Text = "z";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 148);
            Controls.Add(zLabel);
            Controls.Add(ovLabel);
            Controls.Add(ovTextBox);
            Controls.Add(zTextBox);
            Controls.Add(equalityButton);
            Controls.Add(plusButton);
            Controls.Add(resultLabel);
            Controls.Add(bOperandLabel);
            Controls.Add(aOperandLabel);
            Controls.Add(resultTextBox);
            Controls.Add(bOperandTextBox);
            Controls.Add(aOperandTextBox);
            Name = "MainForm";
            Text = "Сложение вычитание эквиваленция";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox aOperandTextBox;
        private TextBox bOperandTextBox;
        private TextBox resultTextBox;
        private Label aOperandLabel;
        private Label bOperandLabel;
        private Label resultLabel;
        private Button plusButton;
        private Button equalityButton;
        private TextBox zTextBox;
        private TextBox ovTextBox;
        private Label ovLabel;
        private Label zLabel;
    }
}
