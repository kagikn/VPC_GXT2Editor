using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPC_GXT2Editor.Forms
{
    public partial class EditorForm : Form
    {
        public bool Canceled = true;

        public EditorForm(string name, string data, bool edit = true)
        {

            InitializeComponent();
            this.textLabelName.Text = name;
            this.textLabelData.Text = data;
            if (!edit)
            {
                //add
                this.Text = "Add A New Text Label";
                this.label1.Text = "Add Text Label Name";
                this.label2.Text = "Add Text Label Name";
            }
        }

        #region Button Handlers
        private void okButton_Click(object sender, EventArgs e)
        {
            this.Canceled = false;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Canceled = true;
            this.Close();
        }
        #endregion
    }
}
