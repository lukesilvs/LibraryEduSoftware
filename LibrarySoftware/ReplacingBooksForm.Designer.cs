namespace LibrarySoftware
{
    partial class ReplacingBooksForm
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
            this.components = new System.ComponentModel.Container();
            this.callNumberList = new System.Windows.Forms.DataGridView();
            this.serialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.callNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReorderAscending = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblProgressBarPercent = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.callNumberList)).BeginInit();
            this.SuspendLayout();
            // 
            // callNumberList
            // 
            this.callNumberList.AllowUserToAddRows = false;
            this.callNumberList.AllowUserToDeleteRows = false;
            this.callNumberList.AllowUserToResizeColumns = false;
            this.callNumberList.AllowUserToResizeRows = false;
            this.callNumberList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.callNumberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.callNumberList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serialNo,
            this.callNumber});
            this.callNumberList.Location = new System.Drawing.Point(14, 134);
            this.callNumberList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.callNumberList.Name = "callNumberList";
            this.callNumberList.ReadOnly = true;
            this.callNumberList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.callNumberList.Size = new System.Drawing.Size(478, 324);
            this.callNumberList.TabIndex = 0;
            this.callNumberList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.callNumberList_CellContentClick);
            this.callNumberList.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.CallNumberList_RowPostPaint);
            // 
            // serialNo
            // 
            this.serialNo.HeaderText = "Serial No.";
            this.serialNo.Name = "serialNo";
            this.serialNo.ReadOnly = true;
            // 
            // callNumber
            // 
            this.callNumber.DataPropertyName = "CallNumber";
            this.callNumber.HeaderText = "Call Number";
            this.callNumber.Name = "callNumber";
            this.callNumber.ReadOnly = true;
            // 
            // btnReorderAscending
            // 
            this.btnReorderAscending.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnReorderAscending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReorderAscending.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReorderAscending.ForeColor = System.Drawing.Color.White;
            this.btnReorderAscending.Location = new System.Drawing.Point(139, 25);
            this.btnReorderAscending.Name = "btnReorderAscending";
            this.btnReorderAscending.Size = new System.Drawing.Size(238, 50);
            this.btnReorderAscending.TabIndex = 1;
            this.btnReorderAscending.Text = "Reorder As Ascending";
            this.btnReorderAscending.UseVisualStyleBackColor = false;
            this.btnReorderAscending.Click += new System.EventHandler(this.BtnReorderAscending_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(139, 91);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(238, 23);
            this.progressBar.TabIndex = 2;
            this.progressBar.Visible = false;
            // 
            // timer
            // 
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // lblProgressBarPercent
            // 
            this.lblProgressBarPercent.AutoSize = true;
            this.lblProgressBarPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgressBarPercent.Location = new System.Drawing.Point(399, 94);
            this.lblProgressBarPercent.Name = "lblProgressBarPercent";
            this.lblProgressBarPercent.Size = new System.Drawing.Size(32, 20);
            this.lblProgressBarPercent.TabIndex = 3;
            this.lblProgressBarPercent.Text = "0%";
            this.lblProgressBarPercent.Visible = false;
            // 
            // ReplacingBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 473);
            this.Controls.Add(this.lblProgressBarPercent);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnReorderAscending);
            this.Controls.Add(this.callNumberList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "ReplacingBooksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ReplacingBooksForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.callNumberList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView callNumberList;
        private System.Windows.Forms.Button btnReorderAscending;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn callNumber;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblProgressBarPercent;
    }
}