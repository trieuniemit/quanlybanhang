using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanHangLibraries;

/**
 * 
 *@ Author: Trieu Tai Niem 
 *@ Nhom: 6
 *@ Create on: 31/10/2018
 *
 */

namespace QuanLyBanHang
{
    public partial class MainForm : Form {

        private Image CloseTab, CloseTabActive;

        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            Helper.CurrentUserId = 1;

            //add event
            this.tabMain.DrawMode = TabDrawMode.OwnerDrawFixed;
            this.tabMain.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabMain_DrawItem);

            //load image
            Size imageSize = new Size(20,20);
            Bitmap imgBitmap = new Bitmap(Properties.Resources.close_tab2, imageSize);
            Bitmap imgBitmapActive = new Bitmap(Properties.Resources.close_tab, imageSize);

            CloseTab = imgBitmap;
            CloseTabActive = imgBitmapActive;
            tabMain.Padding = new Point(40);

        }


        private void AddNewTab(Form frm) {
            TabPage newTabPage = new TabPage(frm.Text.Trim());

            //setting form
            frm.TopLevel = false;
            frm.Parent = newTabPage;
            
            //add new tab add switch to new tab
            tabMain.TabPages.Add(newTabPage);
            tabMain.SelectedTab = tabMain.TabPages[tabMain.TabCount - 1];

            //show form
            frm.Dock = DockStyle.Fill;
            frm.Show();

        } 


        private void tabMain_DrawItem(object sender, DrawItemEventArgs e)
        {
            Rectangle rect = tabMain.GetTabRect(e.Index);
            Rectangle imageRect = new Rectangle(rect.Right - CloseTab.Width, rect.Top+(rect.Height-CloseTab.Height)/2, CloseTab.Width, CloseTab.Height);
            //resize rect
            rect.Size = new Size(rect.Width+24, 38);

            //string style for header
            Font tabHeaderFont;
            StringFormat tabStringFormat = new StringFormat(StringFormat.GenericDefault);
            
            //drow tab header
            if(tabMain.SelectedTab == tabMain.TabPages[e.Index]) {
                 //set background
                e.Graphics.FillRectangle(new SolidBrush(Color.White), e.Bounds);

                //draw icon
                e.Graphics.DrawImage(CloseTabActive, imageRect);
                tabHeaderFont = new Font("Arial", 12, FontStyle.Bold);
               
                //draw text
                e.Graphics.DrawString(tabMain.TabPages[e.Index].Text, tabHeaderFont, Brushes.Black, rect, tabStringFormat);
            } else {
                 //set background
                e.Graphics.FillRectangle(new SolidBrush(Color.WhiteSmoke), e.Bounds);

                 //draw icon
                e.Graphics.DrawImage(CloseTab, imageRect);
                tabHeaderFont = new Font("Arial", 12, FontStyle.Regular);

                //draw text
                e.Graphics.DrawString(tabMain.TabPages[e.Index].Text, tabHeaderFont, Brushes.Black, rect, tabStringFormat);
            }

        }

        //close tab
        private void tabMain_MouseClick(object sender, MouseEventArgs e) {
            for(int i = 0; i < tabMain.TabCount; i++) {
                Rectangle rect = tabMain.GetTabRect(i);
                Rectangle imageRect = new Rectangle(rect.Right - CloseTab.Width, rect.Top+(rect.Height-CloseTab.Height)/2, CloseTab.Width, CloseTab.Height);

                if(imageRect.Contains(e.Location))
                    tabMain.TabPages.Remove(tabMain.SelectedTab);
            }
        }

        //Open Ban Hang form
        private void ptbBanHang_Click_lbBanHang_Click(object sender, EventArgs e) {
            AddNewTab(new Forms.BanHangForm());
        }

    }
}
