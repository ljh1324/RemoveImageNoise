using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace RemoveImageNoise
{
    public partial class Form1 : Form
    {
        private List<Point> points;
        private int[] dx = new int[] { 1, 1, 0, -1, -1, -1, 0, 1 };
        private int[] dy = new int[] { 0, 1, 1, 1, 0, -1, -1, -1 };

        public Form1()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Image img = savePicture.Image;
                img.Save(dialog.FileName);
            }
        }
        private void loadBtn_Click(object sender, EventArgs e)
        {
            // ref: https://msdn.microsoft.com/ko-kr/library/system.windows.forms.openfiledialog(v=vs.110).aspx
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // ref: http://www.vcskicks.com/image-from-file.php
                // Image img = Image.FromFile(dialog.FileName)

                // ref: https://stackoverflow.com/questions/2940558/load-a-bitmap-from-file-in-rgb-format-without-alpha
                Bitmap bitmap = new Bitmap(dialog.FileName);
                
                loadPicture.Image = bitmap;

                // ref: https://stackoverflow.com/questions/4710145/how-can-i-get-scrollbars-on-picturebox
                loadPicture.SizeMode = PictureBoxSizeMode.AutoSize;

                Bitmap bitmapWithoutNoise = removeNoise(bitmap);
                savePicture.Image = bitmapWithoutNoise;
                savePicture.SizeMode = PictureBoxSizeMode.AutoSize;
            }
        }

        private void setRemovePoints(Bitmap bitmap, Boolean[,] visited, int x, int y)
        {
            for (int i = 0; i < dx.Length; ++i)
            {
                int locX = x + dx[i];
                int locY = y + dy[i];
                if (0 <= locX && locX < bitmap.Width && 0 <= locY && locY < bitmap.Height)
                {
                    if (visited[locY, locX])
                        continue;

                    Color color = bitmap.GetPixel(locX, locY);
                    // if not visted pixel, not black
                    if (color.R != 0 || color.G != 0 || color.B != 0)
                    {
                        points.Add(new Point(locX, locY));
                        visited[locY, locX] = true;
                        setRemovePoints(bitmap, visited, locX, locY);
                    }

                }
            }
        }

        private Bitmap removeNoise(Bitmap bitmap)
        {
            Boolean[,] visited = new Boolean[bitmap.Height, bitmap.Width];
            for (int y = 0; y < bitmap.Height; ++y)
                for (int x = 0; x < bitmap.Width; ++x)
                    visited[y, x] = false;

            Bitmap bitmapWithoutNoise = bitmap.Clone(new Rectangle(0, 0, bitmap.Width, bitmap.Height), bitmap.PixelFormat);
            int theta = 10;

            for (int y = 0; y < bitmap.Height; ++y)
                for (int x = 0; x < bitmap.Width; ++x)
                {
                    if (visited[y, x])
                        continue;
                    visited[y, x] = true;

                    Color color = bitmap.GetPixel(x, y);
                    if (color.R != 0 || color.G != 0 || color.B != 0)
                    {
                        points = new List<Point>();
                        points.Add(new Point(x, y));
                        setRemovePoints(bitmap, visited, x, y);

                        if (points.Count < theta)
                            foreach (Point p in points)
                            {
                                bitmapWithoutNoise.SetPixel(p.x, p.y, Color.Black);
                            }
                    }
                }
            return bitmapWithoutNoise;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
