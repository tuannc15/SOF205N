using BUS;
using DAL.Models;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace PRL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            dgvNoiDung.DataSource = XeMayServices.GetAll();

            dgvNoiDung.CellFormatting += GridCellFormatting;

            dgvNoiDung.Columns[0].Visible = false;
        }

        private void GridCellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvNoiDung.Columns[e.ColumnIndex].Name == "STT")
            {
                e.Value = (e.RowIndex + 1).ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}