using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Lib;



namespace Rybch_proga
{
    public partial class MainForm : Form
    {
        Cezar Me = new Cezar();
        Visn Mee = new Visn();

        public MainForm()

        {
            InitializeComponent();
        }

        private string name;


        private void bWork_Click(object sender, EventArgs e)
        {
            if (bCezar.Checked)
            {
                tTo.Text = Me.Codeс(tFrom.Text, (int)nKey.Value);
            }
            if (bVisn.Checked)
            {
                tTo.Text = Mee.Encode(tFrom.Text, tKey.Text);
            }
            if (bCezar.Checked == false && bVisn.Checked == false)
            {
                tTo.Text = "Виберіть метод шифрування";
            }
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            if (bCezar.Checked)
            {
                tTo.Text = Me.Codeс(tFrom.Text, -(int)nKey.Value);
            }
            if (bVisn.Checked)
            {
                tTo.Text = Mee.Decode(tFrom.Text, tKey.Text);
            }
            if (bCezar.Checked == false && bVisn.Checked == false)
            {
                tTo.Text = "Виберіть метод дешифрування";
            }
        }


        private void tlExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Припинити роботу застосунку?",
            "Припинити роботу", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            tFrom.Text = string.Empty;
            tTo.Text = string.Empty;
            tKey.Text = string.Empty;
            nKey.Value = 0;
        }


        private void інформаціяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Программа вміє шифрувати методами:\n\r• Цезаря (англійською, українською, російською а також числа та деякі знаки)\n\r• Віжинера (Поки що тільки українською, якщо необхідні ще мови - звертатися до разробника) \n\r\n\r\n\rАвтор программы: \n\rстудент 205 группи Рибченко Сергій", "Інформація про застосунок",
             MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK);
        }

        private void tlOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                name = openFileDialog1.FileName;
                tFrom.Clear();
                tFrom.Text = File.ReadAllText(name);
            }
        }

        private void tlSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                name = saveFileDialog1.FileName;
                File.WriteAllText(name, tTo.Text);
            }
        }
    }
}
