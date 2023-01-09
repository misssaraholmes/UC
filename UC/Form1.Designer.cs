namespace UC
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
            this.usState1 = new UC.usState();
            this.btnGetState = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usState1
            // 
            this.usState1.Location = new System.Drawing.Point(37, 31);
            this.usState1.Name = "usState1";
            this.usState1.Size = new System.Drawing.Size(460, 112);
            this.usState1.TabIndex = 0;
            // 
            // btnGetState
            // 
            this.btnGetState.Location = new System.Drawing.Point(183, 202);
            this.btnGetState.Name = "btnGetState";
            this.btnGetState.Size = new System.Drawing.Size(94, 29);
            this.btnGetState.TabIndex = 1;
            this.btnGetState.Text = "State";
            this.btnGetState.UseVisualStyleBackColor = true;
            this.btnGetState.Click += new System.EventHandler(this.btnGetState_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 450);
            this.Controls.Add(this.btnGetState);
            this.Controls.Add(this.usState1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private usState usState1;
        private Button btnGetState;
    }
}