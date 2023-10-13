namespace RestaurantPOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            datelbl.Text = DateTime.Now.ToLongTimeString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            datelbl.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
        }

        private void burgercb_CheckedChanged(object sender, EventArgs e)
        {
            if (burgercb.Checked == true)
            {
                burgertb.Enabled = true;
            }
            if (burgercb.Checked == false)
            {
                burgertb.Enabled = false;
                burgertb.Text = "0";
            }
        }

        private void pizzacb_CheckedChanged(object sender, EventArgs e)
        {
            if (pizzacb.Checked == true)
            {
                pizzatb.Enabled = true;
            }
            if (pizzacb.Checked == false)
            {
                pizzatb.Enabled = false;
                pizzatb.Text = "0";
            }
        }

        private void burritocb_CheckedChanged(object sender, EventArgs e)
        {
            if (burritocb.Checked == true)
            {
                burritotb.Enabled = true;
            }
            if (burritocb.Checked == false)
            {
                burritotb.Enabled = false;
                burritotb.Text = "0";
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void chipscb_CheckedChanged(object sender, EventArgs e)
        {
            if (chipscb.Checked == true)
            {
                chipstb.Enabled = true;
            }
            if (chipscb.Checked == false)
            {
                chipstb.Enabled = false;
                chipstb.Text = "0";
            }
        }

        private void colacb_CheckedChanged(object sender, EventArgs e)
        {
            if (colacb.Checked == true)
            {
                colatb.Enabled = true;
            }
            if (colacb.Checked == false)
            {
                colatb.Enabled = false;
                colatb.Text = "0";
            }
        }

        private void fantacb_CheckedChanged(object sender, EventArgs e)
        {
            if (fantacb.Checked == true)
            {
                fantatb.Enabled = true;
            }
            if (fantacb.Checked == false)
            {
                fantatb.Enabled = false;
                fantatb.Text = "0";
            }
        }

        private void spritecb_CheckedChanged(object sender, EventArgs e)
        {
            if (spritecb.Checked == true)
            {
                spritetb.Enabled = true;
            }
            if (spritecb.Checked == false)
            {
                spritetb.Enabled = false;
                spritetb.Text = "0";
            }
        }

        private void watercb_CheckedChanged(object sender, EventArgs e)
        {
            if (watercb.Checked == true)
            {
                watertb.Enabled = true;
            }
            if (watercb.Checked == false)
            {
                watertb.Enabled = false;
                watertb.Text = "0";
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Declare Unit Price for Food and Drinks
        double burgerup = 8.50, pizzaup = 10.50, burritoup = 10, chipsup = 2.50;
        double colaup = 1.5, fantaup = 0.5, spriteup = 2, waterup = 0.5;

        //Declare variable to hold total price for each drink and food
        double burgertp, pizzatp, burritotp, chipstp, colatp, fantatp, spritetp, watertp;
        double SubTotal = 0, tax, grdtotal;


        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            burgertp = burgerup * Convert.ToDouble(burgertb.Text);
            pizzatp = pizzaup * Convert.ToDouble(pizzatb.Text);
            burritotp = burritoup * Convert.ToDouble(burritotb.Text);
            chipstp = chipsup * Convert.ToDouble(chipstb.Text);
            //Drinks
            colatp = colaup * Convert.ToDouble(colatb.Text);
            fantatp = fantaup * Convert.ToDouble(fantatb.Text);
            spritetp = spriteup * Convert.ToDouble(spritetb.Text);
            watertp = waterup * Convert.ToDouble(watertb.Text);

            //Adding products on receipts
            receipttb.Clear();
            SubTotal = 0;
            receipttb.AppendText(Environment.NewLine);
            receipttb.AppendText("\t\t\tRECEIPT\t\t" + datelbl.Text + Environment.NewLine);
            receipttb.AppendText("\t\t**************************" + Environment.NewLine);
            if (burgercb.Checked == true)
            {
                receipttb.AppendText("\tBurger:£" + burgertp + Environment.NewLine);
                SubTotal = SubTotal + burgertp;
                SubTotallbl.Text = "" + SubTotal;
            }
            if (pizzacb.Checked == true)
            {
                receipttb.AppendText("\tPizza:£" + pizzatp + Environment.NewLine);
                SubTotal = SubTotal + pizzatp;
                SubTotallbl.Text = "" + SubTotal;
            }
            if (burritocb.Checked == true)
            {
                receipttb.AppendText("\tBurrito:£" + burritotp + Environment.NewLine);
                SubTotal = SubTotal + burritotp;
                SubTotallbl.Text = "" + SubTotal;
            }
            if (chipscb.Checked == true)
            {
                receipttb.AppendText("\tChips:£" + chipstp + Environment.NewLine);
                SubTotal = SubTotal + chipstp;
                SubTotallbl.Text = "" + SubTotal;
            }
            //Drinks
            if (colacb.Checked == true)
            {
                receipttb.AppendText("\tCoaca-Cola:£" + colatp + Environment.NewLine);
                SubTotal = SubTotal + colatp;
                SubTotallbl.Text = "" + SubTotal;
            }
            if (fantacb.Checked == true)
            {
                receipttb.AppendText("\tFanta:£" + fantatp + Environment.NewLine);
                SubTotal = SubTotal + fantatp;
                SubTotallbl.Text = "" + SubTotal;
            }
            if (spritecb.Checked == true)
            {
                receipttb.AppendText("\tsprite:£" + spritetp + Environment.NewLine);
                SubTotal = SubTotal + spritetp;
                SubTotallbl.Text = "" + SubTotal;
            }
            if (watercb.Checked == true)
            {
                receipttb.AppendText("\tWater:£" + watertp + Environment.NewLine);
                SubTotal = SubTotal + watertp;
                SubTotallbl.Text = "" + SubTotal;
            }
            //tax
            tax = SubTotal * 0.32;
            grdtotal = SubTotal + tax;
            taxlbl.Text = "£" + tax;
            grdtotallbl.Text = "£" + grdtotal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            burgercb.Checked = false;
            pizzacb.Checked = false;
            burritocb.Checked = false;
            chipscb.Checked = false;
            colacb.Checked = false;
            fantacb.Checked = false;
            spritecb.Checked = false;
            watercb.Checked = false;
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(receipttb.Text + " SubTotal: £" + SubTotallbl.Text + "\tTax: " + taxlbl.Text + "\tGrandTotal: " + grdtotallbl.Text, new Font("Century Gothic", 12, FontStyle.Regular), Brushes.Blue, new Point(130));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(printPreviewDialog1.ShowDialog()==DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
    }
}