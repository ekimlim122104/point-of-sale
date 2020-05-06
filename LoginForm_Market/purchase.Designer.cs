namespace LoginForm_Market
{
    partial class purchase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.vattxt = new System.Windows.Forms.TextBox();
            this.vatper = new System.Windows.Forms.Label();
            this._change = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this._ID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this._totalStock = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this._stock = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.t_total = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this._tqty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this._tprice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this._tmoney = new System.Windows.Forms.TextBox();
            this._tname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timelbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.vattxt);
            this.groupBox1.Controls.Add(this.vatper);
            this.groupBox1.Controls.Add(this._change);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this._ID);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this._totalStock);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this._stock);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.t_total);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this._tqty);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this._tprice);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this._tmoney);
            this.groupBox1.Controls.Add(this._tname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 446);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Purchase Products";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 31;
            this.listBox1.Location = new System.Drawing.Point(141, 144);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(162, 35);
            this.listBox1.TabIndex = 8;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // vattxt
            // 
            this.vattxt.Enabled = false;
            this.vattxt.Location = new System.Drawing.Point(179, 402);
            this.vattxt.Name = "vattxt";
            this.vattxt.Size = new System.Drawing.Size(100, 38);
            this.vattxt.TabIndex = 21;
            // 
            // vatper
            // 
            this.vatper.AutoSize = true;
            this.vatper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vatper.Location = new System.Drawing.Point(22, 409);
            this.vatper.Name = "vatper";
            this.vatper.Size = new System.Drawing.Size(48, 20);
            this.vatper.TabIndex = 20;
            this.vatper.Text = "VAT:";
            // 
            // _change
            // 
            this._change.Enabled = false;
            this._change.Location = new System.Drawing.Point(179, 369);
            this._change.Name = "_change";
            this._change.Size = new System.Drawing.Size(100, 38);
            this._change.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 369);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 31);
            this.label10.TabIndex = 18;
            this.label10.Text = "CHANGE";
            // 
            // _ID
            // 
            this._ID.Enabled = false;
            this._ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ID.Location = new System.Drawing.Point(141, 33);
            this._ID.Name = "_ID";
            this._ID.Size = new System.Drawing.Size(231, 22);
            this._ID.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(46, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Product ID";
            // 
            // _totalStock
            // 
            this._totalStock.Enabled = false;
            this._totalStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._totalStock.Location = new System.Drawing.Point(141, 310);
            this._totalStock.Name = "_totalStock";
            this._totalStock.Size = new System.Drawing.Size(231, 22);
            this._totalStock.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(43, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Total Stock";
            // 
            // _stock
            // 
            this._stock.Enabled = false;
            this._stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._stock.Location = new System.Drawing.Point(141, 268);
            this._stock.Name = "_stock";
            this._stock.Size = new System.Drawing.Size(231, 22);
            this._stock.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(43, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Stock Left";
            // 
            // t_total
            // 
            this.t_total.Enabled = false;
            this.t_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_total.Location = new System.Drawing.Point(141, 346);
            this.t_total.Name = "t_total";
            this.t_total.Size = new System.Drawing.Size(231, 22);
            this.t_total.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "TOTAL:";
            // 
            // _tqty
            // 
            this._tqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tqty.Location = new System.Drawing.Point(141, 227);
            this._tqty.Name = "_tqty";
            this._tqty.Size = new System.Drawing.Size(231, 22);
            this._tqty.TabIndex = 9;
            this._tqty.TextChanged += new System.EventHandler(this._tqty_TextChanged);
            this._tqty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._tqty_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Price";
            // 
            // _tprice
            // 
            this._tprice.Enabled = false;
            this._tprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tprice.Location = new System.Drawing.Point(141, 187);
            this._tprice.Name = "_tprice";
            this._tprice.Size = new System.Drawing.Size(231, 22);
            this._tprice.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Name:";
            // 
            // _tmoney
            // 
            this._tmoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tmoney.Location = new System.Drawing.Point(141, 118);
            this._tmoney.Name = "_tmoney";
            this._tmoney.Size = new System.Drawing.Size(231, 22);
            this._tmoney.TabIndex = 5;
            this._tmoney.TextChanged += new System.EventHandler(this._tmoney_TextChanged);
            this._tmoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._tmoney_KeyPress);
            // 
            // _tname
            // 
            this._tname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tname.Location = new System.Drawing.Point(141, 65);
            this._tname.Name = "_tname";
            this._tname.Size = new System.Drawing.Size(231, 22);
            this._tname.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "QTY:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Products:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = " Money:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(168, 464);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 32);
            this.button2.TabIndex = 2;
            this.button2.Text = "CLEAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(309, 464);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 32);
            this.button3.TabIndex = 3;
            this.button3.Text = "BACK";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 464);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "PURCHASE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Font = new System.Drawing.Font("Verdana", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(489, 59);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(426, 360);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(611, 431);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(121, 32);
            this.button5.TabIndex = 6;
            this.button5.Text = "Show Receipt";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timelbl
            // 
            this.timelbl.AutoSize = true;
            this.timelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timelbl.Location = new System.Drawing.Point(427, 9);
            this.timelbl.Name = "timelbl";
            this.timelbl.Size = new System.Drawing.Size(89, 25);
            this.timelbl.TabIndex = 7;
            this.timelbl.Text = "label10";
            this.timelbl.Click += new System.EventHandler(this.timelbl_Click);
            // 
            // purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 524);
            this.Controls.Add(this.timelbl);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "purchase";
            this.Text = "purchase";
            this.Load += new System.EventHandler(this.purchase_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox _tmoney;
        private System.Windows.Forms.TextBox _tname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox _tprice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _tqty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox t_total;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox _stock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox _totalStock;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox _ID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timelbl;
        private System.Windows.Forms.TextBox _change;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox vattxt;
        private System.Windows.Forms.Label vatper;
        private System.Windows.Forms.ListBox listBox1;
    }
}