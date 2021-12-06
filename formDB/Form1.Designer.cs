
namespace formDB
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTMaj = new System.Windows.Forms.Button();
            this.BTMmod = new System.Windows.Forms.Button();
            this.BTMsup = new System.Windows.Forms.Button();
            this.BTMann = new System.Windows.Forms.Button();
            this.BTMcnf = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTMaj
            // 
            this.BTMaj.Location = new System.Drawing.Point(608, 34);
            this.BTMaj.Name = "BTMaj";
            this.BTMaj.Size = new System.Drawing.Size(75, 23);
            this.BTMaj.TabIndex = 0;
            this.BTMaj.Text = "BTMaj";
            this.BTMaj.UseVisualStyleBackColor = true;
            // 
            // BTMmod
            // 
            this.BTMmod.Location = new System.Drawing.Point(608, 103);
            this.BTMmod.Name = "BTMmod";
            this.BTMmod.Size = new System.Drawing.Size(75, 23);
            this.BTMmod.TabIndex = 1;
            this.BTMmod.Text = "BTMmod";
            this.BTMmod.UseVisualStyleBackColor = true;
            // 
            // BTMsup
            // 
            this.BTMsup.Location = new System.Drawing.Point(608, 174);
            this.BTMsup.Name = "BTMsup";
            this.BTMsup.Size = new System.Drawing.Size(75, 23);
            this.BTMsup.TabIndex = 2;
            this.BTMsup.Text = "BTMsup";
            this.BTMsup.UseVisualStyleBackColor = true;
            // 
            // BTMann
            // 
            this.BTMann.Location = new System.Drawing.Point(608, 263);
            this.BTMann.Name = "BTMann";
            this.BTMann.Size = new System.Drawing.Size(75, 23);
            this.BTMann.TabIndex = 3;
            this.BTMann.Text = "BTMann";
            this.BTMann.UseVisualStyleBackColor = true;
            // 
            // BTMcnf
            // 
            this.BTMcnf.Location = new System.Drawing.Point(608, 335);
            this.BTMcnf.Name = "BTMcnf";
            this.BTMcnf.Size = new System.Drawing.Size(75, 23);
            this.BTMcnf.TabIndex = 4;
            this.BTMcnf.Text = "BTMcnf";
            this.BTMcnf.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 276);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(314, 276);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(207, 373);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(62, 373);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(48, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(378, 176);
            this.dataGridView1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BTMcnf);
            this.Controls.Add(this.BTMann);
            this.Controls.Add(this.BTMsup);
            this.Controls.Add(this.BTMmod);
            this.Controls.Add(this.BTMaj);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTMaj;
        private System.Windows.Forms.Button BTMmod;
        private System.Windows.Forms.Button BTMsup;
        private System.Windows.Forms.Button BTMann;
        private System.Windows.Forms.Button BTMcnf;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

