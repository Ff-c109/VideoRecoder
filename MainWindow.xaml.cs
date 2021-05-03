using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VideoRecoder
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int theVideoType = 2233;
        public bool inputFileSelected = false, outputFileSelected = false;
        public class dropDownList
        {
            public string name { get; set; }
            public int id { get; set; }
            public int ids { get; set; }
        }
        public MainWindow()
        {
            InitializeComponent();
            List<dropDownList> videoTypeDropDown = new List<dropDownList>();
            videoTypeDropDown.Add(new dropDownList
            {
                name = "h264",
                id = 0,
                ids = 1
            });
            videoTypeDropDown.Add(new dropDownList
            {
                name = "HEVC(h265)",
                id = 1,
                ids = 2
            });
            videoTypeDropDown.Add(new dropDownList
            {
                name = "h264(flv)",
                id = 2,
                ids = 3
            });
            videoTypeDropDown.Add(new dropDownList
            {
                name = "Quick Time",
                id = 3,
                ids = 4
            });
            videoTypeDropDown.Add(new dropDownList
            {
                name = "mkv",
                id = 4,
                ids = 5
            });
            videoTypeDropDown.Add(new dropDownList
            {
                name = "ogg",
                id = 5,
                ids = 6
            });
            videoTypeDropDown.Add(new dropDownList
            {
                name = "wmv",
                id = 6,
                ids = 7
            });
            videoTypeDropDown.Add(new dropDownList
            {
                name = "webm",
                id = 7,
                ids = 8
            });
            videoType.ItemsSource = videoTypeDropDown;
            videoType.DisplayMemberPath = "name";
            videoType.SelectedValuePath = "ids";
            videoType.SelectedIndex = 0;
        }

        private void inputBrowseButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "所有类型的视频文件 (*.*) | *.*";
            if (ofd.ShowDialog() != true)
                return;
            inputFilePath.Text = ofd.FileName;
            inputFileSelected = true;
        }

        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            if(!(inputFileSelected && outputFileSelected))
            {
                MessageBox.Show("你还没有选择输入/输出文件");
                return;
            }
            if(!File.Exists(inputFilePath.Text))
            {
                MessageBox.Show("输入文件不存在");
                return;
            }
            if (File.Exists(outputFilePath.Text))
                File.Delete(outputFilePath.Text);
            //-vcodec h264
            if(theVideoType == 1)
            {
                Process pro = Process.Start(@"ffmpeg\ffmpeg.exe", "-i " + inputFilePath.Text + " -vcodec h264 " + outputFilePath.Text);
            }
            else if(theVideoType == 2)
            {
                Process pro = Process.Start(@"ffmpeg\ffmpeg.exe", "-i " + inputFilePath.Text + " -c:v libx265 " + outputFilePath.Text);
            }
            else if(theVideoType == 3)
            {
                Process pro = Process.Start(@"ffmpeg\ffmpeg.exe", "-i " + inputFilePath.Text + " -vcodec h264 " + outputFilePath.Text);
            }
            else if(theVideoType == 4)
            {
                Process pro = Process.Start(@"ffmpeg\ffmpeg.exe", "-i " + inputFilePath.Text + " " + outputFilePath.Text);
            }
            else if(theVideoType == 5)
            {
                Process pro = Process.Start(@"ffmpeg\ffmpeg.exe", "-i " + inputFilePath.Text + " " + outputFilePath.Text);
            }
            else if(theVideoType == 6)
            {
                Process pro = Process.Start(@"ffmpeg\ffmpeg.exe", "-i " + inputFilePath.Text + " " + outputFilePath.Text);
            }
            else if(theVideoType == 7)
            {
                Process pro = Process.Start(@"ffmpeg\ffmpeg.exe", "-i " + inputFilePath.Text + " " + outputFilePath.Text);
            }
            else if(theVideoType == 8)
            {
                Process pro = Process.Start(@"ffmpeg\ffmpeg.exe", "-i " + inputFilePath.Text + " " + outputFilePath.Text);
            }
            
        }

        private void outputBrowseButton_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            object selectedObj = videoType.SelectedValue;
            string fileType = selectedObj.ToString();
            if(fileType == "1")
            {
                sfd.Filter = "MP4文件 (*.mp4) | *.mp4";
                if (sfd.ShowDialog() != true)
                    return;
                outputFilePath.Text = sfd.FileName;
                theVideoType = 1;
            }
            else if(fileType == "2")
            {
                sfd.Filter = "HEVC视频文件 (*.mp4) | *.mp4";
                if (sfd.ShowDialog() != true)
                    return;
                outputFilePath.Text = sfd.FileName;
                theVideoType = 2;
            }
            else if(fileType == "3")
            {
                sfd.Filter = "flv视频文件 (*.flv) | *.flv";
                if (sfd.ShowDialog() != true)
                    return;
                outputFilePath.Text = sfd.FileName;
                theVideoType = 3;
            }
            else if(fileType == "4")
            {
                sfd.Filter = "Quick Time视频文件 MOV文件 (*.mov) | *.mov";
                if (sfd.ShowDialog() != true)
                    return;
                outputFilePath.Text = sfd.FileName;
                theVideoType = 4;
            }
            else if(fileType == "5")
            {
                sfd.Filter = "MKV文件 (*.mov) | *.mkv";
                if (sfd.ShowDialog() != true)
                    return;
                outputFilePath.Text = sfd.FileName;
                theVideoType = 5;
            }
            else if(fileType == "6")
            {
                sfd.Filter = "OGG文件 (*.ogg) | *.ogg";
                if (sfd.ShowDialog() != true)
                    return;
                outputFilePath.Text = sfd.FileName;
                theVideoType = 6;
            }
            else if(fileType == "7")
            {
                sfd.Filter = "WMV文件 (*.wmv) | *.wmv";
                if (sfd.ShowDialog() != true)
                    return;
                outputFilePath.Text = sfd.FileName;
                theVideoType = 7;
            }
            else if(fileType == "8")
            {
                sfd.Filter = "WEBM文件 (*.webm) | *.webm";
                if (sfd.ShowDialog() != true)
                    return;
                outputFilePath.Text = sfd.FileName;
                theVideoType = 7;
            }

            outputFileSelected = true;
        }
    }
}
