﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StrongPassGenerator
{
    public partial class GeneratePasswordForm : Form
    {
        Password password = new Password();
        public GeneratePasswordForm()
        {
            InitializeComponent();
        }

        private void readHereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var about = new About();
            about.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            generatedPassword.Text = string.Empty;
            generatedPassword.Text = password.Generate(int.Parse(passwordLengthTextBox.Text),cbIncludeSymbols.Checked,cbIncludeNumbers.Checked,cbIncludeLowercase.Checked,cbIncludeUppercase.Checked, cbExcludeDuplicateChars.Checked, cbExcludeSimilarChars.Checked,cbExcludeAmbiguous.Checked);
            // Copy to clipboard to make it easier to use
            Clipboard.SetText(generatedPassword.Text);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Clipboard.SetText(generatedPassword.Text);
        }
    }
}
