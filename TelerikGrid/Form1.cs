using System.ComponentModel.Composition.Primitives;
using System.Data;
using System.Net.Http.Json;
using System.Reflection;
using Telerik.WinControls.Export;
using Telerik.WinControls.Svg;
using Telerik.WinControls.UI;
using Telerik.Windows.Documents.Spreadsheet.Expressions.Functions;
using TelerikGrid.Models;

namespace TelerikGrid
{
    public partial class Form1 : Form
    {
        static HttpClient client = new HttpClient();
        public List<Todo>? TodoList { get; set; }
        public List<Todo>? NewTodoLists { get; set; } = new List<Todo>();
        public List<Todo>? DeletedTodoList { get; set; } = new List<Todo>();
        public readonly string exportPath = "D:\\samplecode\\Telerik.Grid.Demo\\TelerikGrid\\Exports\\";
        public Form1()
        {
            
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            HttpResponseMessage response = await client.GetAsync("https://jsonplaceholder.typicode.com/todos");
            if (response.IsSuccessStatusCode)
            {
                TodoList = await response.Content.ReadFromJsonAsync<List<Todo>>();
            }
            var dataSource = TodoList.ToList(); //.Take(new Range(0, 50));
            LoadGrid(dataSource);

        }

        private void btnExcelExport_Click(object sender, EventArgs e)
        {
            GridViewSpreadExport spreadExporter = new GridViewSpreadExport(radGrid);
            SpreadExportRenderer exportRenderer = new SpreadExportRenderer();
            var file = $"export_{(new Random()).Next(1000)}.xlsx";
            spreadExporter.RunExport($"{exportPath}{file}", exportRenderer);
            MessageBox.Show($"File Saved to Export//{file}");
        }

        private void btnPdfExport_Click(object sender, EventArgs e)
        {
            GridViewPdfExport pdfExporter = new GridViewPdfExport(radGrid);
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
                radGrid.DataSource = dataSource;

                radGrid.EnableFiltering = true;

                radGrid.Columns[0].Width = 100;
                radGrid.Columns[1].Width = 100;
                radGrid.Columns[2].Width = 500;
                radGrid.Columns[3].Width = 50;
                radGrid.Columns[4].IsVisible = false;

                // Setting Props
                radGrid.AddNewRowPosition = SystemRowPosition.Top;
                radGrid.EnablePaging = true;

                radGrid.Columns[3].AllowSort = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("New Recrods Saved", "Alert");
        }

        private void radGrid_UserAddedRow(object sender, GridViewRowEventArgs e)
        {
        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            var dataSource = TodoList.ToList(); 
            LoadGrid(dataSource);
        }
    }
}