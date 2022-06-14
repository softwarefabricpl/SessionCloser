using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SessionCloser.Forms
{
    public partial class FormEditInforUser : KryptonForm
    {
        public FormEditInforUser(string machine, int timeout)
        {
            InitializeComponent();
            this.Text = machine;
            this.UserTimeout.Value = timeout;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public int CurrentUserTimeout
        {
            get
            {
                return (int)this.UserTimeout.Value;
            }
        }
    }
}
