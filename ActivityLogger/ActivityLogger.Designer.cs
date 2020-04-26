namespace ActivityLogger
{
    partial class ActivityLogger
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
            this.lblBrandingLoggedin = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.txtCollectionBox = new System.Windows.Forms.TextBox();
            this.btnAddNote = new System.Windows.Forms.Button();
            this.btnClearNote = new System.Windows.Forms.Button();
            this.btnExitApp = new System.Windows.Forms.Button();
            this.btnPrintNote = new System.Windows.Forms.Button();
            this.btnEmailNote = new System.Windows.Forms.Button();
            this.txtNoteBox = new System.Windows.Forms.TextBox();
            this.lblSentConfirmation = new System.Windows.Forms.Label();
            this.btnCopyNotes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBrandingLoggedin
            // 
            this.lblBrandingLoggedin.AutoSize = true;
            this.lblBrandingLoggedin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrandingLoggedin.Location = new System.Drawing.Point(28, 40);
            this.lblBrandingLoggedin.Name = "lblBrandingLoggedin";
            this.lblBrandingLoggedin.Size = new System.Drawing.Size(226, 37);
            this.lblBrandingLoggedin.TabIndex = 0;
            this.lblBrandingLoggedin.Text = "Activity Logger";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(32, 94);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(285, 25);
            this.lblQuestion.TabIndex = 1;
            this.lblQuestion.Text = "What are you working on now ?";
            // 
            // txtCollectionBox
            // 
            this.txtCollectionBox.Location = new System.Drawing.Point(36, 429);
            this.txtCollectionBox.Multiline = true;
            this.txtCollectionBox.Name = "txtCollectionBox";
            this.txtCollectionBox.Size = new System.Drawing.Size(595, 430);
            this.txtCollectionBox.TabIndex = 6;
            // 
            // btnAddNote
            // 
            this.btnAddNote.Location = new System.Drawing.Point(36, 366);
            this.btnAddNote.Name = "btnAddNote";
            this.btnAddNote.Size = new System.Drawing.Size(100, 54);
            this.btnAddNote.TabIndex = 3;
            this.btnAddNote.Text = "+ ADD";
            this.btnAddNote.UseVisualStyleBackColor = true;
            this.btnAddNote.Click += new System.EventHandler(this.btnAddNote_Click);
            // 
            // btnClearNote
            // 
            this.btnClearNote.Location = new System.Drawing.Point(143, 366);
            this.btnClearNote.Name = "btnClearNote";
            this.btnClearNote.Size = new System.Drawing.Size(100, 54);
            this.btnClearNote.TabIndex = 4;
            this.btnClearNote.Text = "- CLEAR";
            this.btnClearNote.UseVisualStyleBackColor = true;
            this.btnClearNote.Click += new System.EventHandler(this.btnClearNote_Click);
            // 
            // btnExitApp
            // 
            this.btnExitApp.Location = new System.Drawing.Point(530, 872);
            this.btnExitApp.Name = "btnExitApp";
            this.btnExitApp.Size = new System.Drawing.Size(100, 54);
            this.btnExitApp.TabIndex = 9;
            this.btnExitApp.Text = "EXIT";
            this.btnExitApp.UseVisualStyleBackColor = true;
            this.btnExitApp.Click += new System.EventHandler(this.btnExitApp_Click);
            // 
            // btnPrintNote
            // 
            this.btnPrintNote.Location = new System.Drawing.Point(425, 872);
            this.btnPrintNote.Name = "btnPrintNote";
            this.btnPrintNote.Size = new System.Drawing.Size(100, 54);
            this.btnPrintNote.TabIndex = 8;
            this.btnPrintNote.Text = "PRINT";
            this.btnPrintNote.UseVisualStyleBackColor = true;
            this.btnPrintNote.Click += new System.EventHandler(this.btnPrintNote_Click);
            // 
            // btnEmailNote
            // 
            this.btnEmailNote.Location = new System.Drawing.Point(320, 872);
            this.btnEmailNote.Name = "btnEmailNote";
            this.btnEmailNote.Size = new System.Drawing.Size(100, 54);
            this.btnEmailNote.TabIndex = 7;
            this.btnEmailNote.Text = "EMAIL";
            this.btnEmailNote.UseVisualStyleBackColor = true;
            this.btnEmailNote.Click += new System.EventHandler(this.btnEmailNote_Click);
            // 
            // txtNoteBox
            // 
            this.txtNoteBox.Location = new System.Drawing.Point(36, 137);
            this.txtNoteBox.Multiline = true;
            this.txtNoteBox.Name = "txtNoteBox";
            this.txtNoteBox.Size = new System.Drawing.Size(595, 219);
            this.txtNoteBox.TabIndex = 2;
            // 
            // lblSentConfirmation
            // 
            this.lblSentConfirmation.AutoSize = true;
            this.lblSentConfirmation.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSentConfirmation.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblSentConfirmation.Location = new System.Drawing.Point(50, 887);
            this.lblSentConfirmation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSentConfirmation.Name = "lblSentConfirmation";
            this.lblSentConfirmation.Size = new System.Drawing.Size(252, 23);
            this.lblSentConfirmation.TabIndex = 10;
            this.lblSentConfirmation.Text = "SENT OK ! (Status 200)";
            this.lblSentConfirmation.Visible = false;
            // 
            // btnCopyNotes
            // 
            this.btnCopyNotes.Location = new System.Drawing.Point(249, 366);
            this.btnCopyNotes.Name = "btnCopyNotes";
            this.btnCopyNotes.Size = new System.Drawing.Size(100, 54);
            this.btnCopyNotes.TabIndex = 5;
            this.btnCopyNotes.Text = "COPY";
            this.btnCopyNotes.UseVisualStyleBackColor = true;
            this.btnCopyNotes.Click += new System.EventHandler(this.btnCopyNotes_Click);
            // 
            // ActivityLogger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 935);
            this.Controls.Add(this.btnCopyNotes);
            this.Controls.Add(this.lblSentConfirmation);
            this.Controls.Add(this.txtNoteBox);
            this.Controls.Add(this.btnEmailNote);
            this.Controls.Add(this.btnPrintNote);
            this.Controls.Add(this.btnExitApp);
            this.Controls.Add(this.btnClearNote);
            this.Controls.Add(this.btnAddNote);
            this.Controls.Add(this.txtCollectionBox);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblBrandingLoggedin);
            this.MaximumSize = new System.Drawing.Size(697, 991);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(697, 951);
            this.Name = "ActivityLogger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ActivityLogger";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBrandingLoggedin;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TextBox txtCollectionBox;
        private System.Windows.Forms.Button btnAddNote;
        private System.Windows.Forms.Button btnClearNote;
        private System.Windows.Forms.Button btnExitApp;
        private System.Windows.Forms.Button btnPrintNote;
        private System.Windows.Forms.Button btnEmailNote;
        private System.Windows.Forms.TextBox txtNoteBox;
        private System.Windows.Forms.Label lblSentConfirmation;
        private System.Windows.Forms.Button btnCopyNotes;
    }
}