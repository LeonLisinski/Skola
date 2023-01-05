
namespace Skola
{
    partial class frmUcenici
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cmdPromijeniPodatke = new DevExpress.XtraEditors.SimpleButton();
            this.cmdObrisiUcenika = new DevExpress.XtraEditors.SimpleButton();
            this.cmdDodajUcenika = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1013, 435);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Prezime";
            this.gridColumn1.FieldName = "Prezime";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Ime";
            this.gridColumn2.FieldName = "Ime";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Datum rođenja";
            this.gridColumn3.FieldName = "DatumRodenja";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cmdPromijeniPodatke);
            this.panelControl1.Controls.Add(this.cmdObrisiUcenika);
            this.panelControl1.Controls.Add(this.cmdDodajUcenika);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 435);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1013, 49);
            this.panelControl1.TabIndex = 1;
            // 
            // cmdPromijeniPodatke
            // 
            this.cmdPromijeniPodatke.Location = new System.Drawing.Point(195, 14);
            this.cmdPromijeniPodatke.Name = "cmdPromijeniPodatke";
            this.cmdPromijeniPodatke.Size = new System.Drawing.Size(100, 23);
            this.cmdPromijeniPodatke.TabIndex = 2;
            this.cmdPromijeniPodatke.Text = "Promijeni podatke";
            this.cmdPromijeniPodatke.Click += new System.EventHandler(this.cmdPromijeniPodatke_Click);
            // 
            // cmdObrisiUcenika
            // 
            this.cmdObrisiUcenika.Location = new System.Drawing.Point(103, 14);
            this.cmdObrisiUcenika.Name = "cmdObrisiUcenika";
            this.cmdObrisiUcenika.Size = new System.Drawing.Size(75, 23);
            this.cmdObrisiUcenika.TabIndex = 1;
            this.cmdObrisiUcenika.Text = "Obriši učenika";
            this.cmdObrisiUcenika.Click += new System.EventHandler(this.cmdObrisiUcenika_Click);
            // 
            // cmdDodajUcenika
            // 
            this.cmdDodajUcenika.Location = new System.Drawing.Point(12, 14);
            this.cmdDodajUcenika.Name = "cmdDodajUcenika";
            this.cmdDodajUcenika.Size = new System.Drawing.Size(75, 23);
            this.cmdDodajUcenika.TabIndex = 0;
            this.cmdDodajUcenika.Text = "Dodaj učenika";
            this.cmdDodajUcenika.Click += new System.EventHandler(this.cmdDodajUcenika_Click);
            // 
            // frmUcenici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 484);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmUcenici";
            this.Text = "Učenici";
            this.Load += new System.EventHandler(this.frmUcenici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton cmdDodajUcenika;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.SimpleButton cmdObrisiUcenika;
        private DevExpress.XtraEditors.SimpleButton cmdPromijeniPodatke;
    }
}