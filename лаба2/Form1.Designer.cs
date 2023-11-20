namespace лаба2
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.спадкуванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.наслідуванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.абстракціяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.лабораторкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.лабToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.спадкуванняToolStripMenuItem,
            this.абстракціяToolStripMenuItem,
            this.лабораторкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // спадкуванняToolStripMenuItem
            // 
            this.спадкуванняToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.наслідуванняToolStripMenuItem});
            this.спадкуванняToolStripMenuItem.Name = "спадкуванняToolStripMenuItem";
            this.спадкуванняToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.спадкуванняToolStripMenuItem.Text = "Спадкування";
            this.спадкуванняToolStripMenuItem.Click += new System.EventHandler(this.спадкуванняToolStripMenuItem_Click);
            // 
            // наслідуванняToolStripMenuItem
            // 
            this.наслідуванняToolStripMenuItem.Name = "наслідуванняToolStripMenuItem";
            this.наслідуванняToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.наслідуванняToolStripMenuItem.Text = "Наслідування";
            this.наслідуванняToolStripMenuItem.Click += new System.EventHandler(this.наслідуванняToolStripMenuItem_Click);
            // 
            // абстракціяToolStripMenuItem
            // 
            this.абстракціяToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem});
            this.абстракціяToolStripMenuItem.Name = "абстракціяToolStripMenuItem";
            this.абстракціяToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.абстракціяToolStripMenuItem.Text = "Абстракція";
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aToolStripMenuItem.Text = "Abstract";
            this.aToolStripMenuItem.Click += new System.EventHandler(this.aToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // лабораторкаToolStripMenuItem
            // 
            this.лабораторкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.лабToolStripMenuItem});
            this.лабораторкаToolStripMenuItem.Name = "лабораторкаToolStripMenuItem";
            this.лабораторкаToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.лабораторкаToolStripMenuItem.Text = "5 лабораторка";
            this.лабораторкаToolStripMenuItem.Click += new System.EventHandler(this.лабораторкаToolStripMenuItem_Click);
            // 
            // лабToolStripMenuItem
            // 
            this.лабToolStripMenuItem.Name = "лабToolStripMenuItem";
            this.лабToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.лабToolStripMenuItem.Text = "5 лаб";
            this.лабToolStripMenuItem.Click += new System.EventHandler(this.лабToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem спадкуванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem наслідуванняToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem абстракціяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem лабораторкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem лабToolStripMenuItem;
    }
}

