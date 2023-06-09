﻿namespace Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Car_img = new System.Windows.Forms.PictureBox();
            this.Road_img = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.Road_img2 = new System.Windows.Forms.PictureBox();
            this.redCar = new System.Windows.Forms.PictureBox();
            this.redCar1 = new System.Windows.Forms.PictureBox();
            this.looseMessage = new System.Windows.Forms.Label();
            this.restart_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Car_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Road_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Road_img2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redCar1)).BeginInit();
            this.SuspendLayout();
            // 
            // Car_img
            // 
            this.Car_img.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Car_img.Image = global::Game.Properties.Resources.car;
            this.Car_img.Location = new System.Drawing.Point(548, 510);
            this.Car_img.Name = "Car_img";
            this.Car_img.Size = new System.Drawing.Size(128, 128);
            this.Car_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Car_img.TabIndex = 1;
            this.Car_img.TabStop = false;
            // 
            // Road_img
            // 
            this.Road_img.Image = global::Game.Properties.Resources.Road;
            this.Road_img.Location = new System.Drawing.Point(0, 0);
            this.Road_img.Name = "Road_img";
            this.Road_img.Size = new System.Drawing.Size(915, 650);
            this.Road_img.TabIndex = 0;
            this.Road_img.TabStop = false;
            this.Road_img.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 20;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Road_img2
            // 
            this.Road_img2.Image = global::Game.Properties.Resources.Road;
            this.Road_img2.Location = new System.Drawing.Point(0, -650);
            this.Road_img2.Name = "Road_img2";
            this.Road_img2.Size = new System.Drawing.Size(840, 650);
            this.Road_img2.TabIndex = 2;
            this.Road_img2.TabStop = false;
            // 
            // redCar
            // 
            this.redCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.redCar.Image = ((System.Drawing.Image)(resources.GetObject("redCar.Image")));
            this.redCar.Location = new System.Drawing.Point(170, -130);
            this.redCar.Name = "redCar";
            this.redCar.Size = new System.Drawing.Size(128, 128);
            this.redCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.redCar.TabIndex = 3;
            this.redCar.TabStop = false;
            this.redCar.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // redCar1
            // 
            this.redCar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.redCar1.Image = ((System.Drawing.Image)(resources.GetObject("redCar1.Image")));
            this.redCar1.Location = new System.Drawing.Point(538, -400);
            this.redCar1.Name = "redCar1";
            this.redCar1.Size = new System.Drawing.Size(128, 128);
            this.redCar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.redCar1.TabIndex = 4;
            this.redCar1.TabStop = false;
            // 
            // looseMessage
            // 
            this.looseMessage.AutoSize = true;
            this.looseMessage.BackColor = System.Drawing.Color.Yellow;
            this.looseMessage.Font = new System.Drawing.Font("Microsoft Uighur", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.looseMessage.Location = new System.Drawing.Point(312, 201);
            this.looseMessage.Name = "looseMessage";
            this.looseMessage.Size = new System.Drawing.Size(202, 48);
            this.looseMessage.TabIndex = 5;
            this.looseMessage.Text = "Sorry. You lose";
            this.looseMessage.Click += new System.EventHandler(this.label1_Click);
            // 
            // restart_btn
            // 
            this.restart_btn.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restart_btn.Location = new System.Drawing.Point(259, 306);
            this.restart_btn.Name = "restart_btn";
            this.restart_btn.Size = new System.Drawing.Size(314, 95);
            this.restart_btn.TabIndex = 6;
            this.restart_btn.Text = "Restart";
            this.restart_btn.UseVisualStyleBackColor = true;
            this.restart_btn.Click += new System.EventHandler(this.restart_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(840, 650);
            this.Controls.Add(this.restart_btn);
            this.Controls.Add(this.looseMessage);
            this.Controls.Add(this.redCar1);
            this.Controls.Add(this.redCar);
            this.Controls.Add(this.Car_img);
            this.Controls.Add(this.Road_img);
            this.Controls.Add(this.Road_img2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.Car_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Road_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Road_img2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redCar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Road_img;
        private System.Windows.Forms.PictureBox Car_img;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox Road_img2;
        private System.Windows.Forms.PictureBox redCar;
        private System.Windows.Forms.PictureBox redCar1;
        private System.Windows.Forms.Label looseMessage;
        private System.Windows.Forms.Button restart_btn;
    }
}

