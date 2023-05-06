
namespace WGU968
{
    partial class AddProduct
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.IDText = new System.Windows.Forms.TextBox();
            this.NameText = new System.Windows.Forms.TextBox();
            this.InvText = new System.Windows.Forms.TextBox();
            this.PriceText = new System.Windows.Forms.TextBox();
            this.MaxText = new System.Windows.Forms.TextBox();
            this.minText = new System.Windows.Forms.TextBox();
            this.PartSearchButton = new System.Windows.Forms.Button();
            this.PartSearchBox = new System.Windows.Forms.TextBox();
            this.AddPartButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CandidateP = new System.Windows.Forms.DataGridView();
            this.AssociatedP = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.CandidateP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssociatedP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Product";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Inventory";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Max";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(209, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Min";
            // 
            // IDText
            // 
            this.IDText.Location = new System.Drawing.Point(85, 131);
            this.IDText.Name = "IDText";
            this.IDText.Size = new System.Drawing.Size(100, 22);
            this.IDText.TabIndex = 7;
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(85, 179);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(100, 22);
            this.NameText.TabIndex = 8;
            // 
            // InvText
            // 
            this.InvText.Location = new System.Drawing.Point(85, 224);
            this.InvText.Name = "InvText";
            this.InvText.Size = new System.Drawing.Size(100, 22);
            this.InvText.TabIndex = 9;
            this.InvText.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // PriceText
            // 
            this.PriceText.Location = new System.Drawing.Point(85, 265);
            this.PriceText.Name = "PriceText";
            this.PriceText.Size = new System.Drawing.Size(100, 22);
            this.PriceText.TabIndex = 10;
            // 
            // MaxText
            // 
            this.MaxText.Location = new System.Drawing.Point(85, 304);
            this.MaxText.Name = "MaxText";
            this.MaxText.Size = new System.Drawing.Size(100, 22);
            this.MaxText.TabIndex = 11;
            // 
            // minText
            // 
            this.minText.Location = new System.Drawing.Point(245, 304);
            this.minText.Name = "minText";
            this.minText.Size = new System.Drawing.Size(100, 22);
            this.minText.TabIndex = 12;
            // 
            // PartSearchButton
            // 
            this.PartSearchButton.Location = new System.Drawing.Point(555, 13);
            this.PartSearchButton.Name = "PartSearchButton";
            this.PartSearchButton.Size = new System.Drawing.Size(75, 23);
            this.PartSearchButton.TabIndex = 13;
            this.PartSearchButton.Text = "Search";
            this.PartSearchButton.UseVisualStyleBackColor = true;
            this.PartSearchButton.Click += new System.EventHandler(this.PartSearchButton_Click);
            // 
            // PartSearchBox
            // 
            this.PartSearchBox.Location = new System.Drawing.Point(630, 14);
            this.PartSearchBox.Name = "PartSearchBox";
            this.PartSearchBox.Size = new System.Drawing.Size(100, 22);
            this.PartSearchBox.TabIndex = 14;
            // 
            // AddPartButton
            // 
            this.AddPartButton.Location = new System.Drawing.Point(1055, 244);
            this.AddPartButton.Name = "AddPartButton";
            this.AddPartButton.Size = new System.Drawing.Size(75, 23);
            this.AddPartButton.TabIndex = 17;
            this.AddPartButton.Text = "Add";
            this.AddPartButton.UseVisualStyleBackColor = true;
            this.AddPartButton.Click += new System.EventHandler(this.AddPartButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(1055, 462);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 18;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(1055, 491);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 19;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(974, 491);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 20;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(387, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "All Candidate Parts";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(387, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(221, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "Parts Associated with this Product";
            // 
            // CandidateP
            // 
            this.CandidateP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CandidateP.Location = new System.Drawing.Point(390, 42);
            this.CandidateP.Name = "CandidateP";
            this.CandidateP.RowHeadersWidth = 51;
            this.CandidateP.RowTemplate.Height = 24;
            this.CandidateP.Size = new System.Drawing.Size(740, 196);
            this.CandidateP.TabIndex = 23;
            this.CandidateP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CandidateP_CellContentClick);
            // 
            // AssociatedP
            // 
            this.AssociatedP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AssociatedP.Location = new System.Drawing.Point(390, 288);
            this.AssociatedP.Name = "AssociatedP";
            this.AssociatedP.RowHeadersWidth = 51;
            this.AssociatedP.RowTemplate.Height = 24;
            this.AssociatedP.Size = new System.Drawing.Size(740, 168);
            this.AssociatedP.TabIndex = 24;
            this.AssociatedP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AssociatedP_CellContentClick);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 526);
            this.Controls.Add(this.AssociatedP);
            this.Controls.Add(this.CandidateP);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddPartButton);
            this.Controls.Add(this.PartSearchBox);
            this.Controls.Add(this.PartSearchButton);
            this.Controls.Add(this.minText);
            this.Controls.Add(this.MaxText);
            this.Controls.Add(this.PriceText);
            this.Controls.Add(this.InvText);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.IDText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddProduct";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.CandidateP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssociatedP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox IDText;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.TextBox InvText;
        private System.Windows.Forms.TextBox PriceText;
        private System.Windows.Forms.TextBox MaxText;
        private System.Windows.Forms.TextBox minText;
        private System.Windows.Forms.Button PartSearchButton;
        private System.Windows.Forms.TextBox PartSearchBox;
        private System.Windows.Forms.Button AddPartButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView CandidateP;
        private System.Windows.Forms.DataGridView AssociatedP;
    }
}