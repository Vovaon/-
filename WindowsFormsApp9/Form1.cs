using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            // Встановлення кількості стовпців і рядків
            dataGridView1.ColumnCount = 10;
            dataGridView1.RowCount = 10;


        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Зміна кольору головної діагоналі на червоний
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Cells[i].Style.BackColor = Color.Red;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Стирання всіх клітинок та зміна кольору клітинок під головною діагоналлю на червоний
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                // Стирання всіх клітинок
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.White;
                }

                // Зміна кольору клітинок під головною діагоналлю на червоний
                for (int j = i + 1; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Red;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {  // Стирання всіх клітинок та зміна кольору клітинок під головною діагоналлю на червоний
            for (int i = dataGridView1.RowCount - 1; i >= 0; i--)
            {
                // Стирання всіх клітинок
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.White;
                }

                // Зміна кольору клітинок під головною діагоналлю на червоний
                for (int j = dataGridView1.RowCount - i; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Red;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Стирання всіх клітинок та зміна кольору клітинок під головною діагоналлю на червоний
            for (int i = dataGridView1.RowCount - 1; i >= 0; i--)
            {
                // Стирання всіх клітинок
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.White;
                }

                // Зміна кольору клітинок під головною діагоналлю на червоний
                for (int j = 0; j < i; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Red;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Стирання вмісту всіх клітинок
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = null;
                }
            }

            // Зафарбовування побічної діагоналі на червоний
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Cells[dataGridView1.ColumnCount - i - 1].Style.BackColor = Color.Red;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Стирання вмісту всіх клітинок
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = null;
                }
            }

            // Зафарбування клітинок над побічною діагоналлю на червоний
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    dataGridView1.Rows[j].Cells[i - j - 1].Style.BackColor = Color.Red;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Стирання вмісту всіх клітинок
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = null;
                }
            }

            // Зафарбування верхньої половини таблиці на червоний
            for (int i = 0; i < dataGridView1.RowCount / 2; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Red;
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Стирання вмісту всіх клітинок
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = null;
                }
            }

            // Зафарбування нижньої половини таблиці на червоний
            for (int i = dataGridView1.RowCount / 2; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Red;
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Стирання вмісту всіх клітинок
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = null;
                }
            }

            // Зафарбування правої половини таблиці на червоний
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = dataGridView1.ColumnCount / 2; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Red;
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // Стирання вмісту всіх клітинок
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = null;
                }
            }

            // Зафарбування лівої половини таблиці на червоний
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount / 2; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Red;
                }
            }
        }
    }
}
    
