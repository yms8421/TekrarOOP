using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgeAdam.JumpeNumbe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstLeft.SelectionMode = SelectionMode.MultiSimple;//Control yardımıyla çoklu seçim
            lstRight.SelectionMode = SelectionMode.MultiSimple;
            for (int i = 100; i < 110; i++)
            {
                lstLeft.Items.Add(i + 1);
            }
        }

        private void btnAllRight_Click(object sender, EventArgs e)
        {
            lstRight.Items.AddRange(lstLeft.Items);
            lstLeft.Items.Clear();
        }

        private void btnAllLeft_Click(object sender, EventArgs e)
        {
            lstLeft.Items.AddRange(lstRight.Items);
            lstRight.Items.Clear();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            MoveItems(lstLeft, lstRight);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            MoveItems(lstRight, lstLeft);
        }

        private void MoveItems(ListBox from, ListBox to)
        {
            if (from.SelectedItem == null)
            {
                MessageBox.Show("Bir Öğe Seçiniz");
                return;
            }

            if (from.SelectedItems.Count > 1)
            {
                var itemsToMove = new object[from.SelectedItems.Count];
                from.SelectedItems.CopyTo(itemsToMove, 0);
                to.Items.AddRange(itemsToMove);
                foreach (var item in itemsToMove)
                {
                    from.Items.Remove(item);
                }
            }
            else
            {
                to.Items.Add(from.SelectedItem);
                from.Items.RemoveAt(from.SelectedIndex);
            }
        }
    }
}
