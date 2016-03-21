namespace CatalogCards
{
    partial class frmCatalogCard
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
            this.lblFiction = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPublisherInfo = new System.Windows.Forms.Label();
            this.lblPages = new System.Windows.Forms.Label();
            this.lstSubjects = new System.Windows.Forms.ListBox();
            this.lblSummary = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFiction
            // 
            this.lblFiction.AutoSize = true;
            this.lblFiction.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiction.Location = new System.Drawing.Point(12, 12);
            this.lblFiction.Name = "lblFiction";
            this.lblFiction.Size = new System.Drawing.Size(0, 14);
            this.lblFiction.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(12, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 14);
            this.lblName.TabIndex = 1;
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.Location = new System.Drawing.Point(12, 288);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(0, 14);
            this.lblISBN.TabIndex = 2;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(116, 44);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(0, 14);
            this.lblAuthor.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(143, 58);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 14);
            this.lblTitle.TabIndex = 4;
            // 
            // lblPublisherInfo
            // 
            this.lblPublisherInfo.AutoSize = true;
            this.lblPublisherInfo.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublisherInfo.Location = new System.Drawing.Point(132, 72);
            this.lblPublisherInfo.Name = "lblPublisherInfo";
            this.lblPublisherInfo.Size = new System.Drawing.Size(0, 14);
            this.lblPublisherInfo.TabIndex = 5;
            // 
            // lblPages
            // 
            this.lblPages.AutoSize = true;
            this.lblPages.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPages.Location = new System.Drawing.Point(143, 86);
            this.lblPages.Name = "lblPages";
            this.lblPages.Size = new System.Drawing.Size(0, 14);
            this.lblPages.TabIndex = 6;
            // 
            // lstSubjects
            // 
            this.lstSubjects.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstSubjects.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSubjects.FormattingEnabled = true;
            this.lstSubjects.ItemHeight = 15;
            this.lstSubjects.Location = new System.Drawing.Point(116, 160);
            this.lstSubjects.Name = "lstSubjects";
            this.lstSubjects.Size = new System.Drawing.Size(465, 90);
            this.lstSubjects.TabIndex = 7;
            // 
            // lblSummary
            // 
            this.lblSummary.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummary.Location = new System.Drawing.Point(116, 111);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(465, 46);
            this.lblSummary.TabIndex = 8;
            this.lblSummary.Text = "   Summary: \r\n";
            // 
            // frmCatalogCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 311);
            this.Controls.Add(this.lblSummary);
            this.Controls.Add(this.lstSubjects);
            this.Controls.Add(this.lblPages);
            this.Controls.Add(this.lblPublisherInfo);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblFiction);
            this.Name = "frmCatalogCard";
            this.Text = "CatalogCard";
            this.Load += new System.EventHandler(this.frmCatalogCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFiction;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPublisherInfo;
        private System.Windows.Forms.Label lblPages;
        private System.Windows.Forms.ListBox lstSubjects;
        private System.Windows.Forms.Label lblSummary;
    }
}