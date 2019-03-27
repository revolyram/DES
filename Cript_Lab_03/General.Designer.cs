namespace Cript_Lab_03
{
    partial class General
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.key = new System.Windows.Forms.NumericUpDown();
            this.input = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rezult = new System.Windows.Forms.TextBox();
            this.Decode = new System.Windows.Forms.Button();
            this.Encode = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.key)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.key);
            this.groupBox1.Controls.Add(this.input);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Входные данные";
            // 
            // key
            // 
            this.key.Location = new System.Drawing.Point(6, 63);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(236, 22);
            this.key.TabIndex = 1;
            this.key.ValueChanged += new System.EventHandler(this.key_ValueChanged);
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(6, 29);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(236, 22);
            this.input.TabIndex = 0;
            this.input.TextChanged += new System.EventHandler(this.input_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rezult);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 71);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выходные данные";
            // 
            // rezult
            // 
            this.rezult.Location = new System.Drawing.Point(6, 29);
            this.rezult.Name = "rezult";
            this.rezult.ReadOnly = true;
            this.rezult.Size = new System.Drawing.Size(236, 22);
            this.rezult.TabIndex = 0;
            // 
            // Decode
            // 
            this.Decode.Location = new System.Drawing.Point(13, 106);
            this.Decode.Name = "Decode";
            this.Decode.Size = new System.Drawing.Size(128, 56);
            this.Decode.TabIndex = 2;
            this.Decode.Text = "Расшифровать";
            this.Decode.UseVisualStyleBackColor = true;
            this.Decode.Click += new System.EventHandler(this.Decode_Click);
            // 
            // Encode
            // 
            this.Encode.Location = new System.Drawing.Point(13, 21);
            this.Encode.Name = "Encode";
            this.Encode.Size = new System.Drawing.Size(128, 56);
            this.Encode.TabIndex = 3;
            this.Encode.Text = "Зашифровать";
            this.Encode.UseVisualStyleBackColor = true;
            this.Encode.Click += new System.EventHandler(this.Encode_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Encode);
            this.groupBox3.Controls.Add(this.Decode);
            this.groupBox3.Location = new System.Drawing.Point(269, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(154, 177);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // General
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 199);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "General";
            this.Text = "DES";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.key)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown key;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox rezult;
        private System.Windows.Forms.Button Decode;
        private System.Windows.Forms.Button Encode;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}