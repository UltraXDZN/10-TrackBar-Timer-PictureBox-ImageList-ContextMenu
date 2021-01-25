
namespace ContextMenuKontrola
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
            this.lijeviBox = new System.Windows.Forms.TextBox();
            this.desniBox = new System.Windows.Forms.TextBox();
            this.odabir = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lijevoDesnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desnoLijevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odabir.SuspendLayout();
            this.SuspendLayout();
            // 
            // lijeviBox
            // 
            this.lijeviBox.ContextMenuStrip = this.odabir;
            this.lijeviBox.Location = new System.Drawing.Point(12, 12);
            this.lijeviBox.Name = "lijeviBox";
            this.lijeviBox.Size = new System.Drawing.Size(100, 20);
            this.lijeviBox.TabIndex = 0;
            // 
            // desniBox
            // 
            this.desniBox.ContextMenuStrip = this.odabir;
            this.desniBox.Location = new System.Drawing.Point(187, 12);
            this.desniBox.Name = "desniBox";
            this.desniBox.Size = new System.Drawing.Size(100, 20);
            this.desniBox.TabIndex = 1;
            // 
            // odabir
            // 
            this.odabir.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lijevoDesnoToolStripMenuItem,
            this.desnoLijevoToolStripMenuItem});
            this.odabir.Name = "odabir";
            this.odabir.Size = new System.Drawing.Size(142, 48);
            // 
            // lijevoDesnoToolStripMenuItem
            // 
            this.lijevoDesnoToolStripMenuItem.Name = "lijevoDesnoToolStripMenuItem";
            this.lijevoDesnoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lijevoDesnoToolStripMenuItem.Text = "Lijevo Desno";
            this.lijevoDesnoToolStripMenuItem.Click += new System.EventHandler(this.lijevoDesnoToolStripMenuItem_Click);
            // 
            // desnoLijevoToolStripMenuItem
            // 
            this.desnoLijevoToolStripMenuItem.Name = "desnoLijevoToolStripMenuItem";
            this.desnoLijevoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.desnoLijevoToolStripMenuItem.Text = "Desno Lijevo";
            this.desnoLijevoToolStripMenuItem.Click += new System.EventHandler(this.desnoLijevoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 92);
            this.Controls.Add(this.desniBox);
            this.Controls.Add(this.lijeviBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.odabir.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lijeviBox;
        private System.Windows.Forms.TextBox desniBox;
        private System.Windows.Forms.ContextMenuStrip odabir;
        private System.Windows.Forms.ToolStripMenuItem lijevoDesnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desnoLijevoToolStripMenuItem;
    }
}

