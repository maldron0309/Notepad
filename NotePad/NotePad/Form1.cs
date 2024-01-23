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

namespace NotePad
{
    public partial class Notepad : Form
    {

        public Notepad()
        {
            InitializeComponent();
        }

        private void NotePad_Load(object sender, EventArgs e)
        {
        }

        private void NewTab_Click(object sender, EventArgs e)
        {
            text.Clear();
        }

        private void OpenTab_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                text.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.DefaultExt = ".txt";
            saveFileDialog.Filter = "Text File|*.txt";

            DialogResult dr = saveFileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, text.Text);
            }
        
        }

        private void SaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.DefaultExt = ".txt";
            saveFileDialog.Filter = "Text File|*.txt";

            DialogResult dr = saveFileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, text.Text);
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Cut_Click(object sender, EventArgs e)
        {
            text.Cut();
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            text.Copy();
        }

        private void Paste_Click(object sender, EventArgs e)
        {
            text.Paste();
        }

        private void Undo_Click(object sender, EventArgs e)
        {
            text.Undo();
        }

        private void Font_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                text.Font = fontDialog1.Font;
            }
        }

        private void backgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                text.BackColor = colorDialog1.Color;
            }
        }

        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                text.ForeColor = colorDialog1.Color;
            }
        }
    }

}
