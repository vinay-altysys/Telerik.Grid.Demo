namespace TelerikGrid
{
    partial class NewForm
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            radGridView1 = new Telerik.WinControls.UI.RadGridView();
            btnExcelExport = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            btnSave = new Button();
            btnDiscard = new Button();
            btnPdfExport = new Button();
            ((System.ComponentModel.ISupportInitialize)radGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radGridView1.MasterTemplate).BeginInit();
            SuspendLayout();
            // 
            // radGridView1
            // 
            radGridView1.Location = new Point(30, 150);
            radGridView1.Margin = new Padding(75, 120, 162, 162);
            // 
            // 
            // 
            radGridView1.MasterTemplate.PageSize = 50;
            radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1;
            radGridView1.Name = "radGridView1";
            radGridView1.Size = new Size(1100, 300);
            radGridView1.TabIndex = 0;
            radGridView1.UserAddedRow += radGridView1_UserAddedRow;
            // 
            // btnExcelExport
            // 
            btnExcelExport.Location = new Point(925, 69);
            btnExcelExport.Name = "btnExcelExport";
            btnExcelExport.Size = new Size(119, 23);
            btnExcelExport.TabIndex = 1;
            btnExcelExport.Text = "Export To Excel";
            btnExcelExport.UseVisualStyleBackColor = true;
            btnExcelExport.Click += btnExcelExport_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(294, 12);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Find by Title";
            txtSearch.Size = new Size(263, 23);
            txtSearch.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(949, 11);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(107, 23);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save Changes";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDiscard
            // 
            btnDiscard.Location = new Point(1064, 11);
            btnDiscard.Name = "btnDiscard";
            btnDiscard.Size = new Size(119, 23);
            btnDiscard.TabIndex = 5;
            btnDiscard.Text = "Discard Changes";
            btnDiscard.UseVisualStyleBackColor = true;
            btnDiscard.Click += btnDiscard_Click;
            // 
            // btnPdfExport
            // 
            btnPdfExport.Location = new Point(1064, 69);
            btnPdfExport.Margin = new Padding(2, 2, 2, 2);
            btnPdfExport.Name = "btnPdfExport";
            btnPdfExport.Size = new Size(119, 23);
            btnPdfExport.TabIndex = 6;
            btnPdfExport.Text = "Export to PDF";
            btnPdfExport.UseVisualStyleBackColor = true;
            btnPdfExport.Click += btnPdfExport_Click;
            // 
            // NewForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1210, 595);
            Controls.Add(btnPdfExport);
            Controls.Add(btnDiscard);
            Controls.Add(btnSave);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnExcelExport);
            Controls.Add(radGridView1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "NewForm";
            Text = "NewForm";
            Load += NewForm_Load;
            ((System.ComponentModel.ISupportInitialize)radGridView1.MasterTemplate).EndInit();
            ((System.ComponentModel.ISupportInitialize)radGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Button btnExcelExport;
        private Button btnSearch;
        private TextBox txtSearch;
        private Button btnSave;
        private Button btnDiscard;
        private Button btnPdfExport;
    }
}