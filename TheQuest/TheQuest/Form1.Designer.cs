namespace TheQuest
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.hasSword = new System.Windows.Forms.PictureBox();
            this.hasBluePotion = new System.Windows.Forms.PictureBox();
            this.hasRedPotion = new System.Windows.Forms.PictureBox();
            this.hasMace = new System.Windows.Forms.PictureBox();
            this.hasBow = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.sword = new System.Windows.Forms.PictureBox();
            this.bat = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.bow = new System.Windows.Forms.PictureBox();
            this.redPotion = new System.Windows.Forms.PictureBox();
            this.bluePotion = new System.Windows.Forms.PictureBox();
            this.mace = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.batHitPoints = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.playerHitPoints = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.moveDown = new System.Windows.Forms.Button();
            this.moveLeft = new System.Windows.Forms.Button();
            this.moveRight = new System.Windows.Forms.Button();
            this.moveUp = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hasSword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hasBluePotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hasRedPotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hasMace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hasBow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redPotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mace)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // hasSword
            // 
            this.hasSword.BackColor = System.Drawing.Color.Transparent;
            this.hasSword.BackgroundImage = global::TheQuest.Properties.Resources.sword;
            this.hasSword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hasSword.Location = new System.Drawing.Point(111, 467);
            this.hasSword.Name = "hasSword";
            this.hasSword.Size = new System.Drawing.Size(69, 69);
            this.hasSword.TabIndex = 5;
            this.hasSword.TabStop = false;
            this.hasSword.Click += new System.EventHandler(this.hasSword_Click);
            // 
            // hasBluePotion
            // 
            this.hasBluePotion.BackColor = System.Drawing.Color.Transparent;
            this.hasBluePotion.BackgroundImage = global::TheQuest.Properties.Resources.potion_blue;
            this.hasBluePotion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hasBluePotion.Location = new System.Drawing.Point(411, 467);
            this.hasBluePotion.Name = "hasBluePotion";
            this.hasBluePotion.Size = new System.Drawing.Size(69, 69);
            this.hasBluePotion.TabIndex = 6;
            this.hasBluePotion.TabStop = false;
            // 
            // hasRedPotion
            // 
            this.hasRedPotion.BackColor = System.Drawing.Color.Transparent;
            this.hasRedPotion.BackgroundImage = global::TheQuest.Properties.Resources.potion_red;
            this.hasRedPotion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hasRedPotion.Location = new System.Drawing.Point(336, 467);
            this.hasRedPotion.Name = "hasRedPotion";
            this.hasRedPotion.Size = new System.Drawing.Size(69, 69);
            this.hasRedPotion.TabIndex = 7;
            this.hasRedPotion.TabStop = false;
            // 
            // hasMace
            // 
            this.hasMace.BackColor = System.Drawing.Color.Transparent;
            this.hasMace.BackgroundImage = global::TheQuest.Properties.Resources.mace;
            this.hasMace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hasMace.Location = new System.Drawing.Point(261, 467);
            this.hasMace.Name = "hasMace";
            this.hasMace.Size = new System.Drawing.Size(69, 69);
            this.hasMace.TabIndex = 8;
            this.hasMace.TabStop = false;
            // 
            // hasBow
            // 
            this.hasBow.BackColor = System.Drawing.Color.Transparent;
            this.hasBow.BackgroundImage = global::TheQuest.Properties.Resources.bow;
            this.hasBow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hasBow.Location = new System.Drawing.Point(186, 467);
            this.hasBow.Name = "hasBow";
            this.hasBow.Size = new System.Drawing.Size(69, 69);
            this.hasBow.TabIndex = 9;
            this.hasBow.TabStop = false;
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.Image = global::TheQuest.Properties.Resources.player;
            this.Player.Location = new System.Drawing.Point(128, 90);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(50, 50);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player.TabIndex = 10;
            this.Player.TabStop = false;
            this.Player.Visible = false;
            // 
            // sword
            // 
            this.sword.BackColor = System.Drawing.Color.Transparent;
            this.sword.Image = global::TheQuest.Properties.Resources.sword;
            this.sword.Location = new System.Drawing.Point(128, 201);
            this.sword.Name = "sword";
            this.sword.Size = new System.Drawing.Size(50, 50);
            this.sword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sword.TabIndex = 11;
            this.sword.TabStop = false;
            this.sword.Visible = false;
            // 
            // bat
            // 
            this.bat.BackColor = System.Drawing.Color.Transparent;
            this.bat.Image = global::TheQuest.Properties.Resources.bat;
            this.bat.Location = new System.Drawing.Point(245, 211);
            this.bat.Name = "bat";
            this.bat.Size = new System.Drawing.Size(50, 50);
            this.bat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bat.TabIndex = 12;
            this.bat.TabStop = false;
            this.bat.Visible = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.Image = global::TheQuest.Properties.Resources.ghoul;
            this.pictureBox9.Location = new System.Drawing.Point(236, 90);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(30, 30);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 13;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Visible = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.Image = global::TheQuest.Properties.Resources.ghost;
            this.pictureBox10.Location = new System.Drawing.Point(272, 90);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(30, 30);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 14;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Visible = false;
            // 
            // bow
            // 
            this.bow.BackColor = System.Drawing.Color.Transparent;
            this.bow.Image = global::TheQuest.Properties.Resources.bow;
            this.bow.Location = new System.Drawing.Point(308, 90);
            this.bow.Name = "bow";
            this.bow.Size = new System.Drawing.Size(30, 30);
            this.bow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bow.TabIndex = 15;
            this.bow.TabStop = false;
            this.bow.Visible = false;
            // 
            // redPotion
            // 
            this.redPotion.BackColor = System.Drawing.Color.Transparent;
            this.redPotion.Image = global::TheQuest.Properties.Resources.potion_red;
            this.redPotion.Location = new System.Drawing.Point(344, 90);
            this.redPotion.Name = "redPotion";
            this.redPotion.Size = new System.Drawing.Size(30, 30);
            this.redPotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.redPotion.TabIndex = 16;
            this.redPotion.TabStop = false;
            this.redPotion.Visible = false;
            // 
            // bluePotion
            // 
            this.bluePotion.BackColor = System.Drawing.Color.Transparent;
            this.bluePotion.Image = global::TheQuest.Properties.Resources.potion_blue;
            this.bluePotion.Location = new System.Drawing.Point(380, 90);
            this.bluePotion.Name = "bluePotion";
            this.bluePotion.Size = new System.Drawing.Size(30, 30);
            this.bluePotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bluePotion.TabIndex = 17;
            this.bluePotion.TabStop = false;
            this.bluePotion.Visible = false;
            // 
            // mace
            // 
            this.mace.BackColor = System.Drawing.Color.Transparent;
            this.mace.Image = global::TheQuest.Properties.Resources.mace;
            this.mace.Location = new System.Drawing.Point(416, 90);
            this.mace.Name = "mace";
            this.mace.Size = new System.Drawing.Size(30, 30);
            this.mace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mace.TabIndex = 18;
            this.mace.TabStop = false;
            this.mace.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.5F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.batHitPoints, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.playerHitPoints, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(618, 367);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(196, 83);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "蝙蝠：";
            // 
            // batHitPoints
            // 
            this.batHitPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.batHitPoints.AutoSize = true;
            this.batHitPoints.Location = new System.Drawing.Point(80, 20);
            this.batHitPoints.Name = "batHitPoints";
            this.batHitPoints.Size = new System.Drawing.Size(113, 20);
            this.batHitPoints.TabIndex = 22;
            this.batHitPoints.Text = "label4";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Ghost";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 23);
            this.label7.TabIndex = 25;
            this.label7.Text = "Ghoul";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(80, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 23);
            this.label8.TabIndex = 26;
            this.label8.Text = "label8";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "玩家：";
            // 
            // playerHitPoints
            // 
            this.playerHitPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playerHitPoints.AutoSize = true;
            this.playerHitPoints.Location = new System.Drawing.Point(80, 0);
            this.playerHitPoints.Name = "playerHitPoints";
            this.playerHitPoints.Size = new System.Drawing.Size(113, 20);
            this.playerHitPoints.TabIndex = 20;
            this.playerHitPoints.Text = "label2";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.moveDown);
            this.groupBox1.Controls.Add(this.moveLeft);
            this.groupBox1.Controls.Add(this.moveRight);
            this.groupBox1.Controls.Add(this.moveUp);
            this.groupBox1.Location = new System.Drawing.Point(543, 467);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 81);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "移动";
            // 
            // moveDown
            // 
            this.moveDown.Location = new System.Drawing.Point(54, 43);
            this.moveDown.Name = "moveDown";
            this.moveDown.Size = new System.Drawing.Size(37, 26);
            this.moveDown.TabIndex = 21;
            this.moveDown.Text = "↓";
            this.moveDown.UseVisualStyleBackColor = true;
            this.moveDown.Click += new System.EventHandler(this.moveDown_Click);
            // 
            // moveLeft
            // 
            this.moveLeft.Location = new System.Drawing.Point(11, 25);
            this.moveLeft.Name = "moveLeft";
            this.moveLeft.Size = new System.Drawing.Size(37, 26);
            this.moveLeft.TabIndex = 22;
            this.moveLeft.Text = "←";
            this.moveLeft.UseVisualStyleBackColor = true;
            // 
            // moveRight
            // 
            this.moveRight.Location = new System.Drawing.Point(97, 25);
            this.moveRight.Name = "moveRight";
            this.moveRight.Size = new System.Drawing.Size(37, 26);
            this.moveRight.TabIndex = 23;
            this.moveRight.Text = "→";
            this.moveRight.UseVisualStyleBackColor = true;
            this.moveRight.Click += new System.EventHandler(this.moveRight_Click);
            // 
            // moveUp
            // 
            this.moveUp.Location = new System.Drawing.Point(54, 11);
            this.moveUp.Name = "moveUp";
            this.moveUp.Size = new System.Drawing.Size(37, 26);
            this.moveUp.TabIndex = 0;
            this.moveUp.Text = "↑";
            this.moveUp.UseVisualStyleBackColor = true;
            this.moveUp.Click += new System.EventHandler(this.moveUp_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Location = new System.Drawing.Point(712, 467);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(140, 81);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "攻击";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(54, 43);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(37, 26);
            this.button5.TabIndex = 21;
            this.button5.Text = "↓";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(11, 25);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(37, 26);
            this.button6.TabIndex = 22;
            this.button6.Text = "←";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(97, 25);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(37, 26);
            this.button7.TabIndex = 23;
            this.button7.Text = "→";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(54, 11);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(37, 26);
            this.button8.TabIndex = 0;
            this.button8.Text = "↑";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TheQuest.Properties.Resources.dungeon600x400;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(958, 600);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.bluePotion);
            this.Controls.Add(this.redPotion);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.bat);
            this.Controls.Add(this.hasBow);
            this.Controls.Add(this.hasMace);
            this.Controls.Add(this.hasRedPotion);
            this.Controls.Add(this.hasBluePotion);
            this.Controls.Add(this.hasSword);
            this.Controls.Add(this.sword);
            this.Controls.Add(this.bow);
            this.Controls.Add(this.mace);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "The Quest";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hasSword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hasBluePotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hasRedPotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hasMace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hasBow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redPotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mace)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox hasSword;
        private System.Windows.Forms.PictureBox hasBluePotion;
        private System.Windows.Forms.PictureBox hasRedPotion;
        private System.Windows.Forms.PictureBox hasMace;
        private System.Windows.Forms.PictureBox hasBow;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox sword;
        private System.Windows.Forms.PictureBox bat;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox bow;
        private System.Windows.Forms.PictureBox redPotion;
        private System.Windows.Forms.PictureBox bluePotion;
        private System.Windows.Forms.PictureBox mace;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label batHitPoints;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label playerHitPoints;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button moveDown;
        private System.Windows.Forms.Button moveLeft;
        private System.Windows.Forms.Button moveRight;
        private System.Windows.Forms.Button moveUp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}

