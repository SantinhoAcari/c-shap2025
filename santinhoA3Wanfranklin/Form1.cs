

using System.Net;
using System.Net.Http;
using static System.Net.WebRequestMethods;

namespace santinhoA3Wanfranklin
   
{
    public partial class Form1 : Form
    {
        private const string viaCepUrl = "https://viacep.com.br/ws/{0}/json";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            
            string cep = maskedTextBox1.Text.Trim();
            cep = cep.Replace(".", "").Replace(",", "").Replace("-", "");
            if (string.IsNullOrWhiteSpace(cep))
            {
                using (var httpClient = new HttpClient())
                {
                    string url = string.Format(viaCepUrl, cep);
                    try 
                    { 
                    
                        HttpResponseMessage httpResponse = await httpClient.GetAsync(url);
                        httpResponse.EnsureSuccessStatusCode();

                        if (httpResponse.StatusCode == HttpStatusCode.OK)
                        {
                            string responseBody = await httpResponse.Content.ReadAsStringAsync();
                        }
                    }
                    catch (HttpRequestException ex)
                    {
                         MessageBox.Show($"Você Errou, digite um CEP Válido, A requiseção Http: {ex.Message}", "Deu Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        

                    }
                    
                }

            }
           
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
