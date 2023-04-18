using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.Export;
using Telerik.WinControls.UI;
using Telerik.Windows.Diagrams.Core;
using TelerikGrid.Models;

namespace TelerikGrid
{
    public partial class NewForm : Form
    {
        static HttpClient client = new HttpClient();
        public List<Todo>? TodoList { get; set; }
        public List<Todo>? NewTodoLists { get; set; } = new List<Todo>();
        public List<Todo>? DeletedTodoList { get; set; } = new List<Todo>();
        public readonly string exportPath = "D:\\samplecode\\Telerik.Grid.Demo\\TelerikGrid\\Exports\\";
        private RadContextMenu contextMenu;
        public NewForm()
        {
            contextMenu = new RadContextMenu();
            RadMenuItem menuItem1 = new RadMenuItem("Item 1");
            menuItem1.ForeColor = Color.Red;
            menuItem1.Click += new EventHandler(menuItem1_Click);
            RadMenuItem menuItem2 = new RadMenuItem("Item 2");
            menuItem2.Click += new EventHandler(menuItem2_Click);
            contextMenu.Items.Add(menuItem1);
            contextMenu.Items.Add(menuItem2);

            InitializeComponent();

            radGridView1.ContextMenuOpening += radGridView1_ContextMenuOpening;

        }

        private void radGridView1_ContextMenuOpening(object sender, ContextMenuOpeningEventArgs e)
        {
            e.ContextMenu = contextMenu.DropDown;
        }

        void menuItem2_Click(object sender, EventArgs e)
        {

        }
        void menuItem1_Click(object sender, EventArgs e)
        {

        }

        private async void NewForm_Load(object sender, EventArgs e)
        {
            HttpResponseMessage response = await client.GetAsync("https://jsonplaceholder.typicode.com/todos");
            if (response.IsSuccessStatusCode)
            {
                TodoList = await response.Content.ReadFromJsonAsync<List<Todo>>();
            }
            var dataSource = TodoList.ToList(); //.Take(new Range(0, 50));
            LoadGrid(dataSource);

            //this.radGridView1.AllowSearchRow = true;
            //this.radGridView1.ShowRowHeaderColumn = true;



            //GridViewSummaryItem summaryItemCounts = new GridViewSummaryItem("id", "{0}", GridAggregateFunction.Count);
            ////GridViewSummaryItem summaryItemFreight = new GridViewSummaryItem("Freight", "Max Freight = {0}", GridAggregateFunction.Max);
            //GridViewSummaryRowItem summaryRowItem = new GridViewSummaryRowItem(
            //    new GridViewSummaryItem[] { summaryItemCounts });
            //this.radGridView1.SummaryRowsBottom.Add(summaryRowItem);



            GridViewSummaryItem summaryItem = new GridViewSummaryItem("id", "Total Rows:{0}", GridAggregateFunction.Count);
            //CustomSummaryItem summaryItemCustom = new CustomSummaryItem("id", "Checking the row text.", GridAggregateFunction.Var);
            GridViewSummaryRowItem summaryRowItem = new GridViewSummaryRowItem();
            summaryRowItem.Add(summaryItem);
           //summaryRowItem.Add(summaryItemCustom);
            this.radGridView1.SummaryRowsBottom.Add(summaryRowItem);

            this.radGridView1.MasterTemplate.ShowTotals = true;
            this.radGridView1.MasterView.SummaryRows[0].PinPosition = PinnedRowPosition.Bottom;
            this.radGridView1.MasterTemplate.BottomPinnedRowsMode = GridViewBottomPinnedRowsMode.Fixed;



           // GridViewSummaryItem summaryItem = new GridViewSummaryItem("id", "Total Rows:{0}", GridAggregateFunction.Count);
            CustomSummaryItem summaryItemCustom = new CustomSummaryItem("id", "The low id are {0}.", GridAggregateFunction.Count);
            GridViewSummaryRowItem summaryRowItem1 = new GridViewSummaryRowItem();
            // summaryRowItem.Add(summaryItem);
            summaryRowItem1.Add(summaryItemCustom);
            this.radGridView1.SummaryRowsBottom.Add(summaryRowItem1);

            this.radGridView1.MasterTemplate.ShowTotals = true;
            this.radGridView1.MasterView.SummaryRows[1].PinPosition = PinnedRowPosition.Bottom;
            this.radGridView1.MasterTemplate.BottomPinnedRowsMode = GridViewBottomPinnedRowsMode.Fixed;



            //GridViewSummaryRowItem summary = new GridViewSummaryRowItem();
            //summary.Add(new GridViewSummaryItem("total", "{0:#,###}", GridAggregateFunction.Sum));


            //this.radGridView1.MasterTemplate.ShowTotals = true;
            //this.radGridView1.SummaryRowsBottom.Add(summary);
            //this.radGridView1.MasterView.SummaryRows[0].PinPosition = PinnedRowPosition.Bottom;
            //this.radGridView1.MasterTemplate.BottomPinnedRowsMode = GridViewBottomPinnedRowsMode.Fixed;

        }


