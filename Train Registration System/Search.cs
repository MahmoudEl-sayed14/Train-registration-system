using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Train_Registration_System
{
    public partial class Search : UserControl 
    {
        DataTable table = new DataTable();
        Style style = new Style();
        public Search()
        {
            InitializeComponent();
            
            style.RoundButtonBorder(searchBtn);
            style.RoundButtonBorder(deleteTripBtn);

            table.Columns.Add("Trip Name", typeof(string));
            table.Columns.Add("Tickets", typeof(string));
            dataGridView.DataSource = table;
        }
        
        private void searchTextBox_Enter(object sender, EventArgs e)
        {
            searchPictureBox.Hide();
        }
        private void searchTextBox_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(searchTextBox.Text))
            {
                searchPictureBox.Show();
            }
        }
        private void ClearResults()
        {
            resultsListBox.Items.Clear();
            resultsListBox.Visible = false;
            UserDataPanel.Visible = false;
            TripPanel.Visible = false;
        }
        private void ShowResults()
        {
            resultsListBox.Items.Clear();
            resultsListBox.Visible = true;
        }
        private void AutoSizeListBox()
        {
            int itemHeight = resultsListBox.Font.Height;
            int listBoxHeight = 0;

            foreach (object item in resultsListBox.Items)
            {
                SizeF textSize = resultsListBox.CreateGraphics().MeasureString(item.ToString(), resultsListBox.Font);

                listBoxHeight += (int)textSize.Height;
            }

            listBoxHeight += resultsListBox.Items.Count * 2;

            resultsListBox.Height = listBoxHeight;

            resultsListBox.IntegralHeight = false;
        }
        private void resultsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? selectedData = resultsListBox.SelectedItem?.ToString();
            if (selectedData != null)
            {
                searchTextBox.Text = selectedData;
            }
        }
        private void ShowUserDataPanel(Dictionary<string, string> userData)
        {
            UserDataPanel.Visible = true;
            TripPanel.Visible = false;

            nameLabel.Text = $"Name: {userData["name"]}";
            emailLabel.Text = $"Email: {userData["email"]}";
            phoneLabel.Text = $"Phone: {userData["phone"]}";

            var bookedTickets = new TripManager().GetBookedTickets(userData["email"]);

            if (bookedTickets != null)
            {
                table.Rows.Clear();
                dataGridView.Visible = true;

                foreach (string[] tickets in bookedTickets)
                {
                    table.Rows.Add(tickets);
                }
            }
            else
            {
                dataGridView.Visible = false;
            }
        }
        private void deleteTripBtn_Click(object sender, EventArgs e)
        {
            if (deleteTripBtn.Tag != null)
            {
                string tripName = deleteTripBtn?.Tag?.ToString() ?? "";
                var trip = new TripManager();
                if (trip.DeleteTripData(tripName))
                {
                    style.ShowSuccess("Trip deleted successfully.");
                }
                else
                {
                    style.ShowError("Something went wrong");
                }
            }
        }
        private void ShowTripPanel(Dictionary<string, string> tripData)
        {
            TripPanel.Visible = true;
            UserDataPanel.Visible = false;
            if (tripData != null)
            {
                destinationLabel.Text = $"Destanation {tripData["to"]}";
                tripNameLabel.Text = $"Trip Name: {tripData["tripName"]}";
                stationLabel.Text = $"From: {tripData["from"]}";
                trainNoLabel.Text = $"Train Number: {tripData["trainNumber"]}";
                PlatformLabel.Text = $"Platform: {tripData["platformNumber"]}";
                dateLabel.Text = $"Date: {tripData["date"]}";
                timeLabel.Text = $"Time: {tripData["time"]}";
                priceLabel.Text = $"Price: {tripData["price"]}";
            }
        }
        public void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchTextBox.Text.ToLower();

            if (string.IsNullOrEmpty(searchText))
            {
                ClearResults();
                return;
            }

            ShowResults();

            var searchEngine = new SearchEngine();
            searchEngine.DisplaySearchSuggestions(searchText, resultsListBox);

            AutoSizeListBox();
        }
        private void searchBtn_Click(object sender, EventArgs e)
        {
            string searchText = searchTextBox.Text.ToLower();
            string type = "";
            var searchEngine = new SearchEngine();
            var result = searchEngine.DisplaySearchResults(searchText, ref type);

            if(type == "user")
            {
                ShowUserDataPanel(result);
            }else if (type == "trip")
            {
                ShowTripPanel(result);
                deleteTripBtn.Visible = true;
                deleteTripBtn.Tag = result["tripName"].ToString();
            }
           
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
        private static void ResizeDataGridView(DataGridView dataGridView)
        {
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            int totalRowHeight = dataGridView.Rows.GetRowsHeight(DataGridViewElementStates.None);
            totalRowHeight += dataGridView.ColumnHeadersHeight + dataGridView.Margin.Vertical;
            dataGridView.Height = totalRowHeight;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }
}

