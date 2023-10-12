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
    public partial class NoteView : Form
    {
        public NoteModel Model { get; set; }

        public NoteView()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void saveButton_Click(object sender, EventArgs e)
        {
            // najprawdopodobniej utwórz tutaj ten notemodel i przekaż go do listy na głównym menu
            Model.NoteTitle = TitleTexBox.Text.ToString();
            Model.NoteContent = DescriptionTextBox.Text;
            MessageBox.Show(Model.NoteTitle, Model.NoteContent);
            Close();
        }
    }
}