        //void CustomSummaryItemUsage()
        //{
        //    CustomSummaryItem summaryItem = new CustomSummaryItem("id", "Checking the row text.", GridAggregateFunction.Var);
        //    GridViewSummaryRowItem summaryRowItem = new GridViewSummaryRowItem();
        //    summaryRowItem.Add(summaryItem);
        //    this.radGridView1.SummaryRowsTop.Add(summaryRowItem);
        //}


        private void btnExcelExport_Click(object sender, EventArgs e)
        {
            GridViewSpreadExport spreadExporter = new GridViewSpreadExport(radGridView1);
            SpreadExportRenderer exportRenderer = new SpreadExportRenderer();
            var file = $"export_{(new Random()).Next(1000)}.xlsx";
            spreadExporter.RunExport($"{exportPath}{file}", exportRenderer);
            MessageBox.Show($"File Saved to Export//{file}");
        }

        private void btnPdfExport_Click(object sender, EventArgs e)
        {
            GridViewPdfExport pdfExporter = new GridViewPdfExport(radGridView1);
            PdfExportRenderer renderer = new PdfExportRenderer();
            var file = $"export_{(new Random()).Next(1000)}.pdf";
            pdfExporter.RunExport($"{exportPath}{file}", renderer);
            MessageBox.Show($"File Saved to Export//{file}");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var dataSource = TodoList.Where(todo => todo.title.Contains(txtSearch.Text)).ToList(); //.Take(new Range(0, 50));
            LoadGrid(dataSource);
        }

        private void LoadGrid(IEnumerable<Todo> dataSource)
        {
            if (dataSource.Count() > 0)
            {
                radGridView1.DataSource = dataSource;

                radGridView1.EnableFiltering = false;

                radGridView1.Columns[0].Width = 100;
                radGridView1.Columns[1].Width = 100;
                radGridView1.Columns[2].Width = 500;
                radGridView1.Columns[3].Width = 50;
                radGridView1.Columns[4].IsVisible = false;

                // Setting Props
                radGridView1.AddNewRowPosition = SystemRowPosition.Top;
                radGridView1.EnablePaging = true;

                radGridView1.Columns[3].AllowSort = false;

                //
                //radGridView1.Rows.Clear();
                //radGridView1.Rows.AddNew();
                //radGridView1.AllowAddNewRow = false;
                //radGridView1.Columns.ForEach(col =>
                //{
                //    col.DataType = typeof(string);
                //});
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("New Recrods Saved", "Alert");
        }

        private void radGridView1_UserAddedRow(object sender, GridViewRowEventArgs e)
        {
        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            var dataSource = TodoList.ToList();
            LoadGrid(dataSource);
        }
    }



   
    public class CustomSummaryItem : GridViewSummaryItem
    {
        public CustomSummaryItem(string name,string formatString, GridAggregateFunction aggregate)
            : base(name, formatString, aggregate)
        { }
        public override object Evaluate(IHierarchicalRow row)
        {
            int lowFreightsCount = 0;
            foreach (GridViewRowInfo childRow in row.ChildRows)
            {
                if ((int)childRow.Cells["id"].Value > 40)
                {
                    lowFreightsCount++;
                }
            }
            return lowFreightsCount;
        }
    }

}
