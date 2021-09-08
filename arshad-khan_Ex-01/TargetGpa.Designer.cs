
namespace arshad_khan_Ex_01
{
    partial class TargetGpa
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCurrentGpa = new System.Windows.Forms.TextBox();
            this.textBoxTargetGpa = new System.Windows.Forms.TextBox();
            this.textBoxCurrentCreds = new System.Windows.Forms.TextBox();
            this.textBoxFutureCreds = new System.Windows.Forms.TextBox();
            this.buttonCalcTarget = new System.Windows.Forms.Button();
            this.labelTargetResult = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current GPA";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Target Gpa";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 50);
            this.label3.TabIndex = 2;
            this.label3.Text = "Current credits";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 54);
            this.label4.TabIndex = 3;
            this.label4.Text = "Future credits";
            // 
            // textBoxCurrentGpa
            // 
            this.textBoxCurrentGpa.Location = new System.Drawing.Point(173, 71);
            this.textBoxCurrentGpa.Name = "textBoxCurrentGpa";
            this.textBoxCurrentGpa.Size = new System.Drawing.Size(129, 26);
            this.textBoxCurrentGpa.TabIndex = 4;
            this.textBoxCurrentGpa.Text = "2.8";
            // 
            // textBoxTargetGpa
            // 
            this.textBoxTargetGpa.Location = new System.Drawing.Point(173, 127);
            this.textBoxTargetGpa.Name = "textBoxTargetGpa";
            this.textBoxTargetGpa.Size = new System.Drawing.Size(129, 26);
            this.textBoxTargetGpa.TabIndex = 5;
            this.textBoxTargetGpa.Text = "3.0";
            // 
            // textBoxCurrentCreds
            // 
            this.textBoxCurrentCreds.Location = new System.Drawing.Point(173, 182);
            this.textBoxCurrentCreds.Name = "textBoxCurrentCreds";
            this.textBoxCurrentCreds.Size = new System.Drawing.Size(129, 26);
            this.textBoxCurrentCreds.TabIndex = 6;
            this.textBoxCurrentCreds.Text = "25";
            // 
            // textBoxFutureCreds
            // 
            this.textBoxFutureCreds.Location = new System.Drawing.Point(173, 236);
            this.textBoxFutureCreds.Name = "textBoxFutureCreds";
            this.textBoxFutureCreds.Size = new System.Drawing.Size(129, 26);
            this.textBoxFutureCreds.TabIndex = 7;
            this.textBoxFutureCreds.Text = "15";
            // 
            // buttonCalcTarget
            // 
            this.buttonCalcTarget.Location = new System.Drawing.Point(16, 293);
            this.buttonCalcTarget.Name = "buttonCalcTarget";
            this.buttonCalcTarget.Size = new System.Drawing.Size(88, 41);
            this.buttonCalcTarget.TabIndex = 8;
            this.buttonCalcTarget.Text = "Calculate";
            this.buttonCalcTarget.UseVisualStyleBackColor = true;
            this.buttonCalcTarget.Click += new System.EventHandler(this.buttonCalcTarget_Click);
            // 
            // labelTargetResult
            // 
            this.labelTargetResult.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTargetResult.Location = new System.Drawing.Point(169, 303);
            this.labelTargetResult.Name = "labelTargetResult";
            this.labelTargetResult.Size = new System.Drawing.Size(203, 99);
            this.labelTargetResult.TabIndex = 9;
            this.labelTargetResult.Text = "I need a GPA of:";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.LightCoral;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(92, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(605, 45);
            this.label5.TabIndex = 10;
            this.label5.Text = "MyCentennial Target GPA Calculator";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(511, 139);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(138, 69);
            this.buttonExit.TabIndex = 11;
            this.buttonExit.Text = "Exit Target GPA Calculator";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // TargetGpa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelTargetResult);
            this.Controls.Add(this.buttonCalcTarget);
            this.Controls.Add(this.textBoxFutureCreds);
            this.Controls.Add(this.textBoxCurrentCreds);
            this.Controls.Add(this.textBoxTargetGpa);
            this.Controls.Add(this.textBoxCurrentGpa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TargetGpa";
            this.Text = "TargetGpa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCurrentGpa;
        private System.Windows.Forms.TextBox textBoxTargetGpa;
        private System.Windows.Forms.TextBox textBoxCurrentCreds;
        private System.Windows.Forms.TextBox textBoxFutureCreds;
        private System.Windows.Forms.Button buttonCalcTarget;
        private System.Windows.Forms.Label labelTargetResult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonExit;
    }
}