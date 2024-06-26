﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace ATBM_A_14
{
    public partial class StudentView : Form
    {
        public StudentView()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            StudentView_Load(sender, e);
        }

        private void StudentView_Load(object sender, EventArgs e)
        {
            string sql1 = $"select * from {Program.SCHEMA}.SINHVIEN";
            OracleCommand command = new OracleCommand(sql1, Program.conn);
            try
            {
                DataTable data = new DataTable();
                OracleDataAdapter adapter = new OracleDataAdapter(command);
                adapter.Fill(data);
                dataGridView1.DataSource = data;
            }
            catch (OracleException ex) { MessageBox.Show(ex.Message); }
        }

    }
}
