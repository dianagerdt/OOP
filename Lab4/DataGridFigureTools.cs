using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Windows.Forms;
using System.ComponentModel;

namespace Lab3
{
    //TODO: naming +
    /// <summary>
    /// Класс для создания таблицы желаемого формата
    /// </summary>
    public static class DataGridFigureTools
    {
        /// <summary>
        /// Метод создания таблицы желаемого формата
        /// </summary>
        /// <param name="figures">Список конденсаторов</param>
        /// <param name="dataGridView">Таблица с фигурами</param>
        /// <summary>
        /// Метод создания таблицы 
        /// </summary>
        public static void CreateTable(BindingList<FigureBase> figures,
            DataGridView dataGridView)
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = figures;
            dataGridView.Columns[0].HeaderText = "Фигура";
            dataGridView.Columns[1].HeaderText = "Объём (м)";
            dataGridView.AutoSizeColumnsMode =
               DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
