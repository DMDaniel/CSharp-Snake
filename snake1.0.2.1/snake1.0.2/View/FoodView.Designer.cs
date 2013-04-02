namespace snake1._0._2.View
{
    partial class FoodView
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
            this.FoodPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.FoodPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // FoodPictureBox
            // 
            this.FoodPictureBox.BackColor = System.Drawing.Color.Red;
            this.FoodPictureBox.Location = new System.Drawing.Point(0, 0);
            this.FoodPictureBox.Name = "FoodPictureBox";
            this.FoodPictureBox.Size = new System.Drawing.Size(10, 10);
            this.FoodPictureBox.TabIndex = 0;
            this.FoodPictureBox.TabStop = false;
            ((System.ComponentModel.ISupportInitialize)(this.FoodPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox FoodPictureBox;
    }
}
