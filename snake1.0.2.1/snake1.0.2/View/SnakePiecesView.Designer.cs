﻿namespace snake1._0._2.View
{
    partial class SnakePiecesView
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

        #region Code généré par le Concepteur de composants

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.snakePiecePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.snakePiecePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // snakePiecePictureBox
            // 
            this.snakePiecePictureBox.BackColor = System.Drawing.Color.Green;
            this.snakePiecePictureBox.Location = new System.Drawing.Point(0, 0);
            this.snakePiecePictureBox.Name = "snakePiecePictureBox";
            this.snakePiecePictureBox.Size = new System.Drawing.Size(100, 50);
            this.snakePiecePictureBox.TabIndex = 0;
            this.snakePiecePictureBox.TabStop = false;
            ((System.ComponentModel.ISupportInitialize)(this.snakePiecePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox snakePiecePictureBox;
    }
}
