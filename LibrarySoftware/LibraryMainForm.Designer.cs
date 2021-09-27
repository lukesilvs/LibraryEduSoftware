namespace LibrarySoftware
{
    partial class LibraryMainForm
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
            this.btnReplacingBooks = new System.Windows.Forms.Button();
            this.btnFindingCallNumbers = new System.Windows.Forms.Button();
            this.btnIdentifyingAreas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReplacingBooks
            // 
            this.btnReplacingBooks.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnReplacingBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReplacingBooks.Font = new System.Drawing.Font("Adobe Hebrew", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReplacingBooks.ForeColor = System.Drawing.Color.White;
            this.btnReplacingBooks.Location = new System.Drawing.Point(411, 170);
            this.btnReplacingBooks.Name = "btnReplacingBooks";
            this.btnReplacingBooks.Size = new System.Drawing.Size(238, 50);
            this.btnReplacingBooks.TabIndex = 0;
            this.btnReplacingBooks.Text = "Replacing Books";
            this.btnReplacingBooks.UseVisualStyleBackColor = false;
            this.btnReplacingBooks.Click += new System.EventHandler(this.BtnReplacingBooks_Click);
            // 
            // btnFindingCallNumbers
            // 
            this.btnFindingCallNumbers.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnFindingCallNumbers.Enabled = false;
            this.btnFindingCallNumbers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindingCallNumbers.Font = new System.Drawing.Font("Adobe Hebrew", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindingCallNumbers.ForeColor = System.Drawing.Color.White;
            this.btnFindingCallNumbers.Location = new System.Drawing.Point(411, 344);
            this.btnFindingCallNumbers.Name = "btnFindingCallNumbers";
            this.btnFindingCallNumbers.Size = new System.Drawing.Size(238, 50);
            this.btnFindingCallNumbers.TabIndex = 1;
            this.btnFindingCallNumbers.Text = "Finding Call Numbers";
            this.btnFindingCallNumbers.UseVisualStyleBackColor = false;
            // 
            // btnIdentifyingAreas
            // 
            this.btnIdentifyingAreas.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnIdentifyingAreas.Enabled = false;
            this.btnIdentifyingAreas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIdentifyingAreas.Font = new System.Drawing.Font("Adobe Hebrew", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIdentifyingAreas.ForeColor = System.Drawing.Color.White;
            this.btnIdentifyingAreas.Location = new System.Drawing.Point(411, 256);
            this.btnIdentifyingAreas.Name = "btnIdentifyingAreas";
            this.btnIdentifyingAreas.Size = new System.Drawing.Size(238, 50);
            this.btnIdentifyingAreas.TabIndex = 2;
            this.btnIdentifyingAreas.Text = "Identifying Areas";
            this.btnIdentifyingAreas.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Hebrew", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(353, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome To Library Application";
            // 
            // LibraryMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIdentifyingAreas);
            this.Controls.Add(this.btnFindingCallNumbers);
            this.Controls.Add(this.btnReplacingBooks);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LibraryMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Main Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReplacingBooks;
        private System.Windows.Forms.Button btnFindingCallNumbers;
        private System.Windows.Forms.Button btnIdentifyingAreas;
        private System.Windows.Forms.Label label1;
    }
}

