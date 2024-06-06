using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace PokemonGame_FinalProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ChangeScreen(this, new GameScreen());
        }
        public static void ChangeScreen(object sender, System.Windows.Forms.UserControl Next)
        {
            Form f;
            
            if (sender is Form)
            {
                f = (Form)sender;
            }
            else
            {
                System.Windows.Forms.UserControl current = (System.Windows.Forms.UserControl)sender;
                f = current.FindForm();
                f.Controls.Remove(current);
            }
            Next.Location = new Point((f.ClientSize.Width - Next.Width) / 2, (f.ClientSize.Height - Next.Height) / 2);
            f.Controls.Add(Next);
            Cursor.Position = Next.PointToScreen(new Point(Next.Width/2, (Next.Height / 2) + 100));
            Next.Focus();
        }
    }
}
