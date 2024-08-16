namespace xampCaseiro
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblStatusApache;
        private Label lblStatusMySQL;
        private Label lblStatusPHP;
        private Button btnStartApache;
        private Button btnStopApache;
        private Button btnStartMySQL;
        private Button btnStopMySQL;
        private Button btnStartPHP;
        private Button btnStopPHP;
        private PictureBox pictureBox1;
        private TextBox txtApachePath;
        private TextBox txtMySQLPath;
        private TextBox txtPHPPath;
        private Label label1;
        private Label label2;
        private Label label3;

        private void InitializeComponent()
        {
            lblStatusApache = new Label();
            lblStatusMySQL = new Label();
            lblStatusPHP = new Label();
            btnStartApache = new Button();
            btnStopApache = new Button();
            btnStartMySQL = new Button();
            btnStopMySQL = new Button();
            btnStartPHP = new Button();
            btnStopPHP = new Button();
            pictureBox1 = new PictureBox();
            txtApachePath = new TextBox();
            txtMySQLPath = new TextBox();
            txtPHPPath = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblStatusApache
            // 
            lblStatusApache.AutoSize = true;
            lblStatusApache.Location = new Point(315, 213);
            lblStatusApache.Name = "lblStatusApache";
            lblStatusApache.Size = new Size(110, 20);
            lblStatusApache.TabIndex = 0;
            lblStatusApache.Text = "Status Apache: ";
            // 
            // lblStatusMySQL
            // 
            lblStatusMySQL.AutoSize = true;
            lblStatusMySQL.Location = new Point(306, 355);
            lblStatusMySQL.Name = "lblStatusMySQL";
            lblStatusMySQL.Size = new Size(106, 20);
            lblStatusMySQL.TabIndex = 1;
            lblStatusMySQL.Text = "Status MySQL: ";
            // 
            // lblStatusPHP
            // 
            lblStatusPHP.AutoSize = true;
            lblStatusPHP.Location = new Point(306, 493);
            lblStatusPHP.Name = "lblStatusPHP";
            lblStatusPHP.Size = new Size(87, 20);
            lblStatusPHP.TabIndex = 2;
            lblStatusPHP.Text = "Status PHP: ";
            // 
            // btnStartApache
            // 
            btnStartApache.Location = new Point(12, 176);
            btnStartApache.Name = "btnStartApache";
            btnStartApache.Size = new Size(123, 41);
            btnStartApache.TabIndex = 3;
            btnStartApache.Text = "Iniciar Apache";
            btnStartApache.UseVisualStyleBackColor = true;
            btnStartApache.Click += btnStartApache_Click;
            // 
            // btnStopApache
            // 
            btnStopApache.Location = new Point(162, 176);
            btnStopApache.Name = "btnStopApache";
            btnStopApache.Size = new Size(123, 41);
            btnStopApache.TabIndex = 4;
            btnStopApache.Text = "Parar Apache";
            btnStopApache.UseVisualStyleBackColor = true;
            btnStopApache.Click += btnStopApache_Click;
            // 
            // btnStartMySQL
            // 
            btnStartMySQL.Location = new Point(12, 319);
            btnStartMySQL.Name = "btnStartMySQL";
            btnStartMySQL.Size = new Size(123, 41);
            btnStartMySQL.TabIndex = 5;
            btnStartMySQL.Text = "Iniciar MySQL";
            btnStartMySQL.UseVisualStyleBackColor = true;
            btnStartMySQL.Click += btnStartMySQL_Click;
            // 
            // btnStopMySQL
            // 
            btnStopMySQL.Location = new Point(162, 319);
            btnStopMySQL.Name = "btnStopMySQL";
            btnStopMySQL.Size = new Size(123, 41);
            btnStopMySQL.TabIndex = 6;
            btnStopMySQL.Text = "Parar MySQL";
            btnStopMySQL.UseVisualStyleBackColor = true;
            btnStopMySQL.Click += btnStopMySQL_Click;
            // 
            // btnStartPHP
            // 
            btnStartPHP.Location = new Point(12, 453);
            btnStartPHP.Name = "btnStartPHP";
            btnStartPHP.Size = new Size(123, 41);
            btnStartPHP.TabIndex = 7;
            btnStartPHP.Text = "Iniciar PHP";
            btnStartPHP.UseVisualStyleBackColor = true;
            btnStartPHP.Click += btnStartPHP_Click;
            // 
            // btnStopPHP
            // 
            btnStopPHP.Location = new Point(162, 453);
            btnStopPHP.Name = "btnStopPHP";
            btnStopPHP.Size = new Size(123, 41);
            btnStopPHP.TabIndex = 8;
            btnStopPHP.Text = "Parar PHP";
            btnStopPHP.UseVisualStyleBackColor = true;
            btnStopPHP.Click += btnStopPHP_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Fiserv_Logo_svg;
            pictureBox1.Location = new Point(12, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(172, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // txtApachePath
            // 
            txtApachePath.Location = new Point(12, 254);
            txtApachePath.Name = "txtApachePath";
            txtApachePath.Size = new Size(273, 27);
            txtApachePath.TabIndex = 10;
            // 
            // txtMySQLPath
            // 
            txtMySQLPath.Location = new Point(12, 403);
            txtMySQLPath.Name = "txtMySQLPath";
            txtMySQLPath.Size = new Size(273, 27);
            txtMySQLPath.TabIndex = 11;
            // 
            // txtPHPPath
            // 
            txtPHPPath.Location = new Point(12, 522);
            txtPHPPath.Name = "txtPHPPath";
            txtPHPPath.Size = new Size(273, 27);
            txtPHPPath.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 231);
            label1.Name = "label1";
            label1.Size = new Size(166, 20);
            label1.TabIndex = 13;
            label1.Text = "Inserir Caminho Apache";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 380);
            label2.Name = "label2";
            label2.Size = new Size(162, 20);
            label2.TabIndex = 14;
            label2.Text = "Inserir Caminho MySQL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 499);
            label3.Name = "label3";
            label3.Size = new Size(143, 20);
            label3.TabIndex = 15;
            label3.Text = "Inserir Caminho PHP";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(448, 596);
            label4.Name = "label4";
            label4.Size = new Size(302, 20);
            label4.TabIndex = 16;
            label4.Text = "FISERV DEV TEAM FiservDevHost V.1.0  2024";
            label4.Click += label4_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(753, 615);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPHPPath);
            Controls.Add(txtMySQLPath);
            Controls.Add(txtApachePath);
            Controls.Add(pictureBox1);
            Controls.Add(btnStopPHP);
            Controls.Add(btnStartPHP);
            Controls.Add(btnStopMySQL);
            Controls.Add(btnStartMySQL);
            Controls.Add(btnStopApache);
            Controls.Add(btnStartApache);
            Controls.Add(lblStatusPHP);
            Controls.Add(lblStatusMySQL);
            Controls.Add(lblStatusApache);
            Name = "Form1";
            Text = "Status dos Serviços";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label4;
    }
}
