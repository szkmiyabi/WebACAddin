using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WebACAddin
{
    partial class Ribbon1
    {
        //URL判定
        private Boolean isUrlVal(string str)
        {
            Regex mt = new Regex(@"^http.*://.+");
            if (mt.IsMatch(str)) return true;
            else return false;
        }

        //IE起動パスを取得
        private string getIePath()
        {
            string iepath = "";
            string iepath1 = @"C:\Program Files\Internet Explorer\iexplore.exe";
            string iepath2 = @"C:\Program Files (x86)\Internet Explorer\iexplore.exe";
            if (System.IO.File.Exists(iepath1)) iepath = iepath1;
            else if (System.IO.File.Exists(iepath2)) iepath = iepath2;
            return iepath;
        }

        //Firefox起動パスを取得
        private string getFirefoxPath()
        {
            string ffpath = "";
            string ffpath1 = @"C:\Program Files\Mozilla Firefox\firefox.exe";
            string ffpath2 = @"C:\Program Files (x86)\Mozilla Firefox\firefox.exe";
            if (System.IO.File.Exists(ffpath1)) ffpath = ffpath1;
            else if (System.IO.File.Exists(ffpath2)) ffpath = ffpath2;
            return ffpath;
        }

        //Firefox Developer Edition起動パスを取得
        private string getFirefoxDevPath()
        {
            string ffpath = "";
            string ffpath1 = @"C:\Program Files\Firefox Developer Edition\firefox.exe";
            string ffpath2 = @"C:\Program Files (x86)\Firefox Developer Edition\firefox.exe";
            if (System.IO.File.Exists(ffpath1)) ffpath = ffpath1;
            else if (System.IO.File.Exists(ffpath2)) ffpath = ffpath2;
            return ffpath;
        }

        //Chrome起動パスを取得
        private string getChromePath()
        {
            string gcpath = "";
            string gcpath1 = @"C:\Program Files\Google\Chrome\Application\chrome.exe";
            string gcpath2 = @"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe";
            string gcpath3 = getUserHomePath() + @"\Local Settings\Application Data\Google\Chrome\Application\chrome.exe";
            if (System.IO.File.Exists(gcpath1)) gcpath = gcpath1;
            else if (System.IO.File.Exists(gcpath2)) gcpath = gcpath2;
            else if (System.IO.File.Exists(gcpath3)) gcpath = gcpath3;
            return gcpath;
        }

        //ChromeBeta起動パスを取得
        private string getChromeBetaPath()
        {
            string gcpath = "";
            string gcpath1 = @"C:\Program Files\\Google\Chrome Beta\Application\chrome.exe";
            string gcpath2 = @"C:\Program Files (x86)\Google\Chrome Beta\Application\chrome.exe";
            string gcpath3 = getUserHomePath() + @"\Local Settings\Application Data\Google\Chrome Beta\Application\chrome.exe";
            if (System.IO.File.Exists(gcpath1)) gcpath = gcpath1;
            else if (System.IO.File.Exists(gcpath2)) gcpath = gcpath2;
            else if (System.IO.File.Exists(gcpath3)) gcpath = gcpath3;
            return gcpath;
        }

        //OSビット数判定
        private string getOSBitType()
        {
            if (Environment.Is64BitOperatingSystem) return "64";
            else return "32";
        }

        //OSバージョン判定
        private string getOSVersion()
        {
            System.OperatingSystem os = System.Environment.OSVersion;
            string flag = "";
            if (os.Platform == PlatformID.Win32NT)
            {
                if (os.Version.Major < 6)
                {
                    flag = "under-xp";
                }
                else
                {
                    flag = "upper-xp";
                }
            }
            return flag;
        }

        //ユーザのホームフォルダパス
        private string getUserHomePath()
        {
            return System.Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        }

        //IEで開く
        private void openIEButton_Click(object sender, RibbonControlEventArgs e)
        {
            var range = WebACAddin.Globals.ThisAddIn.Application.Selection
                as Microsoft.Office.Interop.Excel.Range;

            string burl = "";

            if (range.Value is string)
            {
                burl = range.Value;
            }
            else
            {
                MessageBox.Show("URLが入力されたセルが選択されていません！");
                return;
            }

            if (burl == null || burl == "")
            {
                MessageBox.Show("URLが入力されたセルが選択されていません！");
                return;
            }
            if (!isUrlVal(burl))
            {
                MessageBox.Show("URLが入力されたセルが選択されていません！");
                return;
            }

            string iepath = getIePath();
            if (iepath.Equals(""))
            {
                MessageBox.Show("IEのインストール先が取得できませんでした！");
                return;
            }

            System.Diagnostics.Process.Start(iepath, " " + burl);
        }

        //Firefoxで開く
        private void openFirefoxButton_Click(object sender, RibbonControlEventArgs e)
        {
            var range = WebACAddin.Globals.ThisAddIn.Application.Selection
                     as Microsoft.Office.Interop.Excel.Range;

            string burl = "";

            if (range.Value is string)
            {
                burl = range.Value;
            }
            else
            {
                MessageBox.Show("URLが入力されたセルが選択されていません！");
                return;
            }

            if (burl == null || burl == "")
            {
                MessageBox.Show("URLが入力されたセルが選択されていません！");
                return;
            }
            if (!isUrlVal(burl))
            {
                MessageBox.Show("URLが入力されたセルが選択されていません！");
                return;
            }

            string ffpath = getFirefoxPath();
            if (ffpath.Equals(""))
            {
                MessageBox.Show("Firefoxのインストール先が取得できませんでした！");
                return;
            }

            System.Diagnostics.Process.Start(ffpath, "-new-tab " + burl);
        }

        //Chromeで開く
        private void openChromeButton_Click(object sender, RibbonControlEventArgs e)
        {
            var range = WebACAddin.Globals.ThisAddIn.Application.Selection
                as Microsoft.Office.Interop.Excel.Range;

            string burl = "";

            if (range.Value is string)
            {
                burl = range.Value;
            }
            else
            {
                MessageBox.Show("URLが入力されたセルが選択されていません！");
                return;
            }

            if (burl == null || burl == "")
            {
                MessageBox.Show("URLが入力されたセルが選択されていません！");
                return;
            }
            if (!isUrlVal(burl))
            {
                MessageBox.Show("URLが入力されたセルが選択されていません！");
                return;
            }

            string gcpath = getChromePath();
            if (gcpath.Equals(""))
            {
                MessageBox.Show("Google Chromeのインストール先が取得できませんでした！");
                return;
            }

            System.Diagnostics.Process.Start(gcpath, " " + burl);
        }

        //Firefox DevEditonで開く
        private void openFirefoxDevButton_Click(object sender, RibbonControlEventArgs e)
        {
            var range = WebACAddin.Globals.ThisAddIn.Application.Selection
                     as Microsoft.Office.Interop.Excel.Range;

            string burl = "";

            if (range.Value is string)
            {
                burl = range.Value;
            }
            else
            {
                MessageBox.Show("URLが入力されたセルが選択されていません！");
                return;
            }

            if (burl == null || burl == "")
            {
                MessageBox.Show("URLが入力されたセルが選択されていません！");
                return;
            }
            if (!isUrlVal(burl))
            {
                MessageBox.Show("URLが入力されたセルが選択されていません！");
                return;
            }

            string ffpath = getFirefoxDevPath();
            if (ffpath.Equals(""))
            {
                MessageBox.Show("Firefoxのインストール先が取得できませんでした！");
                return;
            }

            System.Diagnostics.Process.Start(ffpath, "-new-tab " + burl);
        }

        //Chrome Betaで開く
        private void openChromeBetaButton_Click(object sender, RibbonControlEventArgs e)
        {
            var range = WebACAddin.Globals.ThisAddIn.Application.Selection
                as Microsoft.Office.Interop.Excel.Range;

            string burl = "";

            if (range.Value is string)
            {
                burl = range.Value;
            }
            else
            {
                MessageBox.Show("URLが入力されたセルが選択されていません！");
                return;
            }

            if (burl == null || burl == "")
            {
                MessageBox.Show("URLが入力されたセルが選択されていません！");
                return;
            }
            if (!isUrlVal(burl))
            {
                MessageBox.Show("URLが入力されたセルが選択されていません！");
                return;
            }

            string gcpath = getChromeBetaPath();
            if (gcpath.Equals(""))
            {
                MessageBox.Show("Google Chrome Betaのインストール先が取得できませんでした！");
                return;
            }

            System.Diagnostics.Process.Start(gcpath, " " + burl);
        }

    }
}
