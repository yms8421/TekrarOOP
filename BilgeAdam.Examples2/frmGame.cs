using BilgeAdam.Examples2.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BilgeAdam.Examples2
{
    public partial class frmGame : Form
    {
        public frmGame()
        {
            InitializeComponent();
            Game = new Game();
        }

        public Game Game { get; set; }
        private string selectedNumber;

        private void frmGame_Load(object sender, EventArgs e)
        {
            Game.CreateBoard(0, 0);
            CreatePanels();
        }

        private void CreatePanels()
        {
            int left = 20, top = 20;
            var rowIndex = 0;
            var columnIndex = 0;
            for (int i = 0; i < 9; i++)
            {
                if (columnIndex != 0 & columnIndex % 3 == 0)
                {
                    rowIndex++;
                    columnIndex = 0;
                }
                var p = new Panel();
                p.BorderStyle = BorderStyle.Fixed3D;
                p.BackColor = Color.White;
                p.Width = 200;
                p.Height = 200;
                p.Left = (p.Width * columnIndex) + left;
                p.Top = (p.Height * rowIndex) + top;
                CreateButtons(p);
                this.Controls.Add(p);
                columnIndex++;
            }
        }

        private void CreateButtons(Panel panel)
        {
            int left = 5, top = 5;
            var rowIndex = 0;
            var columnIndex = 0;
            for (int i = 0; i < 9; i++)
            {
                if (columnIndex != 0 & columnIndex % 3 == 0)
                {
                    rowIndex++;
                    columnIndex = 0;
                }
                var btn = new Button();
                btn.Width = 60;
                btn.Height = 60;
                btn.BackColor = Color.CadetBlue;
                btn.Left = (btn.Width * columnIndex) + left;
                btn.Top = (btn.Height * rowIndex) + top;
                btn.Click += Btn_Click;
                panel.Controls.Add(btn);
                columnIndex++;
            }

            //Button nesnelerinin Tag property'si işinizi belki kolaylaştırabilir
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            (sender as Button).Text = selectedNumber;
        }

        private void ChooseNumber(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                selectedNumber = (sender as Button).Text;
            }
        }
    }
}
