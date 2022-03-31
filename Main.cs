using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeathRollSim
{
    public partial class Deathroll : Form
    {
        public Deathroll()
        {
            InitializeComponent();
        }

        private void Deathroll_Load(object sender, EventArgs e)
        {
            PopulateFrequency();
        }

        public void PopulateFrequency()
        {
            for (int i = 1; i <= 50; i++)
            {
                DataGridViewRow row = (DataGridViewRow)dgvFrequency.Rows[0].Clone();
                row.Cells[0].Value = i.ToString();
                dgvFrequency.Rows.Add(row);
                row.Cells[1].Value = "0";

            }
                DataGridViewRow row2 = (DataGridViewRow)dgvFrequency.Rows[0].Clone();
                row2.Cells[0].Value = "51+";
                dgvFrequency.Rows.Add(row2);
                

        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            bool aFirst = true;
            String Player = "A";
            int Result;
            System.Random random = new System.Random();

            if (rdoRandom.Checked == true)
            {
                aFirst = false;
            }

            for (int i = int.Parse(txtGames.Text); i > 0; i--)
            {
                
                int maxNumber = int.Parse(txtStartingNum.Text);
                if (aFirst == true) 
                {
                    Player = "A";
                }
                else
                {
                    
                    Result = random.Next(1, 3);
                    if (Result == 2)
                    {
                        Player = "B";
                    }
                }
                int rolls = 0;
                while (maxNumber > 1)
                {
                    rolls++;
                    int result;
                    result = random.Next(1, maxNumber+1);


                    DataGridViewRow row = (DataGridViewRow)dgvRolls.Rows[0].Clone();
                    row.Cells[0].Value = Player.ToString();
                    row.Cells[1].Value = i.ToString();
                    row.Cells[2].Value = result.ToString();
                    row.Cells[3].Value = maxNumber.ToString();
                    dgvRolls.Rows.Add(row);

                    maxNumber = result;
                    if (result == 1)
                    {
                        break;
                    }
                    if (Player == "A")
                    {
                        Player = "B";
                    }
                    else
                    {
                        Player = "A";
                    }

                  
                }

                if (Player == "A")
                {
                    txtAWins.Text = (int.Parse(txtAWins.Text) + 1).ToString();
                }
                else
                {
                    txtBWins.Text = (int.Parse(txtBWins.Text) + 1).ToString();
                }

                dgvFrequency.Rows[rolls - 1].Cells["txtFrequency"].Value = int.Parse(dgvFrequency.Rows[rolls - 1].Cells["txtFrequency"].Value.ToString())+1;


            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvFrequency.Rows.Clear();
            dgvRolls.Rows.Clear();
            PopulateFrequency();

            txtAWins.Text = "0";
            txtBWins.Text = "0";
        }
    }
}
