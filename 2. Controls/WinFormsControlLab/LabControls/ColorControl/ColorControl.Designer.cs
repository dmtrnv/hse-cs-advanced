
using System.Drawing;

namespace LabControls.ColorControl
{
    partial class ColorControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.colorNumberBoxRed = new LabControls.ColorControl.ColorNumberBox(this.components);
            this.rectangleControl = new LabControls.ColorControl.RectangleControl(this.components);
            this.colorNumberBoxGreen = new LabControls.ColorControl.ColorNumberBox(this.components);
            this.colorNumberBoxBlue = new LabControls.ColorControl.ColorNumberBox(this.components);
            this.radioBtnDec = new System.Windows.Forms.RadioButton();
            this.radioBtnHex = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRed.Location = new System.Drawing.Point(13, 14);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(64, 16);
            this.lblRed.TabIndex = 0;
            this.lblRed.Text = "Красный";
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGreen.Location = new System.Drawing.Point(13, 40);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(66, 16);
            this.lblGreen.TabIndex = 1;
            this.lblGreen.Text = "Зеленый";
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBlue.Location = new System.Drawing.Point(13, 66);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(49, 16);
            this.lblBlue.TabIndex = 2;
            this.lblBlue.Text = "Синий";
            // 
            // colorNumberBoxRed
            // 
            this.colorNumberBoxRed.CurrentNumberSystem = LabControls.ColorControl.NumberSystem.Decimal;
            this.colorNumberBoxRed.Location = new System.Drawing.Point(82, 10);
            this.colorNumberBoxRed.Name = "colorNumberBoxRed";
            this.colorNumberBoxRed.Size = new System.Drawing.Size(62, 20);
            this.colorNumberBoxRed.TabIndex = 3;
            this.colorNumberBoxRed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // rectangleControl
            // 
            this.rectangleControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rectangleControl.Location = new System.Drawing.Point(164, 10);
            this.rectangleControl.Name = "rectangleControl";
            this.rectangleControl.Size = new System.Drawing.Size(150, 150);
            this.rectangleControl.TabIndex = 6;
            this.rectangleControl.Text = "rectangleControl";
            // 
            // colorNumberBoxGreen
            // 
            this.colorNumberBoxGreen.CurrentNumberSystem = LabControls.ColorControl.NumberSystem.Decimal;
            this.colorNumberBoxGreen.Location = new System.Drawing.Point(82, 36);
            this.colorNumberBoxGreen.Name = "colorNumberBoxGreen";
            this.colorNumberBoxGreen.Size = new System.Drawing.Size(62, 20);
            this.colorNumberBoxGreen.TabIndex = 4;
            this.colorNumberBoxGreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // colorNumberBoxBlue
            // 
            this.colorNumberBoxBlue.CurrentNumberSystem = LabControls.ColorControl.NumberSystem.Decimal;
            this.colorNumberBoxBlue.Location = new System.Drawing.Point(82, 62);
            this.colorNumberBoxBlue.Name = "colorNumberBoxBlue";
            this.colorNumberBoxBlue.Size = new System.Drawing.Size(62, 20);
            this.colorNumberBoxBlue.TabIndex = 5;
            this.colorNumberBoxBlue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // radioBtnDec
            // 
            this.radioBtnDec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioBtnDec.AutoSize = true;
            this.radioBtnDec.Checked = true;
            this.radioBtnDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioBtnDec.Location = new System.Drawing.Point(16, 138);
            this.radioBtnDec.Name = "radioBtnDec";
            this.radioBtnDec.Size = new System.Drawing.Size(51, 20);
            this.radioBtnDec.TabIndex = 7;
            this.radioBtnDec.TabStop = true;
            this.radioBtnDec.Text = "Dec";
            this.radioBtnDec.UseVisualStyleBackColor = true;
            this.radioBtnDec.CheckedChanged += new System.EventHandler(this.OnRadioBtnDecCheckedChanged);
            // 
            // radioBtnHex
            // 
            this.radioBtnHex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioBtnHex.AutoSize = true;
            this.radioBtnHex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioBtnHex.Location = new System.Drawing.Point(82, 138);
            this.radioBtnHex.Name = "radioBtnHex";
            this.radioBtnHex.Size = new System.Drawing.Size(50, 20);
            this.radioBtnHex.TabIndex = 8;
            this.radioBtnHex.TabStop = true;
            this.radioBtnHex.Text = "Hex";
            this.radioBtnHex.UseVisualStyleBackColor = true;
            this.radioBtnHex.CheckedChanged += new System.EventHandler(this.OnRadioBtnHexCheckedChanged);
            // 
            // ColorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radioBtnHex);
            this.Controls.Add(this.radioBtnDec);
            this.Controls.Add(this.rectangleControl);
            this.Controls.Add(this.colorNumberBoxBlue);
            this.Controls.Add(this.colorNumberBoxGreen);
            this.Controls.Add(this.colorNumberBoxRed);
            this.Controls.Add(this.lblBlue);
            this.Controls.Add(this.lblGreen);
            this.Controls.Add(this.lblRed);
            this.Name = "ColorControl";
            this.Size = new System.Drawing.Size(332, 170);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblBlue;
        private ColorNumberBox colorNumberBoxRed;
        private ColorNumberBox colorNumberBoxGreen;
        private ColorNumberBox colorNumberBoxBlue;
        private RectangleControl rectangleControl;
        private System.Windows.Forms.RadioButton radioBtnDec;
        private System.Windows.Forms.RadioButton radioBtnHex;
    }
}
