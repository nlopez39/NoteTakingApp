namespace NoteTakingAppCorrect
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TitleBox = new TextBox();
            NoteBox = new TextBox();
            DataGridView = new DataGridView();
            Save = new Button();
            New = new Button();
            Delete = new Button();
            Edit = new Button();
            Title = new Label();
            Note = new Label();
            ((System.ComponentModel.ISupportInitialize)DataGridView).BeginInit();
            SuspendLayout();
            // 
            // TitleBox
            // 
            TitleBox.Location = new Point(463, 41);
            TitleBox.Name = "TitleBox";
            TitleBox.Size = new Size(325, 23);
            TitleBox.TabIndex = 0;
            // 
            // NoteBox
            // 
            NoteBox.Location = new Point(463, 90);
            NoteBox.Multiline = true;
            NoteBox.Name = "NoteBox";
            NoteBox.Size = new Size(325, 348);
            NoteBox.TabIndex = 1;
            // 
            // DataGridView
            // 
            DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView.Location = new Point(12, 12);
            DataGridView.Name = "DataGridView";
            DataGridView.RowTemplate.Height = 25;
            DataGridView.Size = new Size(445, 350);
            DataGridView.TabIndex = 2;
            DataGridView.CellContentClick += DataGridView_CellContentClick;
            DataGridView.CellContentDoubleClick += DataGridView_CellContentDoubleClick;
            // 
            // Save
            // 
            Save.FlatStyle = FlatStyle.Popup;
            Save.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Save.Location = new Point(14, 368);
            Save.Name = "Save";
            Save.Size = new Size(197, 34);
            Save.TabIndex = 3;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // New
            // 
            New.FlatStyle = FlatStyle.Popup;
            New.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            New.Location = new Point(245, 408);
            New.Name = "New";
            New.Size = new Size(197, 34);
            New.TabIndex = 4;
            New.Text = "New";
            New.UseVisualStyleBackColor = true;
            New.Click += New_Click;
            // 
            // Delete
            // 
            Delete.FlatStyle = FlatStyle.Popup;
            Delete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Delete.Location = new Point(14, 408);
            Delete.Name = "Delete";
            Delete.Size = new Size(197, 34);
            Delete.TabIndex = 5;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // Edit
            // 
            Edit.FlatStyle = FlatStyle.Popup;
            Edit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Edit.Location = new Point(245, 368);
            Edit.Name = "Edit";
            Edit.Size = new Size(197, 34);
            Edit.TabIndex = 6;
            Edit.Text = "Edit";
            Edit.UseVisualStyleBackColor = true;
            Edit.Click += Edit_Click;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            Title.Location = new Point(468, 15);
            Title.Name = "Title";
            Title.Size = new Size(42, 19);
            Title.TabIndex = 7;
            Title.Text = "Title:";
            // 
            // Note
            // 
            Note.AutoSize = true;
            Note.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            Note.Location = new Point(468, 68);
            Note.Name = "Note";
            Note.Size = new Size(46, 19);
            Note.TabIndex = 8;
            Note.Text = "Note:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Note);
            Controls.Add(Title);
            Controls.Add(Edit);
            Controls.Add(Delete);
            Controls.Add(New);
            Controls.Add(Save);
            Controls.Add(DataGridView);
            Controls.Add(NoteBox);
            Controls.Add(TitleBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TitleBox;
        private TextBox NoteBox;
        private DataGridView DataGridView;
        private Button Save;
        private Button New;
        private Button Delete;
        private Button Edit;
        private Label Title;
        private Label Note;
    }
}