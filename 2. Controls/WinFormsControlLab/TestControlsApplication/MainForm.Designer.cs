namespace TestControlsApplication
{
    partial class MainForm
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
            this.colorControl = new LabControls.ColorControl.ColorControl();
            this.filePathSelect2 = new LabControls.FilePathSelect();
            this.filePathSelect1 = new LabControls.FilePathSelect();
            this.numberBox3 = new LabControls.NumberBox(this.components);
            this.numberBox2 = new LabControls.NumberBox(this.components);
            this.numberBox1 = new LabControls.NumberBox(this.components);
            this.rectangleControl = new LabControls.ColorControl.RectangleControl(this.components);
            this.lblRectangleControl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // colorControl
            // 
            this.colorControl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.colorControl.Location = new System.Drawing.Point(456, 118);
            this.colorControl.Name = "colorControl";
            this.colorControl.Size = new System.Drawing.Size(332, 170);
            this.colorControl.TabIndex = 5;
            this.colorControl.RectangleControlColorChanged += new System.EventHandler<LabControls.ColorControl.ColorChangedEventArgs>(this.OnColorControlRectangleControlColorChanged);
            // 
            // filePathSelect2
            // 
            this.filePathSelect2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.filePathSelect2.FileName = "";
            this.filePathSelect2.Location = new System.Drawing.Point(12, 411);
            this.filePathSelect2.Name = "filePathSelect2";
            this.filePathSelect2.Size = new System.Drawing.Size(360, 27);
            this.filePathSelect2.TabIndex = 4;
            // 
            // filePathSelect1
            // 
            this.filePathSelect1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.filePathSelect1.FileName = "";
            this.filePathSelect1.Location = new System.Drawing.Point(12, 378);
            this.filePathSelect1.Name = "filePathSelect1";
            this.filePathSelect1.Size = new System.Drawing.Size(360, 27);
            this.filePathSelect1.TabIndex = 3;
            // 
            // numberBox3
            // 
            this.numberBox3.ForeColor = System.Drawing.Color.Red;
            this.numberBox3.Location = new System.Drawing.Point(12, 64);
            this.numberBox3.Name = "numberBox3";
            this.numberBox3.Size = new System.Drawing.Size(252, 20);
            this.numberBox3.TabIndex = 2;
            // 
            // numberBox2
            // 
            this.numberBox2.ForeColor = System.Drawing.Color.Red;
            this.numberBox2.Location = new System.Drawing.Point(12, 38);
            this.numberBox2.Name = "numberBox2";
            this.numberBox2.Size = new System.Drawing.Size(252, 20);
            this.numberBox2.TabIndex = 1;
            // 
            // numberBox1
            // 
            this.numberBox1.ForeColor = System.Drawing.Color.Red;
            this.numberBox1.Location = new System.Drawing.Point(12, 12);
            this.numberBox1.Name = "numberBox1";
            this.numberBox1.Size = new System.Drawing.Size(252, 20);
            this.numberBox1.TabIndex = 0;
            // 
            // rectangleControl
            // 
            this.rectangleControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rectangleControl.Location = new System.Drawing.Point(748, 398);
            this.rectangleControl.Name = "rectangleControl";
            this.rectangleControl.Size = new System.Drawing.Size(40, 40);
            this.rectangleControl.TabIndex = 6;
            this.rectangleControl.Text = "rectangleControl";
            // 
            // lblRectangleControl
            // 
            this.lblRectangleControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRectangleControl.AutoSize = true;
            this.lblRectangleControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRectangleControl.Location = new System.Drawing.Point(561, 398);
            this.lblRectangleControl.Name = "lblRectangleControl";
            this.lblRectangleControl.Size = new System.Drawing.Size(181, 32);
            this.lblRectangleControl.TabIndex = 7;
            this.lblRectangleControl.Text = "Дублирование изменений\nцвета с ColorControl";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRectangleControl);
            this.Controls.Add(this.rectangleControl);
            this.Controls.Add(this.colorControl);
            this.Controls.Add(this.filePathSelect2);
            this.Controls.Add(this.filePathSelect1);
            this.Controls.Add(this.numberBox3);
            this.Controls.Add(this.numberBox2);
            this.Controls.Add(this.numberBox1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LabControls.NumberBox numberBox1;
        private LabControls.NumberBox numberBox2;
        private LabControls.NumberBox numberBox3;
        private LabControls.FilePathSelect filePathSelect1;
        private LabControls.FilePathSelect filePathSelect2;
        private LabControls.ColorControl.ColorControl colorControl;
        private LabControls.ColorControl.RectangleControl rectangleControl;
        private System.Windows.Forms.Label lblRectangleControl;
    }
}

