using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeWallpaper
{
    class Program
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int SystemParametersInfo(int uAction, int uParam, IntPtr lpvParam, int fuWinIni);

        public const int SPI_SETDESKWALLPAPER = 20;
        public const int SPIF_UPDATEINIFILE = 0x1;
        public const int SPIF_SENDWININICHANGE = 0x2;
        static void Main(string[] args)
        {
            try
            {

                int filescount = new DirectoryInfo(Environment.CurrentDirectory + @"\wallpapers").GetFiles("*.jpg").Length;
                Random rand = new Random();
                string filepath = Directory.GetFiles(Environment.CurrentDirectory + @"\wallpapers")[rand.Next(filescount)];
                SystemParametersInfo(SPI_SETDESKWALLPAPER, 1, Marshal.StringToBSTR(filepath), SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
            }
            catch
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
        }
    }
}
