using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notes
{
    public partial class Notes : Form
    {
        //
        //varible
        //
        DataTable notes = new DataTable();
        bool editing = false;
        public Notes()
        {
            InitializeComponent();
        }

        private void Notes_Load(object sender, EventArgs e)
        {
            notes.Columns.Add("Title");
            notes.Columns.Add("Note");

            previous.DataSource = notes;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //
        //delete button
        //
        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                notes.Rows[previous.CurrentCell.RowIndex].Delete();
            }
            catch (Exception ex) { Console.WriteLine("Note a valid note"); }
        }

        //
        //Load Button
        //
        private void Load_Click(object sender, EventArgs e)
        {
            titleBox.Text = notes.Rows[previous.CurrentCell.RowIndex].ItemArray[0].ToString();
            noteBox.Text = notes.Rows[previous.CurrentCell.RowIndex].ItemArray[1].ToString();
            editing = true;
        }

        //
        //button Save
        //
        private void Save_Click(object sender, EventArgs e)
        {
            if (editing)
            {
                notes.Rows[previous.CurrentCell.RowIndex]["Title"] = titleBox.Text;
                notes.Rows[previous.CurrentCell.RowIndex]["Note"] = noteBox.Text;
            }
            else
            {
                notes.Rows.Add(titleBox.Text, noteBox.Text);
            }
            titleBox.Text = "";
            noteBox.Text = "";
            editing = false;
        }

        //
        //New button
        //
        private void New_Click(object sender, EventArgs e)
        {
            titleBox.Text = "";
            noteBox.Text = "";
        }

        //
        //previes_celldoubleclick
        //
        private void previes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            titleBox.Text = notes.Rows[previous.CurrentCell.RowIndex].ItemArray[0].ToString();
            noteBox.Text = notes.Rows[previous.CurrentCell.RowIndex].ItemArray[1].ToString();
            editing = true;
        }
    }
}
