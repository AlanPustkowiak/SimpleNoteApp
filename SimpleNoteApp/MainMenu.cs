using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelLibrary;




namespace SimpleNoteApp
{
    public partial class MainMenu : Form
    {
        public NoteModel note { get; set; }
        public MainMenu()
        {
            InitializeComponent();
            WireUpList();
        }

        public void RefreshMethod()
        {
            WireUpList();
        }

        private void WireUpList()
        {
            notesList.DataSource = null;
            if (note != null)
            {
                notesList.Items.Add(note.NoteTitle);
            }
        }

        private void addNewButton_Click(object sender, EventArgs e)
        {
            NoteView n = new NoteView(this);
            n.Show();

            this.Hide();
            WireUpList();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int a = notesList.SelectedIndex;
            notesList.Items.RemoveAt(a);
        }

        private void notesList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
