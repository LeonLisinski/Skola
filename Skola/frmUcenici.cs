using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Skola
{
    public partial class frmUcenici : Form
    {
        public frmUcenici()
        {
            InitializeComponent();
        }

        private void frmUcenici_Load(object sender, EventArgs e)
        {
            PopuniUcenike();
        }

        private void PopuniUcenike()
        {

            SqlConnection conn = new SqlConnection(GetConnectionString());

            DataTable dt = new DataTable();

            using (var connection = conn)
            {
                using (var command = new SqlCommand("SELECT * FROM Ucenik", connection))
                {
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }

            gridControl1.DataSource = dt;
        }


        private void ObrisiUcenika(int UcenikId)
        {

            SqlConnection sqlConnection = new SqlConnection(GetConnectionString());

            

            using (var connection = sqlConnection)
            {
                using (var command = new SqlCommand("DELETE FROM Ucenik where UcenikId=" + UcenikId.ToString(), connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                }
            }
            
        }



        private string GetConnectionString()
        {
            var server = "LISINSKI\\SQL2022";
            string database = "Skola";

            string connection = String.Format("data source={0};initial catalog={1};Integrated Security=SSPI", server, database);
            return connection;
        }

        private void cmdDodajUcenika_Click(object sender, EventArgs e)
        {
            frmUceniciAzur form = new frmUceniciAzur();
            if (form.ShowDialog() == DialogResult.OK)
            {
                PopuniUcenike();
            }
        }

        private void cmdObrisiUcenika_Click(object sender, EventArgs e)
        {
            
            if (XtraMessageBox.Show("Potvrdite brisnje učenika!", "Potvrda", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                int ucenikId = Convert.ToInt32(gridView1.GetDataRow(gridView1.FocusedRowHandle)["UcenikId"]);

                ObrisiUcenika(ucenikId);
                PopuniUcenike();
            }
        }

        private void cmdPromijeniPodatke_Click(object sender, EventArgs e)
        {
            frmUceniciAzur form = new frmUceniciAzur();
            form.UcenikId = Convert.ToInt32(gridView1.GetDataRow(gridView1.FocusedRowHandle)["UcenikId"]);
            form.txtIme.Text = gridView1.GetDataRow(gridView1.FocusedRowHandle)["Ime"].ToString();
            form.txtPrezime.Text = gridView1.GetDataRow(gridView1.FocusedRowHandle)["Prezime"].ToString();
            form.txtOib.Text = gridView1.GetDataRow(gridView1.FocusedRowHandle)["Oib"].ToString();
            form.datDatumRodenja.EditValue = Convert.ToDateTime(gridView1.GetDataRow(gridView1.FocusedRowHandle)["DatumRodenja"]);


            if (form.ShowDialog() == DialogResult.OK)
            {
                PopuniUcenike();
            }
        }
    }
}
