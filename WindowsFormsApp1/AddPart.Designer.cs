﻿
namespace WGU968
{
    partial class AddPart
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
            this.label1 = new System.Windows.Forms.Label();
            this.InHouseButton = new System.Windows.Forms.RadioButton();
            this.OutsourcedButton = new System.Windows.Forms.RadioButton();
            this.IDtext = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Nametext = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.InvText = new System.Windows.Forms.TextBox();
            this.Pricetext = new System.Windows.Forms.TextBox();
            this.Maxtext = new System.Windows.Forms.TextBox();
            this.Mintext = new System.Windows.Forms.TextBox();
            this.label8text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SavePartBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Part";
            // 
            // InHouseButton
            // 
            this.InHouseButton.AutoSize = true;
            this.InHouseButton.Location = new System.Drawing.Point(191, 9);
            this.InHouseButton.Name = "InHouseButton";
            this.InHouseButton.Size = new System.Drawing.Size(86, 21);
            this.InHouseButton.TabIndex = 1;
            this.InHouseButton.TabStop = true;
            this.InHouseButton.Text = "In-House";
            this.InHouseButton.UseVisualStyleBackColor = true;
            this.InHouseButton.CheckedChanged += new System.EventHandler(this.InHouseButton_CheckedChanged);
            // 
            // OutsourcedButton
            // 
            this.OutsourcedButton.AutoSize = true;
            this.OutsourcedButton.Location = new System.Drawing.Point(322, 9);
            this.OutsourcedButton.Name = "OutsourcedButton";
            this.OutsourcedButton.Size = new System.Drawing.Size(103, 21);
            this.OutsourcedButton.TabIndex = 2;
            this.OutsourcedButton.TabStop = true;
            this.OutsourcedButton.Text = "Outsourced";
            this.OutsourcedButton.UseVisualStyleBackColor = true;
            this.OutsourcedButton.CheckedChanged += new System.EventHandler(this.OutsourcedButton_CheckedChanged);
            // 
            // IDtext
            // 
            this.IDtext.Location = new System.Drawing.Point(129, 62);
            this.IDtext.Name = "IDtext";
            this.IDtext.Size = new System.Drawing.Size(100, 22);
            this.IDtext.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Nametext
            // 
            this.Nametext.Location = new System.Drawing.Point(129, 110);
            this.Nametext.Name = "Nametext";
            this.Nametext.Size = new System.Drawing.Size(100, 22);
            this.Nametext.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name";
            // 
            // InvText
            // 
            this.InvText.Location = new System.Drawing.Point(129, 158);
            this.InvText.Name = "InvText";
            this.InvText.Size = new System.Drawing.Size(100, 22);
            this.InvText.TabIndex = 7;
            // 
            // Pricetext
            // 
            this.Pricetext.Location = new System.Drawing.Point(129, 212);
            this.Pricetext.Name = "Pricetext";
            this.Pricetext.Size = new System.Drawing.Size(100, 22);
            this.Pricetext.TabIndex = 8;
            // 
            // Maxtext
            // 
            this.Maxtext.Location = new System.Drawing.Point(129, 266);
            this.Maxtext.Name = "Maxtext";
            this.Maxtext.Size = new System.Drawing.Size(100, 22);
            this.Maxtext.TabIndex = 9;
            // 
            // Mintext
            // 
            this.Mintext.Location = new System.Drawing.Point(318, 268);
            this.Mintext.Name = "Mintext";
            this.Mintext.Size = new System.Drawing.Size(100, 22);
            this.Mintext.TabIndex = 10;
            // 
            // label8text
            // 
            this.label8text.Location = new System.Drawing.Point(191, 315);
            this.label8text.Name = "label8text";
            this.label8text.Size = new System.Drawing.Size(100, 22);
            this.label8text.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Inventory";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Price / Cost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Max";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(274, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Min";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(56, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "label8";
            // 
            // SavePartBtn
            // 
            this.SavePartBtn.Location = new System.Drawing.Point(229, 395);
            this.SavePartBtn.Name = "SavePartBtn";
            this.SavePartBtn.Size = new System.Drawing.Size(75, 23);
            this.SavePartBtn.TabIndex = 17;
            this.SavePartBtn.Text = "Save";
            this.SavePartBtn.UseVisualStyleBackColor = true;
            this.SavePartBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(350, 395);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SavePartBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8text);
            this.Controls.Add(this.Mintext);
            this.Controls.Add(this.Maxtext);
            this.Controls.Add(this.Pricetext);
            this.Controls.Add(this.InvText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nametext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IDtext);
            this.Controls.Add(this.OutsourcedButton);
            this.Controls.Add(this.InHouseButton);
            this.Controls.Add(this.label1);
            this.Name = "AddPart";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.AddPart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton InHouseButton;
        private System.Windows.Forms.RadioButton OutsourcedButton;
        private System.Windows.Forms.TextBox IDtext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Nametext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox InvText;
        private System.Windows.Forms.TextBox Pricetext;
        private System.Windows.Forms.TextBox Maxtext;
        private System.Windows.Forms.TextBox Mintext;
        private System.Windows.Forms.TextBox label8text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button SavePartBtn;
        private System.Windows.Forms.Button button2;
    }
}