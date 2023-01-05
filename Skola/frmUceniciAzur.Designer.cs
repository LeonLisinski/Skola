
namespace Skola
{
    partial class frmUceniciAzur
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
            this.txtPrezime = new DevExpress.XtraEditors.TextEdit();
            this.txtIme = new DevExpress.XtraEditors.TextEdit();
            this.txtOib = new DevExpress.XtraEditors.TextEdit();
            this.datDatumRodenja = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cmdSpremi = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrezime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIme.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOib.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datDatumRodenja.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datDatumRodenja.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(12, 24);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(152, 20);
            this.txtPrezime.TabIndex = 0;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(170, 24);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(152, 20);
            this.txtIme.TabIndex = 1;
            // 
            // txtOib
            // 
            this.txtOib.Location = new System.Drawing.Point(12, 66);
            this.txtOib.Name = "txtOib";
            this.txtOib.Size = new System.Drawing.Size(152, 20);
            this.txtOib.TabIndex = 2;
            // 
            // datDatumRodenja
            // 
            this.datDatumRodenja.EditValue = null;
            this.datDatumRodenja.Location = new System.Drawing.Point(170, 66);
            this.datDatumRodenja.Name = "datDatumRodenja";
            this.datDatumRodenja.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datDatumRodenja.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datDatumRodenja.Size = new System.Drawing.Size(151, 20);
            this.datDatumRodenja.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 7);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Prezime";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(170, 7);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(18, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Ime";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 50);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(18, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "OIB";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(170, 50);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(71, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Datum rođenja";
            // 
            // cmdSpremi
            // 
            this.cmdSpremi.Location = new System.Drawing.Point(236, 101);
            this.cmdSpremi.Name = "cmdSpremi";
            this.cmdSpremi.Size = new System.Drawing.Size(85, 23);
            this.cmdSpremi.TabIndex = 8;
            this.cmdSpremi.Text = "Spremi";
            this.cmdSpremi.Click += new System.EventHandler(this.cmdSpremi_Click);
            // 
            // frmUceniciAzur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 136);
            this.Controls.Add(this.cmdSpremi);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.datDatumRodenja);
            this.Controls.Add(this.txtOib);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.txtPrezime);
            this.Name = "frmUceniciAzur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Unos novog učenika";
            this.Load += new System.EventHandler(this.frmUceniciAzur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtPrezime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIme.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOib.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datDatumRodenja.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datDatumRodenja.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton cmdSpremi;
        public DevExpress.XtraEditors.TextEdit txtPrezime;
        public DevExpress.XtraEditors.TextEdit txtIme;
        public DevExpress.XtraEditors.TextEdit txtOib;
        public DevExpress.XtraEditors.DateEdit datDatumRodenja;
    }
}