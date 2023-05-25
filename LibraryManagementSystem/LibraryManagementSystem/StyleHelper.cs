using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class StyleHelper
    {

        public Color normalForeColor = Color.FromArgb(255, 255, 255);
        public Color normalBackColor = Color.FromArgb(0, 135, 100);
        public Color changedForeColor = Color.FromArgb(255, 240, 240);
        public Color changedBackColor = Color.FromArgb(0, 185, 135);

        public Font normalFont = new Font("Comic Sans MS", 16, FontStyle.Regular);
        public Font changedFont = new Font("Comic Sans MS", 18, FontStyle.Bold);
    
    }
}