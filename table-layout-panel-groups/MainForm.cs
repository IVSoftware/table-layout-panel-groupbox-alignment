using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace table_layout_panel_groups
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            labelPlace.Text = string.Empty;
            tableLayoutPanelLeft.BackColor = Color.Transparent;
            tableLayoutPanelLeft.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
            tableLayoutPanelRight.BackColor = Color.Transparent;
            tableLayoutPanelRight.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
        }
    }
}
