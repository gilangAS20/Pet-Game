using System;

namespace main_hewan
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
            this.components = new System.ComponentModel.Container();
            this.radioButtonMakan = new System.Windows.Forms.RadioButton();
            this.radioButtonTidur = new System.Windows.Forms.RadioButton();
            this.progressBarKenyang = new System.Windows.Forms.ProgressBar();
            this.progressBarSenang = new System.Windows.Forms.ProgressBar();
            this.progressBarBugar = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonMulai = new System.Windows.Forms.Button();
            this.buttonBerhenti = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonPijat = new System.Windows.Forms.RadioButton();
            this.timerKucing = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxKucing = new System.Windows.Forms.PictureBox();
            this.timerKenyang = new System.Windows.Forms.Timer(this.components);
            this.timerSenang = new System.Windows.Forms.Timer(this.components);
            this.radioButtonMain = new System.Windows.Forms.RadioButton();
            this.timerBugar = new System.Windows.Forms.Timer(this.components);
            this.buttonSini = new System.Windows.Forms.Button();
            this.timerRandom = new System.Windows.Forms.Timer(this.components);
            this.labelKenyang = new System.Windows.Forms.Label();
            this.textBoxSenang = new System.Windows.Forms.TextBox();
            this.labelUwu = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKucing)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButtonMakan
            // 
            this.radioButtonMakan.AutoSize = true;
            this.radioButtonMakan.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonMakan.Font = new System.Drawing.Font("News701 BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMakan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioButtonMakan.Location = new System.Drawing.Point(7, 129);
            this.radioButtonMakan.Name = "radioButtonMakan";
            this.radioButtonMakan.Size = new System.Drawing.Size(67, 19);
            this.radioButtonMakan.TabIndex = 1;
            this.radioButtonMakan.TabStop = true;
            this.radioButtonMakan.Text = "makan";
            this.radioButtonMakan.UseVisualStyleBackColor = false;
            this.radioButtonMakan.CheckedChanged += new System.EventHandler(this.radioButtonMakan_CheckedChanged);
            // 
            // radioButtonTidur
            // 
            this.radioButtonTidur.AutoSize = true;
            this.radioButtonTidur.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonTidur.Font = new System.Drawing.Font("News701 BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTidur.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioButtonTidur.Location = new System.Drawing.Point(95, 129);
            this.radioButtonTidur.Name = "radioButtonTidur";
            this.radioButtonTidur.Size = new System.Drawing.Size(56, 19);
            this.radioButtonTidur.TabIndex = 3;
            this.radioButtonTidur.TabStop = true;
            this.radioButtonTidur.Text = "tidur";
            this.radioButtonTidur.UseVisualStyleBackColor = false;
            // 
            // progressBarKenyang
            // 
            this.progressBarKenyang.BackColor = System.Drawing.Color.LightGreen;
            this.progressBarKenyang.ForeColor = System.Drawing.Color.DarkRed;
            this.progressBarKenyang.Location = new System.Drawing.Point(95, 12);
            this.progressBarKenyang.Name = "progressBarKenyang";
            this.progressBarKenyang.Size = new System.Drawing.Size(100, 23);
            this.progressBarKenyang.TabIndex = 4;
            this.progressBarKenyang.Click += new System.EventHandler(this.progressBarKenyang_Click);
            // 
            // progressBarSenang
            // 
            this.progressBarSenang.Location = new System.Drawing.Point(95, 50);
            this.progressBarSenang.Name = "progressBarSenang";
            this.progressBarSenang.Size = new System.Drawing.Size(100, 23);
            this.progressBarSenang.TabIndex = 5;
            this.progressBarSenang.Click += new System.EventHandler(this.progressBarSenang_Click);
            // 
            // progressBarBugar
            // 
            this.progressBarBugar.Location = new System.Drawing.Point(95, 93);
            this.progressBarBugar.Name = "progressBarBugar";
            this.progressBarBugar.Size = new System.Drawing.Size(100, 23);
            this.progressBarBugar.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(7, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "beri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(95, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "hussss";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonMulai
            // 
            this.buttonMulai.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMulai.Location = new System.Drawing.Point(429, 28);
            this.buttonMulai.Name = "buttonMulai";
            this.buttonMulai.Size = new System.Drawing.Size(123, 23);
            this.buttonMulai.TabIndex = 9;
            this.buttonMulai.Text = "MULAI";
            this.buttonMulai.UseVisualStyleBackColor = true;
            this.buttonMulai.Click += new System.EventHandler(this.buttonMulai_Click);
            // 
            // buttonBerhenti
            // 
            this.buttonBerhenti.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBerhenti.Location = new System.Drawing.Point(558, 28);
            this.buttonBerhenti.Name = "buttonBerhenti";
            this.buttonBerhenti.Size = new System.Drawing.Size(81, 23);
            this.buttonBerhenti.TabIndex = 10;
            this.buttonBerhenti.Text = "BERHENTI";
            this.buttonBerhenti.UseVisualStyleBackColor = true;
            this.buttonBerhenti.Click += new System.EventHandler(this.buttonBerhenti_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("News701 BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(4, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "lv kenyang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("News701 BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(4, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "lv senang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("News701 BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(4, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "lv bugar";
            // 
            // radioButtonPijat
            // 
            this.radioButtonPijat.AutoSize = true;
            this.radioButtonPijat.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonPijat.Font = new System.Drawing.Font("News701 BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPijat.ForeColor = System.Drawing.Color.Transparent;
            this.radioButtonPijat.Location = new System.Drawing.Point(95, 152);
            this.radioButtonPijat.Name = "radioButtonPijat";
            this.radioButtonPijat.Size = new System.Drawing.Size(53, 19);
            this.radioButtonPijat.TabIndex = 14;
            this.radioButtonPijat.TabStop = true;
            this.radioButtonPijat.Text = "pijat";
            this.radioButtonPijat.UseVisualStyleBackColor = false;
            // 
            // timerKucing
            // 
            this.timerKucing.Tick += new System.EventHandler(this.timerKucing_Tick);
            // 
            // pictureBoxKucing
            // 
            this.pictureBoxKucing.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxKucing.Image = global::main_hewan.Properties.Resources.happy_cat;
            this.pictureBoxKucing.Location = new System.Drawing.Point(567, 262);
            this.pictureBoxKucing.Name = "pictureBoxKucing";
            this.pictureBoxKucing.Size = new System.Drawing.Size(164, 133);
            this.pictureBoxKucing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxKucing.TabIndex = 0;
            this.pictureBoxKucing.TabStop = false;
            // 
            // timerKenyang
            // 
            this.timerKenyang.Interval = 5000;
            this.timerKenyang.Tick += new System.EventHandler(this.timerKenyang_Tick);
            // 
            // timerSenang
            // 
            this.timerSenang.Interval = 3000;
            this.timerSenang.Tick += new System.EventHandler(this.timerSenang_Tick);
            // 
            // radioButtonMain
            // 
            this.radioButtonMain.AutoSize = true;
            this.radioButtonMain.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonMain.Font = new System.Drawing.Font("News701 BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMain.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioButtonMain.Location = new System.Drawing.Point(7, 152);
            this.radioButtonMain.Name = "radioButtonMain";
            this.radioButtonMain.Size = new System.Drawing.Size(56, 19);
            this.radioButtonMain.TabIndex = 15;
            this.radioButtonMain.TabStop = true;
            this.radioButtonMain.Text = "main";
            this.radioButtonMain.UseVisualStyleBackColor = false;
            // 
            // timerBugar
            // 
            this.timerBugar.Interval = 5000;
            this.timerBugar.Tick += new System.EventHandler(this.timerBugar_Tick);
            // 
            // buttonSini
            // 
            this.buttonSini.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSini.Location = new System.Drawing.Point(176, 175);
            this.buttonSini.Name = "buttonSini";
            this.buttonSini.Size = new System.Drawing.Size(75, 23);
            this.buttonSini.TabIndex = 16;
            this.buttonSini.Text = "siniii";
            this.buttonSini.UseVisualStyleBackColor = true;
            this.buttonSini.Click += new System.EventHandler(this.buttonSini_Click);
            // 
            // timerRandom
            // 
            this.timerRandom.Interval = 3000;
            this.timerRandom.Tick += new System.EventHandler(this.timerRandom_Tick);
            // 
            // labelKenyang
            // 
            this.labelKenyang.AutoSize = true;
            this.labelKenyang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKenyang.Location = new System.Drawing.Point(221, 21);
            this.labelKenyang.Name = "labelKenyang";
            this.labelKenyang.Size = new System.Drawing.Size(52, 16);
            this.labelKenyang.TabIndex = 17;
            this.labelKenyang.Text = "uyguyg";
            this.labelKenyang.Click += new System.EventHandler(this.labelKenyang_Click);
            // 
            // textBoxSenang
            // 
            this.textBoxSenang.Location = new System.Drawing.Point(212, 52);
            this.textBoxSenang.Multiline = true;
            this.textBoxSenang.Name = "textBoxSenang";
            this.textBoxSenang.Size = new System.Drawing.Size(100, 20);
            this.textBoxSenang.TabIndex = 18;
            this.textBoxSenang.TextChanged += new System.EventHandler(this.textBoxSenang_TextChanged);
            // 
            // labelUwu
            // 
            this.labelUwu.Location = new System.Drawing.Point(212, 95);
            this.labelUwu.Multiline = true;
            this.labelUwu.Name = "labelUwu";
            this.labelUwu.Size = new System.Drawing.Size(100, 20);
            this.labelUwu.TabIndex = 19;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(448, 103);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::main_hewan.Properties.Resources.ruang_tamu;
            this.ClientSize = new System.Drawing.Size(733, 395);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.labelUwu);
            this.Controls.Add(this.textBoxSenang);
            this.Controls.Add(this.labelKenyang);
            this.Controls.Add(this.buttonSini);
            this.Controls.Add(this.radioButtonMain);
            this.Controls.Add(this.radioButtonPijat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBerhenti);
            this.Controls.Add(this.buttonMulai);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBarBugar);
            this.Controls.Add(this.progressBarSenang);
            this.Controls.Add(this.progressBarKenyang);
            this.Controls.Add(this.radioButtonTidur);
            this.Controls.Add(this.radioButtonMakan);
            this.Controls.Add(this.pictureBoxKucing);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKucing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void radioButtonMain_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxKucing;
        private System.Windows.Forms.RadioButton radioButtonMakan;
        private System.Windows.Forms.RadioButton radioButtonTidur;
        private System.Windows.Forms.ProgressBar progressBarKenyang;
        private System.Windows.Forms.ProgressBar progressBarSenang;
        private System.Windows.Forms.ProgressBar progressBarBugar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonMulai;
        private System.Windows.Forms.Button buttonBerhenti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButtonPijat;
        private System.Windows.Forms.Timer timerKucing;
        private System.Windows.Forms.Timer timerSenang;
        private System.Windows.Forms.Timer timerKenyang;
        private System.Windows.Forms.RadioButton radioButtonMain;
        private System.Windows.Forms.Timer timerBugar;
        private System.Windows.Forms.Button buttonSini;
        private System.Windows.Forms.Timer timerRandom;
        private System.Windows.Forms.Label labelKenyang;
        private System.Windows.Forms.TextBox textBoxSenang;
        private System.Windows.Forms.TextBox labelUwu;
        private System.Windows.Forms.ListBox listBox1;
    }
}

