namespace RestaurantPOS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            close = new Label();
            datelbl = new Label();
            label1 = new Label();
            panel2 = new Panel();
            burritotb = new TextBox();
            chipstb = new TextBox();
            pizzatb = new TextBox();
            burgertb = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            burritocb = new CheckBox();
            chipscb = new CheckBox();
            burgercb = new CheckBox();
            pizzacb = new CheckBox();
            panel3 = new Panel();
            panel4 = new Panel();
            fantatb = new TextBox();
            spritetb = new TextBox();
            watertb = new TextBox();
            colatb = new TextBox();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            colacb = new CheckBox();
            fantacb = new CheckBox();
            spritecb = new CheckBox();
            watercb = new CheckBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label3 = new Label();
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            timer1 = new System.Windows.Forms.Timer(components);
            panel5 = new Panel();
            panel6 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            grdtotallbl = new Label();
            label24 = new Label();
            taxlbl = new Label();
            label22 = new Label();
            SubTotallbl = new Label();
            label21 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            receipttb = new RichTextBox();
            panel7 = new Panel();
            label26 = new Label();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Firebrick;
            panel1.Controls.Add(close);
            panel1.Controls.Add(datelbl);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(951, 127);
            panel1.TabIndex = 0;
            // 
            // close
            // 
            close.AutoSize = true;
            close.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            close.ForeColor = SystemColors.Control;
            close.Location = new Point(920, 0);
            close.Name = "close";
            close.Size = new Size(28, 26);
            close.TabIndex = 2;
            close.Text = "X";
            close.Click += close_Click;
            // 
            // datelbl
            // 
            datelbl.AutoSize = true;
            datelbl.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            datelbl.ForeColor = SystemColors.Control;
            datelbl.Location = new Point(840, 79);
            datelbl.Name = "datelbl";
            datelbl.Size = new Size(67, 26);
            datelbl.TabIndex = 1;
            datelbl.Text = "date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(79, 31);
            label1.Name = "label1";
            label1.Size = new Size(741, 74);
            label1.TabIndex = 0;
            label1.Text = "Fast Food Restaurant";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(burritotb);
            panel2.Controls.Add(chipstb);
            panel2.Controls.Add(pizzatb);
            panel2.Controls.Add(burgertb);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(burritocb);
            panel2.Controls.Add(chipscb);
            panel2.Controls.Add(burgercb);
            panel2.Controls.Add(pizzacb);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 127);
            panel2.Name = "panel2";
            panel2.Size = new Size(235, 323);
            panel2.TabIndex = 1;
            // 
            // burritotb
            // 
            burritotb.Enabled = false;
            burritotb.Location = new Point(195, 199);
            burritotb.Multiline = true;
            burritotb.Name = "burritotb";
            burritotb.Size = new Size(28, 27);
            burritotb.TabIndex = 17;
            burritotb.Text = "0";
            burritotb.TextAlign = HorizontalAlignment.Center;
            // 
            // chipstb
            // 
            chipstb.Enabled = false;
            chipstb.Location = new Point(195, 260);
            chipstb.Multiline = true;
            chipstb.Name = "chipstb";
            chipstb.Size = new Size(28, 27);
            chipstb.TabIndex = 16;
            chipstb.Text = "0";
            chipstb.TextAlign = HorizontalAlignment.Center;
            // 
            // pizzatb
            // 
            pizzatb.Enabled = false;
            pizzatb.Location = new Point(195, 142);
            pizzatb.Multiline = true;
            pizzatb.Name = "pizzatb";
            pizzatb.Size = new Size(28, 27);
            pizzatb.TabIndex = 15;
            pizzatb.Text = "0";
            pizzatb.TextAlign = HorizontalAlignment.Center;
            // 
            // burgertb
            // 
            burgertb.Enabled = false;
            burgertb.Location = new Point(195, 88);
            burgertb.Multiline = true;
            burgertb.Name = "burgertb";
            burgertb.Size = new Size(28, 27);
            burgertb.TabIndex = 3;
            burgertb.Text = "0";
            burgertb.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.Control;
            label7.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Firebrick;
            label7.Location = new Point(62, 255);
            label7.Name = "label7";
            label7.Size = new Size(98, 35);
            label7.TabIndex = 14;
            label7.Text = "Chips";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Firebrick;
            label6.Location = new Point(49, 194);
            label6.Name = "label6";
            label6.Size = new Size(140, 35);
            label6.TabIndex = 13;
            label6.Text = "Burrito";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Firebrick;
            label5.Location = new Point(62, 137);
            label5.Name = "label5";
            label5.Size = new Size(98, 35);
            label5.TabIndex = 12;
            label5.Text = "Pizza";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Firebrick;
            label4.Location = new Point(49, 83);
            label4.Name = "label4";
            label4.Size = new Size(127, 35);
            label4.TabIndex = 11;
            label4.Text = "Burger";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Showcard Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Firebrick;
            label2.Location = new Point(54, 17);
            label2.Name = "label2";
            label2.Size = new Size(122, 46);
            label2.TabIndex = 1;
            label2.Text = "Food";
            // 
            // burritocb
            // 
            burritocb.AutoSize = true;
            burritocb.Location = new Point(25, 209);
            burritocb.Name = "burritocb";
            burritocb.Size = new Size(18, 17);
            burritocb.TabIndex = 10;
            burritocb.UseVisualStyleBackColor = true;
            burritocb.CheckedChanged += burritocb_CheckedChanged;
            // 
            // chipscb
            // 
            chipscb.AutoSize = true;
            chipscb.Location = new Point(25, 270);
            chipscb.Name = "chipscb";
            chipscb.Size = new Size(18, 17);
            chipscb.TabIndex = 9;
            chipscb.UseVisualStyleBackColor = true;
            chipscb.CheckedChanged += chipscb_CheckedChanged;
            // 
            // burgercb
            // 
            burgercb.AutoSize = true;
            burgercb.Location = new Point(25, 94);
            burgercb.Name = "burgercb";
            burgercb.Size = new Size(18, 17);
            burgercb.TabIndex = 8;
            burgercb.UseVisualStyleBackColor = true;
            burgercb.CheckedChanged += burgercb_CheckedChanged;
            // 
            // pizzacb
            // 
            pizzacb.AutoSize = true;
            pizzacb.Location = new Point(25, 152);
            pizzacb.Name = "pizzacb";
            pizzacb.Size = new Size(18, 17);
            pizzacb.TabIndex = 3;
            pizzacb.UseVisualStyleBackColor = true;
            pizzacb.CheckedChanged += pizzacb_CheckedChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(textBox5);
            panel3.Controls.Add(textBox6);
            panel3.Controls.Add(textBox7);
            panel3.Controls.Add(textBox8);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(checkBox5);
            panel3.Controls.Add(checkBox4);
            panel3.Controls.Add(checkBox3);
            panel3.Controls.Add(checkBox2);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(673, 127);
            panel3.Name = "panel3";
            panel3.Size = new Size(278, 323);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(fantatb);
            panel4.Controls.Add(spritetb);
            panel4.Controls.Add(watertb);
            panel4.Controls.Add(colatb);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(label15);
            panel4.Controls.Add(label16);
            panel4.Controls.Add(colacb);
            panel4.Controls.Add(fantacb);
            panel4.Controls.Add(spritecb);
            panel4.Controls.Add(watercb);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(278, 323);
            panel4.TabIndex = 19;
            // 
            // fantatb
            // 
            fantatb.Enabled = false;
            fantatb.Location = new Point(229, 142);
            fantatb.Multiline = true;
            fantatb.Name = "fantatb";
            fantatb.Size = new Size(28, 27);
            fantatb.TabIndex = 21;
            fantatb.Text = "0";
            fantatb.TextAlign = HorizontalAlignment.Center;
            // 
            // spritetb
            // 
            spritetb.Enabled = false;
            spritetb.Location = new Point(229, 199);
            spritetb.Multiline = true;
            spritetb.Name = "spritetb";
            spritetb.Size = new Size(28, 27);
            spritetb.TabIndex = 20;
            spritetb.Text = "0";
            spritetb.TextAlign = HorizontalAlignment.Center;
            // 
            // watertb
            // 
            watertb.Enabled = false;
            watertb.Location = new Point(229, 264);
            watertb.Multiline = true;
            watertb.Name = "watertb";
            watertb.Size = new Size(28, 27);
            watertb.TabIndex = 19;
            watertb.Text = "0";
            watertb.TextAlign = HorizontalAlignment.Center;
            // 
            // colatb
            // 
            colatb.Enabled = false;
            colatb.Location = new Point(229, 88);
            colatb.Multiline = true;
            colatb.Name = "colatb";
            colatb.Size = new Size(28, 27);
            colatb.TabIndex = 18;
            colatb.Text = "0";
            colatb.TextAlign = HorizontalAlignment.Center;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = SystemColors.Control;
            label12.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.Firebrick;
            label12.Location = new Point(66, 260);
            label12.Name = "label12";
            label12.Size = new Size(114, 35);
            label12.TabIndex = 18;
            label12.Text = "Water";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = SystemColors.Control;
            label13.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.Firebrick;
            label13.Location = new Point(69, 194);
            label13.Name = "label13";
            label13.Size = new Size(111, 35);
            label13.TabIndex = 17;
            label13.Text = "Sprite";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = SystemColors.Control;
            label14.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.Firebrick;
            label14.Location = new Point(77, 137);
            label14.Name = "label14";
            label14.Size = new Size(100, 35);
            label14.TabIndex = 16;
            label14.Text = "Fanta";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = SystemColors.Control;
            label15.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = Color.Firebrick;
            label15.Location = new Point(46, 83);
            label15.Name = "label15";
            label15.Size = new Size(167, 35);
            label15.TabIndex = 15;
            label15.Text = "Coca-Cola";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = SystemColors.Control;
            label16.Font = new Font("Showcard Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.Firebrick;
            label16.Location = new Point(53, 17);
            label16.Name = "label16";
            label16.Size = new Size(160, 46);
            label16.TabIndex = 11;
            label16.Text = "Drinks";
            // 
            // colacb
            // 
            colacb.AutoSize = true;
            colacb.Location = new Point(12, 94);
            colacb.Name = "colacb";
            colacb.Size = new Size(18, 17);
            colacb.TabIndex = 7;
            colacb.UseVisualStyleBackColor = true;
            colacb.CheckedChanged += colacb_CheckedChanged;
            // 
            // fantacb
            // 
            fantacb.AutoSize = true;
            fantacb.Location = new Point(12, 152);
            fantacb.Name = "fantacb";
            fantacb.Size = new Size(18, 17);
            fantacb.TabIndex = 6;
            fantacb.UseVisualStyleBackColor = true;
            fantacb.CheckedChanged += fantacb_CheckedChanged;
            // 
            // spritecb
            // 
            spritecb.AutoSize = true;
            spritecb.Location = new Point(12, 209);
            spritecb.Name = "spritecb";
            spritecb.Size = new Size(18, 17);
            spritecb.TabIndex = 5;
            spritecb.UseVisualStyleBackColor = true;
            spritecb.CheckedChanged += spritecb_CheckedChanged;
            // 
            // watercb
            // 
            watercb.AutoSize = true;
            watercb.Location = new Point(12, 270);
            watercb.Name = "watercb";
            watercb.Size = new Size(18, 17);
            watercb.TabIndex = 4;
            watercb.UseVisualStyleBackColor = true;
            watercb.CheckedChanged += watercb_CheckedChanged;
            // 
            // textBox5
            // 
            textBox5.Enabled = false;
            textBox5.Location = new Point(195, 199);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(28, 27);
            textBox5.TabIndex = 23;
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            textBox6.Enabled = false;
            textBox6.Location = new Point(195, 260);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(28, 27);
            textBox6.TabIndex = 22;
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            textBox7.Enabled = false;
            textBox7.Location = new Point(195, 142);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(28, 27);
            textBox7.TabIndex = 21;
            textBox7.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            textBox8.Enabled = false;
            textBox8.Location = new Point(195, 88);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(28, 27);
            textBox8.TabIndex = 20;
            textBox8.TextAlign = HorizontalAlignment.Center;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.Control;
            label11.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.Firebrick;
            label11.Location = new Point(36, 255);
            label11.Name = "label11";
            label11.Size = new Size(114, 35);
            label11.TabIndex = 18;
            label11.Text = "Water";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.Control;
            label10.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Firebrick;
            label10.Location = new Point(36, 194);
            label10.Name = "label10";
            label10.Size = new Size(111, 35);
            label10.TabIndex = 17;
            label10.Text = "Sprite";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.Control;
            label9.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Firebrick;
            label9.Location = new Point(36, 137);
            label9.Name = "label9";
            label9.Size = new Size(100, 35);
            label9.TabIndex = 16;
            label9.Text = "Fanta";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.Control;
            label8.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Firebrick;
            label8.Location = new Point(36, 83);
            label8.Name = "label8";
            label8.Size = new Size(167, 35);
            label8.TabIndex = 15;
            label8.Text = "Coca-Cola";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Showcard Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Firebrick;
            label3.Location = new Point(17, 17);
            label3.Name = "label3";
            label3.Size = new Size(160, 46);
            label3.TabIndex = 11;
            label3.Text = "Drinks";
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(12, 94);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(18, 17);
            checkBox5.TabIndex = 7;
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(12, 152);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(18, 17);
            checkBox4.TabIndex = 6;
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(12, 209);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(18, 17);
            checkBox3.TabIndex = 5;
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(12, 270);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(18, 17);
            checkBox2.TabIndex = 4;
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(label19);
            panel5.Controls.Add(label18);
            panel5.Controls.Add(label17);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(235, 336);
            panel5.Name = "panel5";
            panel5.Size = new Size(438, 114);
            panel5.TabIndex = 3;
            // 
            // panel6
            // 
            panel6.Controls.Add(button3);
            panel6.Controls.Add(button2);
            panel6.Controls.Add(button1);
            panel6.Controls.Add(grdtotallbl);
            panel6.Controls.Add(label24);
            panel6.Controls.Add(taxlbl);
            panel6.Controls.Add(label22);
            panel6.Controls.Add(SubTotallbl);
            panel6.Controls.Add(label21);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(438, 114);
            panel6.TabIndex = 15;
            // 
            // button3
            // 
            button3.BackColor = Color.Firebrick;
            button3.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(285, 57);
            button3.Name = "button3";
            button3.Size = new Size(94, 32);
            button3.TabIndex = 20;
            button3.Text = "PRINT";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Firebrick;
            button2.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(159, 57);
            button2.Name = "button2";
            button2.Size = new Size(94, 32);
            button2.TabIndex = 19;
            button2.Text = "ADD";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Firebrick;
            button1.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(32, 57);
            button1.Name = "button1";
            button1.Size = new Size(94, 32);
            button1.TabIndex = 18;
            button1.Text = "RESET";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // grdtotallbl
            // 
            grdtotallbl.AutoSize = true;
            grdtotallbl.BackColor = SystemColors.Control;
            grdtotallbl.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            grdtotallbl.ForeColor = Color.Black;
            grdtotallbl.Location = new Point(358, 12);
            grdtotallbl.Name = "grdtotallbl";
            grdtotallbl.Size = new Size(21, 26);
            grdtotallbl.TabIndex = 17;
            grdtotallbl.Text = "£";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.BackColor = SystemColors.Control;
            label24.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label24.ForeColor = Color.Firebrick;
            label24.Location = new Point(287, 12);
            label24.Name = "label24";
            label24.Size = new Size(76, 26);
            label24.TabIndex = 16;
            label24.Text = "Total";
            // 
            // taxlbl
            // 
            taxlbl.AutoSize = true;
            taxlbl.BackColor = SystemColors.Control;
            taxlbl.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            taxlbl.ForeColor = Color.Black;
            taxlbl.Location = new Point(220, 12);
            taxlbl.Name = "taxlbl";
            taxlbl.Size = new Size(21, 26);
            taxlbl.TabIndex = 15;
            taxlbl.Text = "£";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = SystemColors.Control;
            label22.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label22.ForeColor = Color.Firebrick;
            label22.Location = new Point(176, 12);
            label22.Name = "label22";
            label22.Size = new Size(52, 26);
            label22.TabIndex = 14;
            label22.Text = "Tax";
            // 
            // SubTotallbl
            // 
            SubTotallbl.AutoSize = true;
            SubTotallbl.BackColor = SystemColors.Control;
            SubTotallbl.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SubTotallbl.ForeColor = Color.Black;
            SubTotallbl.Location = new Point(125, 12);
            SubTotallbl.Name = "SubTotallbl";
            SubTotallbl.Size = new Size(21, 26);
            SubTotallbl.TabIndex = 13;
            SubTotallbl.Text = "£";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = SystemColors.Control;
            label21.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label21.ForeColor = Color.Firebrick;
            label21.Location = new Point(17, 12);
            label21.Name = "label21";
            label21.Size = new Size(113, 26);
            label21.TabIndex = 12;
            label21.Text = "SubTotal";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = SystemColors.Control;
            label19.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label19.ForeColor = Color.Firebrick;
            label19.Location = new Point(303, 12);
            label19.Name = "label19";
            label19.Size = new Size(92, 26);
            label19.TabIndex = 14;
            label19.Text = "Burger";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = SystemColors.Control;
            label18.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label18.ForeColor = Color.Black;
            label18.Location = new Point(105, 12);
            label18.Name = "label18";
            label18.Size = new Size(61, 26);
            label18.TabIndex = 13;
            label18.Text = "Rs/--";
            label18.Click += label18_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = SystemColors.Control;
            label17.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = Color.Firebrick;
            label17.Location = new Point(17, 12);
            label17.Name = "label17";
            label17.Size = new Size(92, 26);
            label17.TabIndex = 12;
            label17.Text = "Burger";
            // 
            // receipttb
            // 
            receipttb.BorderStyle = BorderStyle.None;
            receipttb.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            receipttb.Location = new Point(235, 169);
            receipttb.Name = "receipttb";
            receipttb.Size = new Size(438, 176);
            receipttb.TabIndex = 4;
            receipttb.Text = "";
            // 
            // panel7
            // 
            panel7.Controls.Add(label26);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(235, 127);
            panel7.Name = "panel7";
            panel7.Size = new Size(438, 44);
            panel7.TabIndex = 5;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.BackColor = SystemColors.Control;
            label26.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label26.ForeColor = Color.Firebrick;
            label26.Location = new Point(156, 5);
            label26.Name = "label26";
            label26.Size = new Size(110, 35);
            label26.TabIndex = 12;
            label26.Text = "ORDER";
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            printPreviewDialog1.Load += printPreviewDialog1_Load;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 450);
            Controls.Add(panel7);
            Controls.Add(receipttb);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Label label2;
        private CheckBox burritocb;
        private CheckBox chipscb;
        private CheckBox burgercb;
        private CheckBox pizzacb;
        private Label label3;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private TextBox burgertb;
        private TextBox burritotb;
        private TextBox chipstb;
        private TextBox pizzatb;
        private Panel panel4;
        private TextBox fantatb;
        private TextBox spritetb;
        private TextBox watertb;
        private TextBox colatb;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private CheckBox colacb;
        private CheckBox fantacb;
        private CheckBox spritecb;
        private CheckBox watercb;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private Label datelbl;
        private System.Windows.Forms.Timer timer1;
        private Label close;
        private Panel panel5;
        private Label label17;
        private Label label19;
        private Label label18;
        private Panel panel6;
        private Label label22;
        private Label SubTotallbl;
        private Label label21;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label grdtotallbl;
        private Label label24;
        private Label taxlbl;
        private RichTextBox receipttb;
        private Panel panel7;
        private Label label26;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}