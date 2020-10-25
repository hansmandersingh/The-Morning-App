using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInfoPopup
{
    public partial class User_Info_Popup : Form
    {
        public User_Info_Popup()
        {
            InitializeComponent();
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(first_name_textBox.Text) && !string.IsNullOrWhiteSpace(last_name_textbox.Text))
            {
                UserInfo userInfo = new UserInfo() { First_Name = first_name_textBox.Text, Last_Name = last_name_textbox.Text};

                string result = SerializeObject(userInfo);

                Stream fileStream = new FileStream("C:\\Users\\Public\\Documents\\UserInfo.bin", FileMode.Create, FileAccess.Write, FileShare.None);

                var bytes = Encoding.UTF8.GetBytes(result);

                fileStream.Write(bytes, 0, bytes.Length);

                fileStream.Close();

                this.Close();
            } else
            {
                first_name_textBox.Text = "";
                last_name_textbox.Text = "";
                MessageBox.Show("Name Field's cannot be left empty ! Please fill in your info.", "Error !");
                
            }
        }

        private string SerializeObject(object objToSerialize)
        {
            return JsonConvert.SerializeObject(objToSerialize, Formatting.Indented);
        }

        private void User_Info_Popup_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
