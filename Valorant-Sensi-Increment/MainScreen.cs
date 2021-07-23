using System;
using System.Text.RegularExpressions;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Valorant_Sensi_Increment {
    public partial class MainScreen : Form {
        static string configFile;
        static float target_sensitivity;
        static float dailyIncrement;
        static DateTime lastChange;
        static DateTime targetDate;

        public MainScreen(){
            InitializeComponent();

            string path = Path.GetPathRoot(Environment.SystemDirectory);
            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            string save_loc = path + string.Format("Users\\{0}\\Valorant_Increment.txt", userName.Split('\\')[1]);

            if (File.Exists(save_loc)) {
                using (StreamReader file = new StreamReader(save_loc)) {
                    configFile = file.ReadLine().Split('=')[1];
                    target_sensitivity = float.Parse(file.ReadLine().Split('=')[1]);
                    dailyIncrement = float.Parse(file.ReadLine().Split('=')[1]);
                    lastChange = DateTime.Parse(file.ReadLine().Split('=')[1]);
                    targetDate = DateTime.Parse(file.ReadLine().Split('=')[1]);

                    file.Close();
                }

                file_already_operated_label.Text = configFile.Split('\\')[configFile.Split('\\').Length - 1];
                selected_file.Text = configFile.Split('\\')[configFile.Split('\\').Length - 1];

                target_sensitivity_box.Text = target_sensitivity.ToString();

                dateTimePicker1.Value = targetDate;
                
                if (Math.Abs((lastChange - DateTime.Now.AddDays(1)).Days) == 1) {
                    addIncrement();

                    lastChange = DateTime.Now;
                    updateSaveFile();
                }

                string[] lines = File.ReadAllLines(configFile);
                current_sensitivity_label.Text = getValue(lines[getLine(lines)]);
            }
            else {
                selected_file.Text = "None";

                selected_file.ForeColor = System.Drawing.Color.Red;
                current_sensitivity_label.Text = "N/A";

                file_already_operated_label.Text = "None";
                file_already_operated_label.ForeColor = System.Drawing.Color.Red;
            }

            MainWorker.RunWorkerAsync();
        }

        //regex matches the string for mouse sensitivity
        public static int getLine(string[] lines) {
            for (int i = 0; i<lines.Length; i++) {
                Regex regex = new Regex("^[a-zA-Z]+::MouseSensitivity=([+-]?(?=\\.\\d|\\d)(?:\\d+)?(?:\\.?\\d*))(?:[eE]([+-]?\\d+))?$", RegexOptions.IgnoreCase);
                Match match = regex.Match(lines[i]);

                if (match.Success) {
                    return i;
                }
            }
            return -1;
        }

        public static string getValue(string str) {
            Regex regex = new Regex("^[a-zA-Z]+::MouseSensitivity=([+-]?(?=\\.\\d|\\d)(?:\\d+)?(?:\\.?\\d*))(?:[eE]([+-]?\\d+))?$", RegexOptions.IgnoreCase);
            Match match = regex.Match(str);
            return match.Groups[1].ToString();
        }

        private void button1_Click(object sender, EventArgs e) {
            //preping the dialog box
            openFileDialog1.Title = "Select Config file";
            openFileDialog1.FileName = "";

            //identifying the saved path automatically
            string path = Path.GetPathRoot(Environment.SystemDirectory);
            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            openFileDialog1.InitialDirectory = path + string.Format("Users\\{0}\\AppData\\Local\\VALORANT\\Saved\\Config", userName.Split('\\')[1]);

            if (openFileDialog1.ShowDialog() == DialogResult.OK) {                //identifying file's name
                configFile = openFileDialog1.FileName;
                string[] separated = configFile.Split('\\');
                string filename = separated[separated.Length - 1];
                selected_file.Text = filename;

                //getting the current sensitivity
                string[] lines = File.ReadAllLines(configFile);

                string currentSensitivity = getValue(lines[getLine(lines)]);
                current_sensitivity_label.Text = currentSensitivity;
            }
        }

        private void confirm_target_btn_Click(object sender, EventArgs e)
        {
            target_sensitivity = float.Parse(target_sensitivity_box.Text);
            if (!(target_sensitivity > 0.1 && target_sensitivity <= 6)) {
                MessageBox.Show("Target Sensitivity out of range!", "Error");
                return;
            }

            targetDate = dateTimePicker1.Value;
            if (targetDate < DateTime.Now) {
                MessageBox.Show("You can not add a past date as the target Date!", "Error");
                return;
            }

            int totalDays = (int)Math.Floor((targetDate - DateTime.Now).TotalDays);

            dailyIncrement = (target_sensitivity - float.Parse(current_sensitivity_label.Text)) / totalDays;
            daily_inc_label.Text = dailyIncrement.ToString();
            lastChange = DateTime.Now;

            done_btn.Enabled = true;
        }

        public void addIncrement() {
            string[] lines = File.ReadAllLines(configFile);

            float currentSensitivity = float.Parse(getValue(lines[getLine(lines)]));
            float newSensitivity = currentSensitivity + dailyIncrement;
            if (newSensitivity > target_sensitivity) {
                newSensitivity = target_sensitivity;
            }

            lines[getLine(lines)] = string.Format("EAresFloatSettingName::MouseSensitivity={0}", newSensitivity);

            using (StreamWriter writer = new StreamWriter(configFile)) {
                for (int currentLine = 0; currentLine < lines.Length; ++currentLine) {
                    writer.WriteLine(lines[currentLine]);
                }
            }

        }

        public static void updateSaveFile() {
            string path = Path.GetPathRoot(Environment.SystemDirectory);
            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            string save_loc = path + string.Format("Users\\{0}\\Valorant_Increment.txt", userName.Split('\\')[1]);

            string[] lines = {
                string.Format("ConfigFile={0}", configFile),
                string.Format("target_sensitivity={0}", target_sensitivity),
                string.Format("dailyIncrement={0}", dailyIncrement),
                string.Format("lastChange={0}", lastChange.ToString()),
                string.Format("targetDate={0}", targetDate.ToString())
            };

            // Write file using StreamWriter  
            using (StreamWriter writer = new StreamWriter(save_loc)) {
                for (int i = 0; i < lines.Length; i++) {
                    writer.WriteLine(lines[i]);
                }
            }
        }

        private void done_btn_Click(object sender, EventArgs e) {

            updateSaveFile();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (checkBox1.Checked) {
                rk.SetValue("Valorant Sensi Increment", Application.ExecutablePath);
            } else { 
                rk.DeleteValue("Valorant Sensi Increment", false);
            }
        }

        private void MainWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e) {
            while (true) {
                if (Math.Abs((lastChange - DateTime.Now.AddDays(1)).Days) == 1) {
                    addIncrement();

                    lastChange = DateTime.Now;
                    updateSaveFile();
                }
            }
        }

        private void Tray_Icon_MouseDoubleClick(object sender, MouseEventArgs e) {
            this.Show();
            WindowState = FormWindowState.Normal;
            ShowInTaskbar = true;
            Tray_Icon.Visible = false;
        }

        private void MainScreen_Load(object sender, EventArgs e) {
        }

        private void MainScreen_Resize(object sender, EventArgs e) {
            if (WindowState == FormWindowState.Minimized) {
                this.Hide();
                ShowIcon = false;
                Tray_Icon.Visible = true;
                //Tray_Icon.ShowBalloonTip(1000);
            }
        }
    }
}
