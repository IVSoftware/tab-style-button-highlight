
namespace tab_style_button_highlight
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioTabA = new tab_style_button_highlight.RadioButtonEx();
            this.radioTabB = new tab_style_button_highlight.RadioButtonEx();
            this.radioTabC = new tab_style_button_highlight.RadioButtonEx();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radioTabA
            // 
            this.radioTabA.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioTabA.Location = new System.Drawing.Point(9, 178);
            this.radioTabA.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.radioTabA.Name = "radioTabA";
            this.radioTabA.Size = new System.Drawing.Size(100, 40);
            this.radioTabA.TabIndex = 0;
            this.radioTabA.TabStop = true;
            this.radioTabA.Text = "A";
            this.radioTabA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioTabA.UseVisualStyleBackColor = true;
            // 
            // radioTabB
            // 
            this.radioTabB.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioTabB.Location = new System.Drawing.Point(109, 178);
            this.radioTabB.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.radioTabB.Name = "radioTabB";
            this.radioTabB.Size = new System.Drawing.Size(100, 40);
            this.radioTabB.TabIndex = 1;
            this.radioTabB.TabStop = true;
            this.radioTabB.Text = "B";
            this.radioTabB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioTabB.UseVisualStyleBackColor = true;
            // 
            // radioTabC
            // 
            this.radioTabC.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioTabC.Location = new System.Drawing.Point(209, 178);
            this.radioTabC.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.radioTabC.Name = "radioTabC";
            this.radioTabC.Size = new System.Drawing.Size(100, 40);
            this.radioTabC.TabIndex = 2;
            this.radioTabC.TabStop = true;
            this.radioTabC.Text = "C";
            this.radioTabC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioTabC.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 72);
            this.label1.TabIndex = 3;
            this.label1.Text = "A";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 244);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioTabC);
            this.Controls.Add(this.radioTabB);
            this.Controls.Add(this.radioTabA);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        #endregion

        private tab_style_button_highlight.RadioButtonEx radioTabA;
        private tab_style_button_highlight.RadioButtonEx radioTabB;
        private tab_style_button_highlight.RadioButtonEx radioTabC;
        private System.Windows.Forms.Label label1;
    }
}

