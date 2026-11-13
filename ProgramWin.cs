using System;
using System.Windows.Forms;

namespace TrapInt {
    internal static class ProgramWin {
        /// <summary>
        ///     Основная программа
        /// </summary>
        [STAThread]
        public static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}