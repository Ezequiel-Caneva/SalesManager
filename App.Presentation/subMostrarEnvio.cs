using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Presentation
{
    public partial class subMostrarEnvio : Form
    {

        private readonly Uri _baseAddress = new Uri("https://localhost:7198/api");
        private readonly HttpClient _client;
        public subMostrarEnvio()
        {
            InitializeComponent();
        }

        private void subMostrarEnvio_Load(object sender, EventArgs e)
        {

        }
    }
}
