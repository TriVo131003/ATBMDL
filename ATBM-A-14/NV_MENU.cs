﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATBM_A_14
{
    public partial class NV_MENU : Form
    {
        public NV_MENU()
        {
            InitializeComponent();
        }

        private void NV_MENU_Load(object sender, EventArgs e)
        {
            PersonalInformation stu = new PersonalInformation();
            stu.TopLevel = false;
            panel1.Controls.Add(stu);
            stu.Show();
        }
    }
}
