﻿using LloydsMinister.Transfer_en.LongTerm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LloydsMinister
{
    public partial class Transfer_LongTerm : Form
    {
        public Transfer_LongTerm()
        {
            InitializeComponent();
        }
        SpeechSynthesizer sp = new SpeechSynthesizer();
        private void read(string text)
        {
            sp.Dispose();
            sp = new SpeechSynthesizer();
            sp.SpeakAsync(text);
        }
        private void Transfer_LongTerm_Load(object sender, EventArgs e)
        {
            string text = ("First button on your left is Current First button on your Right is Simple Deposit  Last button on your Right is Back");
            read(text);
            btnTransferBack.Cursor = Cursors.Hand;
            btncurrent.Cursor = Cursors.Hand;
            btnextra1.Cursor = Cursors.Hand;
            btnextra2.Cursor = Cursors.Hand;
            btnextra3.Cursor = Cursors.Hand;
            btnsimple.Cursor = Cursors.Hand;
        }

        private void btncurrent_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transferlongcurrent menu = new Transferlongcurrent();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }

        private void btnsimple_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transferlongsimple menu = new Transferlongsimple();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }

        private void btnTransferBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            TransferMenu menu = new TransferMenu();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }
    }
}
