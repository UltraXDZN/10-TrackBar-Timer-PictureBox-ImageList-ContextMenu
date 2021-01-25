
namespace TrackBarKontrola
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
            this.vrijednost = new System.Windows.Forms.TrackBar();
            this.postavljenaVrijednostBox = new System.Windows.Forms.TextBox();
            this.postavljenjaVrijednostlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vrijednost)).BeginInit();
            this.SuspendLayout();
            // 
            // vrijednost
            // 
            this.vrijednost.Location = new System.Drawing.Point(0, 0);
            this.vrijednost.Maximum = 100;
            this.vrijednost.Name = "vrijednost";
            this.vrijednost.Size = new System.Drawing.Size(361, 45);
            this.vrijednost.TabIndex = 0;
            this.vrijednost.Scroll += new System.EventHandler(this.vrijednost_Scroll);
            // 
            // postavljenaVrijednostBox
            // 
            this.postavljenaVrijednostBox.Location = new System.Drawing.Point(161, 51);
            this.postavljenaVrijednostBox.Name = "postavljenaVrijednostBox";
            this.postavljenaVrijednostBox.Size = new System.Drawing.Size(44, 20);
            this.postavljenaVrijednostBox.TabIndex = 1;
            // 
            // postavljenjaVrijednostlabel
            // 
            this.postavljenjaVrijednostlabel.AutoSize = true;
            this.postavljenjaVrijednostlabel.Location = new System.Drawing.Point(28, 54);
            this.postavljenjaVrijednostlabel.Name = "postavljenjaVrijednostlabel";
            this.postavljenjaVrijednostlabel.Size = new System.Drawing.Size(127, 13);
            this.postavljenjaVrijednostlabel.TabIndex = 2;
            this.postavljenjaVrijednostlabel.Text = "Postavljena vrijednost je: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 85);
            this.Controls.Add(this.postavljenjaVrijednostlabel);
            this.Controls.Add(this.postavljenaVrijednostBox);
            this.Controls.Add(this.vrijednost);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.vrijednost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar vrijednost;
        private System.Windows.Forms.TextBox postavljenaVrijednostBox;
        private System.Windows.Forms.Label postavljenjaVrijednostlabel;
    }
}

