namespace Projet231120.Vues
{
    partial class FormBox
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
            this.dgvBox = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCreer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnEffacer = new System.Windows.Forms.Button();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBox
            // 
            this.dgvBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBox.Location = new System.Drawing.Point(191, 293);
            this.dgvBox.Name = "dgvBox";
            this.dgvBox.RowHeadersWidth = 51;
            this.dgvBox.RowTemplate.Height = 24;
            this.dgvBox.Size = new System.Drawing.Size(583, 181);
            this.dgvBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(417, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adresse";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(389, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "Box";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(350, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ville";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(549, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Code Postal";
            // 
            // btnCreer
            // 
            this.btnCreer.Location = new System.Drawing.Point(264, 235);
            this.btnCreer.Name = "btnCreer";
            this.btnCreer.Size = new System.Drawing.Size(75, 23);
            this.btnCreer.TabIndex = 6;
            this.btnCreer.Text = "Créer";
            this.btnCreer.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(422, 235);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 7;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnEffacer
            // 
            this.btnEffacer.Location = new System.Drawing.Point(593, 235);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(75, 23);
            this.btnEffacer.TabIndex = 8;
            this.btnEffacer.Text = "Effacer";
            this.btnEffacer.UseVisualStyleBackColor = true;
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(674, 163);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(100, 22);
            this.txtCP.TabIndex = 9;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(239, 86);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 10;
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(506, 90);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(268, 22);
            this.txtAdresse.TabIndex = 11;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(422, 163);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(186, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Id";
            // 
            // FormBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 486);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtCP);
            this.Controls.Add(this.btnEffacer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnCreer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBox);
            this.Name = "FormBox";
            this.Text = "Box";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCreer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnEffacer;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
    }
}