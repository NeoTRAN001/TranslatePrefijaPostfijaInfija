namespace UI_1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrefija = new System.Windows.Forms.Button();
            this.btnPostfija = new System.Windows.Forms.Button();
            this.btnInfija = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMoveTop = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTranslate = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnGithub = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panelSelection = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPrefija);
            this.panel1.Controls.Add(this.btnPostfija);
            this.panel1.Controls.Add(this.btnInfija);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 487);
            this.panel1.TabIndex = 0;
            // 
            // btnPrefija
            // 
            this.btnPrefija.FlatAppearance.BorderSize = 0;
            this.btnPrefija.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrefija.ForeColor = System.Drawing.Color.White;
            this.btnPrefija.Image = ((System.Drawing.Image)(resources.GetObject("btnPrefija.Image")));
            this.btnPrefija.Location = new System.Drawing.Point(-3, 323);
            this.btnPrefija.Name = "btnPrefija";
            this.btnPrefija.Size = new System.Drawing.Size(176, 109);
            this.btnPrefija.TabIndex = 3;
            this.btnPrefija.Text = "Prefija";
            this.btnPrefija.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrefija.UseVisualStyleBackColor = true;
            this.btnPrefija.Click += new System.EventHandler(this.btnPrefija_Click);
            // 
            // btnPostfija
            // 
            this.btnPostfija.FlatAppearance.BorderSize = 0;
            this.btnPostfija.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPostfija.ForeColor = System.Drawing.Color.White;
            this.btnPostfija.Image = ((System.Drawing.Image)(resources.GetObject("btnPostfija.Image")));
            this.btnPostfija.Location = new System.Drawing.Point(0, 208);
            this.btnPostfija.Name = "btnPostfija";
            this.btnPostfija.Size = new System.Drawing.Size(176, 109);
            this.btnPostfija.TabIndex = 2;
            this.btnPostfija.Text = "Postfija";
            this.btnPostfija.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPostfija.UseVisualStyleBackColor = true;
            this.btnPostfija.Click += new System.EventHandler(this.btnPostfija_Click);
            // 
            // btnInfija
            // 
            this.btnInfija.FlatAppearance.BorderSize = 0;
            this.btnInfija.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfija.ForeColor = System.Drawing.Color.White;
            this.btnInfija.Image = ((System.Drawing.Image)(resources.GetObject("btnInfija.Image")));
            this.btnInfija.Location = new System.Drawing.Point(0, 93);
            this.btnInfija.Name = "btnInfija";
            this.btnInfija.Size = new System.Drawing.Size(176, 109);
            this.btnInfija.TabIndex = 1;
            this.btnInfija.Text = "Infija";
            this.btnInfija.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInfija.UseVisualStyleBackColor = true;
            this.btnInfija.Click += new System.EventHandler(this.btnInfija_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(176, 72);
            this.panel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bit Magic";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnMoveTop);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtResult);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(176, 286);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(624, 201);
            this.panel2.TabIndex = 0;
            // 
            // btnMoveTop
            // 
            this.btnMoveTop.FlatAppearance.BorderSize = 0;
            this.btnMoveTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveTop.Image = ((System.Drawing.Image)(resources.GetObject("btnMoveTop.Image")));
            this.btnMoveTop.Location = new System.Drawing.Point(574, 11);
            this.btnMoveTop.Name = "btnMoveTop";
            this.btnMoveTop.Size = new System.Drawing.Size(38, 35);
            this.btnMoveTop.TabIndex = 8;
            this.btnMoveTop.UseVisualStyleBackColor = true;
            this.btnMoveTop.Click += new System.EventHandler(this.btnMoveTop_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 18F);
            this.label3.Location = new System.Drawing.Point(18, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "Result:";
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(45)))));
            this.txtResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResult.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtResult.Location = new System.Drawing.Point(21, 52);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(591, 137);
            this.txtResult.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F);
            this.label1.Location = new System.Drawing.Point(194, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Translator for diamond";
            // 
            // txtTranslate
            // 
            this.txtTranslate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(45)))));
            this.txtTranslate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTranslate.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTranslate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTranslate.Location = new System.Drawing.Point(197, 45);
            this.txtTranslate.Multiline = true;
            this.txtTranslate.Name = "txtTranslate";
            this.txtTranslate.Size = new System.Drawing.Size(591, 228);
            this.txtTranslate.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(713, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 29);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnGithub
            // 
            this.btnGithub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGithub.Location = new System.Drawing.Point(632, 7);
            this.btnGithub.Name = "btnGithub";
            this.btnGithub.Size = new System.Drawing.Size(75, 29);
            this.btnGithub.TabIndex = 4;
            this.btnGithub.Text = "Github";
            this.btnGithub.UseVisualStyleBackColor = true;
            this.btnGithub.Click += new System.EventHandler(this.btnGithub_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Location = new System.Drawing.Point(551, 7);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(75, 29);
            this.btnInfo.TabIndex = 5;
            this.btnInfo.Text = "Info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(470, 7);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 29);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // panelSelection
            // 
            this.panelSelection.BackColor = System.Drawing.Color.Teal;
            this.panelSelection.Location = new System.Drawing.Point(178, 0);
            this.panelSelection.Name = "panelSelection";
            this.panelSelection.Size = new System.Drawing.Size(10, 10);
            this.panelSelection.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.panelSelection);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnGithub);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtTranslate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnInfija;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrefija;
        private System.Windows.Forms.Button btnPostfija;
        private System.Windows.Forms.TextBox txtTranslate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnGithub;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panelSelection;
        private System.Windows.Forms.Button btnMoveTop;
    }
}

