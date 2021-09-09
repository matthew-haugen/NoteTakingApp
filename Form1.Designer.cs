
namespace NoteTakingApp
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
            this.tLabel = new System.Windows.Forms.Label();
            this.mLabel = new System.Windows.Forms.Label();
            this.tTxtBox = new System.Windows.Forms.TextBox();
            this.mTxtBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.newButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.readButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tLabel
            // 
            this.tLabel.AutoSize = true;
            this.tLabel.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tLabel.ForeColor = System.Drawing.Color.White;
            this.tLabel.Location = new System.Drawing.Point(76, 54);
            this.tLabel.Name = "tLabel";
            this.tLabel.Size = new System.Drawing.Size(84, 39);
            this.tLabel.TabIndex = 0;
            this.tLabel.Text = "Title";
            this.tLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // mLabel
            // 
            this.mLabel.AutoSize = true;
            this.mLabel.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mLabel.ForeColor = System.Drawing.Color.White;
            this.mLabel.Location = new System.Drawing.Point(12, 120);
            this.mLabel.Name = "mLabel";
            this.mLabel.Size = new System.Drawing.Size(148, 39);
            this.mLabel.TabIndex = 1;
            this.mLabel.Text = "Message";
            // 
            // tTxtBox
            // 
            this.tTxtBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tTxtBox.Font = new System.Drawing.Font("Yu Gothic Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tTxtBox.ForeColor = System.Drawing.Color.White;
            this.tTxtBox.Location = new System.Drawing.Point(165, 49);
            this.tTxtBox.Name = "tTxtBox";
            this.tTxtBox.Size = new System.Drawing.Size(304, 44);
            this.tTxtBox.TabIndex = 2;
            // 
            // mTxtBox
            // 
            this.mTxtBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mTxtBox.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mTxtBox.ForeColor = System.Drawing.Color.White;
            this.mTxtBox.Location = new System.Drawing.Point(165, 120);
            this.mTxtBox.Multiline = true;
            this.mTxtBox.Name = "mTxtBox";
            this.mTxtBox.Size = new System.Drawing.Size(304, 198);
            this.mTxtBox.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(514, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(250, 350);
            this.dataGridView1.TabIndex = 4;
            // 
            // newButton
            // 
            this.newButton.AutoSize = true;
            this.newButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.newButton.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.newButton.ForeColor = System.Drawing.Color.White;
            this.newButton.Location = new System.Drawing.Point(65, 362);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(94, 36);
            this.newButton.TabIndex = 5;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = false;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.AutoSize = true;
            this.saveButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.saveButton.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(169, 362);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(94, 36);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // readButton
            // 
            this.readButton.AutoSize = true;
            this.readButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.readButton.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.readButton.ForeColor = System.Drawing.Color.White;
            this.readButton.Location = new System.Drawing.Point(271, 362);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(94, 36);
            this.readButton.TabIndex = 7;
            this.readButton.Text = "Read";
            this.readButton.UseVisualStyleBackColor = false;
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.AutoSize = true;
            this.deleteButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.deleteButton.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(375, 362);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(94, 36);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.readButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.mTxtBox);
            this.Controls.Add(this.tTxtBox);
            this.Controls.Add(this.mLabel);
            this.Controls.Add(this.tLabel);
            this.Name = "Form1";
            this.Text = "Notes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tLabel;
        private System.Windows.Forms.Label mLabel;
        private System.Windows.Forms.TextBox tTxtBox;
        private System.Windows.Forms.TextBox mTxtBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.Button deleteButton;
    }
}

