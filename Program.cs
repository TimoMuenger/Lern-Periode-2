using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat_GPT_Beispiel
{
    internal static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        { }
            
         
public class BewegungsForm : Form
        {
            private int x = 50; // Startposition X
            private int y = 50; // Startposition Y
            private int schrittweite = 10; // Anzahl der Pixel für jeden Schritt

            public BewegungsForm()
            {
                this.Text = "Bewegung in 2D";
                this.Size = new Size(800, 600);
                this.DoubleBuffered = true; // Reduziert Flackern beim Neuzeichnen
                this.KeyDown += new KeyEventHandler(OnKeyDown); // Event-Handler für Tastatur-Eingaben
            }

            // Diese Methode wird aufgerufen, wenn eine Taste gedrückt wird
            private void OnKeyDown(object sender, KeyEventArgs e)
            {
                switch (e.KeyCode)
                {
                    case Keys.Up:
                        y -= schrittweite;
                        break;
                    case Keys.Down:
                        y += schrittweite;
                        break;
                    case Keys.Left:
                        x -= schrittweite;
                        break;
                    case Keys.Right:
                        x += schrittweite;
                        break;
                }
                Invalidate(); // Löst die Neuzeichnung aus
            }

            // Zeichnet das bewegte Objekt (Rechteck)
            protected override void OnPaint(PaintEventArgs e)
            {
                Graphics g = e.Graphics;
                g.Clear(Color.White); // Hintergrundfarbe der Fläche
                g.FillRectangle(Brushes.Blue, x, y, 50, 50); // Zeichnet ein blaues Rechteck an Position (x, y) mit Größe 50x50
            }

            // Startet das Formular
            [STAThread]
            public static void Main()
            {
                Application.EnableVisualStyles();
                Application.Run(new BewegungsForm());
            }
        }

    }
}

