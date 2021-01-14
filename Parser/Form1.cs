using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await Task.Run(()=>this.StartParsing());
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormKeyEventHandler(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Enter:
                    button1_Click(sender, new EventArgs());
                    break;
                case Keys.Up:
                    if (this.StartEndNumber.Value < this.StartEndNumber.Maximum)
                        this.StartEndNumber.Value++;
                    break;
                case Keys.Down:
                    if(this.StartEndNumber.Value > this.StartEndNumber.Minimum)
                        this.StartEndNumber.Value--;
                    break;
            }
        }

        private void StartParsing()
        {
            IParseSettings parseSettings = new ParseSettings();
            parseSettings.PageClass = this.Class.Text.Trim(' ');
            parseSettings.Uri = this.link.Text;
            parseSettings.PageStartIndex = (int)this.StartIndexNumber.Value;
            parseSettings.PageEndIndex = (int)this.StartEndNumber.Value;

            Parse parse = new Parse(parseSettings);
            List<string> list = parse.StartParse();
            this.ListBox.Items.Clear();
            foreach(string str in list)
            {
                this.ListBox.Items.Add(str);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void StartIndexNumber_ValueChanged(object sender, EventArgs e)
        {
            if(this.StartIndexNumber.Value >= this.StartEndNumber.Value)
            {
                this.StartIndexNumber.Value = this.StartEndNumber.Value - 1;
            }
        }
    }
}
