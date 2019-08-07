﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_Final_Lesson_A_Part2.Views
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm document = new ChildForm();
            document.MdiParent = this;
            document.Text = $"Document {this.MdiChildren.Length}";
            document.Show();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolStripToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            toolStrip1.Visible = (toolStrip1.Visible)? false:true;
        }

        private void StatusBarToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            statusStrip1.Visible = (statusStrip1.Visible) ? false : true;
        }
    }
}
