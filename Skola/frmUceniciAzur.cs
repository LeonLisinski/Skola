using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skola
{
    public partial class frmUceniciAzur : Form
    {
        public int UcenikId { get; set; } = 0;

        public frmUceniciAzur()
        {
            InitializeComponent();
        }

        private void cmdSpremi_Click(object sender, EventArgs e)
        {
            SpremiUcenika();
            DialogResult = DialogResult.OK;
        }

        private void SpremiUcenika()
        {
            string prezime = txtPrezime.Text;
            string ime = txtIme.Text;
            string oib = txtOib.Text;
            DateTime datumRodenja = Convert.ToDateTime(datDatumRodenja.EditValue);

            SqlConnection conn = new SqlConnection(GetConnectionString());

            using (var connection = conn)
            {
                string sql = "INSERT INTO Ucenik (Prezime, Ime, Oib, DatumRodenja) VALUES('" + prezime + "', '" + ime + "', '" + oib + "', '" + datumRodenja.ToString("yyyyMMdd") + "')";

                using (var command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }


        private string GetConnectionString()
        {
            var server = "ILISINSKI2";
            string database = "Skola";

            string connection = String.Format("data source={0};initial catalog={1};Integrated Security=SSPI", server, database);
            return connection;
        }

        private void frmUceniciAzur_Load(object sender, EventArgs e)
        {
            if (UcenikId > 0)
            {
                this.Text = "Promjena";
            }
        }
    }
}
