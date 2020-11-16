using MyFootZalApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFootZalApp
{
    public partial class Form1 : Form
    {
        MyFootZalDBEntities db = new MyFootZalDBEntities();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string password = txtPassword.Text;
            string[] arr = new string[] { name, password };
            if (Utilities.MyEmpty(arr, string.Empty))
            {
                lblError.Visible = false;
                Isci acIsci = db.Isci.FirstOrDefault(x => x.UserName == name);
                if (acIsci != null)
                {
                    lblError.Visible = false;
                    if (acIsci.Password == password)
                    {
                        lblError.Visible = false;
                        WorkerDash dash = new WorkerDash();
                        dash.ShowDialog();
                    }
                    else
                    {
                        lblError.Visible = true;
                        lblError.Text = "Parol Sehvdir!";
                    }
                }
                else
                {
                    lblError.Visible = true;
                    lblError.Text = "Ad Sehvdir";
                }
            }
            else
            {
                lblError.Visible = true;
                lblError.Text = "Xanalari Doldurun!";
            }
        }
    }
}
