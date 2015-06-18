namespace Threads
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnLinear = new System.Windows.Forms.Button();
            this.lblLinear = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblOneThread = new System.Windows.Forms.Label();
            this.lblMoreThreads = new System.Windows.Forms.Label();
            this.btnMoreThreads = new System.Windows.Forms.Button();
            this.lblLinear2 = new System.Windows.Forms.Label();
            this.btnLinear2 = new System.Windows.Forms.Button();
            this.lblLinqMulti = new System.Windows.Forms.Label();
            this.btnLinqMulti = new System.Windows.Forms.Button();
            this.lblLinqOne = new System.Windows.Forms.Label();
            this.btnLinqOne = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLinear
            // 
            this.btnLinear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLinear.Location = new System.Drawing.Point(12, 12);
            this.btnLinear.Name = "btnLinear";
            this.btnLinear.Size = new System.Drawing.Size(130, 33);
            this.btnLinear.TabIndex = 0;
            this.btnLinear.Text = "Linear";
            this.btnLinear.UseVisualStyleBackColor = true;
            this.btnLinear.Click += new System.EventHandler(this.btnLinear_Click);
            // 
            // lblLinear
            // 
            this.lblLinear.AutoSize = true;
            this.lblLinear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinear.Location = new System.Drawing.Point(224, 16);
            this.lblLinear.Name = "lblLinear";
            this.lblLinear.Size = new System.Drawing.Size(26, 29);
            this.lblLinear.TabIndex = 1;
            this.lblLinear.Text = "0";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "1 Thread";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblOneThread
            // 
            this.lblOneThread.AutoSize = true;
            this.lblOneThread.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOneThread.Location = new System.Drawing.Point(224, 97);
            this.lblOneThread.Name = "lblOneThread";
            this.lblOneThread.Size = new System.Drawing.Size(26, 29);
            this.lblOneThread.TabIndex = 3;
            this.lblOneThread.Text = "0";
            // 
            // lblMoreThreads
            // 
            this.lblMoreThreads.AutoSize = true;
            this.lblMoreThreads.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoreThreads.Location = new System.Drawing.Point(224, 137);
            this.lblMoreThreads.Name = "lblMoreThreads";
            this.lblMoreThreads.Size = new System.Drawing.Size(26, 29);
            this.lblMoreThreads.TabIndex = 5;
            this.lblMoreThreads.Text = "0";
            // 
            // btnMoreThreads
            // 
            this.btnMoreThreads.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoreThreads.Location = new System.Drawing.Point(12, 134);
            this.btnMoreThreads.Name = "btnMoreThreads";
            this.btnMoreThreads.Size = new System.Drawing.Size(130, 34);
            this.btnMoreThreads.TabIndex = 4;
            this.btnMoreThreads.Text = "Multi Threads";
            this.btnMoreThreads.UseVisualStyleBackColor = true;
            this.btnMoreThreads.Click += new System.EventHandler(this.btnMoreThreads_Click);
            // 
            // lblLinear2
            // 
            this.lblLinear2.AutoSize = true;
            this.lblLinear2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinear2.Location = new System.Drawing.Point(224, 55);
            this.lblLinear2.Name = "lblLinear2";
            this.lblLinear2.Size = new System.Drawing.Size(26, 29);
            this.lblLinear2.TabIndex = 7;
            this.lblLinear2.Text = "0";
            // 
            // btnLinear2
            // 
            this.btnLinear2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLinear2.Location = new System.Drawing.Point(12, 51);
            this.btnLinear2.Name = "btnLinear2";
            this.btnLinear2.Size = new System.Drawing.Size(130, 33);
            this.btnLinear2.TabIndex = 6;
            this.btnLinear2.Text = "Linear 2";
            this.btnLinear2.UseVisualStyleBackColor = true;
            this.btnLinear2.Click += new System.EventHandler(this.btnLinear2_Click);
            // 
            // lblLinqMulti
            // 
            this.lblLinqMulti.AutoSize = true;
            this.lblLinqMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinqMulti.Location = new System.Drawing.Point(224, 240);
            this.lblLinqMulti.Name = "lblLinqMulti";
            this.lblLinqMulti.Size = new System.Drawing.Size(26, 29);
            this.lblLinqMulti.TabIndex = 11;
            this.lblLinqMulti.Text = "0";
            // 
            // btnLinqMulti
            // 
            this.btnLinqMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLinqMulti.Location = new System.Drawing.Point(12, 237);
            this.btnLinqMulti.Name = "btnLinqMulti";
            this.btnLinqMulti.Size = new System.Drawing.Size(181, 34);
            this.btnLinqMulti.TabIndex = 10;
            this.btnLinqMulti.Text = "Linq Multi Threads";
            this.btnLinqMulti.UseVisualStyleBackColor = true;
            this.btnLinqMulti.Click += new System.EventHandler(this.btnLinqMulti_Click);
            // 
            // lblLinqOne
            // 
            this.lblLinqOne.AutoSize = true;
            this.lblLinqOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinqOne.Location = new System.Drawing.Point(224, 200);
            this.lblLinqOne.Name = "lblLinqOne";
            this.lblLinqOne.Size = new System.Drawing.Size(26, 29);
            this.lblLinqOne.TabIndex = 9;
            this.lblLinqOne.Text = "0";
            // 
            // btnLinqOne
            // 
            this.btnLinqOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLinqOne.Location = new System.Drawing.Point(12, 197);
            this.btnLinqOne.Name = "btnLinqOne";
            this.btnLinqOne.Size = new System.Drawing.Size(181, 34);
            this.btnLinqOne.TabIndex = 8;
            this.btnLinqOne.Text = "Linq 1 Thread";
            this.btnLinqOne.UseVisualStyleBackColor = true;
            this.btnLinqOne.Click += new System.EventHandler(this.btnLinqOne_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(862, 445);
            this.Controls.Add(this.lblLinqMulti);
            this.Controls.Add(this.btnLinqMulti);
            this.Controls.Add(this.lblLinqOne);
            this.Controls.Add(this.btnLinqOne);
            this.Controls.Add(this.lblLinear2);
            this.Controls.Add(this.btnLinear2);
            this.Controls.Add(this.lblMoreThreads);
            this.Controls.Add(this.btnMoreThreads);
            this.Controls.Add(this.lblOneThread);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblLinear);
            this.Controls.Add(this.btnLinear);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLinear;
        private System.Windows.Forms.Label lblLinear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblOneThread;
        private System.Windows.Forms.Label lblMoreThreads;
        private System.Windows.Forms.Button btnMoreThreads;
        private System.Windows.Forms.Label lblLinear2;
        private System.Windows.Forms.Button btnLinear2;
        private System.Windows.Forms.Label lblLinqMulti;
        private System.Windows.Forms.Button btnLinqMulti;
        private System.Windows.Forms.Label lblLinqOne;
        private System.Windows.Forms.Button btnLinqOne;
    }
}

