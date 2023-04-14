using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using TelerikGrid.Models;

namespace TelerikGrid
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {

        static HttpClient client = new HttpClient();
        public List<Todo>? TodoList { get; set; } 
        public RadForm1()
        {
            InitializeComponent();

            GridViewSummaryRowItem summary = new GridViewSummaryRowItem();
            summary.Add(new GridViewSummaryItem("total", "{0} Items", GridAggregateFunction.Count));
            radGridView1.MasterTemplate.ShowTotals = true;

            //this.radGridView1.MasterTemplate.ShowTotals = true;
            this.radGridView1.SummaryRowsBottom.Add(summary);
            this.radGridView1.MasterView.SummaryRows[0].PinPosition = PinnedRowPosition.Bottom;

            //radGridView1.DataSource = GetTable();
            var task = Task.Run(() => client.GetAsync("https://jsonplaceholder.typicode.com/todos"));
            task.Wait();
            HttpResponseMessage response = task.Result;
            if (response.IsSuccessStatusCode)
            {
                ReadData(response);
            }
            var dataSource = TodoList.ToList();
            this.radGridView1.DataSource = dataSource;

            //radGridView1.Rows.ed.IsInEditMode = false;

            //this.radGridView1.SummaryRowsBottom.Remove(summary);
            //summary = new GridViewSummaryRowItem();
            //summary.Add(new GridViewSummaryItem("total", "{0} Items", GridAggregateFunction.Count));
            //this.radGridView1.SummaryRowsBottom.Add(summary);
            //this.radGridView1.MasterView.SummaryRows[0].PinPosition = PinnedRowPosition.Bottom;

            radGridView1.MasterView.Refresh();
            radGridView1.TableElement.Update(GridUINotifyAction.Reset);

            //var row = radGridView1.Rows.AddNew();
            //row.IsPinned = true;
            //row.PinPosition = PinnedRowPosition.Bottom;
            //row.Cells[0].Value = radGridView1.Rows.Count + " Items";
            //radGridView1.MasterView.MasterGridViewTemplate.Update(GridUINotifyAction.DataChanged);

            var newRow = radGridView1.Rows.AddNew();
            newRow.PinPosition = PinnedRowPosition.Top;
            
        }

        private async void ReadData(HttpResponseMessage response)
        {
            TodoList = await response.Content.ReadFromJsonAsync<List<Todo>>();
        }
        static DataTable GetTable()
        {

            DataTable table = new DataTable();
            table.Columns.Add("total", typeof(int));
            table.Columns.Add("Drug", typeof(string));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Date", typeof(DateTime));

            for (int i = 0; i < 10; i++)
            {


                table.Rows.Add(25, "Indocin", "David", DateTime.Now);
                table.Rows.Add(50, "Enebrel", "Sam", DateTime.Now);
                table.Rows.Add(10, "Hydralazine", "Christoff", DateTime.Now);
                table.Rows.Add(21, "Combivent", "Janet", DateTime.Now);

                table.Rows.Add(100, "Dilantin", "Melanie", DateTime.Now);
            }
            return table;
        }

    }

    public class ListtoDataTableConverter
    {
        public DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);
            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }
    }

}
