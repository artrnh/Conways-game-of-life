namespace Conway_s_game_of_life
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
            this.label1 = new System.Windows.Forms.Label();
            this.play = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Pulsar = new System.Windows.Forms.Button();
            this.dieHard = new System.Windows.Forms.Button();
            this.Glider = new System.Windows.Forms.Button();
            this.blinker = new System.Windows.Forms.Button();
            this.drawTimer = new System.Windows.Forms.Timer(this.components);
            this.clear = new System.Windows.Forms.Button();
            this.Shuriken = new System.Windows.Forms.Button();
            this.Toad = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(574, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Generation: ";
            // 
            // play
            // 
            this.play.Location = new System.Drawing.Point(574, 25);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(119, 36);
            this.play.TabIndex = 2;
            this.play.Text = "Play";
            this.play.UseVisualStyleBackColor = true;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Toad);
            this.groupBox1.Controls.Add(this.Shuriken);
            this.groupBox1.Controls.Add(this.Pulsar);
            this.groupBox1.Controls.Add(this.dieHard);
            this.groupBox1.Controls.Add(this.Glider);
            this.groupBox1.Controls.Add(this.blinker);
            this.groupBox1.Location = new System.Drawing.Point(574, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(119, 242);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patterns:";
            // 
            // Pulsar
            // 
            this.Pulsar.Location = new System.Drawing.Point(6, 167);
            this.Pulsar.Name = "Pulsar";
            this.Pulsar.Size = new System.Drawing.Size(106, 31);
            this.Pulsar.TabIndex = 3;
            this.Pulsar.Text = "Pulsar";
            this.Pulsar.UseVisualStyleBackColor = true;
            this.Pulsar.Click += new System.EventHandler(this.Pulsar_Click);
            // 
            // dieHard
            // 
            this.dieHard.Location = new System.Drawing.Point(6, 130);
            this.dieHard.Name = "dieHard";
            this.dieHard.Size = new System.Drawing.Size(107, 31);
            this.dieHard.TabIndex = 2;
            this.dieHard.Text = "Diehard";
            this.dieHard.UseVisualStyleBackColor = true;
            this.dieHard.Click += new System.EventHandler(this.dieHard_Click);
            // 
            // Glider
            // 
            this.Glider.Location = new System.Drawing.Point(6, 93);
            this.Glider.Name = "Glider";
            this.Glider.Size = new System.Drawing.Size(107, 31);
            this.Glider.TabIndex = 1;
            this.Glider.Text = "Glider";
            this.Glider.UseVisualStyleBackColor = true;
            this.Glider.Click += new System.EventHandler(this.Glider_Click);
            // 
            // blinker
            // 
            this.blinker.Location = new System.Drawing.Point(6, 19);
            this.blinker.Name = "blinker";
            this.blinker.Size = new System.Drawing.Size(107, 31);
            this.blinker.TabIndex = 0;
            this.blinker.Text = "Blinker";
            this.blinker.UseVisualStyleBackColor = true;
            this.blinker.Click += new System.EventHandler(this.blinker_Click);
            // 
            // drawTimer
            // 
            this.drawTimer.Tick += new System.EventHandler(this.drawTimer_Tick);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(574, 67);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(119, 36);
            this.clear.TabIndex = 4;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Shuriken
            // 
            this.Shuriken.Location = new System.Drawing.Point(6, 204);
            this.Shuriken.Name = "Shuriken";
            this.Shuriken.Size = new System.Drawing.Size(106, 31);
            this.Shuriken.TabIndex = 4;
            this.Shuriken.Text = "Galaxy";
            this.Shuriken.UseVisualStyleBackColor = true;
            this.Shuriken.Click += new System.EventHandler(this.Shuriken_Click);
            // 
            // Toad
            // 
            this.Toad.Location = new System.Drawing.Point(6, 56);
            this.Toad.Name = "Toad";
            this.Toad.Size = new System.Drawing.Size(106, 31);
            this.Toad.TabIndex = 5;
            this.Toad.Text = "Toad";
            this.Toad.UseVisualStyleBackColor = true;
            this.Toad.Click += new System.EventHandler(this.Toad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 565);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.play);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Conway\'s Game of Life";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button dieHard;
        private System.Windows.Forms.Button Glider;
        private System.Windows.Forms.Button blinker;
        private System.Windows.Forms.Timer drawTimer;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button Pulsar;
        private System.Windows.Forms.Button Shuriken;
        private System.Windows.Forms.Button Toad;
    }
}

