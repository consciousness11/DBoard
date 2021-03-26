
namespace DBoard
{
    partial class MainControl
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.content = new System.Windows.Forms.Panel();
            this.content.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(163, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 85);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Customer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(407, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 85);
            this.button2.TabIndex = 1;
            this.button2.Text = "Add Product";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(636, 140);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 85);
            this.button3.TabIndex = 2;
            this.button3.Text = "View Sales ";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Admin Dashboard";
            // 
            // content
            // 
            this.content.Controls.Add(this.label1);
            this.content.Controls.Add(this.button3);
            this.content.Controls.Add(this.button2);
            this.content.Controls.Add(this.button1);
            this.content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content.Location = new System.Drawing.Point(0, 0);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(1106, 666);
            this.content.TabIndex = 4;
            // 
            // MainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.content);
            this.Name = "MainControl";
            this.Size = new System.Drawing.Size(1106, 666);
            this.content.ResumeLayout(false);
            this.content.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel content;
    }
}
