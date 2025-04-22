using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Social_Media_Post_Sync
{
  public partial class Form1 : Form
  {
    Label myControl;

    public Form1()
    {
      InitializeComponent();

      myControl = new Label();
    }

    private void button1_Click(object sender, EventArgs e)
    {

    }

    private void CenterControl(Control ctrl)
    {
      int x = (this.ClientSize.Width - ctrl.Width) / 2;
      //int y = (this.ClientSize.Height - ctrl.Height) / 2;
      int y = ctrl.Height;
      ctrl.Location = new Point(x, y);
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      CenterControl(label1);
      CenterControl(label2);
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
  }
}
