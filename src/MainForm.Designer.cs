namespace automated_click
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SteadyBar = new System.Windows.Forms.PictureBox();
            this.SweepBar = new System.Windows.Forms.PictureBox();
            this.Start = new System.Windows.Forms.Button();
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SteadyBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SweepBar)).BeginInit();
            this.SuspendLayout();
            // 
            // SteadyBar
            // 
            this.SteadyBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.SteadyBar.BackgroundImage = global::automated_click.Properties.Resources.steady_bar;
            this.SteadyBar.Location = new System.Drawing.Point(174, 0);
            this.SteadyBar.Name = "SteadyBar";
            this.SteadyBar.Size = new System.Drawing.Size(57, 450);
            this.SteadyBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SteadyBar.TabIndex = 1;
            this.SteadyBar.TabStop = false;
            // 
            // SweepBar
            // 
            this.SweepBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SweepBar.BackgroundImage = global::automated_click.Properties.Resources.sweeping_bar;
            this.SweepBar.Location = new System.Drawing.Point(0, 0);
            this.SweepBar.Name = "SweepBar";
            this.SweepBar.Size = new System.Drawing.Size(57, 450);
            this.SweepBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SweepBar.TabIndex = 0;
            this.SweepBar.TabStop = false;
            // 
            // Start
            // 
            this.Start.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Start.Location = new System.Drawing.Point(145, 174);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(112, 119);
            this.Start.TabIndex = 2;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // MainTimer
            // 
            this.MainTimer.Interval = 1;
            this.MainTimer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(405, 450);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.SweepBar);
            this.Controls.Add(this.SteadyBar);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Automated Click";
            ((System.ComponentModel.ISupportInitialize)(this.SteadyBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SweepBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox SweepBar;
        private System.Windows.Forms.PictureBox SteadyBar;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Timer MainTimer;
    }
}

