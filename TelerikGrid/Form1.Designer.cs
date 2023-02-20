namespace TelerikGrid
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radGrid = new Telerik.WinControls.UI.RadGridView();
            this.btnExcelExport = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDiscard = new System.Windows.Forms.Button();
            this.btnPdfExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.radGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGrid.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // radGrid
            // 
            this.radGrid.Location = new System.Drawing.Point(30, 150);
            this.radGrid.Margin = new System.Windows.Forms.Padding(75, 120, 162, 162);
            // 
            // 
            // 
            this.radGrid.MasterTemplate.PageSize = 50;
            this.radGrid.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGrid.Name = "radGrid";
            this.radGrid.Size = new System.Drawing.Size(1100, 400);
            this.radGrid.TabIndex = 0;
            this.radGrid.UserAddedRow += new Telerik.WinControls.UI.GridViewRowEventHandler(this.radGrid_UserAddedRow);
            // 
            // btnExcelExport
            // 
            this.btnExcelExport.Location = new System.Drawing.Point(1322, 115);
            this.btnExcelExport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExcelExport.Name = "btnExcelExport";
            this.btnExcelExport.Size = new System.Drawing.Size(170, 38);
            this.btnExcelExport.TabIndex = 1;
            this.btnExcelExport.Text = "Export To Excel";
            this.btnExcelExport.UseVisualStyleBackColor = true;
            this.btnExcelExport.Click += new System.EventHandler(this.btnExcelExport_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(420, 20);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(107, 38);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(17, 20);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Find by Title";
            this.txtSearch.Size = new System.Drawing.Size(374, 31);
            this.txtSearch.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1356, 18);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(153, 38);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDiscard
            // 
            this.btnDiscard.Location = new System.Drawing.Point(1520, 18);
            this.btnDiscard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDiscard.Name = "btnDiscard";
            this.btnDiscard.Size = new System.Drawing.Size(170, 38);
            this.btnDiscard.TabIndex = 5;
            this.btnDiscard.Text = "Discard Changes";
            this.btnDiscard.UseVisualStyleBackColor = true;
            this.btnDiscard.Click += new System.EventHandler(this.btnDiscard_Click);
            // 
            // btnPdfExport
            // 
            this.btnPdfExport.Location = new System.Drawing.Point(1520, 115);
            this.btnPdfExport.Name = "btnPdfExport";
            this.btnPdfExport.Size = new System.Drawing.Size(170, 38);
            this.btnPdfExport.TabIndex = 6;
            this.btnPdfExport.Text = "Export to PDF";
            this.btnPdfExport.UseVisualStyleBackColor = true;
            this.btnPdfExport.Click += new System.EventHandler(this.btnPdfExport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1728, 992);
            this.Controls.Add(this.btnPdfExport);
            this.Controls.Add(this.btnDiscard);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnExcelExport);
            this.Controls.Add(this.radGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGrid.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGrid;
        private Button btnExcelExport;
        private Button btnSearch;
        private TextBox txtSearch;
        private Button btnSave;
        private Button btnDiscard;
        private Button btnPdfExport;
    }
}