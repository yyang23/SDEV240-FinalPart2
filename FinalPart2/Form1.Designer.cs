
namespace FinalPart2
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
            this.instructionLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.line1CTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.line1BTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.line1ATextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.line2CTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.line2BTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.line2ATextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkIntersectionBtn = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.Load = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.BackColor = System.Drawing.SystemColors.Window;
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.Location = new System.Drawing.Point(4, 9);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(207, 25);
            this.instructionLabel.TabIndex = 0;
            this.instructionLabel.Text = "A line is Ax + By = C";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.line1CTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.line1BTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.line1ATextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(44, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 122);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Set line1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(188, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 24);
            this.label9.TabIndex = 7;
            this.label9.Text = "y = ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(107, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 24);
            this.label8.TabIndex = 6;
            this.label8.Text = "x + ";
            // 
            // line1CTextBox
            // 
            this.line1CTextBox.Location = new System.Drawing.Point(234, 83);
            this.line1CTextBox.Name = "line1CTextBox";
            this.line1CTextBox.Size = new System.Drawing.Size(30, 29);
            this.line1CTextBox.TabIndex = 5;
            this.line1CTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "C value";
            // 
            // line1BTextBox
            // 
            this.line1BTextBox.Location = new System.Drawing.Point(154, 83);
            this.line1BTextBox.Name = "line1BTextBox";
            this.line1BTextBox.Size = new System.Drawing.Size(28, 29);
            this.line1BTextBox.TabIndex = 3;
            this.line1BTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "B value";
            // 
            // line1ATextBox
            // 
            this.line1ATextBox.Location = new System.Drawing.Point(73, 83);
            this.line1ATextBox.Name = "line1ATextBox";
            this.line1ATextBox.Size = new System.Drawing.Size(28, 29);
            this.line1ATextBox.TabIndex = 1;
            this.line1ATextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "A value";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Lavender;
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.line2CTextBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.line2BTextBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.line2ATextBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(44, 208);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 140);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Set line2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(188, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 24);
            this.label11.TabIndex = 7;
            this.label11.Text = "y =";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(107, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 24);
            this.label10.TabIndex = 6;
            this.label10.Text = "x + ";
            // 
            // line2CTextBox
            // 
            this.line2CTextBox.Location = new System.Drawing.Point(235, 82);
            this.line2CTextBox.Name = "line2CTextBox";
            this.line2CTextBox.Size = new System.Drawing.Size(29, 29);
            this.line2CTextBox.TabIndex = 5;
            this.line2CTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(213, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "C value";
            // 
            // line2BTextBox
            // 
            this.line2BTextBox.Location = new System.Drawing.Point(154, 82);
            this.line2BTextBox.Name = "line2BTextBox";
            this.line2BTextBox.Size = new System.Drawing.Size(29, 29);
            this.line2BTextBox.TabIndex = 3;
            this.line2BTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(130, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "B value";
            // 
            // line2ATextBox
            // 
            this.line2ATextBox.Location = new System.Drawing.Point(73, 82);
            this.line2ATextBox.Name = "line2ATextBox";
            this.line2ATextBox.Size = new System.Drawing.Size(29, 29);
            this.line2ATextBox.TabIndex = 1;
            this.line2ATextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "A value";
            // 
            // checkIntersectionBtn
            // 
            this.checkIntersectionBtn.BackColor = System.Drawing.Color.Plum;
            this.checkIntersectionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkIntersectionBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.checkIntersectionBtn.Location = new System.Drawing.Point(109, 367);
            this.checkIntersectionBtn.Name = "checkIntersectionBtn";
            this.checkIntersectionBtn.Size = new System.Drawing.Size(221, 41);
            this.checkIntersectionBtn.TabIndex = 8;
            this.checkIntersectionBtn.Text = "Check Line Relationship";
            this.checkIntersectionBtn.UseVisualStyleBackColor = false;
            this.checkIntersectionBtn.Click += new System.EventHandler(this.CheckLineRelationship_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.outputLabel.Location = new System.Drawing.Point(44, 408);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(57, 24);
            this.outputLabel.TabIndex = 9;
            this.outputLabel.Text = "Output";
            this.outputLabel.UseCompatibleTextRendering = true;
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.SteelBlue;
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.ForeColor = System.Drawing.SystemColors.Info;
            this.Save.Location = new System.Drawing.Point(424, 142);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 41);
            this.Save.TabIndex = 10;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Load
            // 
            this.Load.BackColor = System.Drawing.Color.SteelBlue;
            this.Load.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Load.ForeColor = System.Drawing.SystemColors.Info;
            this.Load.Location = new System.Drawing.Point(424, 208);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(75, 41);
            this.Load.TabIndex = 11;
            this.Load.Text = "Load";
            this.Load.UseVisualStyleBackColor = false;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.Color.OrangeRed;
            this.clearBtn.Location = new System.Drawing.Point(424, 273);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 41);
            this.clearBtn.TabIndex = 12;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.Clear_Click);
            // 
            // outputTextBox
            // 
            this.outputTextBox.BackColor = System.Drawing.Color.Thistle;
            this.outputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputTextBox.Location = new System.Drawing.Point(44, 435);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(350, 67);
            this.outputTextBox.TabIndex = 13;
            this.outputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(530, 514);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.checkIntersectionBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.instructionLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox line1CTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox line1BTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox line1ATextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox line2CTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox line2BTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox line2ATextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button checkIntersectionBtn;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox outputTextBox;
    }
}

