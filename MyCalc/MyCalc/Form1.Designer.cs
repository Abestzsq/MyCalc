namespace MyCalc
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelresultare = new System.Windows.Forms.Panel();
            this.labelresult = new System.Windows.Forms.Label();
            this.panelcalcuare = new System.Windows.Forms.Panel();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.buttonMul = new System.Windows.Forms.Button();
            this.buttonSub = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.panelputare = new System.Windows.Forms.Panel();
            this.textBoxop2 = new System.Windows.Forms.TextBox();
            this.textBoxop1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panelresultare.SuspendLayout();
            this.panelcalcuare.SuspendLayout();
            this.panelputare.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelresultare);
            this.panel1.Controls.Add(this.panelcalcuare);
            this.panel1.Controls.Add(this.panelputare);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(508, 438);
            this.panel1.TabIndex = 0;
            // 
            // panelresultare
            // 
            this.panelresultare.Controls.Add(this.labelresult);
            this.panelresultare.Location = new System.Drawing.Point(21, 12);
            this.panelresultare.Name = "panelresultare";
            this.panelresultare.Size = new System.Drawing.Size(461, 62);
            this.panelresultare.TabIndex = 1;
            // 
            // labelresult
            // 
            this.labelresult.AutoSize = true;
            this.labelresult.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelresult.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelresult.Location = new System.Drawing.Point(13, 12);
            this.labelresult.Name = "labelresult";
            this.labelresult.Size = new System.Drawing.Size(96, 39);
            this.labelresult.TabIndex = 0;
            this.labelresult.Text = "result";
            // 
            // panelcalcuare
            // 
            this.panelcalcuare.Controls.Add(this.buttonEqual);
            this.panelcalcuare.Controls.Add(this.buttonDiv);
            this.panelcalcuare.Controls.Add(this.buttonMul);
            this.panelcalcuare.Controls.Add(this.buttonSub);
            this.panelcalcuare.Controls.Add(this.buttonAdd);
            this.panelcalcuare.Location = new System.Drawing.Point(346, 87);
            this.panelcalcuare.Name = "panelcalcuare";
            this.panelcalcuare.Size = new System.Drawing.Size(104, 334);
            this.panelcalcuare.TabIndex = 0;
            // 
            // buttonEqual
            // 
            this.buttonEqual.Location = new System.Drawing.Point(16, 268);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(70, 50);
            this.buttonEqual.TabIndex = 5;
            this.buttonEqual.Text = "=";
            this.buttonEqual.UseVisualStyleBackColor = true;
            // 
            // buttonDiv
            // 
            this.buttonDiv.Location = new System.Drawing.Point(16, 196);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(70, 50);
            this.buttonDiv.TabIndex = 4;
            this.buttonDiv.Text = "/";
            this.buttonDiv.UseVisualStyleBackColor = true;
            this.buttonDiv.Click += new System.EventHandler(this.buttonDiv_Click);
            // 
            // buttonMul
            // 
            this.buttonMul.Location = new System.Drawing.Point(16, 139);
            this.buttonMul.Name = "buttonMul";
            this.buttonMul.Size = new System.Drawing.Size(70, 50);
            this.buttonMul.TabIndex = 3;
            this.buttonMul.Text = "*";
            this.buttonMul.UseVisualStyleBackColor = true;
            this.buttonMul.Click += new System.EventHandler(this.buttonMul_Click);
            // 
            // buttonSub
            // 
            this.buttonSub.Location = new System.Drawing.Point(16, 83);
            this.buttonSub.Name = "buttonSub";
            this.buttonSub.Size = new System.Drawing.Size(70, 50);
            this.buttonSub.TabIndex = 2;
            this.buttonSub.Text = "-";
            this.buttonSub.UseVisualStyleBackColor = true;
            this.buttonSub.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(16, 27);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(70, 50);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelputare
            // 
            this.panelputare.Controls.Add(this.textBoxop2);
            this.panelputare.Controls.Add(this.textBoxop1);
            this.panelputare.Location = new System.Drawing.Point(21, 87);
            this.panelputare.Name = "panelputare";
            this.panelputare.Size = new System.Drawing.Size(299, 334);
            this.panelputare.TabIndex = 0;
            // 
            // textBoxop2
            // 
            this.textBoxop2.Location = new System.Drawing.Point(24, 203);
            this.textBoxop2.Name = "textBoxop2";
            this.textBoxop2.Size = new System.Drawing.Size(234, 27);
            this.textBoxop2.TabIndex = 2;
            // 
            // textBoxop1
            // 
            this.textBoxop1.Location = new System.Drawing.Point(24, 151);
            this.textBoxop1.Name = "textBoxop1";
            this.textBoxop1.Size = new System.Drawing.Size(234, 27);
            this.textBoxop1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "MyCalc";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panelresultare.ResumeLayout(false);
            this.panelresultare.PerformLayout();
            this.panelcalcuare.ResumeLayout(false);
            this.panelputare.ResumeLayout(false);
            this.panelputare.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelresultare;
        private System.Windows.Forms.Label labelresult;
        private System.Windows.Forms.Panel panelcalcuare;
        private System.Windows.Forms.Button buttonEqual;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.Button buttonMul;
        private System.Windows.Forms.Button buttonSub;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Panel panelputare;
        private System.Windows.Forms.TextBox textBoxop2;
        private System.Windows.Forms.TextBox textBoxop1;
    }
}

