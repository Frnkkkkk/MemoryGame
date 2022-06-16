namespace MemoryMio
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TimerSecondario = new System.Windows.Forms.Timer(this.components);
            this.labelMosse = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.RadioEasy = new System.Windows.Forms.RadioButton();
            this.RadioHard = new System.Windows.Forms.RadioButton();
            this.LabelDifficulty = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TimerSecondario
            // 
            this.TimerSecondario.Tick += new System.EventHandler(this.TimerSecondario_Tick);
            // 
            // labelMosse
            // 
            this.labelMosse.AutoSize = true;
            this.labelMosse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMosse.Location = new System.Drawing.Point(10, 10);
            this.labelMosse.Name = "labelMosse";
            this.labelMosse.Size = new System.Drawing.Size(136, 36);
            this.labelMosse.TabIndex = 0;
            this.labelMosse.Text = "Mosse: 0";
            this.labelMosse.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(63, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Gioca";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RadioEasy
            // 
            this.RadioEasy.AutoSize = true;
            this.RadioEasy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioEasy.Location = new System.Drawing.Point(63, 78);
            this.RadioEasy.Name = "RadioEasy";
            this.RadioEasy.Size = new System.Drawing.Size(89, 29);
            this.RadioEasy.TabIndex = 2;
            this.RadioEasy.TabStop = true;
            this.RadioEasy.Text = "Facile";
            this.RadioEasy.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.RadioEasy.UseVisualStyleBackColor = true;
            this.RadioEasy.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // RadioHard
            // 
            this.RadioHard.AutoSize = true;
            this.RadioHard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioHard.Location = new System.Drawing.Point(63, 113);
            this.RadioHard.Name = "RadioHard";
            this.RadioHard.Size = new System.Drawing.Size(98, 29);
            this.RadioHard.TabIndex = 3;
            this.RadioHard.TabStop = true;
            this.RadioHard.Text = "Difficile";
            this.RadioHard.UseVisualStyleBackColor = true;
            this.RadioHard.CheckedChanged += new System.EventHandler(this.RadioHard_CheckedChanged);
            // 
            // LabelDifficulty
            // 
            this.LabelDifficulty.AutoSize = true;
            this.LabelDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDifficulty.Location = new System.Drawing.Point(61, 45);
            this.LabelDifficulty.Name = "LabelDifficulty";
            this.LabelDifficulty.Size = new System.Drawing.Size(112, 30);
            this.LabelDifficulty.TabIndex = 5;
            this.LabelDifficulty.Text = "Difficoltà";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 239);
            this.Controls.Add(this.LabelDifficulty);
            this.Controls.Add(this.RadioHard);
            this.Controls.Add(this.RadioEasy);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelMosse);
            this.Name = "Form1";
            this.Text = "Memory";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer TimerSecondario;
        private System.Windows.Forms.Label labelMosse;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton RadioEasy;
        private System.Windows.Forms.RadioButton RadioHard;
        private System.Windows.Forms.Label LabelDifficulty;
    }
}

