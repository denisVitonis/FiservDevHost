using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace xampCaseiro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Inicializa os TextBoxes com os caminhos padrão
            txtApachePath.Text = @"\httpd.exe";
            txtMySQLPath.Text = @"\mysqld.exe";
            txtPHPPath.Text = @"\php.exe";

            UpdateServiceStatus();
        }

        private void UpdateServiceStatus()
        {
            lblStatusApache.Text = IsServiceRunning(txtApachePath.Text) ? "Em execução" : "Parado";
            lblStatusMySQL.Text = IsServiceRunning(txtMySQLPath.Text) ? "Em execução" : "Parado";
            lblStatusPHP.Text = IsServiceRunning(txtPHPPath.Text) ? "Em execução" : "Parado";
        }

        private bool IsServiceRunning(string path)
        {
            var processName = Path.GetFileNameWithoutExtension(path);
            foreach (var process in Process.GetProcessesByName(processName))
            {
                if (process.MainModule.FileName.Equals(path, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }

        private void btnStartApache_Click(object sender, EventArgs e)
        {
            StartProcess(txtApachePath.Text);
            UpdateServiceStatus();
        }

        private void btnStopApache_Click(object sender, EventArgs e)
        {
            StopProcess("httpd");
            UpdateServiceStatus();
        }

        private void btnStartMySQL_Click(object sender, EventArgs e)
        {
            string mysqlPath = txtMySQLPath.Text;

            if (string.IsNullOrEmpty(mysqlPath) || !System.IO.File.Exists(mysqlPath))
            {
                MessageBox.Show("O caminho do MySQL não é válido. Verifique e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string mysqlDirectory = System.IO.Path.GetDirectoryName(mysqlPath);
            StartProcessMysql(mysqlDirectory, "mysqld", "--console");
            UpdateServiceStatus();
        }

        private void btnStopMySQL_Click(object sender, EventArgs e)
        {
            StopProcess("mysqld");
            UpdateServiceStatus();
        }


        private void btnStartPHP_Click(object sender, EventArgs e)
        {
            StartProcess(txtPHPPath.Text);
            UpdateServiceStatus();
        }

        private void btnStopPHP_Click(object sender, EventArgs e)
        {
            StopProcess("php");
            UpdateServiceStatus();
        }

        private void StartProcess(string fileName, string arguments = "", string workingDirectory = "")
        {
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = fileName,
                    Arguments = arguments,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true,
                };

                if (!string.IsNullOrEmpty(workingDirectory))
                {
                    startInfo.WorkingDirectory = workingDirectory;
                }

                Process process = new Process { StartInfo = startInfo };
                process.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao iniciar o processo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void StopProcess(string processName)
        {
            try
            {
                foreach (var process in Process.GetProcessesByName(processName))
                {
                    process.Kill();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao parar o processo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StartProcessMysql(string? workingDirectory, string? fileName, string arguments = "")
        {
            if (string.IsNullOrEmpty(fileName))
            {
                MessageBox.Show("O nome do arquivo não pode ser nulo ou vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(workingDirectory))
            {
                MessageBox.Show("O diretório de trabalho não pode ser nulo ou vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = fileName,
                    Arguments = arguments,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true,
                    WorkingDirectory = workingDirectory // Define o diretório de trabalho
                };

                Process process = new Process { StartInfo = startInfo };
                process.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao iniciar o processo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
