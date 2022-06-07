namespace TeamsBotonProject
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.imgPepe = new System.Windows.Forms.PictureBox();
            this.btnAction = new System.Windows.Forms.Button();
            this.timerMouse = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imgPepe)).BeginInit();
            this.SuspendLayout();
            // 
            // imgPepe
            // 
            this.imgPepe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgPepe.Image = global::TeamsBotonProject.Properties.Resources.pissed;
            this.imgPepe.Location = new System.Drawing.Point(-122, -140);
            this.imgPepe.Name = "imgPepe";
            this.imgPepe.Size = new System.Drawing.Size(618, 618);
            this.imgPepe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgPepe.TabIndex = 0;
            this.imgPepe.TabStop = false;
            // 
            // btnAction
            // 
            this.btnAction.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAction.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAction.Location = new System.Drawing.Point(502, -4);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(136, 338);
            this.btnAction.TabIndex = 1;
            this.btnAction.Text = "Iniciar";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // timerMouse
            // 
            this.timerMouse.Interval = 500;
            this.timerMouse.Tick += new System.EventHandler(this.timerMouse_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(630, 332);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.imgPepe);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.imgPepe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox imgPepe;
        private Button btnAction;
        private System.Windows.Forms.Timer timerMouse;
    }
}