namespace WebDraft1
{
    partial class HistoryForm
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
            this.hview = new System.Windows.Forms.ListView();
            this.URL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.htmlTextBX = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.statusCodelbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hview
            // 
            this.hview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.URL});
            this.hview.HideSelection = false;
            this.hview.Location = new System.Drawing.Point(38, 41);
            this.hview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hview.Name = "hview";
            this.hview.Size = new System.Drawing.Size(672, 341);
            this.hview.TabIndex = 0;
            this.hview.UseCompatibleStateImageBehavior = false;
            this.hview.View = System.Windows.Forms.View.Details;
            this.hview.SelectedIndexChanged += new System.EventHandler(this.hview_SelectedIndexChanged);
            // 
            // URL
            // 
            this.URL.Text = "URLS";
            this.URL.Width = 760;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "HISTORY";
            // 
            // htmlTextBX
            // 
            this.htmlTextBX.Location = new System.Drawing.Point(733, 41);
            this.htmlTextBX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.htmlTextBX.Name = "htmlTextBX";
            this.htmlTextBX.Size = new System.Drawing.Size(252, 297);
            this.htmlTextBX.TabIndex = 3;
            this.htmlTextBX.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(733, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "HTML";
            // 
            // statusCodelbl
            // 
            this.statusCodelbl.AutoSize = true;
            this.statusCodelbl.Location = new System.Drawing.Point(748, 378);
            this.statusCodelbl.Name = "statusCodelbl";
            this.statusCodelbl.Size = new System.Drawing.Size(79, 17);
            this.statusCodelbl.TabIndex = 5;
            this.statusCodelbl.Text = "statusCode";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(728, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Status Code";
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 424);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.statusCodelbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.htmlTextBX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hview);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HistoryForm";
            this.Text = "HistoryForm";
            this.Load += new System.EventHandler(this.HistoryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView hview;
        private System.Windows.Forms.ColumnHeader URL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox htmlTextBX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label statusCodelbl;
        private System.Windows.Forms.Label label4;
    }
}