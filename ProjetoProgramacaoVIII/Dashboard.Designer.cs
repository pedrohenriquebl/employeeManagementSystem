namespace ProjetoProgramacaoVIII
{
    partial class Dashboard
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panel1 = new Panel();
            panel3 = new Panel();
            dashboard_AE = new Label();
            label3 = new Label();
            label7 = new Label();
            panel5 = new Panel();
            dashboard_IE = new Label();
            label2 = new Label();
            label9 = new Label();
            panel4 = new Panel();
            dashboard_TE = new Label();
            label4 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Location = new Point(19, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(825, 156);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(79, 0, 11);
            panel3.Controls.Add(dashboard_AE);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label7);
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(286, 20);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 120);
            panel3.TabIndex = 0;
            // 
            // dashboard_AE
            // 
            dashboard_AE.AutoSize = true;
            dashboard_AE.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dashboard_AE.Location = new Point(212, 51);
            dashboard_AE.Name = "dashboard_AE";
            dashboard_AE.Size = new Size(25, 30);
            dashboard_AE.TabIndex = 4;
            dashboard_AE.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 24F);
            label3.Location = new Point(15, 9);
            label3.Name = "label3";
            label3.Size = new Size(54, 37);
            label3.TabIndex = 2;
            label3.Text = "✔️";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(15, 88);
            label7.Name = "label7";
            label7.Size = new Size(131, 21);
            label7.TabIndex = 3;
            label7.Text = "Active Employees";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(79, 0, 11);
            panel5.Controls.Add(dashboard_IE);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(label9);
            panel5.ForeColor = Color.White;
            panel5.Location = new Point(557, 20);
            panel5.Name = "panel5";
            panel5.Size = new Size(250, 120);
            panel5.TabIndex = 2;
            // 
            // dashboard_IE
            // 
            dashboard_IE.AutoSize = true;
            dashboard_IE.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dashboard_IE.Location = new Point(208, 51);
            dashboard_IE.Name = "dashboard_IE";
            dashboard_IE.Size = new Size(25, 30);
            dashboard_IE.TabIndex = 6;
            dashboard_IE.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 24F);
            label2.Location = new Point(21, 9);
            label2.Name = "label2";
            label2.Size = new Size(54, 37);
            label2.TabIndex = 1;
            label2.Text = "❎";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(21, 88);
            label9.Name = "label9";
            label9.Size = new Size(142, 21);
            label9.TabIndex = 5;
            label9.Text = "Inactive Employees";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(79, 0, 11);
            panel4.Controls.Add(dashboard_TE);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label1);
            panel4.ForeColor = Color.White;
            panel4.Location = new Point(17, 20);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 120);
            panel4.TabIndex = 1;
            // 
            // dashboard_TE
            // 
            dashboard_TE.AutoSize = true;
            dashboard_TE.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dashboard_TE.Location = new Point(189, 51);
            dashboard_TE.Name = "dashboard_TE";
            dashboard_TE.Size = new Size(25, 30);
            dashboard_TE.TabIndex = 2;
            dashboard_TE.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(14, 88);
            label4.Name = "label4";
            label4.Size = new Size(121, 21);
            label4.TabIndex = 1;
            label4.Text = "Total Employees";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 24F);
            label1.Location = new Point(14, 9);
            label1.Name = "label1";
            label1.Size = new Size(82, 37);
            label1.TabIndex = 0;
            label1.Text = "💯%";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(19, 208);
            panel2.Name = "panel2";
            panel2.Size = new Size(825, 345);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(825, 345);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Dashboard";
            Size = new Size(875, 565);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label dashboard_TE;
        private Label dashboard_AE;
        private Label label7;
        private Label dashboard_IE;
        private Label label9;
        private PictureBox pictureBox1;
    }
}
