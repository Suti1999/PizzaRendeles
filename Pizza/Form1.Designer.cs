namespace Pizza
{
    partial class Form1
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button1_Betoltes = new System.Windows.Forms.Button();
            this.textBox1_Forrasfajl = new System.Windows.Forms.TextBox();
            this.listBox_Pizzaklista = new System.Windows.Forms.ListBox();
            this.button_TeruletekAtlaga = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_LegfeljebbSzazEzer = new System.Windows.Forms.RadioButton();
            this.radioButton_bankkartyasffizetes = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton1_nem = new System.Windows.Forms.RadioButton();
            this.radioButton2_igen = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1_Megrendeles = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1_PizzaDarabSzam = new System.Windows.Forms.TextBox();
            this.textBox1_PizzaKivalasztasa = new System.Windows.Forms.TextBox();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Silver;
            this.groupBox5.Controls.Add(this.button1_Betoltes);
            this.groupBox5.Controls.Add(this.textBox1_Forrasfajl);
            this.groupBox5.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(229, 114);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Forrásfájl neve";
            // 
            // button1_Betoltes
            // 
            this.button1_Betoltes.BackColor = System.Drawing.Color.Silver;
            this.button1_Betoltes.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1_Betoltes.Location = new System.Drawing.Point(16, 68);
            this.button1_Betoltes.Name = "button1_Betoltes";
            this.button1_Betoltes.Size = new System.Drawing.Size(194, 40);
            this.button1_Betoltes.TabIndex = 24;
            this.button1_Betoltes.Text = "BETÖLTÉS";
            this.button1_Betoltes.UseVisualStyleBackColor = false;
            this.button1_Betoltes.Click += new System.EventHandler(this.button_Betoltes_Click);
            // 
            // textBox1_Forrasfajl
            // 
            this.textBox1_Forrasfajl.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox1_Forrasfajl.Location = new System.Drawing.Point(16, 32);
            this.textBox1_Forrasfajl.Name = "textBox1_Forrasfajl";
            this.textBox1_Forrasfajl.Size = new System.Drawing.Size(194, 22);
            this.textBox1_Forrasfajl.TabIndex = 4;
            this.textBox1_Forrasfajl.TextChanged += new System.EventHandler(this.textBox1_Forrasfajl_TextChanged);
            // 
            // listBox_Pizzaklista
            // 
            this.listBox_Pizzaklista.BackColor = System.Drawing.Color.Silver;
            this.listBox_Pizzaklista.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox_Pizzaklista.FormattingEnabled = true;
            this.listBox_Pizzaklista.ItemHeight = 15;
            this.listBox_Pizzaklista.Location = new System.Drawing.Point(12, 132);
            this.listBox_Pizzaklista.Name = "listBox_Pizzaklista";
            this.listBox_Pizzaklista.Size = new System.Drawing.Size(229, 289);
            this.listBox_Pizzaklista.TabIndex = 18;
            this.listBox_Pizzaklista.SelectedIndexChanged += new System.EventHandler(this.listBox_Pizzaklista_SelectedIndexChanged);
            // 
            // button_TeruletekAtlaga
            // 
            this.button_TeruletekAtlaga.BackColor = System.Drawing.Color.Silver;
            this.button_TeruletekAtlaga.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_TeruletekAtlaga.Location = new System.Drawing.Point(12, 428);
            this.button_TeruletekAtlaga.Name = "button_TeruletekAtlaga";
            this.button_TeruletekAtlaga.Size = new System.Drawing.Size(229, 40);
            this.button_TeruletekAtlaga.TabIndex = 19;
            this.button_TeruletekAtlaga.Text = "PIZZÁK ÁRÁNAK ÁTLAGA";
            this.button_TeruletekAtlaga.UseVisualStyleBackColor = false;
            this.button_TeruletekAtlaga.Click += new System.EventHandler(this.button_TeruletekAtlaga_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.radioButton_LegfeljebbSzazEzer);
            this.groupBox1.Controls.Add(this.radioButton_bankkartyasffizetes);
            this.groupBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(270, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 114);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mivel szeretne fizetni?";
            // 
            // radioButton_LegfeljebbSzazEzer
            // 
            this.radioButton_LegfeljebbSzazEzer.AutoSize = true;
            this.radioButton_LegfeljebbSzazEzer.Checked = true;
            this.radioButton_LegfeljebbSzazEzer.Location = new System.Drawing.Point(29, 70);
            this.radioButton_LegfeljebbSzazEzer.Name = "radioButton_LegfeljebbSzazEzer";
            this.radioButton_LegfeljebbSzazEzer.Size = new System.Drawing.Size(165, 20);
            this.radioButton_LegfeljebbSzazEzer.TabIndex = 1;
            this.radioButton_LegfeljebbSzazEzer.TabStop = true;
            this.radioButton_LegfeljebbSzazEzer.Text = "Készpénzes fizetés";
            this.radioButton_LegfeljebbSzazEzer.UseVisualStyleBackColor = true;
            // 
            // radioButton_bankkartyasffizetes
            // 
            this.radioButton_bankkartyasffizetes.AutoSize = true;
            this.radioButton_bankkartyasffizetes.Location = new System.Drawing.Point(29, 29);
            this.radioButton_bankkartyasffizetes.Name = "radioButton_bankkartyasffizetes";
            this.radioButton_bankkartyasffizetes.Size = new System.Drawing.Size(168, 20);
            this.radioButton_bankkartyasffizetes.TabIndex = 0;
            this.radioButton_bankkartyasffizetes.Text = "Bankkártyás fizetés";
            this.radioButton_bankkartyasffizetes.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.radioButton1_nem);
            this.groupBox2.Controls.Add(this.radioButton2_igen);
            this.groupBox2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(270, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 114);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kérek számlát a vásárlásról?";
            // 
            // radioButton1_nem
            // 
            this.radioButton1_nem.AutoSize = true;
            this.radioButton1_nem.Checked = true;
            this.radioButton1_nem.Location = new System.Drawing.Point(29, 70);
            this.radioButton1_nem.Name = "radioButton1_nem";
            this.radioButton1_nem.Size = new System.Drawing.Size(56, 20);
            this.radioButton1_nem.TabIndex = 1;
            this.radioButton1_nem.TabStop = true;
            this.radioButton1_nem.Text = "Nem";
            this.radioButton1_nem.UseVisualStyleBackColor = true;
            // 
            // radioButton2_igen
            // 
            this.radioButton2_igen.AutoSize = true;
            this.radioButton2_igen.Location = new System.Drawing.Point(29, 29);
            this.radioButton2_igen.Name = "radioButton2_igen";
            this.radioButton2_igen.Size = new System.Drawing.Size(58, 20);
            this.radioButton2_igen.TabIndex = 0;
            this.radioButton2_igen.Text = "Igen";
            this.radioButton2_igen.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Silver;
            this.groupBox3.Controls.Add(this.button1_Megrendeles);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.textBox1_PizzaDarabSzam);
            this.groupBox3.Controls.Add(this.textBox1_PizzaKivalasztasa);
            this.groupBox3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox3.Location = new System.Drawing.Point(270, 279);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(230, 143);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pizza megrendelés";
            // 
            // button1_Megrendeles
            // 
            this.button1_Megrendeles.BackColor = System.Drawing.Color.Silver;
            this.button1_Megrendeles.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1_Megrendeles.Location = new System.Drawing.Point(6, 97);
            this.button1_Megrendeles.Name = "button1_Megrendeles";
            this.button1_Megrendeles.Size = new System.Drawing.Size(218, 40);
            this.button1_Megrendeles.TabIndex = 23;
            this.button1_Megrendeles.Text = "MEGRENDELÉS";
            this.button1_Megrendeles.UseVisualStyleBackColor = false;
            this.button1_Megrendeles.Click += new System.EventHandler(this.button1_Megrendeles_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "db";
            // 
            // textBox1_PizzaDarabSzam
            // 
            this.textBox1_PizzaDarabSzam.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox1_PizzaDarabSzam.Location = new System.Drawing.Point(63, 59);
            this.textBox1_PizzaDarabSzam.Name = "textBox1_PizzaDarabSzam";
            this.textBox1_PizzaDarabSzam.Size = new System.Drawing.Size(103, 22);
            this.textBox1_PizzaDarabSzam.TabIndex = 24;
            // 
            // textBox1_PizzaKivalasztasa
            // 
            this.textBox1_PizzaKivalasztasa.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox1_PizzaKivalasztasa.Location = new System.Drawing.Point(6, 19);
            this.textBox1_PizzaKivalasztasa.Name = "textBox1_PizzaKivalasztasa";
            this.textBox1_PizzaKivalasztasa.Size = new System.Drawing.Size(218, 22);
            this.textBox1_PizzaKivalasztasa.TabIndex = 23;
            this.textBox1_PizzaKivalasztasa.TextChanged += new System.EventHandler(this.textBox1_PizzaKivalasztasa_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(531, 479);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_TeruletekAtlaga);
            this.Controls.Add(this.listBox_Pizzaklista);
            this.Controls.Add(this.groupBox5);
            this.Name = "Form1";
            this.Text = "Pizza rendelés";
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBox1_Forrasfajl;
        private System.Windows.Forms.ListBox listBox_Pizzaklista;
        private System.Windows.Forms.Button button_TeruletekAtlaga;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_LegfeljebbSzazEzer;
        private System.Windows.Forms.RadioButton radioButton_bankkartyasffizetes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton1_nem;
        private System.Windows.Forms.RadioButton radioButton2_igen;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox1_PizzaKivalasztasa;
        private System.Windows.Forms.TextBox textBox1_PizzaDarabSzam;
        private System.Windows.Forms.Button button1_Megrendeles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1_Betoltes;
    }
}

