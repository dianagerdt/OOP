using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace Lab3
{
    /// <summary>
    /// Класс главная форма
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Инициализация формы
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false;
            DataFigureView.AllowUserToAddRows = false;
            DataFigureView.RowHeadersVisible = false;
            DropFilterButton.Enabled = false;

        }

        /// <summary>
		/// Cписок фигур
		/// </summary>
		private BindingList<FigureBase> _figureList = 
            new BindingList<FigureBase>();

        /// <summary>
        /// Лист фильтрованных фигур
        /// </summary>
        private readonly BindingList<FigureBase> _listForSearch = 
            new BindingList<FigureBase>();


        /// <summary>
        /// Для файлов
        /// </summary>
        private readonly XmlSerializer _serializer = 
            new XmlSerializer(typeof(BindingList<FigureBase>));
        
        /// <summary>
        /// Событие при загрузке формы
        /// </summary>
        private void MainForm_Load(object sender, EventArgs e)
        {
            DataGridFigureTools.CreateTable(_figureList, DataFigureView);
        }

        /// <summary>
        /// Событие при добавлении фигуры
        /// </summary>
        private void AddFigureButton_Click(object sender, EventArgs e)
        {
            var figure = new AddFigureForm();

            if (figure.ShowDialog() == DialogResult.OK)
            {
                _figureList.Add(figure.FigureData);
            }
        }

        /// <summary>
        /// Событие при удалении фигуры
        /// </summary>
        private void DeleteFugureButton_Click(object sender, EventArgs e)
        {
            var countOfRows = DataFigureView.SelectedRows.Count;
            for (int i = 0; i < countOfRows; i++)
            {
                _figureList.RemoveAt(DataFigureView.SelectedRows[0].Index);
            }
        }
        
        /// <summary>
        /// Событие при загрузке файла
        /// </summary>
        private void LoadToolStripMenuItemClick(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "Файлы (*.di)|*.di|Все файлы (*.*)|*.*",
            };

            if (openFileDialog.ShowDialog() != DialogResult.OK) return;

            var path = openFileDialog.FileName.ToString();
            try
            {
                using (FileStream fileStream = new FileStream(path,
                    FileMode.OpenOrCreate))
                {
                    _figureList = (BindingList<FigureBase>)_serializer.
                        Deserialize(fileStream);
                }
                DataFigureView.DataSource = _figureList;
                DataFigureView.CurrentCell = null;
                MessageBox.Show("Файл успешно загружен.", "Загрузка завершена",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Файл повреждён или не соответствует формату.",
                    "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        /// <summary>
        /// Событие при сохранении файла
        /// </summary>
        private void SaveToolStripMenuItemClick(object sender, EventArgs e)
        {
            if (_figureList.Count == 0)
            {
                MessageBox.Show("Отсутствуют данные для сохранения.",
                    "Данные не сохранены",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var saveFileDialog = new SaveFileDialog
            {
                Filter = "Файлы (*.di)|*.di|Все файлы (*.*)|*.*",
                AddExtension = true,
                DefaultExt = ".di"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var path = saveFileDialog.FileName.ToString();
                using (FileStream fileStream = new FileStream(path,
                    FileMode.OpenOrCreate))
                {
                    _serializer.Serialize(fileStream, _figureList);
                }
            }

            MessageBox.Show("Файл успешно сохранён.", "Сохранение завершено",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Событие при генерации случайной фигуры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RandomFigureButton_Click(object sender, EventArgs e)
        {
            _figureList.Add(RandomFigure.GetRandomFigure());
        }
        
        /// <summary>
        /// Событие при поиске фигуры
        /// </summary>
        private void SearchFigureButton_Click(object sender, EventArgs e)
        {
            var figureSearch = new SearchFigureForm(_figureList);
            figureSearch.SendDataFromFormEvent += AddSearchTransportEvent;
            figureSearch.Show();
        }

        /// <summary>
        /// Обработчик события получения данных из формы поиска
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void AddSearchTransportEvent(object sender, FigureEventArgs e)
        {
            _listForSearch.Add(e.SendingFigure);
            DataGridFigureTools.CreateTable(_listForSearch, DataFigureView);
            DeleteFugureButton.Enabled = false;
            DropFilterButton.Enabled = true;
            SearchFigureButton.Enabled = false;
        }

        // <summary>
        /// Обработчик события при сбросе фильтрации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DropFilterButton_Click(object sender, EventArgs e)
        {
            DataFigureView.DataSource = null;
            DataGridFigureTools.CreateTable(_figureList, DataFigureView);
            DeleteFugureButton.Enabled = true;
            SearchFigureButton.Enabled = true;
            _listForSearch.Clear();
        }
    }
}
