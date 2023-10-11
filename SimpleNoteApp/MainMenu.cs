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
        public MainMenu()
        {
            InitializeComponent();
        }

        private void addNewButton_Click(object sender, EventArgs e)
        {
            NoteView n = new NoteView();
            n.Show();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void notesList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
