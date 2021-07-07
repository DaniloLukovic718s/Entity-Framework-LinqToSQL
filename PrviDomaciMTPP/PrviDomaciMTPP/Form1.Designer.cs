
namespace PrviDomaciMTPP
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
            this.dgKupac = new System.Windows.Forms.DataGridView();
            this.dgFaktura = new System.Windows.Forms.DataGridView();
            this.dgFakturaStavka = new System.Windows.Forms.DataGridView();
            this.btnDodajKupca = new System.Windows.Forms.Button();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.btnDodajFakturu = new System.Windows.Forms.Button();
            this.dtpFaktura = new System.Windows.Forms.DateTimePicker();
            this.cmbKupacFaktura = new System.Windows.Forms.ComboBox();
            this.btnDodajStavkuFakture = new System.Windows.Forms.Button();
            this.txtDodajNazivStavke = new System.Windows.Forms.TextBox();
            this.txtDodajCenuStavke = new System.Windows.Forms.TextBox();
            this.cmbFakturaFakturaStavke = new System.Windows.Forms.ComboBox();
            this.btnConvertXML = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgKupac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgFaktura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgFakturaStavka)).BeginInit();
            this.SuspendLayout();
            // 
            // dgKupac
            // 
            this.dgKupac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKupac.Location = new System.Drawing.Point(636, 14);
            this.dgKupac.Name = "dgKupac";
            this.dgKupac.Size = new System.Drawing.Size(328, 186);
            this.dgKupac.TabIndex = 0;
            // 
            // dgFaktura
            // 
            this.dgFaktura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFaktura.Location = new System.Drawing.Point(636, 269);
            this.dgFaktura.Name = "dgFaktura";
            this.dgFaktura.Size = new System.Drawing.Size(332, 186);
            this.dgFaktura.TabIndex = 1;
            // 
            // dgFakturaStavka
            // 
            this.dgFakturaStavka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFakturaStavka.Location = new System.Drawing.Point(636, 531);
            this.dgFakturaStavka.Name = "dgFakturaStavka";
            this.dgFakturaStavka.Size = new System.Drawing.Size(332, 186);
            this.dgFakturaStavka.TabIndex = 2;
            // 
            // btnDodajKupca
            // 
            this.btnDodajKupca.Location = new System.Drawing.Point(448, 84);
            this.btnDodajKupca.Name = "btnDodajKupca";
            this.btnDodajKupca.Size = new System.Drawing.Size(119, 41);
            this.btnDodajKupca.TabIndex = 3;
            this.btnDodajKupca.Text = "Dodaj Kupca";
            this.btnDodajKupca.UseVisualStyleBackColor = true;
            this.btnDodajKupca.Click += new System.EventHandler(this.btnDodajKupca_Click);
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(189, 66);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(194, 20);
            this.txtNaziv.TabIndex = 4;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(189, 123);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(194, 20);
            this.txtAdresa.TabIndex = 5;
            // 
            // btnDodajFakturu
            // 
            this.btnDodajFakturu.Location = new System.Drawing.Point(448, 328);
            this.btnDodajFakturu.Name = "btnDodajFakturu";
            this.btnDodajFakturu.Size = new System.Drawing.Size(119, 46);
            this.btnDodajFakturu.TabIndex = 6;
            this.btnDodajFakturu.Text = "Dodaj Fakturu";
            this.btnDodajFakturu.UseVisualStyleBackColor = true;
            this.btnDodajFakturu.Click += new System.EventHandler(this.btnDodajFakturu_Click);
            // 
            // dtpFaktura
            // 
            this.dtpFaktura.Location = new System.Drawing.Point(189, 312);
            this.dtpFaktura.Name = "dtpFaktura";
            this.dtpFaktura.Size = new System.Drawing.Size(194, 20);
            this.dtpFaktura.TabIndex = 7;
            // 
            // cmbKupacFaktura
            // 
            this.cmbKupacFaktura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKupacFaktura.FormattingEnabled = true;
            this.cmbKupacFaktura.Location = new System.Drawing.Point(189, 375);
            this.cmbKupacFaktura.Name = "cmbKupacFaktura";
            this.cmbKupacFaktura.Size = new System.Drawing.Size(194, 21);
            this.cmbKupacFaktura.TabIndex = 8;
            // 
            // btnDodajStavkuFakture
            // 
            this.btnDodajStavkuFakture.Location = new System.Drawing.Point(448, 598);
            this.btnDodajStavkuFakture.Name = "btnDodajStavkuFakture";
            this.btnDodajStavkuFakture.Size = new System.Drawing.Size(119, 45);
            this.btnDodajStavkuFakture.TabIndex = 9;
            this.btnDodajStavkuFakture.Text = "Dodaj Stavku Fakture";
            this.btnDodajStavkuFakture.UseVisualStyleBackColor = true;
            this.btnDodajStavkuFakture.Click += new System.EventHandler(this.btnDodajStavkuFakture_Click);
            // 
            // txtDodajNazivStavke
            // 
            this.txtDodajNazivStavke.Location = new System.Drawing.Point(189, 571);
            this.txtDodajNazivStavke.Name = "txtDodajNazivStavke";
            this.txtDodajNazivStavke.Size = new System.Drawing.Size(194, 20);
            this.txtDodajNazivStavke.TabIndex = 10;
            // 
            // txtDodajCenuStavke
            // 
            this.txtDodajCenuStavke.Location = new System.Drawing.Point(189, 611);
            this.txtDodajCenuStavke.Name = "txtDodajCenuStavke";
            this.txtDodajCenuStavke.Size = new System.Drawing.Size(61, 20);
            this.txtDodajCenuStavke.TabIndex = 11;
            // 
            // cmbFakturaFakturaStavke
            // 
            this.cmbFakturaFakturaStavke.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFakturaFakturaStavke.FormattingEnabled = true;
            this.cmbFakturaFakturaStavke.Location = new System.Drawing.Point(189, 648);
            this.cmbFakturaFakturaStavke.Name = "cmbFakturaFakturaStavke";
            this.cmbFakturaFakturaStavke.Size = new System.Drawing.Size(194, 21);
            this.cmbFakturaFakturaStavke.TabIndex = 12;
            // 
            // btnConvertXML
            // 
            this.btnConvertXML.Location = new System.Drawing.Point(1045, 312);
            this.btnConvertXML.Name = "btnConvertXML";
            this.btnConvertXML.Size = new System.Drawing.Size(202, 90);
            this.btnConvertXML.TabIndex = 13;
            this.btnConvertXML.Text = "Konvertuj u XML";
            this.btnConvertXML.UseVisualStyleBackColor = true;
            this.btnConvertXML.Click += new System.EventHandler(this.btnConvertXML_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Naziv Kupca:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Adresa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Datum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Naziv Kupca";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 571);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Naziv Stavke";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 618);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Cena Stavke";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 656);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Faktura ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 753);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConvertXML);
            this.Controls.Add(this.cmbFakturaFakturaStavke);
            this.Controls.Add(this.txtDodajCenuStavke);
            this.Controls.Add(this.txtDodajNazivStavke);
            this.Controls.Add(this.btnDodajStavkuFakture);
            this.Controls.Add(this.cmbKupacFaktura);
            this.Controls.Add(this.dtpFaktura);
            this.Controls.Add(this.btnDodajFakturu);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.btnDodajKupca);
            this.Controls.Add(this.dgFakturaStavka);
            this.Controls.Add(this.dgFaktura);
            this.Controls.Add(this.dgKupac);
            this.Name = "Form1";
            this.Text = "Danilo Lukovic s7/18";
            ((System.ComponentModel.ISupportInitialize)(this.dgKupac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgFaktura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgFakturaStavka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgKupac;
        private System.Windows.Forms.DataGridView dgFaktura;
        private System.Windows.Forms.DataGridView dgFakturaStavka;
        private System.Windows.Forms.Button btnDodajKupca;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Button btnDodajFakturu;
        private System.Windows.Forms.DateTimePicker dtpFaktura;
        private System.Windows.Forms.ComboBox cmbKupacFaktura;
        private System.Windows.Forms.Button btnDodajStavkuFakture;
        private System.Windows.Forms.TextBox txtDodajNazivStavke;
        private System.Windows.Forms.TextBox txtDodajCenuStavke;
        private System.Windows.Forms.ComboBox cmbFakturaFakturaStavke;
        private System.Windows.Forms.Button btnConvertXML;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

