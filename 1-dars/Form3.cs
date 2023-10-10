using Messager;
using Messager.Models;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;

namespace _1_dars
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private async void sendBtn_Click(object sender, EventArgs e)
        {
            string phone = phoneNumber.Text.Replace("-", "").Substring(1);

            if (!string.IsNullOrEmpty(phoneNumber.Text) &&
                phoneNumber.Text.Length >= 12)
            {
                var token = await LoginAsync();
                var res = await SendSMSAsync(phone, text.Text, token);
                MessageBox.Show(res.Message);
            }
        }

        private async Task<string> LoginAsync()
        {
            using var httpClient = new HttpClient();
            var data = new
            {
                email = Constants.EMAIL,
                password = Constants.SecretKey
            };
            var httpContent = new StringContent(JsonConvert.SerializeObject(data),
                Encoding.UTF8, "application/json");
            var httpResponse = await httpClient.PostAsync(Constants.LOGIN_URL, httpContent);

            if (httpResponse.IsSuccessStatusCode)
            {
                var json = await httpResponse.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<JWT_Token>(json).data.token;
            }
            else
            {
                return httpResponse.StatusCode.ToString();
            }
        }

        public async Task<SendResultSMS> SendSMSAsync(string phoneNumber, string text, string TOKEN)
        {
            var sms = new SMS()
            {
                mobile_phone = phoneNumber,
                from = "4546",
                message = text,
                callback_url = "https://software-engineer.uz"
            };
            using var httpClient = new HttpClient();
            var httpContent = new StringContent(JsonConvert.SerializeObject(sms),
                Encoding.UTF8, "application/json");

            var htm = new HttpRequestMessage(HttpMethod.Post, Constants.Send_SMS_URL);
            htm.Content = httpContent;
            htm.Headers.Authorization = new AuthenticationHeaderValue("Bearer", TOKEN);

            var httpResponse = await httpClient.SendAsync(htm);


            if (httpResponse.IsSuccessStatusCode)
            {
                var result = new SendResultSMS("Successfully sent!");
                result.Success = true;
                return result;
            }
            else
            {
                var result = new SendResultSMS("Something went wrong!");
                result.Success = false;
                return result;
            }
        }
    }
}
