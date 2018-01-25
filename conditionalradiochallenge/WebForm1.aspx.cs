using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace conditionalradiochallenge
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            if (pencilRadio.Checked == true)
                resultLabel.Text = "You selected pencil.";
            else if (penRadio.Checked == true)
                resultLabel.Text = "You selected pen.";
            else if (phoneRadio.Checked == true)
                resultLabel.Text = "You selected phone.";
            else if (tabletRadio.Checked == true)
                resultLabel.Text = "You selected tablet.";
            else resultLabel.Text = "Please select an option.";

            if (pencilRadio.Checked == true)
                showImage.ImageUrl = "https://target.scene7.com/is/image/Target/17077875?wid=520&hei=520&fmt=pjpeg";
            else if (penRadio.Checked == true)
                showImage.ImageUrl = "https://www.customink.com/mms/images/catalog/styles/103700/catalog_detail_image_large.jpg";
            else if (phoneRadio.Checked == true)
                showImage.ImageUrl = "https://i5.walmartimages.com/asr/80bdd9c3-fccb-4ce1-ada3-fe9052d68005_1.eda20373d8d69127055bf1276f19a385.jpeg";
            else if (tabletRadio.Checked == true)
                showImage.ImageUrl = "https://gloimg.gbtcdn.com/gb/pdm-product-pic/Electronic/2017/08/19/goods-img/1503107536771803487.jpg";
        }
    }
}