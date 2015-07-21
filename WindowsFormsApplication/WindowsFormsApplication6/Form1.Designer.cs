namespace WindowsFormsApplication6
{
    partial class Form1
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
            this.addRadioButton = new System.Windows.Forms.RadioButton();
            this.translateRadioButton = new System.Windows.Forms.RadioButton();
            this.deleteRadioButton = new System.Windows.Forms.RadioButton();
            this.cizimAlaniLabel = new System.Windows.Forms.Label();
            this.clusterButton = new System.Windows.Forms.Button();
            this.clusterNumberTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addRadioButton
            // 
            this.addRadioButton.AutoSize = true;
            this.addRadioButton.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addRadioButton.Location = new System.Drawing.Point(65, 111);
            this.addRadioButton.Name = "addRadioButton";
            this.addRadioButton.Size = new System.Drawing.Size(103, 22);
            this.addRadioButton.TabIndex = 0;
            this.addRadioButton.TabStop = true;
            this.addRadioButton.Text = "Nokta Ekle";
            this.addRadioButton.UseVisualStyleBackColor = true;
            this.addRadioButton.CheckedChanged += new System.EventHandler(this.addRadioButton_CheckedChanged);
            // 
            // translateRadioButton
            // 
            this.translateRadioButton.AutoSize = true;
            this.translateRadioButton.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.translateRadioButton.Location = new System.Drawing.Point(65, 138);
            this.translateRadioButton.Name = "translateRadioButton";
            this.translateRadioButton.Size = new System.Drawing.Size(108, 22);
            this.translateRadioButton.TabIndex = 1;
            this.translateRadioButton.TabStop = true;
            this.translateRadioButton.Text = "Yer Değiştir";
            this.translateRadioButton.UseVisualStyleBackColor = true;
            this.translateRadioButton.CheckedChanged += new System.EventHandler(this.translateRadioButton_CheckedChanged);
            // 
            // deleteRadioButton
            // 
            this.deleteRadioButton.AutoSize = true;
            this.deleteRadioButton.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deleteRadioButton.Location = new System.Drawing.Point(65, 165);
            this.deleteRadioButton.Name = "deleteRadioButton";
            this.deleteRadioButton.Size = new System.Drawing.Size(90, 22);
            this.deleteRadioButton.TabIndex = 2;
            this.deleteRadioButton.TabStop = true;
            this.deleteRadioButton.Text = "Nokta Sil";
            this.deleteRadioButton.UseVisualStyleBackColor = true;
            this.deleteRadioButton.CheckedChanged += new System.EventHandler(this.deleteRadioButton_CheckedChanged);
            // 
            // cizimAlaniLabel
            // 
            this.cizimAlaniLabel.AutoSize = true;
            this.cizimAlaniLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cizimAlaniLabel.Location = new System.Drawing.Point(335, 45);
            this.cizimAlaniLabel.Name = "cizimAlaniLabel";
            this.cizimAlaniLabel.Size = new System.Drawing.Size(129, 24);
            this.cizimAlaniLabel.TabIndex = 3;
            this.cizimAlaniLabel.Text = "Çizim Alanı";
            // 
            // clusterButton
            // 
            this.clusterButton.Location = new System.Drawing.Point(6, 49);
            this.clusterButton.Name = "clusterButton";
            this.clusterButton.Size = new System.Drawing.Size(84, 34);
            this.clusterButton.TabIndex = 4;
            this.clusterButton.Text = "Kümele";
            this.clusterButton.UseVisualStyleBackColor = true;
            this.clusterButton.Click += new System.EventHandler(this.clusterButton_Click);
            // 
            // clusterNumberTextBox
            // 
            this.clusterNumberTextBox.Location = new System.Drawing.Point(6, 21);
            this.clusterNumberTextBox.Multiline = true;
            this.clusterNumberTextBox.Name = "clusterNumberTextBox";
            this.clusterNumberTextBox.Size = new System.Drawing.Size(84, 22);
            this.clusterNumberTextBox.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clusterNumberTextBox);
            this.groupBox1.Controls.Add(this.clusterButton);
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(65, 224);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(108, 89);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Küme Sayısı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 454);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cizimAlaniLabel);
            this.Controls.Add(this.deleteRadioButton);
            this.Controls.Add(this.translateRadioButton);
            this.Controls.Add(this.addRadioButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton addRadioButton;
        private System.Windows.Forms.RadioButton translateRadioButton;
        private System.Windows.Forms.RadioButton deleteRadioButton;
        private System.Windows.Forms.Label cizimAlaniLabel;
        private System.Windows.Forms.Button clusterButton;
        private System.Windows.Forms.TextBox clusterNumberTextBox;
        private System.Windows.Forms.GroupBox groupBox1;

    }
}

