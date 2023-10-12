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
        public MainMenu mainForm { get; set; }
        public NoteView(MainMenu mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            (this.mainForm as MainMenu).Show();
            this.Close();
        }

        public void saveButton_Click(object sender, EventArgs e)
        {
            // najprawdopodobniej utwórz tutaj ten notemodel i przekaż go do listy na głównym menu
            NoteModel model = new NoteModel();
            model.NoteTitle = TitleTexBox.Text;
            model.NoteContent = DescriptionTextBox.Text;
            mainForm.note = model;

            mainForm.RefreshMethod();

            (this.mainForm as MainMenu).Show();
            this.Close();

        }
    }
}
