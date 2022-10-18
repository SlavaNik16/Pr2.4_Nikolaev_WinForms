using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_4._2_Nikolaev_WinForms
{
    public partial class Form1 : Form
    {
        private decimal n, m;
        private int q;
        private int[,] mas;
        private int[] stroka;
        public Form1()
        {
            InitializeComponent();
        }

        private void butInput_Click(object sender, EventArgs e)
        {

            //Берем Строки(n) и Столбцы(m) из numericUpDown
            n = Nnum.Value;
            m = Mnum.Value;
            q = 0;
            stroka = new int[(int)(n)];
            //Очищаем DataGridView чтобы не добавлялись доп.ячейки
            DataGrid.Columns.Clear();
            mas = new int[(int)n, (int)m];
            //Цикл добавление столбцов
            for (int i = 0; i <= m; i++)
            {
                DataGrid.Columns.Add("", "");
                if (i > 0) DataGrid.Columns[i].HeaderText = (i - 1).ToString();
                DataGrid.Columns[i].Width = 40;

            }
            //Цикл добавление строк
            for (int j = 0; j < n; j++)
            {
                DataGrid.Rows.Add(j.ToString());
                DataGrid.Rows[j].Cells[0].ReadOnly = true; //Запрещаем изменять 
            }
            //Заполняем DataGridView по умолчанию каким-то знаком,
            //чтобы не вызывало исключений
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {

                   DataGrid.Rows[i].Cells[j+1].Style.BackColor = (i + j) % 2 == 0 ? Color.Yellow : Color.Orange;
                   DataGrid.Rows[i].Cells[j + 1].Value = "!";
                    
                }
            }
            //Отключаем сортировку
            foreach (DataGridViewColumn column in DataGrid.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            //Активируем кнопку вывода
            butOutput.Enabled = true;
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Запрещаем вводить буквы и другие знаки в ячейки
        private void DataGrid_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            
            if (DataGrid.CurrentCell.ColumnIndex == 1)
            {
                e.Control.KeyPress += new KeyPressEventHandler(DataGrid_KeyPress);
            }
        }
        private void DataGrid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }
        //
        private void butOutput_Click(object sender, EventArgs e)
        {
            int k = 0;
            int p;
            //Очищаем ListBox
            ResultListArray.Items.Clear();
            //Делаем проверку на то, что пользователь вел все ячейки значением
            p = Validate();
            if (p == 0)
            {
                //Находим строки в котором все числа отрицательны
                ValidateOtric();

                //Заполняем ListBox
                for (int i = 0; i < q; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        string r = $"{stroka[i]},{j}";
                        ResultListArray.Items.Add(r);
                    }
                }
                
                //Заполняем количество таких строк в TextBox
                CountBox.Text = q.ToString();
       
            }
            else
            {
                MessageBox.Show("Заполните все ячейки!!!", "Ошибка",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int Validate()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (DataGrid.Rows[i].Cells[j + 1].Value == "!")
                    {
                        return 1;
                    }
                }
               
            }
            return 0;
        }
        private void ValidateOtric()
        {
            int count = 0;
            q = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    try
                    {
                        mas[i, j] = int.Parse(DataGrid.Rows[i].Cells[j + 1].Value.ToString());
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Неверный  формат!!!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Close();
                    }

                    if (mas[i, j] < 0)
                    {
                        count++;
                    }
                    if (count == m)
                    {
                        count = 0;
                        stroka[q] = i;
                        q++;
                    }

                }
                count = 0;
            }
        }


    }
}
