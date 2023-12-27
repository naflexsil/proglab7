namespace proglab7
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.рассчитатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сгенерироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьИзExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.textSIZE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.checkBoxCramer = new System.Windows.Forms.CheckBox();
            this.checkBoxGauss = new System.Windows.Forms.CheckBox();
            this.checkBoxJordanGauss = new System.Windows.Forms.CheckBox();
            this.resCramer = new System.Windows.Forms.TextBox();
            this.resGauss = new System.Windows.Forms.TextBox();
            this.resJordanGauss = new System.Windows.Forms.TextBox();
            this.timeCramer = new System.Windows.Forms.TextBox();
            this.timeGauss = new System.Windows.Forms.TextBox();
            this.timeJordanGauss = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рассчитатьToolStripMenuItem,
            this.очиститьToolStripMenuItem,
            this.сгенерироватьToolStripMenuItem,
            this.загрузитьИзExcelToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1102, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // рассчитатьToolStripMenuItem
            // 
            this.рассчитатьToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.рассчитатьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("рассчитатьToolStripMenuItem.Image")));
            this.рассчитатьToolStripMenuItem.Name = "рассчитатьToolStripMenuItem";
            this.рассчитатьToolStripMenuItem.Size = new System.Drawing.Size(129, 34);
            this.рассчитатьToolStripMenuItem.Text = "рассчитать";
            this.рассчитатьToolStripMenuItem.Click += new System.EventHandler(this.рассчитатьToolStripMenuItem_Click);
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.очиститьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("очиститьToolStripMenuItem.Image")));
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(115, 34);
            this.очиститьToolStripMenuItem.Text = "очистить";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
            // 
            // сгенерироватьToolStripMenuItem
            // 
            this.сгенерироватьToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.сгенерироватьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("сгенерироватьToolStripMenuItem.Image")));
            this.сгенерироватьToolStripMenuItem.Name = "сгенерироватьToolStripMenuItem";
            this.сгенерироватьToolStripMenuItem.Size = new System.Drawing.Size(157, 34);
            this.сгенерироватьToolStripMenuItem.Text = "сгенерировать";
            this.сгенерироватьToolStripMenuItem.Click += new System.EventHandler(this.сгенерироватьButton_Click);
            // 
            // загрузитьИзExcelToolStripMenuItem
            // 
            this.загрузитьИзExcelToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.загрузитьИзExcelToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("загрузитьИзExcelToolStripMenuItem.Image")));
            this.загрузитьИзExcelToolStripMenuItem.Name = "загрузитьИзExcelToolStripMenuItem";
            this.загрузитьИзExcelToolStripMenuItem.Size = new System.Drawing.Size(178, 34);
            this.загрузитьИзExcelToolStripMenuItem.Text = "загрузить из Excel";
            this.загрузитьИзExcelToolStripMenuItem.Click += new System.EventHandler(this.загрузитьИзExcelToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(26, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "размерность (NxN) от 2 до 50";
            // 
            // textSIZE
            // 
            this.textSIZE.Location = new System.Drawing.Point(77, 86);
            this.textSIZE.Name = "textSIZE";
            this.textSIZE.Size = new System.Drawing.Size(100, 22);
            this.textSIZE.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(51, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "матрица:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(344, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "метод:";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 169);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1079, 246);
            this.dataGridView.TabIndex = 7;
            // 
            // checkBoxCramer
            // 
            this.checkBoxCramer.AutoSize = true;
            this.checkBoxCramer.Location = new System.Drawing.Point(347, 84);
            this.checkBoxCramer.Name = "checkBoxCramer";
            this.checkBoxCramer.Size = new System.Drawing.Size(86, 20);
            this.checkBoxCramer.TabIndex = 8;
            this.checkBoxCramer.Text = "Крамера";
            this.checkBoxCramer.UseVisualStyleBackColor = true;
            // 
            // checkBoxGauss
            // 
            this.checkBoxGauss.AutoSize = true;
            this.checkBoxGauss.Location = new System.Drawing.Point(347, 110);
            this.checkBoxGauss.Name = "checkBoxGauss";
            this.checkBoxGauss.Size = new System.Drawing.Size(74, 20);
            this.checkBoxGauss.TabIndex = 9;
            this.checkBoxGauss.Text = "Гаусса";
            this.checkBoxGauss.UseVisualStyleBackColor = true;
            // 
            // checkBoxJordanGauss
            // 
            this.checkBoxJordanGauss.AutoSize = true;
            this.checkBoxJordanGauss.Location = new System.Drawing.Point(347, 136);
            this.checkBoxJordanGauss.Name = "checkBoxJordanGauss";
            this.checkBoxJordanGauss.Size = new System.Drawing.Size(139, 20);
            this.checkBoxJordanGauss.TabIndex = 10;
            this.checkBoxJordanGauss.Text = "Жордана-Гаусса";
            this.checkBoxJordanGauss.UseVisualStyleBackColor = true;
            // 
            // resCramer
            // 
            this.resCramer.Location = new System.Drawing.Point(12, 453);
            this.resCramer.Multiline = true;
            this.resCramer.Name = "resCramer";
            this.resCramer.Size = new System.Drawing.Size(158, 140);
            this.resCramer.TabIndex = 11;
            // 
            // resGauss
            // 
            this.resGauss.Location = new System.Drawing.Point(217, 453);
            this.resGauss.Multiline = true;
            this.resGauss.Name = "resGauss";
            this.resGauss.Size = new System.Drawing.Size(160, 140);
            this.resGauss.TabIndex = 12;
            // 
            // resJordanGauss
            // 
            this.resJordanGauss.Location = new System.Drawing.Point(443, 453);
            this.resJordanGauss.Multiline = true;
            this.resJordanGauss.Name = "resJordanGauss";
            this.resJordanGauss.Size = new System.Drawing.Size(165, 140);
            this.resJordanGauss.TabIndex = 13;
            // 
            // timeCramer
            // 
            this.timeCramer.Location = new System.Drawing.Point(12, 632);
            this.timeCramer.Multiline = true;
            this.timeCramer.Name = "timeCramer";
            this.timeCramer.Size = new System.Drawing.Size(148, 69);
            this.timeCramer.TabIndex = 14;
            // 
            // timeGauss
            // 
            this.timeGauss.Location = new System.Drawing.Point(217, 632);
            this.timeGauss.Multiline = true;
            this.timeGauss.Name = "timeGauss";
            this.timeGauss.Size = new System.Drawing.Size(160, 69);
            this.timeGauss.TabIndex = 15;
            // 
            // timeJordanGauss
            // 
            this.timeJordanGauss.Location = new System.Drawing.Point(443, 632);
            this.timeJordanGauss.Multiline = true;
            this.timeJordanGauss.Name = "timeJordanGauss";
            this.timeJordanGauss.Size = new System.Drawing.Size(157, 69);
            this.timeJordanGauss.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(26, 432);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 18);
            this.label4.TabIndex = 17;
            this.label4.Text = "результат Крамера:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(230, 430);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 18);
            this.label5.TabIndex = 18;
            this.label5.Text = "результат Гаусса:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.Location = new System.Drawing.Point(456, 430);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 18);
            this.label6.TabIndex = 19;
            this.label6.Text = "результат Жордана-Гаусса:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label7.Location = new System.Drawing.Point(26, 611);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 18);
            this.label7.TabIndex = 20;
            this.label7.Text = "время выполнения:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label8.Location = new System.Drawing.Point(230, 611);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 18);
            this.label8.TabIndex = 21;
            this.label8.Text = "время выполнения:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label9.Location = new System.Drawing.Point(456, 611);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 18);
            this.label9.TabIndex = 22;
            this.label9.Text = "время выполнения:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 743);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.timeJordanGauss);
            this.Controls.Add(this.timeGauss);
            this.Controls.Add(this.timeCramer);
            this.Controls.Add(this.resJordanGauss);
            this.Controls.Add(this.resGauss);
            this.Controls.Add(this.resCramer);
            this.Controls.Add(this.checkBoxJordanGauss);
            this.Controls.Add(this.checkBoxGauss);
            this.Controls.Add(this.checkBoxCramer);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textSIZE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem рассчитатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textSIZE;
        private System.Windows.Forms.ToolStripMenuItem сгенерироватьToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.CheckBox checkBoxCramer;
        private System.Windows.Forms.CheckBox checkBoxGauss;
        private System.Windows.Forms.CheckBox checkBoxJordanGauss;
        private System.Windows.Forms.TextBox resCramer;
        private System.Windows.Forms.TextBox resGauss;
        private System.Windows.Forms.TextBox resJordanGauss;
        private System.Windows.Forms.TextBox timeCramer;
        private System.Windows.Forms.TextBox timeGauss;
        private System.Windows.Forms.TextBox timeJordanGauss;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripMenuItem загрузитьИзExcelToolStripMenuItem;
    }
}

