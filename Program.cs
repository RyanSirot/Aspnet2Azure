//
// COMP 4560: Assignment 2
// C# starting from a windows application project
//

using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Assignment2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new asgn2());
        }

    class asgn2 : Form
        {

            public asgn2()
            {
                //This is code to be added to the default constructor set up by visual studio

                Text = "COMP 4560:  Assignment 2, Exercise 1 (A00929055RyanDicks4S/2016)";
                BackColor = Color.Black;
                ResizeRedraw = true;
                // enable double-buffering to avoid flicker
                // copied from http://www.publicjoe.f9.co.uk/csharp/card09.html
                SetStyle(ControlStyles.UserPaint, true);
                SetStyle(ControlStyles.AllPaintingInWmPaint, true);
                SetStyle(ControlStyles.DoubleBuffer, true);
            }

            protected override void OnPaint(PaintEventArgs pea)
            {
                Graphics grfx = pea.Graphics;

                grfx.SmoothingMode = SmoothingMode.HighQuality;
                grfx.PixelOffsetMode = PixelOffsetMode.HighQuality;

                // window width
                int cx = ClientSize.Width;
                // window height
                int cy = ClientSize.Height;

                // centerpoint x
                int mx = cx / 2;
                // centerpoint y
                int my = cy / 2;
                
                // length of smallest window edge
                int S;
                if (cx < cy)
                {
                    S = cx;
                } else
                {
                    S = cy;
                }
                
                //here is where all of your drawing code would go.  For example, the following
                // statements produce a blue filled circle of diameter 50 pixels, with the upper 
                // hand corner of the bounding box of the circle being at x = 100, y = 200.
                SolidBrush yellow = new SolidBrush(Color.Yellow);
                SolidBrush blue   = new SolidBrush(Color.Blue);
                SolidBrush green  = new SolidBrush(Color.Green);
                SolidBrush red    = new SolidBrush(Color.Red);

                grfx.FillEllipse(blue,  (mx - ((5 * S) / 12)), (my - ((5 * S) / 12)), S / 3, S / 3);
                grfx.FillEllipse(green, (mx - ((2 * S) / 6 )), (my - ((2 * S) / 6 )), S / 6, S / 6);

                grfx.FillEllipse(blue,  (mx - ((5 * S) / 12)), (my + ((S) / 12)),     S / 3, S / 3);
                grfx.FillEllipse(red, (mx - ((2 * S) / 6 )), (my + ((S) / 6 )),     S / 6, S / 6);

                grfx.FillEllipse(yellow,  (mx + (S / 12)),       (my - ((5 * S) / 12)), S / 3, S / 3);
                grfx.FillEllipse(green, (mx + (S / 6)),        (my - ((2 * S) / 6 )), S / 6, S / 6);

                grfx.FillEllipse(yellow,  (mx + (S / 12)),       (my + (S / 12)),       S / 3, S / 3);
                grfx.FillEllipse(red, (mx + (S / 6)),        (my + (S / 6)),        S / 6, S / 6);
            }
        }

    }
}
