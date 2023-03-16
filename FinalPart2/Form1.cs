using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalPart2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }       

        private void CheckLineRelationship_Click(object sender, EventArgs e)
        {
            Line[] lines = CreateTwoLinesArray();
            if(lines != null)
                DecideLineRelationship(lines);
            return;            
        }
        private Line[] CreateTwoLinesArray() 
        {
            Line[] lines = new Line[2]; // Create an array including two lines.
            try
            {
                lines[0] = new Line(Convert.ToDouble(line1ATextBox.Text), Convert.ToDouble(line1BTextBox.Text),
                Convert.ToDouble(line1CTextBox.Text));
                lines[1] = new Line(Convert.ToDouble(line2ATextBox.Text), Convert.ToDouble(line2BTextBox.Text),
                    Convert.ToDouble(line2CTextBox.Text));
            }
            catch(Exception ex)
            {
                DialogResult answer;
                string exceptionMessage = ex.Message;
                if (ex is LineException)
                    exceptionMessage = ((LineException)ex).Message;
                answer = MessageBox.Show(exceptionMessage, "Input Error",
                    MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                if (answer == DialogResult.Retry)
                {
                    if (((line1ATextBox.Text == "" || Convert.ToDouble(line1ATextBox.Text) == 0)
                        && (line1BTextBox.Text == "" || Convert.ToDouble(line1BTextBox.Text) == 0))
                        || line1CTextBox.Text == "")
                    {
                        line1ATextBox.Text = "";
                        line1BTextBox.Text = "";
                        line1CTextBox.Text = "";
                    }
                    if (((line2ATextBox.Text == "" || Convert.ToDouble(line2ATextBox.Text) == 0)
                        && (line2BTextBox.Text == "" || Convert.ToDouble(line2BTextBox.Text) == 0))
                        || line2CTextBox.Text == "")
                    {
                        line2ATextBox.Text = "";
                        line2BTextBox.Text = "";
                        line2CTextBox.Text = "";
                    }
                }
                else
                    Close();
                return null;
            }            
            return lines;            
        }
        private void FillTwoLinesBoxes(Line[] lines)
        {
            line1ATextBox.Text = lines[0].A.ToString();
            line1BTextBox.Text = lines[0].B.ToString();
            line1CTextBox.Text = lines[0].C.ToString();
            line2ATextBox.Text = lines[1].A.ToString();
            line2BTextBox.Text = lines[1].B.ToString();
            line2CTextBox.Text = lines[1].C.ToString();
        }
        private void DecideLineRelationship(Line[] lines)
        {
            //Check parallell or not
            if (lines[0].A * lines[1].B == lines[0].B * lines[1].A)  
            {
                if (lines[0].B * lines[1].C == lines[0].C * lines[1].B)
                {
                    outputTextBox.Text = "Same line.";
                }
                else
                {
                    outputTextBox.Text = "The two lines are parallel.";
                }
            }
            else
            {
                double intersactionX = (lines[0].B * lines[1].C - lines[1].B * lines[0].C) / (lines[0].B * lines[1].A - lines[1].B * lines[0].A);
                double intersactionY = (lines[0].A * lines[1].C - lines[1].A * lines[0].C) / (lines[0].A * lines[1].B - lines[1].A * lines[0].B);
                outputTextBox.Text = $"The two lines has a intersection. \nThe solution is ({intersactionX}, {intersactionY})";
            }
            return;
        }
        private void Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Please select a folder to save";
            sfd.InitialDirectory = Application.StartupPath;
            sfd.Filter = "ser|*.ser";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string FILENAME = sfd.FileName;
                FileStream outFile = new FileStream(FILENAME, FileMode.Create, FileAccess.Write);
                BinaryFormatter bFormatter = new BinaryFormatter();
                bFormatter.Serialize(outFile, CreateTwoLinesArray());
                outFile.Close();
            }
        }

        private void Load_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Please select a file to load";
            ofd.InitialDirectory = Application.StartupPath;
            ofd.Filter = "txt|*.txt|ser|*.ser|all|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string FILENAME = ofd.FileName;
                FileStream inFile = new FileStream(FILENAME, FileMode.Open, FileAccess.Read);
                BinaryFormatter bFormatter = new BinaryFormatter();
                while (inFile.Position < inFile.Length)
                {
                    Line[] lines = (Line[])bFormatter.Deserialize(inFile);
                    FillTwoLinesBoxes(lines);
                }
                inFile.Close();
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            DialogResult answer;
            
            answer = MessageBox.Show("Do you want to clear ALL the values in the boxes?", "Warning", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (answer == DialogResult.Yes)
            {
                line1ATextBox.Text = null;
                line1BTextBox.Text = null;
                line1CTextBox.Text = null;
                line2ATextBox.Text = null;
                line2BTextBox.Text = null;
                line2CTextBox.Text = null;
                outputTextBox.Text = null;
            }
        }
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow digit and '.' to input.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Only allow one decimal point.
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }

    class LineException: Exception
    {
        string message;
        public string Message
        {
            get
            {
                return message;
            }
            set
            {
                message = value;
            }
        }
    }

    [Serializable]
    class Line
    {
        // line is Ax + By = C
        // A is variable x's coefficient
        // B is variable y's coefficient
        // C is constant coefficient
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; } 
        public Line(double coefficientOfX, double coefficientOfY, double constCoefficient)
        {
            this.A = coefficientOfX;
            this.B = coefficientOfY;
            this.C = constCoefficient;
            if(this.A == 0 && this.B == 0)
            {
                LineException notLine = new LineException();
                notLine.Message = "For a line, values A and B cannot be zero at the same time.";
                throw (notLine);
            }
        }
    }

}
