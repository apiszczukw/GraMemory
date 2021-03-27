
namespace GraMemory
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
            this.labelOpisCzas = new System.Windows.Forms.Label();
            this.labelWartoscCzas = new System.Windows.Forms.Label();
            this.labelOpisPunkty = new System.Windows.Forms.Label();
            this.labelWartoscPunkty = new System.Windows.Forms.Label();
            this.labelStartInfo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timerCzasGry = new System.Windows.Forms.Timer(this.components);
            this.timerCzasPodgladu = new System.Windows.Forms.Timer(this.components);
            this.timerZakrywacz = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelOpisCzas
            // 
            this.labelOpisCzas.AutoSize = true;
            this.labelOpisCzas.Font = new System.Drawing.Font("Oxygen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOpisCzas.Location = new System.Drawing.Point(13, 13);
            this.labelOpisCzas.Name = "labelOpisCzas";
            this.labelOpisCzas.Size = new System.Drawing.Size(38, 16);
            this.labelOpisCzas.TabIndex = 0;
            this.labelOpisCzas.Text = "Czas:";
            // 
            // labelWartoscCzas
            // 
            this.labelWartoscCzas.AutoSize = true;
            this.labelWartoscCzas.Font = new System.Drawing.Font("Oxygen", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWartoscCzas.Location = new System.Drawing.Point(57, 13);
            this.labelWartoscCzas.Name = "labelWartoscCzas";
            this.labelWartoscCzas.Size = new System.Drawing.Size(24, 16);
            this.labelWartoscCzas.TabIndex = 0;
            this.labelWartoscCzas.Text = "60";
            // 
            // labelOpisPunkty
            // 
            this.labelOpisPunkty.AutoSize = true;
            this.labelOpisPunkty.Font = new System.Drawing.Font("Oxygen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOpisPunkty.Location = new System.Drawing.Point(109, 13);
            this.labelOpisPunkty.Name = "labelOpisPunkty";
            this.labelOpisPunkty.Size = new System.Drawing.Size(51, 16);
            this.labelOpisPunkty.TabIndex = 0;
            this.labelOpisPunkty.Text = "Punkty:";
            // 
            // labelWartoscPunkty
            // 
            this.labelWartoscPunkty.AutoSize = true;
            this.labelWartoscPunkty.Font = new System.Drawing.Font("Oxygen", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWartoscPunkty.Location = new System.Drawing.Point(166, 13);
            this.labelWartoscPunkty.Name = "labelWartoscPunkty";
            this.labelWartoscPunkty.Size = new System.Drawing.Size(16, 16);
            this.labelWartoscPunkty.TabIndex = 0;
            this.labelWartoscPunkty.Text = "0";
            // 
            // labelStartInfo
            // 
            this.labelStartInfo.AutoSize = true;
            this.labelStartInfo.Font = new System.Drawing.Font("Oxygen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartInfo.Location = new System.Drawing.Point(357, 13);
            this.labelStartInfo.Name = "labelStartInfo";
            this.labelStartInfo.Size = new System.Drawing.Size(109, 16);
            this.labelStartInfo.TabIndex = 0;
            this.labelStartInfo.Text = "Początek gry za 5";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(16, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 228);
            this.panel1.TabIndex = 1;
            // 
            // timerCzasGry
            // 
            this.timerCzasGry.Interval = 1000;
            // 
            // timerCzasPodgladu
            // 
            this.timerCzasPodgladu.Interval = 1000;
            // 
            // timerZakrywacz
            // 
            this.timerZakrywacz.Interval = 1000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 457);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelWartoscPunkty);
            this.Controls.Add(this.labelWartoscCzas);
            this.Controls.Add(this.labelStartInfo);
            this.Controls.Add(this.labelOpisPunkty);
            this.Controls.Add(this.labelOpisCzas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Memory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOpisCzas;
        private System.Windows.Forms.Label labelWartoscCzas;
        private System.Windows.Forms.Label labelOpisPunkty;
        private System.Windows.Forms.Label labelWartoscPunkty;
        private System.Windows.Forms.Label labelStartInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timerCzasGry;
        private System.Windows.Forms.Timer timerCzasPodgladu;
        private System.Windows.Forms.Timer timerZakrywacz;
    }
}

