﻿namespace MyWorld
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.bStop = new System.Windows.Forms.Button();
            this.bStart = new System.Windows.Forms.Button();
            this.nuDensity = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nuResolution = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bDisease = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuDensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuResolution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.bDisease);
            this.splitContainer1.Panel1.Controls.Add(this.bStop);
            this.splitContainer1.Panel1.Controls.Add(this.bStart);
            this.splitContainer1.Panel1.Controls.Add(this.nuDensity);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.nuResolution);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1227, 674);
            this.splitContainer1.SplitterDistance = 248;
            this.splitContainer1.TabIndex = 0;
            // 
            // bStop
            // 
            this.bStop.Font = new System.Drawing.Font("High Tower Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bStop.Location = new System.Drawing.Point(27, 207);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(146, 53);
            this.bStop.TabIndex = 5;
            this.bStop.Text = "Stop";
            this.bStop.UseVisualStyleBackColor = true;
            this.bStop.Click += new System.EventHandler(this.button2_Click);
            // 
            // bStart
            // 
            this.bStart.Font = new System.Drawing.Font("High Tower Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bStart.Location = new System.Drawing.Point(27, 148);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(146, 53);
            this.bStart.TabIndex = 4;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // nuDensity
            // 
            this.nuDensity.Location = new System.Drawing.Point(27, 100);
            this.nuDensity.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nuDensity.Name = "nuDensity";
            this.nuDensity.Size = new System.Drawing.Size(120, 22);
            this.nuDensity.TabIndex = 3;
            this.nuDensity.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("High Tower Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Density";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // nuResolution
            // 
            this.nuResolution.Location = new System.Drawing.Point(27, 52);
            this.nuResolution.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nuResolution.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuResolution.Name = "nuResolution";
            this.nuResolution.Size = new System.Drawing.Size(120, 22);
            this.nuResolution.TabIndex = 1;
            this.nuResolution.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("High Tower Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resolution";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(971, 670);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bDisease
            // 
            this.bDisease.Font = new System.Drawing.Font("High Tower Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDisease.Location = new System.Drawing.Point(27, 494);
            this.bDisease.Name = "bDisease";
            this.bDisease.Size = new System.Drawing.Size(146, 61);
            this.bDisease.TabIndex = 6;
            this.bDisease.Text = "Disease";
            this.bDisease.UseVisualStyleBackColor = true;
            this.bDisease.Click += new System.EventHandler(this.bDisease_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 674);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nuDensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuResolution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.NumericUpDown nuResolution;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown nuDensity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bStop;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button bDisease;
    }
}
