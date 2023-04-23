using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace binaryConvertor
{
    public partial class Stack : Form
    {
        Stack<string> myStack = new Stack<string>();

        public Stack()
        {
            InitializeComponent();
            //Declare variables
            string ax, bx, cx, dx;

            //Assign memory location to each variable
            // Obtain the maximum addressable memory location
            IntPtr maxAddress = IntPtr.MaxValue;
            ax = maxAddress.ToString();
            bx = maxAddress.ToString();
            cx = maxAddress.ToString();
            dx = maxAddress.ToString();

            //Assign to label
            axValue.Text = ax;
            bxValue.Text = bx;
            cxValue.Text = cx;
            dxValue.Text = dx;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void convertorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm convertor = new MainForm();
            convertor.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Version: 1.0\n" +
               "Release Date: April 23rd 2023\n" +
               "Developers: Deniz K Acikbas, Kyle McCarthy, Samuel Stenerson \n"
               + "Annotation: Released as a project for CIS 375";
            string title = "About Assemblex";

            MessageBox.Show(message, title, MessageBoxButtons.OK);
        }

        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpMenu hmenu = new HelpMenu();
            hmenu.l1.Text = "#1 To assign a variable to a register, you can select the register 'Ex. EAX', enter your value, and then click on 'mov'.";
            hmenu.l2.Text = "#2 To add or subtract variables, you can select your register 'Ex. EAX' and click on 'add' for addition or 'sub' for subtraction.";
            hmenu.l3.Text = "#3 To push your variable into stack, just click on 'PUSH'.";
            hmenu.Show();
        }

        private void movButton_Click(object sender, EventArgs e)
        {
            //Declare variables
            string ax, bx, cx, dx;

            //Assign variables here
            if (axButton.Checked)
            {
                ax = valueBox.Text;
                axValue.Text = ax;
            }

            if (bxButton.Checked)
            {
                bx = valueBox.Text;
                bxValue.Text = bx;
            } 

            if (cxButton.Checked)
            {
                cx = valueBox.Text;
                cxValue.Text = cx;
            } 
            
            if (dxButton.Checked)
            {
                dx = valueBox.Text;
                dxValue.Text = dx;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //Declare variables
            string ax, bx, cx, dx;

            //Assign variables
            ax = axValue.Text;
            bx =bxValue.Text;
            cx = cxValue.Text;
            dx = dxValue.Text;

            //Temp variable for transformation
            int temp; 
            //Assign variables here
            if (axButton.Checked)
            {
                try
                {
                    temp = Convert.ToInt32(ax) + Convert.ToInt32(valueBox.Text);
                    ax = temp.ToString();
                    axValue.Text = ax;
                } catch (Exception ex) { 
                    MessageBox.Show(ex.Message);
                }
                
            }

            if (bxButton.Checked)
            {
                try
                {
                    temp = Convert.ToInt32(bx) + Convert.ToInt32(valueBox.Text);
                    bx = temp.ToString();
                    bxValue.Text = bx;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (cxButton.Checked)
            {
                try
                {
                    temp = Convert.ToInt32(cx) + Convert.ToInt32(valueBox.Text);
                    cx = temp.ToString();
                    cxValue.Text = cx;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (dxButton.Checked)
            {
                try
                {
                    temp = Convert.ToInt32(dx) + Convert.ToInt32(valueBox.Text);
                    dx = temp.ToString();
                    dxValue.Text = dx;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void subButton_Click(object sender, EventArgs e)
        {
            //Declare variables
            string ax, bx, cx, dx;

            //Assign variables
            ax = axValue.Text;
            bx = bxValue.Text;
            cx = cxValue.Text;
            dx = dxValue.Text;

            //Temp variable for transformation
            int temp;
            //Assign variables here
            if (axButton.Checked)
            {
                try
                {
                    temp = Convert.ToInt32(ax) - Convert.ToInt32(valueBox.Text);
                    ax = temp.ToString();
                    axValue.Text = ax;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

            if (bxButton.Checked)
            {
                try
                {
                    temp = Convert.ToInt32(bx) - Convert.ToInt32(valueBox.Text);
                    bx = temp.ToString();
                    bxValue.Text = bx;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (cxButton.Checked)
            {
                try
                {
                    temp = Convert.ToInt32(cx) - Convert.ToInt32(valueBox.Text);
                    cx = temp.ToString();
                    cxValue.Text = cx;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (dxButton.Checked)
            {
                try
                {
                    temp = Convert.ToInt32(dx) - Convert.ToInt32(valueBox.Text);
                    dx = temp.ToString();
                    dxValue.Text = dx;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void pushButton_Click(object sender, EventArgs e)
        {
            stackBox.Text = "";

            if (axButton.Checked)
            {
                myStack.Push(" " + "AX=" + valueBox.Text);
            }
            if (bxButton.Checked)
            {
                myStack.Push(" " + "BX=" + valueBox.Text);
            }
            if (cxButton.Checked)
            {
                myStack.Push(" " + "CX=" + valueBox.Text);
            }
            if (dxButton.Checked)
            {
                myStack.Push(" " + "DX=" + valueBox.Text);
            }
            foreach (var item in myStack)
            {
                stackBox.Text += item.ToString();
            }
        }
    }
}
