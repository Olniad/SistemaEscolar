
namespace BD_51
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.img_aluno = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.img_disciplinas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.img_aluno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_disciplinas)).BeginInit();
            this.SuspendLayout();
            // 
            // img_aluno
            // 
            this.img_aluno.Image = ((System.Drawing.Image)(resources.GetObject("img_aluno.Image")));
            this.img_aluno.Location = new System.Drawing.Point(24, 79);
            this.img_aluno.Name = "img_aluno";
            this.img_aluno.Size = new System.Drawing.Size(210, 216);
            this.img_aluno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_aluno.TabIndex = 0;
            this.img_aluno.TabStop = false;
            this.img_aluno.Click += new System.EventHandler(this.img_aluno_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // img_disciplinas
            // 
            this.img_disciplinas.Image = ((System.Drawing.Image)(resources.GetObject("img_disciplinas.Image")));
            this.img_disciplinas.Location = new System.Drawing.Point(394, 79);
            this.img_disciplinas.Name = "img_disciplinas";
            this.img_disciplinas.Size = new System.Drawing.Size(210, 216);
            this.img_disciplinas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_disciplinas.TabIndex = 1;
            this.img_disciplinas.TabStop = false;
            this.img_disciplinas.Click += new System.EventHandler(this.img_disciplinas_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 400);
            this.Controls.Add(this.img_disciplinas);
            this.Controls.Add(this.img_aluno);
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            ((System.ComponentModel.ISupportInitialize)(this.img_aluno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_disciplinas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox img_aluno;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox img_disciplinas;
    }
}