using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Proyecto_Paint_Poo1
{
    public partial class Paleta_o_Paint : Form
    {
        private Color[] paletteColors;
        Bitmap Mb;
        Graphics g;
        bool pintar = false;
        Point px, py;
        Pen pluma = new Pen(Color.Black, 1);
        Pen borrador = new Pen(Color.White, 50);
        int indice;
        int x, y, sX, sY, cX, cY;

        public Paleta_o_Paint()
        {
            InitializeComponent(); // Inicializa la interfaz de usuario del formulario.

            Mb = new Bitmap(pbLienzo.Width, pbLienzo.Height);
            g = Graphics.FromImage(Mb);
            pbLienzo.Image = Mb;

            paletteColors = new[] {
                Color.Black, Color.White, Color.Gray, Color.Maroon, Color.Orange,
                Color.Red, Color.Purple, Color.Fuchsia, Color.Green, Color.Lime,
                Color.Olive, Color.Yellow, Color.Navy, Color.Blue, Color.Teal, Color.Aqua
            };

            // Crea una paleta de colores con 16 colores predefinidos .
            for (int i = 0; i < 16; i++)
            {
                var colorBtn = new Button(); // Crea un nuevo botón.
                tablaDeColores.Controls.Add(colorBtn, i % 2, i / 2); // Agrega el botón a un panel.
                colorBtn.Dock = DockStyle.Fill;
                colorBtn.FlatStyle = FlatStyle.Flat;
                colorBtn.BackColor = paletteColors[i]; // Establece el color de fondo del botón.
                colorBtn.MouseDown += ColorBtn_MouseDown; // Asigna el mismo evento a todos los botones.
            }
        }

        private void ColorBtn_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    ColorBtnGetColor(sender); // Llama a la función para obtener el color del botón.
                    break;
                case MouseButtons.Right:
                    ColorBtnColorPicker(sender); // Llama a la función para seleccionar un color personalizado.
                    break;
                default:
                    break;
            }
        }

        private void ColorBtnColorPicker(object sender)
        {
            var btn = (Button)sender;
            var clrDialog = new ColorDialog() { FullOpen = true, AnyColor = true };
            if (clrDialog.ShowDialog() == DialogResult.OK)
                btn.BackColor = clrDialog.Color; // Actualiza el color de fondo del botón con el color seleccionado.
        }

        private void ColorBtnGetColor(object sender)
        {
            var btn = (Button)sender;
            pbLienzo.BackColor = btn.BackColor; // Actualiza el color de fondo de un objeto llamado "pbLienzo" (Es un PictureBox).
            btnColorSeleccionado.BackColor = btn.BackColor;
            pluma.Color = btn.BackColor;
        }


        private void pbLienzo_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            if (pintar)
            {
                if (indice == 3)
                {
                    g.DrawEllipse(pluma, cX, cY, sX, sY);
                }

                if (indice == 4)
                {
                    g.DrawRectangle(pluma, cX, cY, sX, sY);
                }

                if (indice == 5)
                {
                    g.DrawLine(pluma, cX, cY, sX, sY);
                }
            }
        }

        private void pbLienzo_MouseDown(object sender, MouseEventArgs e)
        {
            pintar = true;
            py = e.Location;

            cX = e.X;
            cY = e.Y;
        }

        private void pbLienzo_MouseMove(object sender, MouseEventArgs e)
        {
            if (pintar)
            {
                if (indice == 1)
                {
                    px = e.Location;
                    g.DrawLine(pluma, px, py);
                    py = px;
                }

                if (indice == 2)
                {
                    px = e.Location;
                    g.DrawLine(borrador, px, py);
                    py = px;
                }
            }
            pbLienzo.Refresh();

            x = e.X;
            y = e.Y;
            sX = e.X - cX;
            sY = e.Y - cY;
        }

        private void pbLienzo_MouseUp(object sender, MouseEventArgs e)
        {
            pintar = false;

            sX = x - cX;
            sY = y - cY;

            if (indice == 3)
            {
                g.DrawEllipse(pluma, cX, cY, sX, sY);
            }

            if (indice == 4)
            {
                g.DrawRectangle(pluma, cX, cY, sX, sY);
            }

            if (indice == 5)
            {
                g.DrawLine(pluma, cX, cY, sX, sY);
            }
        }

        private void btnLapiz_Click(object sender, EventArgs e)
        {
            indice = 1;
        }

        private void btnBorrador_Click(object sender, EventArgs e)
        {
            indice = 2;
        }

        private void btnCirculo_Click(object sender, EventArgs e)
        {
            indice = 3;
        }

        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            indice = 4;
        }

        private void btnLinea_Click(object sender, EventArgs e)
        {
            indice = 5;
        }
    }
}