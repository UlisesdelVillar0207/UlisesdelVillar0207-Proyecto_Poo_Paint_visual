namespace Proyecto_Paint_Poo1
{
    partial class Paleta_o_Paint
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tablaDeColores = new System.Windows.Forms.TableLayoutPanel();
            this.btnColorSeleccionado = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBorrador = new System.Windows.Forms.Button();
            this.btnLapiz = new System.Windows.Forms.Button();
            this.btnRellenar = new System.Windows.Forms.Button();
            this.btnLinea = new System.Windows.Forms.Button();
            this.btnCirculo = new System.Windows.Forms.Button();
            this.btnCuadrado = new System.Windows.Forms.Button();
            this.pbLienzo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLienzo)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tablaDeColores);
            this.splitContainer1.Panel1.Controls.Add(this.btnColorSeleccionado);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.pbLienzo);
            this.splitContainer1.Size = new System.Drawing.Size(916, 721);
            this.splitContainer1.SplitterDistance = 262;
            this.splitContainer1.TabIndex = 0;
            // 
            // tablaDeColores
            // 
            this.tablaDeColores.ColumnCount = 2;
            this.tablaDeColores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablaDeColores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablaDeColores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tablaDeColores.Location = new System.Drawing.Point(3, 3);
            this.tablaDeColores.Name = "tablaDeColores";
            this.tablaDeColores.RowCount = 8;
            this.tablaDeColores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.17518F));
            this.tablaDeColores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.82482F));
            this.tablaDeColores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tablaDeColores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tablaDeColores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tablaDeColores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tablaDeColores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tablaDeColores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tablaDeColores.Size = new System.Drawing.Size(256, 607);
            this.tablaDeColores.TabIndex = 0;
            // 
            // btnColorSeleccionado
            // 
            this.btnColorSeleccionado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnColorSeleccionado.Location = new System.Drawing.Point(97, 632);
            this.btnColorSeleccionado.Name = "btnColorSeleccionado";
            this.btnColorSeleccionado.Size = new System.Drawing.Size(50, 50);
            this.btnColorSeleccionado.TabIndex = 1;
            this.btnColorSeleccionado.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBorrador);
            this.panel1.Controls.Add(this.btnLapiz);
            this.panel1.Controls.Add(this.btnRellenar);
            this.panel1.Controls.Add(this.btnLinea);
            this.panel1.Controls.Add(this.btnCirculo);
            this.panel1.Controls.Add(this.btnCuadrado);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 621);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 100);
            this.panel1.TabIndex = 1;
            // 
            // btnBorrador
            // 
            this.btnBorrador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBorrador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrador.Location = new System.Drawing.Point(313, 11);
            this.btnBorrador.Name = "btnBorrador";
            this.btnBorrador.Size = new System.Drawing.Size(50, 50);
            this.btnBorrador.UseVisualStyleBackColor = true;
            this.btnBorrador.Click += new System.EventHandler(this.btnBorrador_Click);
            // 
            // btnLapiz
            // 
            this.btnLapiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLapiz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLapiz.Location = new System.Drawing.Point(201, 11);
            this.btnLapiz.Name = "btnLapiz";
            this.btnLapiz.Size = new System.Drawing.Size(50, 50);
            this.btnLapiz.TabIndex = 5;
            this.btnLapiz.UseVisualStyleBackColor = true;
            this.btnLapiz.Click += new System.EventHandler(this.btnLapiz_Click);
            // 
            // btnRellenar
            // 
            this.btnRellenar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRellenar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRellenar.Location = new System.Drawing.Point(257, 11);
            this.btnRellenar.Name = "btnRellenar";
            this.btnRellenar.Size = new System.Drawing.Size(50, 50);
            this.btnRellenar.TabIndex = 4;
            this.btnRellenar.UseVisualStyleBackColor = true;
            // 
            // btnLinea
            // 
            this.btnLinea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLinea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLinea.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLinea.Location = new System.Drawing.Point(145, 11);
            this.btnLinea.Name = "btnLinea";
            this.btnLinea.Size = new System.Drawing.Size(50, 50);
            this.btnLinea.TabIndex = 3;
            this.btnLinea.Text = "/";
            this.btnLinea.UseVisualStyleBackColor = true;
            this.btnLinea.Click += new System.EventHandler(this.btnLinea_Click);
            // 
            // btnCirculo
            // 
            this.btnCirculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCirculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCirculo.Location = new System.Drawing.Point(89, 11);
            this.btnCirculo.Name = "btnCirculo";
            this.btnCirculo.Size = new System.Drawing.Size(50, 50);
            this.btnCirculo.TabIndex = 2;
            this.btnCirculo.UseVisualStyleBackColor = true;
            this.btnCirculo.Click += new System.EventHandler(this.btnCirculo_Click);
            // 
            // btnCuadrado
            // 
            this.btnCuadrado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCuadrado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCuadrado.Location = new System.Drawing.Point(33, 11);
            this.btnCuadrado.Name = "btnCuadrado";
            this.btnCuadrado.Size = new System.Drawing.Size(50, 50);
            this.btnCuadrado.TabIndex = 0;
            this.btnCuadrado.UseVisualStyleBackColor = true;
            this.btnCuadrado.Click += new System.EventHandler(this.btnCuadrado_Click);
            // 
            // pbLienzo
            // 
            this.pbLienzo.Location = new System.Drawing.Point(-73, 3);
            this.pbLienzo.Name = "pbLienzo";
            this.pbLienzo.Size = new System.Drawing.Size(592, 607);
            this.pbLienzo.TabIndex = 0;
            this.pbLienzo.TabStop = false;
            this.pbLienzo.Paint += new System.Windows.Forms.PaintEventHandler(this.pbLienzo_Paint);
            this.pbLienzo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbLienzo_MouseDown);
            this.pbLienzo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbLienzo_MouseMove);
            this.pbLienzo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbLienzo_MouseUp);
            // 
            // Paleta_o_Paint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 721);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Paleta_o_Paint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paleta_o_Paint";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLienzo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pbLienzo;
        private System.Windows.Forms.TableLayoutPanel tablaDeColores;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCuadrado;
        private System.Windows.Forms.Button btnLinea;
        private System.Windows.Forms.Button btnCirculo;
        private System.Windows.Forms.Button btnColorSeleccionado;
        private System.Windows.Forms.Button btnBorrador;
        private System.Windows.Forms.Button btnLapiz;
        private System.Windows.Forms.Button btnRellenar;
    }
}