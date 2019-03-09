namespace StudentsListCRUD
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
            this.emri = new System.Windows.Forms.Label();
            this.buttonRuaj = new System.Windows.Forms.Button();
            this.txtEmri = new System.Windows.Forms.TextBox();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.txtMbiemri = new System.Windows.Forms.TextBox();
            this.mbiemri = new System.Windows.Forms.Label();
            this.txtProfili = new System.Windows.Forms.TextBox();
            this.profili = new System.Windows.Forms.Label();
            this.buttonFshi = new System.Windows.Forms.Button();
            this.buttonAnuloje = new System.Windows.Forms.Button();
            this.txtKerko = new System.Windows.Forms.TextBox();
            this.buttonKerko = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // emri
            // 
            this.emri.AutoSize = true;
            this.emri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emri.Location = new System.Drawing.Point(12, 74);
            this.emri.Name = "emri";
            this.emri.Size = new System.Drawing.Size(41, 20);
            this.emri.TabIndex = 0;
            this.emri.Text = "Emri";
            // 
            // buttonRuaj
            // 
            this.buttonRuaj.Location = new System.Drawing.Point(12, 186);
            this.buttonRuaj.Name = "buttonRuaj";
            this.buttonRuaj.Size = new System.Drawing.Size(75, 23);
            this.buttonRuaj.TabIndex = 1;
            this.buttonRuaj.Text = "Ruaj";
            this.buttonRuaj.UseVisualStyleBackColor = true;
            this.buttonRuaj.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtEmri
            // 
            this.txtEmri.Location = new System.Drawing.Point(96, 74);
            this.txtEmri.Name = "txtEmri";
            this.txtEmri.Size = new System.Drawing.Size(100, 20);
            this.txtEmri.TabIndex = 2;
            // 
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToDeleteRows = false;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(303, 53);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.Size = new System.Drawing.Size(339, 185);
            this.dgvStudents.TabIndex = 3;
            this.dgvStudents.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvStudents_MouseDoubleClick);
            // 
            // txtMbiemri
            // 
            this.txtMbiemri.Location = new System.Drawing.Point(96, 111);
            this.txtMbiemri.Name = "txtMbiemri";
            this.txtMbiemri.Size = new System.Drawing.Size(100, 20);
            this.txtMbiemri.TabIndex = 5;
            // 
            // mbiemri
            // 
            this.mbiemri.AutoSize = true;
            this.mbiemri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbiemri.Location = new System.Drawing.Point(12, 111);
            this.mbiemri.Name = "mbiemri";
            this.mbiemri.Size = new System.Drawing.Size(64, 20);
            this.mbiemri.TabIndex = 4;
            this.mbiemri.Text = "Mbiemri";
            // 
            // txtProfili
            // 
            this.txtProfili.Location = new System.Drawing.Point(96, 145);
            this.txtProfili.Name = "txtProfili";
            this.txtProfili.Size = new System.Drawing.Size(100, 20);
            this.txtProfili.TabIndex = 7;
            // 
            // profili
            // 
            this.profili.AutoSize = true;
            this.profili.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profili.Location = new System.Drawing.Point(12, 145);
            this.profili.Name = "profili";
            this.profili.Size = new System.Drawing.Size(47, 20);
            this.profili.TabIndex = 6;
            this.profili.Text = "Profili";
            // 
            // buttonFshi
            // 
            this.buttonFshi.Location = new System.Drawing.Point(105, 186);
            this.buttonFshi.Name = "buttonFshi";
            this.buttonFshi.Size = new System.Drawing.Size(75, 23);
            this.buttonFshi.TabIndex = 8;
            this.buttonFshi.Text = "Fshi";
            this.buttonFshi.UseVisualStyleBackColor = true;
            this.buttonFshi.Click += new System.EventHandler(this.buttonFshi_Click);
            // 
            // buttonAnuloje
            // 
            this.buttonAnuloje.Location = new System.Drawing.Point(197, 186);
            this.buttonAnuloje.Name = "buttonAnuloje";
            this.buttonAnuloje.Size = new System.Drawing.Size(75, 23);
            this.buttonAnuloje.TabIndex = 9;
            this.buttonAnuloje.Text = "Anuloje";
            this.buttonAnuloje.UseVisualStyleBackColor = true;
            this.buttonAnuloje.Click += new System.EventHandler(this.buttonAnuloje_Click);
            // 
            // txtKerko
            // 
            this.txtKerko.Location = new System.Drawing.Point(447, 12);
            this.txtKerko.Name = "txtKerko";
            this.txtKerko.Size = new System.Drawing.Size(100, 20);
            this.txtKerko.TabIndex = 10;
            // 
            // buttonKerko
            // 
            this.buttonKerko.Location = new System.Drawing.Point(567, 12);
            this.buttonKerko.Name = "buttonKerko";
            this.buttonKerko.Size = new System.Drawing.Size(75, 23);
            this.buttonKerko.TabIndex = 11;
            this.buttonKerko.Text = "Kerko";
            this.buttonKerko.UseVisualStyleBackColor = true;
            this.buttonKerko.Click += new System.EventHandler(this.buttonKerko_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 250);
            this.Controls.Add(this.emri);
            this.Controls.Add(this.buttonKerko);
            this.Controls.Add(this.txtKerko);
            this.Controls.Add(this.buttonAnuloje);
            this.Controls.Add(this.buttonFshi);
            this.Controls.Add(this.txtProfili);
            this.Controls.Add(this.profili);
            this.Controls.Add(this.txtMbiemri);
            this.Controls.Add(this.mbiemri);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.txtEmri);
            this.Controls.Add(this.buttonRuaj);
            this.Name = "Form1";
            this.Text = "Lista e Studenteve";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label emri;
        private System.Windows.Forms.Button buttonRuaj;
        private System.Windows.Forms.TextBox txtEmri;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.TextBox txtMbiemri;
        private System.Windows.Forms.Label mbiemri;
        private System.Windows.Forms.TextBox txtProfili;
        private System.Windows.Forms.Label profili;
        private System.Windows.Forms.Button buttonFshi;
        private System.Windows.Forms.Button buttonAnuloje;
        private System.Windows.Forms.TextBox txtKerko;
        private System.Windows.Forms.Button buttonKerko;
    }
}

