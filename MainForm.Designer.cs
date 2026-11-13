namespace TrapInt
{
    partial class MainForm
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
            this.EditA = new System.Windows.Forms.TextBox();
            this.EditB = new System.Windows.Forms.TextBox();
            this.LabelAB = new System.Windows.Forms.Label();
            this.LabelEps = new System.Windows.Forms.Label();
            this.EditEps = new System.Windows.Forms.TextBox();
            this.LabelN = new System.Windows.Forms.Label();
            this.EditN = new System.Windows.Forms.TextBox();
            this.LabelT = new System.Windows.Forms.Label();
            this.EditT = new System.Windows.Forms.TextBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.calcResult = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.fileName = new System.Windows.Forms.TextBox();
            this.inputFromFileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EditA
            // 
            this.EditA.Location = new System.Drawing.Point(111, 60);
            this.EditA.Name = "EditA";
            this.EditA.Size = new System.Drawing.Size(98, 20);
            this.EditA.TabIndex = 0;
            this.EditA.Text = "0";
            this.EditA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // EditB
            // 
            this.EditB.Location = new System.Drawing.Point(245, 60);
            this.EditB.Name = "EditB";
            this.EditB.Size = new System.Drawing.Size(112, 20);
            this.EditB.TabIndex = 1;
            this.EditB.Text = "0.6";
            this.EditB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LabelAB
            // 
            this.LabelAB.AutoSize = true;
            this.LabelAB.Location = new System.Drawing.Point(46, 63);
            this.LabelAB.Name = "LabelAB";
            this.LabelAB.Size = new System.Drawing.Size(59, 13);
            this.LabelAB.TabIndex = 2;
            this.LabelAB.Text = "Интервал:";
            // 
            // LabelEps
            // 
            this.LabelEps.AutoSize = true;
            this.LabelEps.Location = new System.Drawing.Point(49, 90);
            this.LabelEps.Name = "LabelEps";
            this.LabelEps.Size = new System.Drawing.Size(78, 13);
            this.LabelEps.TabIndex = 3;
            this.LabelEps.Text = "Погрешность:";
            // 
            // EditEps
            // 
            this.EditEps.Location = new System.Drawing.Point(133, 87);
            this.EditEps.Name = "EditEps";
            this.EditEps.Size = new System.Drawing.Size(98, 20);
            this.EditEps.TabIndex = 4;
            this.EditEps.Text = "0.001";
            this.EditEps.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LabelN
            // 
            this.LabelN.AutoSize = true;
            this.LabelN.Location = new System.Drawing.Point(252, 90);
            this.LabelN.Name = "LabelN";
            this.LabelN.Size = new System.Drawing.Size(119, 13);
            this.LabelN.TabIndex = 5;
            this.LabelN.Text = "Количество отрезков:";
            // 
            // EditN
            // 
            this.EditN.Location = new System.Drawing.Point(377, 87);
            this.EditN.Name = "EditN";
            this.EditN.Size = new System.Drawing.Size(98, 20);
            this.EditN.TabIndex = 6;
            this.EditN.Text = "10";
            this.EditN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LabelT
            // 
            this.LabelT.AutoSize = true;
            this.LabelT.Location = new System.Drawing.Point(52, 121);
            this.LabelT.Name = "LabelT";
            this.LabelT.Size = new System.Drawing.Size(67, 13);
            this.LabelT.TabIndex = 7;
            this.LabelT.Text = "Параметр t:";
            // 
            // EditT
            // 
            this.EditT.Location = new System.Drawing.Point(133, 118);
            this.EditT.Name = "EditT";
            this.EditT.Size = new System.Drawing.Size(98, 20);
            this.EditT.TabIndex = 8;
            this.EditT.Text = "0.1";
            this.EditT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(290, 121);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(151, 23);
            this.calcButton.TabIndex = 10;
            this.calcButton.Text = "Вычислить интеграл";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // calcResult
            // 
            this.calcResult.AutoSize = true;
            this.calcResult.Location = new System.Drawing.Point(17, 164);
            this.calcResult.Name = "calcResult";
            this.calcResult.Size = new System.Drawing.Size(123, 13);
            this.calcResult.TabIndex = 11;
            this.calcResult.Text = "Результат вычислений";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(13, 193);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(512, 174);
            this.textBox1.TabIndex = 12;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "Файл с параметрами";
            // 
            // fileName
            // 
            this.fileName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.fileName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.fileName.Location = new System.Drawing.Point(29, 12);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(308, 20);
            this.fileName.TabIndex = 13;
            this.fileName.Text = "input.txt";
            // 
            // inputFromFileButton
            // 
            this.inputFromFileButton.Location = new System.Drawing.Point(358, 9);
            this.inputFromFileButton.Name = "inputFromFileButton";
            this.inputFromFileButton.Size = new System.Drawing.Size(117, 23);
            this.inputFromFileButton.TabIndex = 14;
            this.inputFromFileButton.Text = "Ввод из файла";
            this.inputFromFileButton.UseVisualStyleBackColor = true;
            this.inputFromFileButton.Click += new System.EventHandler(this.inputFromFileButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 379);
            this.Controls.Add(this.inputFromFileButton);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.calcResult);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.EditT);
            this.Controls.Add(this.LabelT);
            this.Controls.Add(this.EditN);
            this.Controls.Add(this.LabelN);
            this.Controls.Add(this.EditEps);
            this.Controls.Add(this.LabelEps);
            this.Controls.Add(this.LabelAB);
            this.Controls.Add(this.EditB);
            this.Controls.Add(this.EditA);
            this.Name = "MainForm";
            this.Text = "Вычисление значения определённого интеграла";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EditA;
        private System.Windows.Forms.TextBox EditB;
        private System.Windows.Forms.Label LabelAB;
        private System.Windows.Forms.Label LabelEps;
        private System.Windows.Forms.TextBox EditEps;
        private System.Windows.Forms.Label LabelN;
        private System.Windows.Forms.TextBox EditN;
        private System.Windows.Forms.Label LabelT;
        private System.Windows.Forms.TextBox EditT;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Label calcResult;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox fileName;
        private System.Windows.Forms.Button inputFromFileButton;
    }
}

