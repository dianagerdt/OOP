using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lab3
{
    /// <summary>
    /// Класс для обработки ввода в TextBox
    /// </summary>
    public static class TextBoxProcessing
    {
        //TODO: naming +
        /// <summary>
        /// Обработка ввода в TextBox
        /// </summary>
        /// <param name="pattern">Паттерн</param>
        /// <param name="e">Объект события</param>
        public static bool TextBoxProcessingKeyPress(string pattern, char e)
        {
            var letterRegex = new Regex(pattern);

            if (!letterRegex.IsMatch(e.ToString())
                    || e == (char)Keys.Back)
            {
                return false;
            }
            return true;
        }
    }
}
