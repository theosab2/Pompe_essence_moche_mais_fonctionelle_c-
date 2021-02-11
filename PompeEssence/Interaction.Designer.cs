namespace PompeEssence
{
    partial class Interaction
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
            System.Windows.Forms.Button LabInserer;
            this.LabPompe = new System.Windows.Forms.Button();
            this.LabRanger = new System.Windows.Forms.Button();
            LabInserer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabInserer
            // 
            LabInserer.Location = new System.Drawing.Point(151, 48);
            LabInserer.Name = "LabInserer";
            LabInserer.Size = new System.Drawing.Size(553, 67);
            LabInserer.TabIndex = 0;
            LabInserer.Text = "Inserer carte";
            LabInserer.UseVisualStyleBackColor = true;
            LabInserer.Click += new System.EventHandler(this.inserer_Click);
            // 
            // LabPompe
            // 
            this.LabPompe.Location = new System.Drawing.Point(151, 164);
            this.LabPompe.Name = "LabPompe";
            this.LabPompe.Size = new System.Drawing.Size(553, 67);
            this.LabPompe.TabIndex = 1;
            this.LabPompe.Text = "Sortir la pompe";
            this.LabPompe.UseVisualStyleBackColor = true;
            this.LabPompe.Click += new System.EventHandler(this.LabPompe_Click);
            // 
            // LabRanger
            // 
            this.LabRanger.Location = new System.Drawing.Point(151, 279);
            this.LabRanger.Name = "LabRanger";
            this.LabRanger.Size = new System.Drawing.Size(553, 67);
            this.LabRanger.TabIndex = 2;
            this.LabRanger.Text = "Ranger la pompe";
            this.LabRanger.UseVisualStyleBackColor = true;
            this.LabRanger.Click += new System.EventHandler(this.LabRanger_Click);
            // 
            // Interaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabRanger);
            this.Controls.Add(this.LabPompe);
            this.Controls.Add(LabInserer);
            this.Name = "Interaction";
            this.Text = "Interaction";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button LabPompe;
        private System.Windows.Forms.Button LabRanger;
    }
}