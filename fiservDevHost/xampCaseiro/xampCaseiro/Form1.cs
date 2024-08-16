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
            txtApachePath.Text = @"C:\Users\Vitonis\projetos\Apache24\bin\httpd.exe";
            txtMySQLPath.Text = @"C:\Users\Vitonis\projetos\mysql\bin\mysqld.exe";
            txtPHPPath.Text = @"C:\Users\Vitonis\projetos\php\php.exe";

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
            StartProcess(txtMySQLPath.Text);
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

        private void StartProcess(string path)
        {
            try
            {
                Process.Start(path);
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

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
