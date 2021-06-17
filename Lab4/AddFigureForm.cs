using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Model;
using Model.Figures;

namespace Lab3
{
    /// <summary>
    /// Класс, описывающий форму добавления
    /// </summary>
    public partial class AddFigureForm : Form
    {
        /// <summary>
        /// Словарь для сопоставления TextBox и Action
        /// </summary>
        private readonly Dictionary<TextBox, 
            Action<FigureBase, double>> _textBoxValidationAction;

        /// <summary>
        /// Инициализация формы и словаря
        /// </summary>
        public AddFigureForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            LengthTextbox.Visible = false;
            LengthLabel.Visible = false;
            WidthTextbox.Visible = false;
            WidthLabel.Visible = false;
            HeightTextbox.Visible = false;
            HeigthLabel.Visible = false;
            RadiusTextbox.Visible = false;
            RadiusLabel.Visible = false;
            _textBoxValidationAction = new Dictionary<TextBox, Action<FigureBase, double>>
            {
                {
                    LengthTextbox,
                    (figure, doubleValue) =>
                    {
                        if (figure is BoxOfBeer parallelepiped)
                        {
                            parallelepiped.Length = doubleValue;
                        }
                        else if (figure is EgyptianForce pyramid)
                        {
                            pyramid.Length = doubleValue;
                        }
                    }
                },
                {
                    WidthTextbox,
                    (figure, doubleValue) =>
                    {
                        if (figure is BoxOfBeer parallelepiped)
                        {
                            parallelepiped.Width = doubleValue;
                        }
                        else if (figure is EgyptianForce pyramid)
                        {
                            pyramid.Width = doubleValue;
                        }
                    }
                },
                {
                    HeightTextbox,
                    (figure, doubleValue) =>
                    {
                        if (figure is BoxOfBeer parallelepiped)
                        {
                            parallelepiped.Height = doubleValue;
                        }
                        else if (figure is EgyptianForce pyramid)
                        {
                            pyramid.Height = doubleValue;
                        }
                    }
                },
                {
                    RadiusTextbox,
                    (figure, doubleValue) =>
                    {
                        if (figure is DiscoBall ball)
                        {
                            ball.Radius = doubleValue;
                        }
                    }
                }
            };
            
            OkAddFigureButton.Enabled = false;
            LengthTextbox.TextChanged += ShowOKButton;
            WidthTextbox.TextChanged += ShowOKButton;
            HeightTextbox.TextChanged += ShowOKButton;
            RadiusTextbox.TextChanged += ShowOKButton;
        }
        
        /// <summary>
        /// Поле для создания фигуры
        /// </summary>
        private FigureBase _figure;

        /// <summary>
        /// Свойство для вывода данных о фигуре
        /// </summary>
        public FigureBase FigureData
        {
            get
            {
                return _figure;
            }
        }

        /// <summary>
        /// Установка видимых TextBox в зависимости
        /// от выбранной фигуры
        /// </summary>
        /// <param name="capacitor">Фигура</param>
        private void MakeVisible(FigureBase figure)
        {
            switch (figure)
            {
                case BoxOfBeer _:
                {
                    LengthTextbox.Visible = true;
                    LengthLabel.Visible = true;
                    WidthTextbox.Visible = true;
                    WidthLabel.Visible = true;
                    HeightTextbox.Visible = true;
                    HeigthLabel.Visible = true;
                    RadiusTextbox.Visible = false;
                    RadiusLabel.Visible = false;
                    break;
                }
                case EgyptianForce _:
                {
                    LengthTextbox.Visible = true;
                    LengthLabel.Visible = true;
                    WidthTextbox.Visible = true;
                    WidthLabel.Visible = true;
                    HeightTextbox.Visible = true;
                    HeigthLabel.Visible = true;
                    RadiusTextbox.Visible = false;
                    RadiusLabel.Visible = false;
                    break;
                }
                case DiscoBall _:
                {
                    RadiusTextbox.Visible = true;
                    RadiusLabel.Visible = true;
                    LengthTextbox.Visible = false;
                    LengthLabel.Visible = false;
                    WidthTextbox.Visible = false;
                    WidthLabel.Visible = false;
                    HeightTextbox.Visible = false;
                    HeigthLabel.Visible = false;
                    break;
                }
                default:
                {
                    throw new ArgumentException("Вы не выбрали тип фигуры!");
                }
            }
        }

