using System;
using MetroFramework.Forms;

namespace FutBud
{
    public partial class TwoFactor : MetroForm
    {
        public TwoFactor()
        {
            InitializeComponent();
        }

        public string Code { get; set; }

        private void FormTwoFactor_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Code = tbCode.Text;
            Close();
        }
    }
}
