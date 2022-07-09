namespace RandomQuotes
{
    partial class frm1
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
            this.btnShuffle = new System.Windows.Forms.Button();
            this.lbQuote = new System.Windows.Forms.Label();
            this.lbAuthor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnShuffle
            // 
            this.btnShuffle.Image = global::RandomQuotes.Properties.Resources.shuffle_smallest;
            this.btnShuffle.Location = new System.Drawing.Point(989, 468);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(83, 81);
            this.btnShuffle.TabIndex = 0;
            this.btnShuffle.UseVisualStyleBackColor = true;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // lbQuote
            // 
            this.lbQuote.AutoSize = true;
            this.lbQuote.Font = new System.Drawing.Font("Roboto", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuote.Location = new System.Drawing.Point(186, 162);
            this.lbQuote.Name = "lbQuote";
            this.lbQuote.Size = new System.Drawing.Size(715, 116);
            this.lbQuote.TabIndex = 1;
            this.lbQuote.Text = "THE QUOTE WILL GO HERE AND\r\nIT WILL BE EXCELLENT!";
            this.lbQuote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbAuthor
            // 
            this.lbAuthor.AutoSize = true;
            this.lbAuthor.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAuthor.Location = new System.Drawing.Point(728, 297);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(173, 33);
            this.lbAuthor.TabIndex = 2;
            this.lbAuthor.Text = "- Author Here";
            this.lbAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.lbAuthor);
            this.Controls.Add(this.lbQuote);
            this.Controls.Add(this.btnShuffle);
            this.Name = "frm1";
            this.Text = "Random Quotes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.Label lbQuote;
        private System.Windows.Forms.Label lbAuthor;
    }
}

