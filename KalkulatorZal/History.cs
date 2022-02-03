using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalkulatorZal
{
    public partial class History : Form
    {

        public HistoryElement model;
        Color[] tab = { Color.Gainsboro, Color.DarkGray };
        public History(List<HistoryElement> list)
        {
            InitializeComponent();
            for(int i = 0; i< list.Count; i++){
                ListViewItem lvi = new ListViewItem();
                lvi.Text = list[i].equation;
                lvi.SubItems.Add(list[i].result);
                lvi.BackColor = tab[i % 2];
                listView1.Items.Add(lvi);
            }
        }

        public class DataModel
        {
            public string equation { get; set; }
            public string result { get; set; }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            foreach (int i in listView1.SelectedIndices)
            {
                if (i < 0)
                {
                    ListViewItem item = listView1.SelectedItems[0];
                    model = new HistoryElement(item.Text, item.SubItems[1].Text);

                }
                else
                {
                    ListViewItem item = listView1.SelectedItems[i-1];
                    model = new HistoryElement(item.Text, item.SubItems[1].Text);
                }
                
            }
            DialogResult = DialogResult.OK;

        }
    }

}
