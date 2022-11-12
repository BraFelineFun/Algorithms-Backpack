using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackPack_UI
{
    public class SolutionLabel : Label
    {
        public SolutionLabel(string text, string id): base()
        {
            AutoSize = true;
            BackColor = System.Drawing.SystemColors.ButtonFace;
            Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            MaximumSize = new System.Drawing.Size(736, 1000);
            Name = id;
            Padding = new System.Windows.Forms.Padding(10);
            Margin = new System.Windows.Forms.Padding(10);
            Text = text;
        }
    }
}
