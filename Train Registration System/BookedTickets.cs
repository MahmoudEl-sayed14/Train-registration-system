using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Train_Registration_System
{
    public partial class BookedTickets : UserControl
    {
        readonly string email;
        readonly DataTable table = new DataTable();
        public BookedTickets(string email)
        {
            InitializeComponent();
            this.email = email;
        }
        private void BookedTickets_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Trip Name", typeof(string));
            table.Columns.Add("Tickets", typeof(string));
            dataGridView.DataSource = table;

            var ticket = new TripManager();

            if (email == "admin")
            {
                var trip = new TripManager();
                string[] trips = trip.GetAllTrips();

                if (trips.Length > 0)
                {
                    foreach (string Trip in trips)
                    {
                        string[]? tickets = ticket.GetAllBookedTickets(Trip); 
                        string result = string.Join(" ", tickets ?? Array.Empty<string>()); 
                        table.Rows.Add(Trip, result);
                    }
                }
            }
            else
            {
                List<string[]> bookedTickets = ticket.GetBookedTickets(email);
                if (bookedTickets != null)
                {
                    foreach (string[] tickets in bookedTickets)
                    {
                        table.Rows.Add(tickets);
                    }
                }
            }
        }
        private static void ResizeDataGridView(DataGridView dataGridView)
        {
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            int totalRowHeight = dataGridView.Rows.GetRowsHeight(DataGridViewElementStates.None);
            totalRowHeight += dataGridView.ColumnHeadersHeight + dataGridView.Margin.Vertical;
            dataGridView.Height = totalRowHeight;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private void DataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.CellStyle != null)
            {
                if (e.RowIndex % 2 == 0)
                    e.CellStyle.BackColor = Color.LightGray;
                else
                    e.CellStyle.BackColor = Color.White;
            }
        }
        private void DataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            ResizeDataGridView(dataGridView);
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void DataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            ResizeDataGridView(dataGridView);
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
