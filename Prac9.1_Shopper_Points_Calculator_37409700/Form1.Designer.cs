
namespace Prac9._1_Shopper_Points_Calculator_37409700
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
            this.lbltotal = new System.Windows.Forms.Label();
            this.lblpoints = new System.Windows.Forms.Label();
            this.lblpoint = new System.Windows.Forms.Label();
            this.grouptier = new System.Windows.Forms.GroupBox();
            this.radio1 = new System.Windows.Forms.RadioButton();
            this.radio2 = new System.Windows.Forms.RadioButton();
            this.radio3 = new System.Windows.Forms.RadioButton();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.grouptier.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(26, 44);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(34, 13);
            this.lbltotal.TabIndex = 0;
            this.lbltotal.Text = "Total:";
            // 
            // lblpoints
            // 
            this.lblpoints.AutoSize = true;
            this.lblpoints.Location = new System.Drawing.Point(131, 263);
            this.lblpoints.Name = "lblpoints";
            this.lblpoints.Size = new System.Drawing.Size(0, 13);
            this.lblpoints.TabIndex = 1;
            // 
            // lblpoint
            // 
            this.lblpoint.AutoSize = true;
            this.lblpoint.Location = new System.Drawing.Point(47, 263);
            this.lblpoint.Name = "lblpoint";
            this.lblpoint.Size = new System.Drawing.Size(75, 13);
            this.lblpoint.TabIndex = 2;
            this.lblpoint.Text = "Earned points:";
            // 
            // grouptier
            // 
            this.grouptier.Controls.Add(this.radio3);
            this.grouptier.Controls.Add(this.radio2);
            this.grouptier.Controls.Add(this.radio1);
            this.grouptier.Location = new System.Drawing.Point(29, 87);
            this.grouptier.Name = "grouptier";
            this.grouptier.Size = new System.Drawing.Size(127, 109);
            this.grouptier.TabIndex = 3;
            this.grouptier.TabStop = false;
            this.grouptier.Text = "Tier";
            // 
            // radio1
            // 
            this.radio1.AutoSize = true;
            this.radio1.Location = new System.Drawing.Point(21, 19);
            this.radio1.Name = "radio1";
            this.radio1.Size = new System.Drawing.Size(31, 17);
            this.radio1.TabIndex = 0;
            this.radio1.TabStop = true;
            this.radio1.Text = "1";
            this.radio1.UseVisualStyleBackColor = true;
            // 
            // radio2
            // 
            this.radio2.AutoSize = true;
            this.radio2.Location = new System.Drawing.Point(21, 53);
            this.radio2.Name = "radio2";
            this.radio2.Size = new System.Drawing.Size(31, 17);
            this.radio2.TabIndex = 1;
            this.radio2.TabStop = true;
            this.radio2.Text = "2";
            this.radio2.UseVisualStyleBackColor = true;
            this.radio2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radio3
            // 
            this.radio3.AutoSize = true;
            this.radio3.Location = new System.Drawing.Point(21, 86);
            this.radio3.Name = "radio3";
            this.radio3.Size = new System.Drawing.Size(31, 17);
            this.radio3.TabIndex = 2;
            this.radio3.TabStop = true;
            this.radio3.Text = "3";
            this.radio3.UseVisualStyleBackColor = true;
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(66, 41);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(100, 20);
            this.txttotal.TabIndex = 4;
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(29, 215);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(75, 23);
            this.btncalculate.TabIndex = 5;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(134, 215);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 6;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 307);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.grouptier);
            this.Controls.Add(this.lblpoint);
            this.Controls.Add(this.lblpoints);
            this.Controls.Add(this.lbltotal);
            this.Name = "Form1";
            this.Text = "Shopper Points Calculator";
            this.grouptier.ResumeLayout(false);
            this.grouptier.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lblpoints;
        private System.Windows.Forms.Label lblpoint;
        private System.Windows.Forms.GroupBox grouptier;
        private System.Windows.Forms.RadioButton radio3;
        private System.Windows.Forms.RadioButton radio2;
        private System.Windows.Forms.RadioButton radio1;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btncancel;
    }
}

