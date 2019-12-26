namespace IUK_Management
{
    partial class DispatchForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.dataGridRtw = new System.Windows.Forms.DataGridView();
            this.dataGridKtw = new System.Windows.Forms.DataGridView();
            this.dataGridNef = new System.Windows.Forms.DataGridView();
            this.kCount = new System.Windows.Forms.Label();
            this.nCount = new System.Windows.Forms.Label();
            this.rCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRtw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKtw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNef)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dispatch";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(746, 469);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 2;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // dataGridRtw
            // 
            this.dataGridRtw.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridRtw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridRtw.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridRtw.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridRtw.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridRtw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRtw.Location = new System.Drawing.Point(21, 96);
            this.dataGridRtw.Name = "dataGridRtw";
            this.dataGridRtw.Size = new System.Drawing.Size(263, 309);
            this.dataGridRtw.TabIndex = 3;
            this.dataGridRtw.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridKtw
            // 
            this.dataGridKtw.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridKtw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridKtw.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridKtw.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridKtw.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridKtw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridKtw.Location = new System.Drawing.Point(289, 96);
            this.dataGridKtw.Name = "dataGridKtw";
            this.dataGridKtw.Size = new System.Drawing.Size(263, 309);
            this.dataGridKtw.TabIndex = 4;
            // 
            // dataGridNef
            // 
            this.dataGridNef.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridNef.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridNef.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridNef.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridNef.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridNef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridNef.Location = new System.Drawing.Point(558, 96);
            this.dataGridNef.Name = "dataGridNef";
            this.dataGridNef.Size = new System.Drawing.Size(263, 309);
            this.dataGridNef.TabIndex = 5;
            // 
            // kCount
            // 
            this.kCount.AutoSize = true;
            this.kCount.Location = new System.Drawing.Point(292, 424);
            this.kCount.Name = "kCount";
            this.kCount.Size = new System.Drawing.Size(35, 13);
            this.kCount.TabIndex = 6;
            this.kCount.Text = "KTW;";
            this.kCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nCount
            // 
            this.nCount.AutoSize = true;
            this.nCount.Location = new System.Drawing.Point(555, 424);
            this.nCount.Name = "nCount";
            this.nCount.Size = new System.Drawing.Size(31, 13);
            this.nCount.TabIndex = 7;
            this.nCount.Text = "NEF:";
            this.nCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rCount
            // 
            this.rCount.AutoSize = true;
            this.rCount.Location = new System.Drawing.Point(18, 424);
            this.rCount.Name = "rCount";
            this.rCount.Size = new System.Drawing.Size(36, 13);
            this.rCount.TabIndex = 8;
            this.rCount.Text = "RTW:";
            this.rCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rCount.Click += new System.EventHandler(this.Label4_Click);
            // 
            // DispatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(841, 504);
            this.Controls.Add(this.rCount);
            this.Controls.Add(this.nCount);
            this.Controls.Add(this.kCount);
            this.Controls.Add(this.dataGridNef);
            this.Controls.Add(this.dataGridKtw);
            this.Controls.Add(this.dataGridRtw);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.label1);
            this.Name = "DispatchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DispatchForm";
            this.Load += new System.EventHandler(this.DispatchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRtw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKtw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNef)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.DataGridView dataGridRtw;
        private System.Windows.Forms.DataGridView dataGridKtw;
        private System.Windows.Forms.DataGridView dataGridNef;
        private System.Windows.Forms.Label kCount;
        private System.Windows.Forms.Label nCount;
        private System.Windows.Forms.Label rCount;
    }
}