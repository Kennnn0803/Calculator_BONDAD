
namespace Calculator_BONDAD
{
    partial class Body
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Body));
            this.bseven = new System.Windows.Forms.Button();
            this.textbox_result = new System.Windows.Forms.TextBox();
            this.bfour = new System.Windows.Forms.Button();
            this.bone = new System.Windows.Forms.Button();
            this.bzero = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bseven
            // 
            this.bseven.Location = new System.Drawing.Point(12, 64);
            this.bseven.Name = "bseven";
            this.bseven.Size = new System.Drawing.Size(50, 50);
            this.bseven.TabIndex = 0;
            this.bseven.Text = "7";
            this.bseven.UseVisualStyleBackColor = true;
            // 
            // textbox_result
            // 
            this.textbox_result.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textbox_result.Location = new System.Drawing.Point(12, 31);
            this.textbox_result.Name = "textbox_result";
            this.textbox_result.Size = new System.Drawing.Size(258, 28);
            this.textbox_result.TabIndex = 1;
            this.textbox_result.Text = "0";
            this.textbox_result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bfour
            // 
            this.bfour.Location = new System.Drawing.Point(12, 120);
            this.bfour.Name = "bfour";
            this.bfour.Size = new System.Drawing.Size(50, 50);
            this.bfour.TabIndex = 2;
            this.bfour.Text = "4";
            this.bfour.UseVisualStyleBackColor = true;
            // 
            // bone
            // 
            this.bone.Location = new System.Drawing.Point(12, 176);
            this.bone.Name = "bone";
            this.bone.Size = new System.Drawing.Size(50, 50);
            this.bone.TabIndex = 3;
            this.bone.Text = "1";
            this.bone.UseVisualStyleBackColor = true;
            // 
            // bzero
            // 
            this.bzero.Location = new System.Drawing.Point(12, 232);
            this.bzero.Name = "bzero";
            this.bzero.Size = new System.Drawing.Size(50, 50);
            this.bzero.TabIndex = 4;
            this.bzero.Text = "0";
            this.bzero.UseVisualStyleBackColor = true;
            // 
            // Body
            // 
            this.ClientSize = new System.Drawing.Size(282, 325);
            this.Controls.Add(this.bzero);
            this.Controls.Add(this.bone);
            this.Controls.Add(this.bfour);
            this.Controls.Add(this.textbox_result);
            this.Controls.Add(this.bseven);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Body";
            this.Text = "God\'s Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button bseven;
        private System.Windows.Forms.TextBox textbox_result;
        private System.Windows.Forms.Button bfour;
        private System.Windows.Forms.Button bone;
        private System.Windows.Forms.Button bzero;
    }
}
#endregion