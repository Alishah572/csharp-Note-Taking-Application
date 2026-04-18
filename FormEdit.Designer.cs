namespace Note_Taking_App
{
    partial class FormEdit
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
            btnConfirm = new Button();
            editTitle = new TextBox();
            label1 = new Label();
            label2 = new Label();
            editNote = new TextBox();
            SuspendLayout();
            // 
            // btnConfirm
            // 
            btnConfirm.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnConfirm.BackColor = Color.Wheat;
            btnConfirm.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnConfirm.Location = new Point(37, 325);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(306, 48);
            btnConfirm.TabIndex = 0;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // editTitle
            // 
            editTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            editTitle.BackColor = Color.PaleGoldenrod;
            editTitle.Location = new Point(37, 48);
            editTitle.Name = "editTitle";
            editTitle.Size = new Size(306, 27);
            editTitle.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Wheat;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label1.Location = new Point(37, 16);
            label1.Name = "label1";
            label1.Size = new Size(144, 25);
            label1.TabIndex = 2;
            label1.Text = "Enter new Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Wheat;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label2.Location = new Point(36, 92);
            label2.Name = "label2";
            label2.Size = new Size(150, 25);
            label2.TabIndex = 3;
            label2.Text = "Enter new Note";
            // 
            // editNote
            // 
            editNote.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            editNote.BackColor = Color.PaleGoldenrod;
            editNote.Location = new Point(36, 127);
            editNote.Multiline = true;
            editNote.Name = "editNote";
            editNote.Size = new Size(306, 174);
            editNote.TabIndex = 4;
            // 
            // FormEdit
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Goldenrod;
            ClientSize = new Size(392, 400);
            Controls.Add(editNote);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(editTitle);
            Controls.Add(btnConfirm);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MinimumSize = new Size(410, 447);
            Name = "FormEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfirm;
        private TextBox editTitle;
        private Label label1;
        private Label label2;
        private TextBox editNote;
    }
}