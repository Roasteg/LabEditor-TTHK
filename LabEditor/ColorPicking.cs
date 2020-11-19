using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabEditor
{
    public partial class ColorPicking : Form
    {
        Color result;
        Color color;
        public ColorPicking()
        {
            InitializeComponent();

            redScroll.Tag = redNumeric;
            greenScroll.Tag = greenNumeric;
            blueScroll.Tag = blueNumeric;

            redNumeric.Tag = redScroll;
            greenNumeric.Tag = greenScroll;
            blueNumeric.Tag = blueScroll;

            redNumeric.Value = color.R;
            greenNumeric.Value = color.G;
            blueNumeric.Value = color.B;

            
           
            
        }



        private void redScroll_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void redScroll_ValueChanged(object sender, EventArgs e)
        {
            ScrollBar scrollBar = (ScrollBar)sender;
            NumericUpDown numericUpDown = (NumericUpDown)scrollBar.Tag;
            numericUpDown.Value = scrollBar.Value;
            MixColors();
        }

        private void redNumeric_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            ScrollBar scrollBar = (ScrollBar)numericUpDown.Tag;
            scrollBar.Value = (int)numericUpDown.Value;
        }

        private void greenScroll_ValueChanged(object sender, EventArgs e)
        {
            ScrollBar scrollBar = (ScrollBar)sender;
            NumericUpDown numericUpDown = (NumericUpDown)scrollBar.Tag;
            numericUpDown.Value = scrollBar.Value;
            MixColors();
        }

        private void greenNumeric_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            ScrollBar scrollBar = (ScrollBar)numericUpDown.Tag;
            scrollBar.Value = (int)numericUpDown.Value;
        }

        private void blueScroll_ValueChanged(object sender, EventArgs e)
        {
            ScrollBar scrollBar = (ScrollBar)sender;
            NumericUpDown numericUpDown = (NumericUpDown)scrollBar.Tag;
            numericUpDown.Value = scrollBar.Value;
            MixColors();
        }

        private void blueNumeric_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            ScrollBar scrollBar = (ScrollBar)numericUpDown.Tag;
            scrollBar.Value = (int)numericUpDown.Value;
        }
        private void MixColors()
        {
            result = Color.FromArgb(redScroll.Value, greenScroll.Value, blueScroll.Value);
            mixedColor.BackColor = result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if(colorDialog.ShowDialog()==DialogResult.OK)
            {
                redScroll.Value = colorDialog.Color.R;
                greenScroll.Value = colorDialog.Color.G;
                blueScroll.Value = colorDialog.Color.B;
                result = colorDialog.Color;

                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                main.currentPen.Color = Color.FromArgb(redScroll.Value, greenScroll.Value, blueScroll.Value);
                main.historyColor = main.currentPen.Color;
            }
            this.Close();
        }

        private void mixedColor_BackColorChanged(object sender, EventArgs e)
        {
        }
    }
}
