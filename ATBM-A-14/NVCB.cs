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
    public partial class NVCB : UserControl
    {
        public NVCB()
        {
            InitializeComponent();

            PersonalInformation stu = new PersonalInformation();
            stu.TopLevel = false;
            panel1.Controls.Add(stu);
            stu.Show();
        }
    }
}
