namespace SimpleNoteApp
{
    partial class MainMenu
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
            this.addNewButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.notesList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // addNewButton
            // 
            this.addNewButton.Location = new System.Drawing.Point(32, 13);
            this.addNewButton.Name = "addNewButton";
            this.addNewButton.Size = new System.Drawing.Size(139, 50);
            this.addNewButton.TabIndex = 0;
            this.addNewButton.Text = "Add new";
            this.addNewButton.UseVisualStyleBackColor = true;
            this.addNewButton.Click += new System.EventHandler(this.addNewButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(586, 13);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(139, 50);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // notesList
            // 
            this.notesList.FormattingEnabled = true;
            this.notesList.Location = new System.Drawing.Point(32, 78);
            this.notesList.Name = "notesList";
            this.notesList.Size = new System.Drawing.Size(693, 511);
            this.notesList.TabIndex = 2;
            this.notesList.SelectedIndexChanged += new System.EventHandler(this.notesList_SelectedIndexChanged);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 624);
            this.Controls.Add(this.notesList);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addNewButton);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addNewButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ListBox notesList;
    }
}

