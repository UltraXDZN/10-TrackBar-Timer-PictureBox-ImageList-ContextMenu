
namespace ImageListKomponenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.images = new System.Windows.Forms.ImageList(this.components);
            this.promijeni = new System.Windows.Forms.Button();
            this.slika = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.slika)).BeginInit();
            this.SuspendLayout();
            // 
            // images
            // 
            this.images.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("images.ImageStream")));
            this.images.TransparentColor = System.Drawing.Color.Transparent;
            this.images.Images.SetKeyName(0, "verysexywouldjudgmentnutagain.jpg");
            this.images.Images.SetKeyName(1, "archersmile.jpg");
            // 
            // promijeni
            // 
            this.promijeni.Location = new System.Drawing.Point(12, 12);
            this.promijeni.Name = "promijeni";
            this.promijeni.Size = new System.Drawing.Size(91, 23);
            this.promijeni.TabIndex = 0;
            this.promijeni.Text = "Promijeni sliku";
            this.promijeni.UseVisualStyleBackColor = true;
            this.promijeni.Click += new System.EventHandler(this.promijeni_Click);
            // 
            // slika
            // 
            this.slika.Location = new System.Drawing.Point(12, 41);
            this.slika.Name = "slika";
            this.slika.Size = new System.Drawing.Size(776, 397);
            this.slika.TabIndex = 1;
            this.slika.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.slika);
            this.Controls.Add(this.promijeni);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.slika)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList images;
        private System.Windows.Forms.Button promijeni;
        private System.Windows.Forms.PictureBox slika;
    }
}

