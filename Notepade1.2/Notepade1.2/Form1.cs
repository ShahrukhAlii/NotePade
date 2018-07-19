using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepade1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            if (open.ShowDialog() == DialogResult.OK)
                richTextBox1.LoadFile(open.FileName, RichTextBoxStreamType.PlainText);
            this.Text = open.FileName;

                
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();

            save.Filter = " Text Document (*.txt) | *.txt ";
            if (save.ShowDialog() == DialogResult.OK)

                richTextBox1.SaveFile(save.FileName, RichTextBoxStreamType.PlainText) ;
            this.Text = save.FileName;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fontToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            font.Font = richTextBox1.SelectionFont;
            if (font.ShowDialog() == DialogResult.OK) {

                richTextBox1.SelectionFont = font.Font;
                
            }
        }

        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();

            if (color.ShowDialog() == DialogResult.OK) {


                richTextBox1.BackColor = color.Color;
            }
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is the new version of  Notpade");
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

          


            this.newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            this.openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            this.saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            this.cutToolStripMenuItem.ShortcutKeys =  Keys.Control | Keys.X;
            this.pasteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            this.undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            this.fontToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F;
            this.backgroundColorToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;

         

            

                

                

                
                

                
            



        }
    }
}
