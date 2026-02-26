using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VkNet;
using VkNet.Exception;
using VkNet.Model;

namespace planner
{
    public partial class VKlink : Form
    {
        public long? ID;
        public string token;
        public VKlink()
        {
            InitializeComponent();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tokenBox.Text) && !string.IsNullOrEmpty(idBox.Text))
            {
                token = tokenBox.Text;
                if (long.TryParse(idBox.Text, out long result))
                {
                    ID = result;
                }
                else return;
            }
            else
            {
                return;
            }

            MainForm.vkApi = new VkApi();
            try
            {
                await MainForm.vkApi.AuthorizeAsync(new ApiAuthParams { AccessToken = token });
                await MainForm.vkApi.Messages.SendAsync(new MessagesSendParams
                {
                    UserId = ID,
                    RandomId = new Random().Next(),
                    Message = "Привязка успешна ✅"
                });
            }
            catch (VkApiException ex)
            { ID = null; token = null; return; }
            finally
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}
