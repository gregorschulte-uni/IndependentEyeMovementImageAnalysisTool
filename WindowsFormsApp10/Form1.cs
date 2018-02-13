using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        private void MakeDataTableAndDisplay(string MyFilename)
        {
            string fileName = MyFilename;
            // Create new DataTable.
            DataTable MyTable = new DataTable();

            // Declare DataColumn and DataRow variables.
            DataColumn column;
            DataRow row;

            // Create new DataColumn, set DataType, ColumnName
            // and add to DataTable.    
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "id";
            MyTable.Columns.Add(column);

            // Create second column.
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "filename";
            MyTable.Columns.Add(column);

            // Create thrid column.
            column = new DataColumn();
            column.DataType = Type.GetType("System.Int32");
            column.ColumnName = "score";
            MyTable.Columns.Add(column);

            // Create new DataRow objects and add to DataTable.    
            for (int i = 0; i < 10; i++)
            {
                row = MyTable.NewRow();
                row["id"] = i;
                row["filename"] = fileName;
                row["score"] = 0;
                MyTable.Rows.Add(row);
            }
            // Set to DataGrid.DataSource property to the table.
            //dataGrid1.DataSource = table;
        }

        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            const string message = "Are you sure that you would like to close the programm? \r\nMake sure you saved all data by pressing 'w'! ";
            const string caption = "Close Program";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            e.Cancel = (result == DialogResult.No);
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            MyTextBox.Visible = false;
            MyLabelFilename.Visible =false;
            MyLabelMaximum.Visible = false;
            MyLabelPosition.Visible =false;
            MyProgressbar.Visible = false;

            MyPictureBox_2.Location = new Point(0, 0);

            MyPictureBox_2.Height = this.Height;
            MyPictureBox_2.Width = this.Width;

            MyTextBox.Text =    "\r\n\talt + F4 / ESC\tquit program\r\n" +
                                "\tH\t\tdisplay this help\r\n" +
                                "\tJ\t\tshow filename and position\r\n" +
                                "\tO\t\topen folder\r\n" +
                                "\tmouse drag\tmove image\r\n" +
                                "\tmouse wheel\tzoom\r\n" +
                                "\tF\t\treset view\r\n" +
                                "\tW\t\twrite results to file\r\n" +
                                "\tleft\t\tback one image\r\n" +
                                "\tright\t\tforward one image\r\n" +
                                "\tshift + left\t\tback 100 images\r\n" +
                                "\tshift + right\tforward 100 images\r\n" +
                                "\t1/2/3/4/5/6\tscore images (on Numpad)";
        }

        int MyMaximum = 0;
        private int MyPosition = 0;
        int[] score;
        string[] files;
        public string MySourceFolder = "empty";
        public String[] filters = new String[] { "jpg", "jpeg" };
        string[] mytable;
        private Point mouseDown;

        private void MyKeyPress(object sender, KeyEventArgs e)
        {
            if ((ModifierKeys & Keys.Shift) == Keys.Shift)
            {
                switch (e.KeyCode)
                {
                    case Keys.Right:
               
                    next100Images();
                        break;
                    case Keys.Left:
                        previous100Images();
                        break;
                    default:
                        break;
                }
                
            }
            else
            {
                switch (e.KeyCode)
                {

                    case Keys.H:
                        MyTextBox.Visible = !MyTextBox.Visible;
                        break;

                    case Keys.Escape:
                        Application.Exit();
                        break;

                    case Keys.Right:
                        nextImage();
                        break;

                    case Keys.Left:
                         previousImage(); 
                        break;
                    case Keys.NumPad1:
                        if (score !=null)
                        { 
                            score[MyPosition] = 1;
                            MyLabelScore.Text = score[MyPosition].ToString();
                            nextImage();
                        }
                        else { Console.Beep(); }
                        break;

                    case Keys.NumPad2:
                        if (score != null)
                        {
                            score[MyPosition] = 2;
                            MyLabelScore.Text = score[MyPosition].ToString();
                            nextImage();
                        }
                        else { Console.Beep(); }
                        break;

                    case Keys.NumPad3:
                        if (score != null)
                        {
                            score[MyPosition] =3;
                            MyLabelScore.Text = score[MyPosition].ToString();
                            nextImage();
                        }
                        else { Console.Beep(); }
                        break;

                    case Keys.NumPad4:
                        if (score != null)
                        {
                            score[MyPosition] = 4;
                            MyLabelScore.Text = score[MyPosition].ToString();
                            nextImage();
                        }
                        else { Console.Beep(); }
                        break;

                    case Keys.NumPad5:
                        if (score != null)
                        {
                            score[MyPosition] = 5;
                            MyLabelScore.Text = score[MyPosition].ToString();
                            nextImage();
                        }
                        else { Console.Beep(); }                    
                        break;

                    case Keys.NumPad6:
                        if (score != null)
                        {
                            score[MyPosition] = 6;
                            MyLabelScore.Text = score[MyPosition].ToString();
                            nextImage();
                        }
                        else { Console.Beep(); }
                        break;

                    case Keys.NumPad7:
                        if (score != null)
                        {
                            score[MyPosition] = 7;
                            MyLabelScore.Text = score[MyPosition].ToString();
                            nextImage();
                        }
                        else { Console.Beep(); }
                        break;

                    case Keys.NumPad8:
                        if (score != null)
                        {
                            score[MyPosition] = 8;
                            MyLabelScore.Text = score[MyPosition].ToString();
                            nextImage();
                        }
                        else { Console.Beep(); }
                        break;

                    case Keys.NumPad9:
                        if (score != null)
                        {
                            score[MyPosition] = 9;
                            MyLabelScore.Text = score[MyPosition].ToString();
                            nextImage();
                        }
                        else { Console.Beep(); }
                        break;

                    case Keys.NumPad0:
                        if (score != null)
                        {
                            score[MyPosition] = 0;
                            MyLabelScore.Text = score[MyPosition].ToString();
                            nextImage();
                        }
                        else { Console.Beep(); }
                        break;

                    case Keys.O:
                        if (MyFolderBrowserDialog.ShowDialog() == DialogResult.OK)
                        {
                            MyPosition = 0;
                            if (files != null)
                            {
                                Array.Clear(files, 0, files.Length);
                                Console.Beep();
                            }
                            //Array.Clear(score, 0, score.Length);
                            MySourceFolder = MyFolderBrowserDialog.SelectedPath;
                            files = GetFilesFrom(MySourceFolder, filters, false);
                            if (Path.GetFileNameWithoutExtension(files[MyPosition]).Length==54)
                                { 
                            Array.Sort(files, (a, b) => string.Compare(Path.GetFileNameWithoutExtension(a).Substring(46,8), Path.GetFileNameWithoutExtension(b).Substring(46, 8))) ;
                            //MyPosMax = files.Length;
                            //MyLabelScore.Text = MyPosMax.ToString();
                            MyPictureBox_2.Image = Image.FromFile(files[MyPosition]);
                            MyMaximum = files.Length;
                            //MyLabelScore.Text = Path.GetFileNameWithoutExtension(files[1]).Substring(46, 8);// files[1].Substring(55, 8).ToString();

                            score = new int[files.Length];

                            for (int i = 0; i < score.Length; i++)
                                {
                                    score[i] = -1;
                                }

                            MyLabelScore.Text = score[MyPosition].ToString();

                            MyLabelFilename.Text = Path.GetFileNameWithoutExtension(files[MyPosition]);
                            MyProgressbar.Maximum = files.Length-1;
                        
                            MyProgressbar.Value = MyPosition;
                            MyLabelPosition.Text = MyPosition.ToString();
                            MyLabelMaximum.Text = MyMaximum.ToString();

                            }
                            else MessageBox.Show("Filenames do not match expected scheme");

                        }
                        break;

                    case Keys.W:
                        writeResults();
                        break;

                    case Keys.J:
                        MyLabelFilename.Visible = !MyLabelFilename.Visible;
                        MyLabelPosition.Visible = !MyLabelPosition.Visible;
                        MyProgressbar.Visible = !MyProgressbar.Visible;
                        MyLabelMaximum.Visible = !MyLabelMaximum.Visible;
                        break;

                    case Keys.F:                    
                        MyPictureBox_2.Width = this.Width;
                        MyPictureBox_2.Height = this.Height;
                        MyPictureBox_2.Location = new Point(0, 0);
                        break;

                    default:
                        break;
                }
            }


            Invalidate();
        }

        private void MyMouseDown(object sender, EventArgs e)
        {
            MouseEventArgs mouse = e as MouseEventArgs;

            if (mouse.Button == MouseButtons.Left)
            {
                 mouseDown = mouse.Location;
            }
        }

        private void MyMouseWheel(object sender, MouseEventArgs e)
        {

            if (e.Delta > 0)
            {
                if (MyPictureBox_2.Width < 4000)
                {
                    //MyPictureBox_2.Location = new Point(MyPictureBox_2.Location.X - (int)(MyPictureBox_2.Width * 0.05), MyPictureBox_2.Location.Y - (int)(MyPictureBox_2.Height * 0.05));

                    MyPictureBox_2.Width = (int)(MyPictureBox_2.Width * 1.1);
                    MyPictureBox_2.Height = (int)(MyPictureBox_2.Width * 1.1);
                }
            }
            else
            {
                if (MyPictureBox_2.Width > 100)
                {
                    //MyPictureBox_2.Location = new Point(MyPictureBox_2.Location.X + (int)(MyPictureBox_2.Width * 0.05), MyPictureBox_2.Location.Y + (int)(MyPictureBox_2.Height * 0.05));

                    MyPictureBox_2.Width = (int)(MyPictureBox_2.Width * 0.9);
                    MyPictureBox_2.Height = (int)(MyPictureBox_2.Width * 0.9);
                }
            }
            
        }

        private void MyMouseMove(object sender, EventArgs e)
        {
            //MouseDown = mouse.Location;
            MouseEventArgs mouse = e as MouseEventArgs;            
           
            if (mouse.Button == MouseButtons.Left)
            {
                Point mousePosNow = mouse.Location;
                //MyTextBox.Text = "X: "+ mouseDown.X.ToString() +" Y: "+ mouseDown.Y.ToString();

                int deltaX = mousePosNow.X - mouseDown.X;
                int deltaY = mousePosNow.Y - mouseDown.Y;

                int newX = MyPictureBox_2.Location.X + deltaX;
                int newY = MyPictureBox_2.Location.Y + deltaY;

                MyPictureBox_2.Location = new Point(newX, newY);
            }
        }

        public static String[] GetFilesFrom(String searchFolder, String[] filters, bool isRecursive)
        {
            List<String> filesFound = new List<String>();
            var searchOption = isRecursive ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
            foreach (var filter in filters)
            {
                filesFound.AddRange(Directory.GetFiles(searchFolder, String.Format("*.{0}", filter), searchOption));
            }
            return filesFound.ToArray();
        }

        private void nextImage ()
        {
            if (MyPosition < MyMaximum - 1)
            {
                
                MyPosition++;
                MyLabelScore.Text = score[MyPosition].ToString();
                MyPictureBox_2.Image = Image.FromFile(files[MyPosition]);
                MyLabelFilename.Text = Path.GetFileNameWithoutExtension(files[MyPosition]);
                MyLabelPosition.Text = MyPosition.ToString();
                MyProgressbar.Value = MyPosition;
            }
            else {
                Console.Beep();
            }
        }

        private void next100Images()
        {
            if (MyPosition < MyMaximum - 100)
            {

                MyPosition=MyPosition+100;
                MyLabelScore.Text = score[MyPosition].ToString();
                MyPictureBox_2.Image = Image.FromFile(files[MyPosition]);
                MyLabelFilename.Text = Path.GetFileNameWithoutExtension(files[MyPosition]);
                MyLabelPosition.Text = MyPosition.ToString();
                MyProgressbar.Value = MyPosition;
            }
            else
            {
                MyPosition = MyMaximum-1;
                MyLabelScore.Text = score[MyPosition].ToString();
                MyPictureBox_2.Image = Image.FromFile(files[MyPosition]);
                MyLabelFilename.Text = Path.GetFileNameWithoutExtension(files[MyPosition]);
                MyLabelPosition.Text = MyPosition.ToString();
                MyProgressbar.Value = MyPosition;
                Console.Beep();
            }
        }

        private void previousImage()
        {
            if (MyPosition > 0)
            {
                
                MyPosition--;
                MyLabelScore.Text = score[MyPosition].ToString();
                MyPictureBox_2.Image = Image.FromFile(files[MyPosition]);
                MyLabelFilename.Text = Path.GetFileNameWithoutExtension(files[MyPosition]);
                MyLabelPosition.Text = MyPosition.ToString();
                MyProgressbar.Value = MyPosition;
 
            }
            else { Console.Beep(); }
        }

        private void previous100Images()
        {
            if (MyPosition > 100)
            {

                MyPosition= MyPosition -100;
                MyLabelScore.Text = score[MyPosition].ToString();
                MyPictureBox_2.Image = Image.FromFile(files[MyPosition]);
                MyLabelFilename.Text = Path.GetFileNameWithoutExtension(files[MyPosition]);
                MyLabelPosition.Text = MyPosition.ToString();
                MyProgressbar.Value = MyPosition;

            }

            else {
                MyPosition = 0;
                MyLabelScore.Text = score[MyPosition].ToString();
                MyPictureBox_2.Image = Image.FromFile(files[MyPosition]);
                MyLabelFilename.Text = Path.GetFileNameWithoutExtension(files[MyPosition]);
                MyLabelPosition.Text = MyPosition.ToString();
                MyProgressbar.Value = MyPosition;
                Console.Beep(); }
        }

        private void writeResults()
        {
            if (score != null && !Array.Exists(score, element => element.Equals(-1)))
            {
                string outfile = Path.GetFileNameWithoutExtension(files[0]).Substring(0, 5);
                string outfolder = Path.GetDirectoryName(files[0]);
                mytable = new string[files.Length];
                for (int i = 0; i < files.Length; i++)
                {
                    mytable[i] = Path.GetFileNameWithoutExtension(files[i]) + ";" + score[i].ToString();
                }
                File.WriteAllLines(outfolder + "\\" + outfile + ".txt", mytable, Encoding.UTF8);
                MessageBox.Show("Results successfully written to: " + outfolder + "\\"+ outfile + ".txt.");
            }
            else
            {
                if (score != null)
                { 
                int x = 0;
                for (int i = 0; i < score.Length - 1; i++)
                {
                    if (score[i] == -1)
                    {
                        x++;
                    }
                }

                Console.Beep();
                MessageBox.Show(x.ToString()+ " Pictures have not been rated. First missing value is at index: "+ Array.IndexOf(score,-1).ToString());
                }
            }
        }

        private void MyTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
