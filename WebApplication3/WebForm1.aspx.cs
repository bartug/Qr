using System.Web.UI.WebControls;
using QRCoder;
using System.IO;
using System.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace WebApplication3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
       // string[] email = { "www.bartugsevindik.com", "","www.alıveli.com","www.izmirgaz.com" };
        protected void Page_Load(object sender, EventArgs e)
        {
            /* cmd2 = new SqlCommand("select [Kolon_Adi_1] from [Tablo_Adi] where [Kolon_Adi_2]=@veri2", cnn);
            cmd2.Parameters.AddWithValue("@veri2", "değeri");
            SqlDataReader dr = cmd2.ExecuteReader();
            if (dr.Read())
            {
                textBox1.Text = dr["Kolon_Adi"].ToString(); 

            } */
            //TextBox1.Text = "";
           // Label1.Text = TextBox1.Text;
        }

       
        public void QrYarat()
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(Label1.Text, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);

            
            System.Web.UI.WebControls.Image imgBarCode = new System.Web.UI.WebControls.Image();
            int x = Int32.Parse(DropDownList1.SelectedItem.Value);
            imgBarCode.Height = x;
            imgBarCode.Width = x;
            using (Bitmap bitMap = qrCode.GetGraphic(20))
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    bitMap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    byte[] byteImage = ms.ToArray();
                    imgBarCode.ImageUrl = "data:image/png;base64," + Convert.ToBase64String(byteImage);
                }
                PlaceHolder1.Controls.Add(imgBarCode);
            }
            TextBox1.Text = "";
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
           // TextBox1.Text = email[0]; //array[0] => text box ataması ; veri tabanından çekecegim e mailler için deneme
            QrYarat();
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Qr Kodunuz Yaratıldı!')", true);

        }

        
    }
}