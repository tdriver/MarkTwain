namespace MarkTwain
{
    partial class SettingsForm
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
            this.components = new System.ComponentModel.Container();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudMaxLength = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudMinLength = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudNumWords = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudMinPasswordLength = new System.Windows.Forms.NumericUpDown();
            this.nudMaxPasswordLength = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumWords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinPasswordLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxPasswordLength)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnOk.Location = new System.Drawing.Point(157, 152);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(58, 152);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudMaxLength);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nudMinLength);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nudNumWords);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 78);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Words";
            // 
            // nudMaxLength
            // 
            this.nudMaxLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMaxLength.Location = new System.Drawing.Point(176, 41);
            this.nudMaxLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMaxLength.Name = "nudMaxLength";
            this.nudMaxLength.Size = new System.Drawing.Size(65, 20);
            this.nudMaxLength.TabIndex = 5;
            this.nudMaxLength.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudMaxLength.ValueChanged += new System.EventHandler(this.nudMaxLength_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(173, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Max Length";
            // 
            // nudMinLength
            // 
            this.nudMinLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMinLength.Location = new System.Drawing.Point(92, 41);
            this.nudMinLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMinLength.Name = "nudMinLength";
            this.nudMinLength.Size = new System.Drawing.Size(65, 20);
            this.nudMinLength.TabIndex = 3;
            this.nudMinLength.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudMinLength.ValueChanged += new System.EventHandler(this.nudMinLength_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Min Length";
            // 
            // nudNumWords
            // 
            this.nudNumWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNumWords.Hexadecimal = true;
            this.nudNumWords.Location = new System.Drawing.Point(9, 41);
            this.nudNumWords.Name = "nudNumWords";
            this.nudNumWords.Size = new System.Drawing.Size(65, 20);
            this.nudNumWords.TabIndex = 1;
            this.nudNumWords.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Minimum Password Length";
            // 
            // nudMinPasswordLength
            // 
            this.nudMinPasswordLength.Location = new System.Drawing.Point(209, 12);
            this.nudMinPasswordLength.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudMinPasswordLength.Minimum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.nudMinPasswordLength.Name = "nudMinPasswordLength";
            this.nudMinPasswordLength.Size = new System.Drawing.Size(63, 20);
            this.nudMinPasswordLength.TabIndex = 5;
            this.nudMinPasswordLength.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.nudMinPasswordLength.ValueChanged += new System.EventHandler(this.nudMinPasswordLength_ValueChanged);
            // 
            // nudMaxPasswordLength
            // 
            this.nudMaxPasswordLength.Location = new System.Drawing.Point(209, 38);
            this.nudMaxPasswordLength.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudMaxPasswordLength.Minimum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.nudMaxPasswordLength.Name = "nudMaxPasswordLength";
            this.nudMaxPasswordLength.Size = new System.Drawing.Size(63, 20);
            this.nudMaxPasswordLength.TabIndex = 7;
            this.toolTip1.SetToolTip(this.nudMaxPasswordLength, "The minimum word length may be modified to meet this criteria");
            this.nudMaxPasswordLength.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudMaxPasswordLength.ValueChanged += new System.EventHandler(this.nudMaxPasswordLength_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Maximum Password Length";
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(290, 196);
            this.Controls.Add(this.nudMaxPasswordLength);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudMinPasswordLength);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Options";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumWords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinPasswordLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxPasswordLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudMaxLength;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudMinLength;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudNumWords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudMinPasswordLength;
        private System.Windows.Forms.NumericUpDown nudMaxPasswordLength;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
