using ADonet.Db;
using ADonet.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADonet.Services
{
    public enum ChoiseMaxMin { Max, Min }
    public enum MoreOrLess { More, Less }
    public class ItemService
    {
        private readonly VegetablesAndFruitsDbContext _dbContext;

        public ItemService(VegetablesAndFruitsDbContext dbContext) => 
            _dbContext = dbContext;

        private DataTable CreateFullTable()
        {
            var table = new DataTable();
            table.Columns.Add("Название");
            table.Columns.Add("Тип");
            table.Columns.Add("Цвет");
            table.Columns.Add("Калорийность");

            return table;
        }
        public void FillColorsComboBox(ComboBox comboBox)
        {
            comboBox.Items.Add("All Colors");

            foreach (var en in Enum.GetValues(typeof(Colors)))
            {
                comboBox.Items.Add(en);
            }
        }

        public void ShowAll(DataGridView dataGridView)
        {
            var list = _dbContext.Items.ToList();

            var table = CreateFullTable();

            foreach (var item in list)
            {
                table.Rows.Add(item.Name, item.Type, item.Color, item.Calories);
            }

            dataGridView.DataSource = table;
        }

        public void ShowNames(DataGridView dataGridView)
        {
            var list = _dbContext.Items.Select(x => x.Name).ToList();

            var table = new DataTable();
            table.Columns.Add("Название");

            foreach (var it in list)
            {
                table.Rows.Add(it);
            }

            dataGridView.DataSource = table;
        }

        public void ShowColors(DataGridView dataGridView)
        {
            var list = _dbContext.Items.Select(x => x.Color).Distinct().ToList();

            var table = new DataTable();
            table.Columns.Add("Цвета");

            foreach (var it in list)
            {
                table.Rows.Add(it);
            }

            dataGridView.DataSource = table;
        }

        public void ShowCountColors(DataGridView dataGridView)
        {
            var list = _dbContext.Items.Select(x => x.Color).Distinct().ToList();

            var dict = new Dictionary<Colors, int>();

            foreach (var it in list)
            {
                var count = _dbContext.Items.Count(c => c.Color == it);
                dict.Add(it, count);
            }

            var table = new DataTable();
            table.Columns.Add("Цвет");
            table.Columns.Add("Количество");

            foreach (var it in dict)
            {
                table.Rows.Add(it.Key, it.Value);
            }

            dataGridView.DataSource = table;
        }

        public void ShowRedOrYellowColors(DataGridView dataGridView)
        {
            var list = _dbContext.Items.Where(c => c.Color == Colors.Red || c.Color == Colors.Yellow).ToList();

            var table = CreateFullTable();

            foreach (var item in list)
            {
                table.Rows.Add(item.Name, item.Type, item.Color, item.Calories);
            }

            dataGridView.DataSource = table;
        }

        public void ShowCalories(ChoiseMaxMin? choiseMaxMin = null)
        {
            switch (choiseMaxMin)
            {
                case ChoiseMaxMin.Max:
                    var maxC = _dbContext.Items.Select(c => c.Calories).Max();
                    MessageBox.Show("Максимальная калорийность = " + maxC);
                    break;
                case ChoiseMaxMin.Min:
                    var minC = _dbContext.Items.Select(c => c.Calories).Min();
                    MessageBox.Show("Минимальная калорийность = " + minC);
                    break;
                default:
                    var count = _dbContext.Items.Count();
                    var average = _dbContext.Items.Select(c => c.Calories).Sum() / count;
                    MessageBox.Show("Средняя калорийность = " + average);
                    break;
            }
        }

        public void ShowCountVegetablesOrFruits(ComboBox comboBox, Types type)
        {
            string names = type switch
            {
                Types.Fruit => "фруктов",
                Types.Vegetable => "овощей",
                _ => ""
            };

            if (comboBox.SelectedItem is Colors)
            {
                var count = _dbContext.Items.Count(c => c.Type == type && c.Color == (Colors)comboBox.SelectedItem);
                MessageBox.Show($"Количество {names} заданого цвета = " + count);
            }
            else
            {
                var count = _dbContext.Items.Count(c => c.Type == type);
                MessageBox.Show($"Количество {names} всех цветов = " + count);
            }
        }

        public void ShowMoreOrLessCalories(DataGridView dataGridView, TextBox textBox, MoreOrLess moreOrLess)
        {
            var cal = TryConvertToInt(textBox);

            var list = moreOrLess switch
            {
                MoreOrLess.More => _dbContext.Items.Where(c => c.Calories >= cal).ToList(),
                MoreOrLess.Less => _dbContext.Items.Where(c => c.Calories <= cal).ToList(),
                _ => new()
            };

            var table = CreateFullTable();

            for (int i = 0; i < list.Count; i++)
            {
                table.Rows.Add(list[i].Name, list[i].Type, list[i].Color, list[i].Calories);
            }

            dataGridView.DataSource = table;
        }

        public void ShowBetweenCalories(DataGridView dataGridView, TextBox textBoxFrom, TextBox textBoxTo)
        {
            var calFrom = TryConvertToInt(textBoxFrom);
            var calTo = TryConvertToInt(textBoxTo);

            if (calFrom > calTo)
            {
                calTo = calFrom;
                textBoxTo.Text = calTo.ToString();
            }

            var list = _dbContext.Items.Where(c => c.Calories >= calFrom && c.Calories <= calTo).ToList();

            var table = CreateFullTable();

            for (int i = 0; i < list.Count; i++)
            {
                table.Rows.Add(list[i].Name, list[i].Type, list[i].Color, list[i].Calories);
            }

            dataGridView.DataSource = table;

        }

        private int TryConvertToInt(TextBox textBox)
        {
            int outInt = 0;
            try
            {
                outInt = Convert.ToInt32(textBox.Text);
            }
            catch (FormatException)
            {
                textBox.Text = "0";
            }

            return outInt;
        }

        public async Task FillTest()
        {
            var list = new List<Item> {
                new Item{ Id = Guid.NewGuid(), Name = "Помидор", Type = Types.Vegetable, Color = Colors.Red, Calories = 650 },
                new Item{ Id = Guid.NewGuid(), Name = "Огурец", Type = Types.Vegetable, Color = Colors.Green, Calories = 500 },
                new Item{ Id = Guid.NewGuid(), Name = "Банан", Type = Types.Fruit, Color = Colors.Yellow, Calories = 300 },
                new Item{ Id = Guid.NewGuid(), Name = "Яблоко", Type = Types.Fruit, Color = Colors.Red, Calories = 150 },
                new Item{ Id = Guid.NewGuid(), Name = "Слива", Type = Types.Fruit, Color = Colors.Violet, Calories = 100 }
            };

            foreach (var it in list)
            {
                _dbContext.Items.Add(it);
            }

            await _dbContext.SaveChangesAsync();
        }
    }
}
