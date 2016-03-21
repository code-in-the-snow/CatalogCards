namespace CatalogCards
{
    partial class frmSelectBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectBooks));
            this.radFiction = new System.Windows.Forms.RadioButton();
            this.radNonfiction = new System.Windows.Forms.RadioButton();
            this.lblISBN = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.btnMakeCard = new System.Windows.Forms.Button();
            this.grpFictionButtons = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpFictionButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // radFiction
            // 
            this.radFiction.AutoSize = true;
            this.radFiction.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFiction.Location = new System.Drawing.Point(6, 19);
            this.radFiction.Name = "radFiction";
            this.radFiction.Size = new System.Drawing.Size(66, 22);
            this.radFiction.TabIndex = 0;
            this.radFiction.Text = "Fiction";
            this.radFiction.UseVisualStyleBackColor = true;
            // 
            // radNonfiction
            // 
            this.radNonfiction.AutoSize = true;
            this.radNonfiction.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNonfiction.Location = new System.Drawing.Point(89, 19);
            this.radNonfiction.Name = "radNonfiction";
            this.radNonfiction.Size = new System.Drawing.Size(86, 22);
            this.radNonfiction.TabIndex = 1;
            this.radNonfiction.Text = "Nonfiction";
            this.radNonfiction.UseVisualStyleBackColor = true;
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.Location = new System.Drawing.Point(20, 170);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(105, 22);
            this.lblISBN.TabIndex = 2;
            this.lblISBN.Text = "ISBN number:";
            // 
            // txtISBN
            // 
            this.txtISBN.AcceptsReturn = true;
            this.txtISBN.Location = new System.Drawing.Point(145, 170);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(100, 20);
            this.txtISBN.TabIndex = 3;
            // 
            // lblInstructions
            // 
            this.lblInstructions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInstructions.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(20, 20);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(557, 120);
            this.lblInstructions.TabIndex = 4;
            this.lblInstructions.Text = resources.GetString("lblInstructions.Text");
            // 
            // btnMakeCard
            // 
            this.btnMakeCard.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeCard.Location = new System.Drawing.Point(20, 267);
            this.btnMakeCard.Name = "btnMakeCard";
            this.btnMakeCard.Size = new System.Drawing.Size(134, 30);
            this.btnMakeCard.TabIndex = 5;
            this.btnMakeCard.Text = "Preview Card";
            this.btnMakeCard.UseVisualStyleBackColor = true;
            this.btnMakeCard.Click += new System.EventHandler(this.btnMakeCard_Click);
            // 
            // grpFictionButtons
            // 
            this.grpFictionButtons.Controls.Add(this.radNonfiction);
            this.grpFictionButtons.Controls.Add(this.radFiction);
            this.grpFictionButtons.Location = new System.Drawing.Point(24, 195);
            this.grpFictionButtons.Name = "grpFictionButtons";
            this.grpFictionButtons.Size = new System.Drawing.Size(200, 50);
            this.grpFictionButtons.TabIndex = 6;
            this.grpFictionButtons.TabStop = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(231, 269);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(134, 30);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "Print Card";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(445, 269);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(134, 30);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmSelectBooks
            // 
            this.AcceptButton = this.btnMakeCard;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 311);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.grpFictionButtons);
            this.Controls.Add(this.btnMakeCard);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.lblISBN);
            this.Name = "frmSelectBooks";
            this.Text = "Select Books";
            this.grpFictionButtons.ResumeLayout(false);
            this.grpFictionButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radFiction;
        private System.Windows.Forms.RadioButton radNonfiction;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Button btnMakeCard;
        private System.Windows.Forms.GroupBox grpFictionButtons;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnExit;
    }
}

