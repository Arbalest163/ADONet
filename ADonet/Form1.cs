using ADonet.Db;
using ADonet.Models;
using ADonet.Services;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADonet
{
    public partial class Form1 : Form
    {
        private ItemService _itemService;
        public Form1(ItemService service)
        {
            InitializeComponent();
            _itemService = service;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            _itemService.ShowAll(dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _itemService.ShowNames(dataGridView1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _itemService.ShowColors(dataGridView1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _itemService.ShowCalories(ChoiseMaxMin.Max);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _itemService.ShowCalories(ChoiseMaxMin.Min);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            _itemService.ShowCalories();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            _itemService.ShowCountVegetablesOrFruits(comboBox1, Types.Vegetable);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            _itemService.ShowCountVegetablesOrFruits(comboBox1, Types.Fruit);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            _itemService.ShowRedOrYellowColors(dataGridView1);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            _itemService.ShowCountColors(dataGridView1);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            _itemService.ShowMoreOrLessCalories(dataGridView1, textBox1, MoreOrLess.Less);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            _itemService.ShowMoreOrLessCalories(dataGridView1, textBox1, MoreOrLess.More);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            _itemService.ShowBetweenCalories(dataGridView1, textBoxFrom, textBoxTo);
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await _itemService.FillTest();
            _itemService.FillColorsComboBox(comboBox1);
        }
    }
}
