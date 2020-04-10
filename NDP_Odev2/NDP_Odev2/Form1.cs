using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDP_Odev2
{
    public partial class AnaPanel : Form
    {
        public int x = 0, y = 0, sayac = 0;
        ArrayList xBasamaklari;
        ArrayList yBasamaklari;
        int toplamX;
        int toplamY;
        Label xListBoxLabel;
        Label yListBoxLabel;
        ListBox xListBox;
        ListBox yListBox;
        Label toplamlarLabel;
        TextBox xTextBoxList;
        TextBox yTextBoxList;

        public AnaPanel()
        {
            InitializeComponent();
        }

        private void AnaPanel_Load(object sender, EventArgs e)
        {

        }
        
        private void sonButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void arkadasButton_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {

                if (xTextBox.Text != "" && yTextBox.Text != "")
                {
                    this.x = Convert.ToInt32(xTextBox.Text);
                    this.y = Convert.ToInt32(yTextBox.Text);

                    this.Width = 800;
                    this.Height = 500;

                    xListBoxLabel = new Label();
                    xListBoxLabel.Size = new Size(24, 20);
                    xListBoxLabel.Location = new Point(423, 50);
                    xListBoxLabel.Text = "X:";
                    this.Controls.Add(xListBoxLabel);

                    yListBoxLabel = new Label();
                    yListBoxLabel.Size = new Size(24, 20);
                    yListBoxLabel.Location = new Point(623, 50);
                    yListBoxLabel.Text = "Y:";
                    this.Controls.Add(yListBoxLabel);

                    xListBox = new ListBox();
                    xListBox.Size = new Size(120, 275);
                    xListBox.Location = new Point(375, 70);
                    this.Controls.Add(xListBox);

                    yListBox = new ListBox();
                    yListBox.Size = new Size(120, 275);
                    yListBox.Location = new Point(575, 70);
                    this.Controls.Add(yListBox);

                    toplamlarLabel = new Label();
                    toplamlarLabel.Size = new Size(75, 20);
                    toplamlarLabel.Location = new Point(300, 375);
                    toplamlarLabel.Text = "TOPLAMLAR:";
                    this.Controls.Add(toplamlarLabel);


                    xTextBoxList = new TextBox();
                    xTextBoxList.Size = new Size(120, 20);
                    xTextBoxList.Location = new Point(375, 375);
                    this.Controls.Add(xTextBoxList);

                    yTextBoxList = new TextBox();
                    yTextBoxList.Size = new Size(120, 20);
                    yTextBoxList.Location = new Point(575, 375);
                    this.Controls.Add(yTextBoxList);



                    xBasamaklari = new ArrayList();
                    yBasamaklari = new ArrayList();

                    for (int i = 1; i < x; i++)
                    {
                        if (x % i == 0)
                        {
                            xBasamaklari.Add(i);
                        }
                    }

                    for (int i = 1; i < y; i++)
                    {
                        if (y % i == 0)
                        {
                            yBasamaklari.Add(i);
                        }
                    }


                    foreach (var item in xBasamaklari)
                    {
                        xListBox.Items.Add(item);
                    }

                    foreach (var item in yBasamaklari)
                    {
                        yListBox.Items.Add(item);
                    }


                    toplamX = 0;

                    foreach (var item in xListBox.Items)
                    {
                        toplamX = toplamX + Convert.ToInt32(item);
                        xTextBoxList.Text = Convert.ToString(toplamX);
                    }


                    toplamY = 0;

                    foreach (var item in yListBox.Items)
                    {
                        toplamY = toplamY + Convert.ToInt32(item);
                        yTextBoxList.Text = Convert.ToString(toplamY);
                    }

                    if (x==toplamY && y==toplamX)
                    {
                        MessageBox.Show("Arkadaş sayıdırlar.");
                    }
                    else
                    {
                        MessageBox.Show("Arkadaş sayı değildirler.");
                    }
                    sayac++;
                }
                else
                {
                    MessageBox.Show("Lütfen bütün textboxları doldurunuz!");
                }
                
            }

            else
            {
                if (xTextBox.Text != "" && yTextBox.Text != "")
                {
                    xListBox.Items.Clear();
                    yListBox.Items.Clear();
                    xTextBoxList.Text = "";
                    yTextBoxList.Text = "";

                    this.x = Convert.ToInt32(xTextBox.Text);
                    this.y = Convert.ToInt32(yTextBox.Text);

                    xBasamaklari = new ArrayList();
                    yBasamaklari = new ArrayList();

                    for (int i = 1; i < x; i++)
                    {
                        if (x % i == 0)
                        {
                            xBasamaklari.Add(i);
                        }
                    }

                    for (int i = 1; i < y; i++)
                    {
                        if (y % i == 0)
                        {
                            yBasamaklari.Add(i);
                        }
                    }


                    foreach (var item in xBasamaklari)
                    {
                        xListBox.Items.Add(item);
                    }

                    foreach (var item in yBasamaklari)
                    {
                        yListBox.Items.Add(item);
                    }


                    toplamX = 0;

                    foreach (var item in xListBox.Items)
                    {
                        toplamX = toplamX + Convert.ToInt32(item);
                        xTextBoxList.Text = Convert.ToString(toplamX);
                    }


                    toplamY = 0;

                    foreach (var item in yListBox.Items)
                    {
                        toplamY = toplamY + Convert.ToInt32(item);
                        yTextBoxList.Text = Convert.ToString(toplamY);
                    }

                    if (x == toplamY && y == toplamX)
                    {
                        MessageBox.Show("Arkadaş sayıdırlar.");
                    }
                    else
                    {
                        MessageBox.Show("Arkadaş sayı değildirler.");
                    }
                    sayac++;
                }
                else
                {
                    MessageBox.Show("Lütfen bütün textboxları doldurunuz!");
                }
                
            }


        }


    }
}
