using System.IO;
using System.Text;
using System.Windows.Forms;

namespace TrapInt {
    /// <summary>
    ///     Вывод в TextBox как в поток
    /// </summary>
    public class TextBoxStreamWriter : TextWriter {
        private readonly TextBox _stream;

        public TextBoxStreamWriter(TextBox stream) {
            _stream = stream;
        }

        public override Encoding Encoding {
            get { return Encoding.UTF8; }
        }

        public override void Write(char value) {
            base.Write(value); // В стандартный
            _stream.AppendText(value.ToString());
        }
    }
}