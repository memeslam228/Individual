namespace Rybch_proga
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tlOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tlSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tlExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.інформаціяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bWork = new System.Windows.Forms.Button();
            this.Label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tTo = new System.Windows.Forms.TextBox();
            this.tFrom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bBack = new System.Windows.Forms.Button();
            this.nKey = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tKey = new System.Windows.Forms.TextBox();
            this.bCezar = new System.Windows.Forms.RadioButton();
            this.bVisn = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nKey)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.tlExit,
            this.toolStripMenuItem2,
            this.інформаціяToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 41);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlOpen,
            this.tlSave});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.toolStripMenuItem1.Image = global::Rybch_proga.Properties.Resources.icons8_opened_folder_208;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(73, 37);
            this.toolStripMenuItem1.Text = "Файл";
            // 
            // tlOpen
            // 
            this.tlOpen.Name = "tlOpen";
            this.tlOpen.Size = new System.Drawing.Size(180, 24);
            this.tlOpen.Text = "Відкрити";
            this.tlOpen.ToolTipText = "Відкриє текстовий файл у вікно \"Запит\"";
            this.tlOpen.Click += new System.EventHandler(this.tlOpen_Click);
            // 
            // tlSave
            // 
            this.tlSave.Name = "tlSave";
            this.tlSave.Size = new System.Drawing.Size(180, 24);
            this.tlSave.Text = "Зберегти";
            this.tlSave.ToolTipText = "Збереже у текстовий файл з вікна \"Результат\"";
            this.tlSave.Click += new System.EventHandler(this.tlSave_Click);
            // 
            // tlExit
            // 
            this.tlExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tlExit.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.tlExit.Image = global::Rybch_proga.Properties.Resources.exit_icon_icons_com_48304;
            this.tlExit.Margin = new System.Windows.Forms.Padding(0, 8, 10, 0);
            this.tlExit.Name = "tlExit";
            this.tlExit.Size = new System.Drawing.Size(82, 29);
            this.tlExit.Text = "Вихід";
            this.tlExit.ToolTipText = "Вийти з додатку";
            this.tlExit.Click += new System.EventHandler(this.tlExit_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.AccessibleDescription = "";
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.toolStripMenuItem2.Image = global::Rybch_proga.Properties.Resources.editclearrtl_104465;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(102, 37);
            this.toolStripMenuItem2.Text = "Очистити";
            this.toolStripMenuItem2.ToolTipText = "Натисніть для того щоб очистити всі поля";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // інформаціяToolStripMenuItem
            // 
            this.інформаціяToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.інформаціяToolStripMenuItem.Image = global::Rybch_proga.Properties.Resources.information;
            this.інформаціяToolStripMenuItem.Name = "інформаціяToolStripMenuItem";
            this.інформаціяToolStripMenuItem.Size = new System.Drawing.Size(118, 37);
            this.інформаціяToolStripMenuItem.Text = "Інформація";
            this.інформаціяToolStripMenuItem.ToolTipText = "Натисніть щоб переглянути інформацию";
            this.інформаціяToolStripMenuItem.Click += new System.EventHandler(this.інформаціяToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // bWork
            // 
            this.bWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bWork.Location = new System.Drawing.Point(12, 338);
            this.bWork.Name = "bWork";
            this.bWork.Size = new System.Drawing.Size(318, 47);
            this.bWork.TabIndex = 1;
            this.bWork.Text = "Зашифрувати";
            this.bWork.UseVisualStyleBackColor = true;
            this.bWork.Click += new System.EventHandler(this.bWork_Click);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Label.Location = new System.Drawing.Point(368, 63);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(48, 17);
            this.Label.TabIndex = 4;
            this.Label.Text = "Запит";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(368, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Результат";
            // 
            // tTo
            // 
            this.tTo.Location = new System.Drawing.Point(349, 281);
            this.tTo.Multiline = true;
            this.tTo.Name = "tTo";
            this.tTo.Size = new System.Drawing.Size(441, 156);
            this.tTo.TabIndex = 6;
            // 
            // tFrom
            // 
            this.tFrom.Location = new System.Drawing.Point(349, 83);
            this.tFrom.Multiline = true;
            this.tFrom.Name = "tFrom";
            this.tFrom.Size = new System.Drawing.Size(441, 156);
            this.tFrom.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(12, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ключ для Цезаря";
            // 
            // bBack
            // 
            this.bBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bBack.Location = new System.Drawing.Point(12, 391);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(318, 47);
            this.bBack.TabIndex = 10;
            this.bBack.Text = "Дешифрувати";
            this.bBack.UseVisualStyleBackColor = true;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // nKey
            // 
            this.nKey.Location = new System.Drawing.Point(12, 199);
            this.nKey.Name = "nKey";
            this.nKey.Size = new System.Drawing.Size(145, 20);
            this.nKey.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ключ для Віжинера";
            // 
            // tKey
            // 
            this.tKey.Location = new System.Drawing.Point(12, 242);
            this.tKey.Multiline = true;
            this.tKey.Name = "tKey";
            this.tKey.Size = new System.Drawing.Size(318, 68);
            this.tKey.TabIndex = 13;
            // 
            // bCezar
            // 
            this.bCezar.AutoSize = true;
            this.bCezar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.bCezar.Location = new System.Drawing.Point(12, 83);
            this.bCezar.Name = "bCezar";
            this.bCezar.Size = new System.Drawing.Size(309, 26);
            this.bCezar.TabIndex = 14;
            this.bCezar.Text = "Шифрування алгоритмом Цезаря";
            this.bCezar.UseVisualStyleBackColor = true;
            // 
            // bVisn
            // 
            this.bVisn.AutoSize = true;
            this.bVisn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.bVisn.Location = new System.Drawing.Point(12, 124);
            this.bVisn.Name = "bVisn";
            this.bVisn.Size = new System.Drawing.Size(327, 26);
            this.bVisn.TabIndex = 15;
            this.bVisn.Text = "Шифрування алгоритмом Віжинера";
            this.bVisn.UseVisualStyleBackColor = true;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bVisn);
            this.Controls.Add(this.bCezar);
            this.Controls.Add(this.tKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nKey);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tFrom);
            this.Controls.Add(this.tTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.bWork);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nKey)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tlOpen;
        private System.Windows.Forms.ToolStripMenuItem tlSave;
        private System.Windows.Forms.ToolStripMenuItem tlExit;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button bWork;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tTo;
        private System.Windows.Forms.TextBox tFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.NumericUpDown nKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tKey;
        private System.Windows.Forms.RadioButton bCezar;
        private System.Windows.Forms.RadioButton bVisn;
        private System.Windows.Forms.ToolStripMenuItem інформаціяToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

