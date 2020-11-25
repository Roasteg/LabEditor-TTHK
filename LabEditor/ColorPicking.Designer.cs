namespace LabEditor
{
    partial class ColorPicking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColorPicking));
            this.redScroll = new System.Windows.Forms.HScrollBar();
            this.greenScroll = new System.Windows.Forms.HScrollBar();
            this.blueScroll = new System.Windows.Forms.HScrollBar();
            this.redNumeric = new System.Windows.Forms.NumericUpDown();
            this.greenNumeric = new System.Windows.Forms.NumericUpDown();
            this.blueNumeric = new System.Windows.Forms.NumericUpDown();
            this.mixedColor = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.redNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mixedColor)).BeginInit();
            this.SuspendLayout();
            // 
            // redScroll
            // 
            this.redScroll.LargeChange = 1;
            resources.ApplyResources(this.redScroll, "redScroll");
            this.redScroll.Maximum = 255;
            this.redScroll.Name = "redScroll";
            this.redScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.redScroll_Scroll);
            this.redScroll.ValueChanged += new System.EventHandler(this.redScroll_ValueChanged);
            // 
            // greenScroll
            // 
            this.greenScroll.LargeChange = 1;
            resources.ApplyResources(this.greenScroll, "greenScroll");
            this.greenScroll.Maximum = 255;
            this.greenScroll.Name = "greenScroll";
            this.greenScroll.ValueChanged += new System.EventHandler(this.greenScroll_ValueChanged);
            // 
            // blueScroll
            // 
            this.blueScroll.LargeChange = 1;
            resources.ApplyResources(this.blueScroll, "blueScroll");
            this.blueScroll.Maximum = 255;
            this.blueScroll.Name = "blueScroll";
            this.blueScroll.ValueChanged += new System.EventHandler(this.blueScroll_ValueChanged);
            // 
            // redNumeric
            // 
            resources.ApplyResources(this.redNumeric, "redNumeric");
            this.redNumeric.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.redNumeric.Name = "redNumeric";
            this.redNumeric.ValueChanged += new System.EventHandler(this.redNumeric_ValueChanged);
            // 
            // greenNumeric
            // 
            resources.ApplyResources(this.greenNumeric, "greenNumeric");
            this.greenNumeric.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.greenNumeric.Name = "greenNumeric";
            this.greenNumeric.ValueChanged += new System.EventHandler(this.greenNumeric_ValueChanged);
            // 
            // blueNumeric
            // 
            resources.ApplyResources(this.blueNumeric, "blueNumeric");
            this.blueNumeric.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.blueNumeric.Name = "blueNumeric";
            this.blueNumeric.ValueChanged += new System.EventHandler(this.blueNumeric_ValueChanged);
            // 
            // mixedColor
            // 
            this.mixedColor.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.mixedColor, "mixedColor");
            this.mixedColor.Name = "mixedColor";
            this.mixedColor.TabStop = false;
            this.mixedColor.BackColorChanged += new System.EventHandler(this.mixedColor_BackColorChanged);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ColorPicking
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mixedColor);
            this.Controls.Add(this.blueNumeric);
            this.Controls.Add(this.greenNumeric);
            this.Controls.Add(this.redNumeric);
            this.Controls.Add(this.blueScroll);
            this.Controls.Add(this.greenScroll);
            this.Controls.Add(this.redScroll);
            this.Name = "ColorPicking";
            ((System.ComponentModel.ISupportInitialize)(this.redNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mixedColor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.HScrollBar redScroll;
        private System.Windows.Forms.HScrollBar greenScroll;
        private System.Windows.Forms.HScrollBar blueScroll;
        private System.Windows.Forms.NumericUpDown redNumeric;
        private System.Windows.Forms.NumericUpDown greenNumeric;
        private System.Windows.Forms.NumericUpDown blueNumeric;
        private System.Windows.Forms.PictureBox mixedColor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}