using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemoveImageNoise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {

        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            // ref: https://msdn.microsoft.com/ko-kr/library/system.windows.forms.openfiledialog(v=vs.110).aspx
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // ref: http://www.vcskicks.com/image-from-file.php
                Image img = Image.FromFile(dialog.FileName);
                loadPicture.Image = img;

                // ref: https://stackoverflow.com/questions/4710145/how-can-i-get-scrollbars-on-picturebox
                loadPicture.SizeMode = PictureBoxSizeMode.AutoSize;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
