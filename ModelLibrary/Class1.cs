using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary
{
    public class NoteModel
    {
        public NoteModel(string title, string content)
        {
            this.NoteTitle = title;
            this.NoteContent = content;
        }
        private string NoteTitle { get; set; }
        private string NoteContent { get; set; }
    }
}