        /// <summary>
        /// Событие при нажатии на фигуру в меню
        /// </summary>
        private void FigureChoiceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FigureChoiceComboBox.SelectedIndex == 0)
            {
                _figure = new BoxOfBeer();
                MakeVisible(_figure);
            }
            if (FigureChoiceComboBox.SelectedIndex == 1)
            {
                _figure = new EgyptianForce();
                MakeVisible(_figure);
            }
            if (FigureChoiceComboBox.SelectedIndex == 2)
            {
                _figure = new DiscoBall();
                MakeVisible(_figure);
            }
        }

        /// <summary>
        /// Установить значение свойствам экземпляра класса 
        /// Параллелепипед/Пирамида/Шар
        /// </summary>
        private void SetValue(Action action)
        {
            action.Invoke();
            return;
        }

        /// <summary>
        /// Ввод данных о параллелепипеде
        /// </summary>
        /// <returns>Созданный экземпляр класса BoxOfBeer</returns>
        private BoxOfBeer GetNewParallelepiped()
        {
            var newParallelepiped = new BoxOfBeer();
            var actions = new List<Action>()
            {
                new Action(() =>
                {
                    newParallelepiped.Length = 
                    Convert.ToDouble(LengthTextbox.Text);
                }),
                new Action(() =>
                {
                    newParallelepiped.Width =
                    Convert.ToDouble(WidthTextbox.Text);
                }),
                new Action(() =>
                {
                    newParallelepiped.Height =
                    Convert.ToDouble(HeightTextbox.Text);
                })
            };
            actions.ForEach(SetValue);
            return newParallelepiped;
        }

        /// <summary>
        /// Ввод данных о пирамиде
        /// </summary>
        /// <returns>Созданный экземпляр класса EgyptianForce</returns>
        private EgyptianForce GetNewPyramid()
        {
            var newPyramid = new EgyptianForce();
            var actions = new List<Action>()
            {
                new Action(() =>
                {
                    newPyramid.Length =
                    Convert.ToDouble(LengthTextbox.Text);
                }),
                new Action(() =>
                {
                    newPyramid.Width =
                    Convert.ToDouble(WidthTextbox.Text);
                }),
                new Action(() =>
                {
                    newPyramid.Height =
                    Convert.ToDouble(HeightTextbox.Text);
                })
            };
            actions.ForEach(SetValue);
            return newPyramid;
        }

        /// <summary>
        /// Ввод данных о шаре
        /// </summary>
        /// <returns>Созданный экземпляр класса DiscoBall</returns>
        private DiscoBall GetNewBall()
        {
            var newBall = new DiscoBall();
            var actions = new List<Action>()
            {
                new Action(() =>
                {
                    newBall.Radius =
                    Convert.ToDouble(RadiusTextbox.Text);
                })
            };
            actions.ForEach(SetValue);
            return newBall;
        }

        /// <summary>
        /// Ввод данных о фигурах
        /// </summary>
        private void InsertData()
        {
            switch (_figure)
            {
                case BoxOfBeer _:
                {
                    _figure = GetNewParallelepiped();
                    break;
                }
                case EgyptianForce _:
                {
                    _figure = GetNewPyramid();
                    break;
                }
                case DiscoBall _:
                {
                    _figure = GetNewBall();
                    break;
                }
                default:
                {
                    throw new ArgumentException("Такой фигуры нет в природе.");
                }
            }
        }

        // <summary>
        /// Событие при добавлении новой фигуры
        /// </summary>
        private void OkAddFigureButton_Click(object sender, EventArgs e)
        {
            InsertData();
            DialogResult = DialogResult.OK;
            Close();
        }
        
        /// <summary>
        /// Обработка чисел на форме
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumericTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            const string letterPattern = @"[^0-9,]";
            CheckBox.CheckBox_KeyPress(letterPattern, e);
        }

        /// <summary>
        /// Активация кнопки ОКэй, если заполнены поля
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowOKButton(object sender, EventArgs e)
        {
            switch (FigureChoiceComboBox.SelectedIndex)
            {
                case 0:
                case 1:
                {
                    OkAddFigureButton.Enabled = LengthTextbox.Text.Length > 0
                        && WidthTextbox.Text.Length > 0
                        && HeightTextbox.Text.Length > 0;
                    break;
                }
                case 2:
                {
                    OkAddFigureButton.Enabled = RadiusTextbox.Text.Length > 0;
                    break;
                }
            }
        }
        
        /// <summary>
        /// Закрыть форму
        /// </summary>
        private void CloseFormButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
