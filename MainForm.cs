using System;
using System.IO;
using System.Windows.Forms;
using Functions;

namespace TrapInt {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e) {
            // Получаем все параметры из интерфейса
            var T = double.Parse(EditT.Text, Integrator.culture);
            var a = double.Parse(EditA.Text, Integrator.culture);
            var b = double.Parse(EditB.Text, Integrator.culture);
            var eps = double.Parse(EditEps.Text, Integrator.culture);
            var n = int.Parse(EditN.Text);
            // Вычисляем значение интеграла
            Console.SetOut(new TextBoxStreamWriter(textBox1));
            var res = new TrapInt(new MyFunc(T), a, b, eps, n);

            // Отправляем результат обратно в интерфейс
            calcResult.Text = string.Format("Значение интеграла: {0}", res.Calc());
        }

        private void inputFromFileButton_Click(object sender, EventArgs e) {
            // Читаем данные из файла
            try {
                using (var reader = new StreamReader(fileName.Text)) {
                    var s = reader.ReadLine();
                    if (s == null) return;
                    var income = s.Split();
                    EditA.Text = income[0];
                    EditB.Text = income[1];
                    EditEps.Text = income[2];
                    EditN.Text = income[3];
                    EditT.Text = income[4];
                }
            }
            catch (FileNotFoundException ex) {
                MessageBox.Show(ex.FileName, @"Файл не найден", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}