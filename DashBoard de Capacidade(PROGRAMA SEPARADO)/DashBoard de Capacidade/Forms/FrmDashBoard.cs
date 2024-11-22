using DashBoard_de_Capacidade.Forms;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Util.Store;
using System;
using System.IO;
using System.Threading;



namespace DashBoard_de_Capacidade
{
    public partial class FrmDashBoard : Form
    {
        static string[] Scopes = { SheetsService.Scope.SpreadsheetsReadonly };
        static string ApplicationName = "Google Sheets API .NET Quickstart";
        private DataGridView gradeVendas;

        public FrmDashBoard()
        {
            InitializeComponent();
            /*
                        this.gradeVendas = new DataGridView();
                        this.SuspendLayout();

                        // Configuração do DataGridView
                        this.gradeVendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                        this.gradeVendas.Location = new Point(3, 71);
                        this.gradeVendas.Name = "gradeVend";
                        this.gradeVendas.Size = new Size(340, 150);
                        this.gradeVendas.TabIndex = 0;

                        // Adicionando colunas e dados de exemplo ao DataGridView
                        this.gradeVendas.Columns.Add("clVendas", "Venda");
                        this.gradeVendas.Columns[0].Width = 60;
                        this.gradeVendas.Columns[0].ReadOnly = true;
                        this.gradeVendas.Columns.Add("clEstojo", "Estojo");
                        this.gradeVendas.Columns[1].Width = 150;
                        this.gradeVendas.Columns[1].ReadOnly = true;
                        this.gradeVendas.Columns.Add("clUN", "UN");
                        this.gradeVendas.Columns[2].Width = 50;
                        this.gradeVendas.Columns[2].ReadOnly = true;
                        this.gradeVendas.Columns.Add("clData", "Data");
                        this.gradeVendas.Columns[3].Width = 70;
                        this.gradeVendas.Columns[3].ReadOnly = true;
                        this.gradeVendas.Rows.Add("clUN", "UN", 8, "11/22/08");

                        // Configurando a cor do cabeçalho do DataGridView
                        this.gradeVendas.BorderStyle = BorderStyle.None;
                        this.gradeVendas.RowHeadersVisible = false;
                        this.gradeVendas.BackgroundColor = Color.FromArgb(228, 112, 33);
                        this.gradeVendas.GridColor = Color.White;
                        this.gradeVendas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(152, 74, 22);
                        this.gradeVendas.ColumnHeadersDefaultCellStyle.ForeColor = Color.Snow;
                        this.gradeVendas.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Bold);
                        this.gradeVendas.RowsDefaultCellStyle.BackColor = Color.FromArgb(228, 112, 33);
                        this.gradeVendas.RowsDefaultCellStyle.ForeColor = Color.Snow; ;
                        this.gradeVendas.RowsDefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Regular);

                        // Para aplicar as mudanças
                        this.gradeVendas.EnableHeadersVisualStyles = false;

                        // Adicionando o DataGridView ao formulário
                        this.panel6.Controls.Add(this.gradeVendas);

                        // Configuração do Formulário

                        this.AutoScaleMode = AutoScaleMode.Font;
                        this.ClientSize = new Size(340, 150);
                        this.Name = "Form1";
                        this.Text = "Form1";
                        this.Load += new EventHandler(this.FrmDashBoard_Load);
                        this.ResumeLayout(false);
            */
        }

        private void GoogleAcess()
        {
            UserCredential credential;
            using (var stream = new FileStream("C:\\DashBoard de Capacidade\\DashBoard de Capacidade\\bin\\Debug\\net8.0-windows/client_secret.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = "token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                MessageBox.Show("Credencial Salva em: " + credPath);
            }
            var service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });
            String spreadsheetId = "1MQKNJdNH4KXTNfCjhKAJ2dd2uwlHuQSgcQZ4-1RKVUc";
            String range = "Sheet1!A2:H300";
            SpreadsheetsResource.ValuesResource.GetRequest request = service.Spreadsheets.Values.Get(spreadsheetId, range);

            ValueRange response = request.Execute();
            IList<IList<Object>> values = response.Values;
            if (values != null && values.Count > 0)
            {
                MessageBox.Show("Name. Major");
                foreach (var row in values)
                {
                    MessageBox.Show("{0}, {1}" + row[0] + "" + row[4]);
                }
            }
            else
            {
                MessageBox.Show("Nenhum dado encontrado");
            }

        }

        private void FrmDashBoard_Load(object sender, EventArgs e)
        {

        }

        private void btnProd_Click(object sender, EventArgs e)
        {
            var Vendas = new FrmVendas();
            Vendas.Show();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            GoogleAcess();
        }
    }
}
