
namespace Calculator_BONDAD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bone = new System.Windows.Forms.Button();
            this.bseven = new System.Windows.Forms.Button();
            this.bfour = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.beight = new System.Windows.Forms.Button();
            this.bfive = new System.Windows.Forms.Button();
            this.btwo = new System.Windows.Forms.Button();
            this.bnine = new System.Windows.Forms.Button();
            this.bdivision = new System.Windows.Forms.Button();
            this.bsix = new System.Windows.Forms.Button();
            this.bmultiplication = new System.Windows.Forms.Button();
            this.bthree = new System.Windows.Forms.Button();
            this.bsubtraction = new System.Windows.Forms.Button();
            this.bdot = new System.Windows.Forms.Button();
            this.baddition = new System.Windows.Forms.Button();
            this.bclearentry = new System.Windows.Forms.Button();
            this.bclear = new System.Windows.Forms.Button();
            this.bequal = new System.Windows.Forms.Button();
            this.tbox = new System.Windows.Forms.TextBox();
            this.labelCO = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bone
            // 
            this.bone.Location = new System.Drawing.Point(12, 192);
            this.bone.Name = "bone";
            this.bone.Size = new System.Drawing.Size(50, 50);
            this.bone.TabIndex = 0;
            this.bone.Text = "1";
            this.bone.UseVisualStyleBackColor = true;
            this.bone.Click += new System.EventHandler(this.button_click);
            // 
            // bseven
            // 
            this.bseven.Location = new System.Drawing.Point(12, 80);
            this.bseven.Name = "bseven";
            this.bseven.Size = new System.Drawing.Size(50, 50);
            this.bseven.TabIndex = 1;
            this.bseven.Text = "7";
            this.bseven.UseVisualStyleBackColor = true;
            this.bseven.Click += new System.EventHandler(this.button_click);
            // 
            // bfour
            // 
            this.bfour.Location = new System.Drawing.Point(12, 136);
            this.bfour.Name = "bfour";
            this.bfour.Size = new System.Drawing.Size(50, 50);
            this.bfour.TabIndex = 2;
            this.bfour.Text = "4";
            this.bfour.UseVisualStyleBackColor = true;
            this.bfour.Click += new System.EventHandler(this.button_click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 248);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 50);
            this.button2.TabIndex = 3;
            this.button2.Text = "0";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_click);
            // 
            // beight
            // 
            this.beight.Location = new System.Drawing.Point(68, 80);
            this.beight.Name = "beight";
            this.beight.Size = new System.Drawing.Size(50, 50);
            this.beight.TabIndex = 4;
            this.beight.Text = "8";
            this.beight.UseVisualStyleBackColor = true;
            this.beight.Click += new System.EventHandler(this.button_click);
            // 
            // bfive
            // 
            this.bfive.Location = new System.Drawing.Point(68, 136);
            this.bfive.Name = "bfive";
            this.bfive.Size = new System.Drawing.Size(50, 50);
            this.bfive.TabIndex = 5;
            this.bfive.Text = "5";
            this.bfive.UseVisualStyleBackColor = true;
            this.bfive.Click += new System.EventHandler(this.button_click);
            // 
            // btwo
            // 
            this.btwo.Location = new System.Drawing.Point(68, 192);
            this.btwo.Name = "btwo";
            this.btwo.Size = new System.Drawing.Size(50, 50);
            this.btwo.TabIndex = 6;
            this.btwo.Text = "2";
            this.btwo.UseVisualStyleBackColor = true;
            this.btwo.Click += new System.EventHandler(this.button_click);
            // 
            // bnine
            // 
            this.bnine.Location = new System.Drawing.Point(124, 80);
            this.bnine.Name = "bnine";
            this.bnine.Size = new System.Drawing.Size(50, 50);
            this.bnine.TabIndex = 7;
            this.bnine.Text = "9";
            this.bnine.UseVisualStyleBackColor = true;
            this.bnine.Click += new System.EventHandler(this.button_click);
            // 
            // bdivision
            // 
            this.bdivision.Location = new System.Drawing.Point(180, 80);
            this.bdivision.Name = "bdivision";
            this.bdivision.Size = new System.Drawing.Size(50, 50);
            this.bdivision.TabIndex = 8;
            this.bdivision.Text = "/";
            this.bdivision.UseVisualStyleBackColor = true;
            this.bdivision.Click += new System.EventHandler(this.operator_click);
            // 
            // bsix
            // 
            this.bsix.Location = new System.Drawing.Point(124, 136);
            this.bsix.Name = "bsix";
            this.bsix.Size = new System.Drawing.Size(50, 50);
            this.bsix.TabIndex = 9;
            this.bsix.Text = "6";
            this.bsix.UseVisualStyleBackColor = true;
            this.bsix.Click += new System.EventHandler(this.button_click);
            // 
            // bmultiplication
            // 
            this.bmultiplication.Location = new System.Drawing.Point(180, 136);
            this.bmultiplication.Name = "bmultiplication";
            this.bmultiplication.Size = new System.Drawing.Size(50, 50);
            this.bmultiplication.TabIndex = 10;
            this.bmultiplication.Text = "*";
            this.bmultiplication.UseVisualStyleBackColor = true;
            this.bmultiplication.Click += new System.EventHandler(this.operator_click);
            // 
            // bthree
            // 
            this.bthree.Location = new System.Drawing.Point(124, 192);
            this.bthree.Name = "bthree";
            this.bthree.Size = new System.Drawing.Size(50, 50);
            this.bthree.TabIndex = 11;
            this.bthree.Text = "3";
            this.bthree.UseVisualStyleBackColor = true;
            this.bthree.Click += new System.EventHandler(this.button_click);
            // 
            // bsubtraction
            // 
            this.bsubtraction.Location = new System.Drawing.Point(180, 192);
            this.bsubtraction.Name = "bsubtraction";
            this.bsubtraction.Size = new System.Drawing.Size(50, 50);
            this.bsubtraction.TabIndex = 12;
            this.bsubtraction.Text = "-";
            this.bsubtraction.UseVisualStyleBackColor = true;
            this.bsubtraction.Click += new System.EventHandler(this.operator_click);
            // 
            // bdot
            // 
            this.bdot.Location = new System.Drawing.Point(124, 248);
            this.bdot.Name = "bdot";
            this.bdot.Size = new System.Drawing.Size(50, 50);
            this.bdot.TabIndex = 13;
            this.bdot.Text = ".";
            this.bdot.UseVisualStyleBackColor = true;
            this.bdot.Click += new System.EventHandler(this.button_click);
            // 
            // baddition
            // 
            this.baddition.Location = new System.Drawing.Point(180, 248);
            this.baddition.Name = "baddition";
            this.baddition.Size = new System.Drawing.Size(50, 50);
            this.baddition.TabIndex = 14;
            this.baddition.Text = "+";
            this.baddition.UseVisualStyleBackColor = true;
            this.baddition.Click += new System.EventHandler(this.operator_click);
            // 
            // bclearentry
            // 
            this.bclearentry.Location = new System.Drawing.Point(236, 80);
            this.bclearentry.Name = "bclearentry";
            this.bclearentry.Size = new System.Drawing.Size(50, 50);
            this.bclearentry.TabIndex = 15;
            this.bclearentry.Text = "CE";
            this.bclearentry.UseVisualStyleBackColor = true;
            this.bclearentry.Click += new System.EventHandler(this.ce_click);
            // 
            // bclear
            // 
            this.bclear.Location = new System.Drawing.Point(236, 136);
            this.bclear.Name = "bclear";
            this.bclear.Size = new System.Drawing.Size(50, 50);
            this.bclear.TabIndex = 16;
            this.bclear.Text = "C";
            this.bclear.UseVisualStyleBackColor = true;
            this.bclear.Click += new System.EventHandler(this.c_click);
            // 
            // bequal
            // 
            this.bequal.Location = new System.Drawing.Point(236, 192);
            this.bequal.Name = "bequal";
            this.bequal.Size = new System.Drawing.Size(50, 106);
            this.bequal.TabIndex = 17;
            this.bequal.Text = "=";
            this.bequal.UseVisualStyleBackColor = true;
            this.bequal.Click += new System.EventHandler(this.equal_click);
            // 
            // tbox
            // 
            this.tbox.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbox.Location = new System.Drawing.Point(12, 46);
            this.tbox.Name = "tbox";
            this.tbox.Size = new System.Drawing.Size(274, 28);
            this.tbox.TabIndex = 18;
            this.tbox.Text = "0";
            this.tbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelCO
            // 
            this.labelCO.AutoSize = true;
            this.labelCO.Location = new System.Drawing.Point(12, 14);
            this.labelCO.Name = "labelCO";
            this.labelCO.Size = new System.Drawing.Size(0, 20);
            this.labelCO.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 310);
            this.Controls.Add(this.labelCO);
            this.Controls.Add(this.tbox);
            this.Controls.Add(this.bequal);
            this.Controls.Add(this.bclear);
            this.Controls.Add(this.bclearentry);
            this.Controls.Add(this.baddition);
            this.Controls.Add(this.bdot);
            this.Controls.Add(this.bsubtraction);
            this.Controls.Add(this.bthree);
            this.Controls.Add(this.bmultiplication);
            this.Controls.Add(this.bsix);
            this.Controls.Add(this.bdivision);
            this.Controls.Add(this.bnine);
            this.Controls.Add(this.btwo);
            this.Controls.Add(this.bfive);
            this.Controls.Add(this.beight);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bfour);
            this.Controls.Add(this.bseven);
            this.Controls.Add(this.bone);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "God\'s Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bone;
        private System.Windows.Forms.Button bseven;
        private System.Windows.Forms.Button bfour;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button beight;
        private System.Windows.Forms.Button bfive;
        private System.Windows.Forms.Button btwo;
        private System.Windows.Forms.Button bnine;
        private System.Windows.Forms.Button bdivision;
        private System.Windows.Forms.Button bsix;
        private System.Windows.Forms.Button bmultiplication;
        private System.Windows.Forms.Button bthree;
        private System.Windows.Forms.Button bsubtraction;
        private System.Windows.Forms.Button bdot;
        private System.Windows.Forms.Button baddition;
        private System.Windows.Forms.Button bclearentry;
        private System.Windows.Forms.Button bclear;
        private System.Windows.Forms.Button bequal;
        private System.Windows.Forms.TextBox tbox;
        private System.Windows.Forms.Label labelCO;
    }
}

