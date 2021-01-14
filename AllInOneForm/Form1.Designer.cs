using System;

namespace AllInOneForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            AllInOneForm.Form1.panelAdd = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.LightGray;
            this.flowLayoutPanel1.Controls.Add(AllInOneForm.Form1.panelAdd);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(56, 450);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            AllInOneForm.Form1.panelAdd.Location = new System.Drawing.Point(3, 3);
            AllInOneForm.Form1.panelAdd.Name = "panelAdd";
            AllInOneForm.Form1.panelAdd.Size = new System.Drawing.Size(50, 50);
            AllInOneForm.Form1.panelAdd.TabIndex = 0;
            AllInOneForm.Form1.panelAdd.Paint += new System.Windows.Forms.PaintEventHandler(AllInOneForm.ButtonAdd.panelAdd_Paint);
            AllInOneForm.Form1.panelAdd.MouseEnter += new EventHandler(AllInOneForm.ButtonAdd.panelAdd_MouseEnter);
            AllInOneForm.Form1.panelAdd.MouseLeave += new EventHandler(AllInOneForm.ButtonAdd.panelAdd_MouseLeave);
            AllInOneForm.Form1.panelAdd.Click += new EventHandler(AllInOneForm.ButtonAdd.panelAdd_Click);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(56, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 450);
            this.panel1.TabIndex = 1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        public static System.Windows.Forms.Panel panelAdd;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;

        #endregion
    }
}