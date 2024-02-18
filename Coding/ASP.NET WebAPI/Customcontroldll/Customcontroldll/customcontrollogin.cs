using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Customcontroldll
{
    [DefaultProperty("Text")]
    [ToolboxData("<{0}:customcontrollogin runat=server></{0}:customcontrollogin>")]
    public class Webcustomcontrollogin : CompositeControl
    {
        Label lblusername;
        Label lblpassword;
        TextBox textBox1;
        TextBox textBox2;
        Button button1;
        LiteralControl lt1;
        Label label1;

        protected override void CreateChildControls()
        {
            lblusername= new Label();
            lblusername.Text = "Enter UserName";
            lblusername.Width = 100;

            lblpassword= new Label();
            lblpassword.Text = "Enter Password";
            lblpassword.Width = 100;

            textBox1 = new TextBox();
            textBox1.ID = "TXTBOX1";
            textBox1.Width = 120;

            textBox2 = new TextBox();
            textBox2.ID = "TXTBOX2";
            textBox2.Width = 120;


            button1 = new Button();
            button1.ID = "btnSubmit";
            button1.Text = "submit";
            button1.Width = 130;
            button1.Click += new EventHandler(btnSubmit_Click);


            lt1 = new LiteralControl("<br/>");

            label1 = new Label();

             this.Controls.Add(lblusername);
             this.Controls.Add(textBox1 );
             this.Controls.Add(lt1);
             this.Controls.Add(lblpassword);
            this.Controls.Add(textBox2);
             this.Controls.Add(lt1 );
             this.Controls.Add(button1);
            this.Controls.Add(lt1);
            this.Controls.Add(lt1);
            this.Controls.Add(label1);
        }
        protected override  void Render(HtmlTextWriter writer)
        {
            lblusername.RenderControl(writer);
            textBox1.RenderControl(writer);
            lt1.RenderControl(writer);
            lblpassword.RenderControl(writer);
            textBox2.RenderControl(writer);
            lt1.RenderControl(writer);
            button1.RenderControl(writer);
                 lt1.RenderControl(writer);
            lt1.RenderControl(writer);
            label1.RenderControl(writer);

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(textBox1.Text =="Sun"&& textBox2.Text == "moon")
            {
                label1.Text = "Welcome";
                label1.ForeColor = System.Drawing.Color.Blue;
            }
            else
            {
                label1.Text = "wrong username or password";
                label1.ForeColor= System.Drawing.Color.Red;
            }
        }
    }  
}
