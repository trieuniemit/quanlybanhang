﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanHangLibraries;
using QuanLyBanHangDTOs;
using QuanLyBanHangBULs;
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
        private User CurrentUser;

        private GetUserBUL GetUserBul = new GetUserBUL();

        public MainForm(int logedInUser = -1) {

            InitializeComponent();

            ////test data
            //CurrentUser = new User(
            //    1,
            //    "trieuniemit",
            //    "Triệu Tài Niêm",
            //    "81dc9bdb52d04dc20036dbd8313ed055",
            //    "0395710844",
            //    "trieuniemit@gmail.com",
            //    2,
            //    0,
            //    "08-02-1998",
            //    "20-10-2018"
            //);

            CurrentUser = GetUserBul.getCurrentUser(logedInUser);

            lbUserName.Text = CurrentUser.Fullname;
            lbPosition.Text = Helper.GetUserRole(CurrentUser.Role);
        }

        private void MainForm_Load(object sender, EventArgs e) {
            //add introduce tab
             AddNewTab(new IntroduceForm());

            //add event
            this.tabMain.DrawMode = TabDrawMode.OwnerDrawFixed;
            this.tabMain.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabMain_DrawItem);

            //load image
            Size imageSize = new Size(20,20);
            Bitmap imgBitmap = new Bitmap(Properties.Resources.close_tab2, imageSize);
            Bitmap imgBitmapActive = new Bitmap(Properties.Resources.close_tab, imageSize);
            CloseTab = imgBitmap;
            CloseTabActive = imgBitmapActive;

            //set padding for tab header
            tabMain.Padding = new Point(40);

            if(CurrentUser.Role > 1) {
                parentCaiDat.Visible = false;
                parentNhanVien.Visible = false;
                parentThongKe.Visible = false;
                toolStripSeparator3.Visible = false;
                toolStripSeparator4.Visible = false;
                toolStripSeparator5.Visible = false;
            }

        }


        private void AddNewTab(Form frm) {
            //open tab if it exitst
            for(int i = 0; i < tabMain.TabCount; i++) {
                if(frm.Text.Trim() == tabMain.TabPages[i].Text) {
                    tabMain.SelectedTab = tabMain.TabPages[i];
                    return;
                }

                if(tabMain.TabPages[i].Text == "Giới thiệu") {
                    tabMain.TabPages.RemoveAt(i);
                }
            }


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


        private void tabMain_DrawItem(object sender, DrawItemEventArgs e) {
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
                tabHeaderFont = new Font("Arial", 11, FontStyle.Bold);
               
                //draw text
                e.Graphics.DrawString(tabMain.TabPages[e.Index].Text, tabHeaderFont, Brushes.Black, rect, tabStringFormat);
            } else {
                 //set background
                e.Graphics.FillRectangle(new SolidBrush(Color.WhiteSmoke), e.Bounds);

                 //draw icon
                e.Graphics.DrawImage(CloseTab, imageRect);
                tabHeaderFont = new Font("Arial", 11, FontStyle.Regular);

                //draw text
                e.Graphics.DrawString(tabMain.TabPages[e.Index].Text, tabHeaderFont, Brushes.Black, rect, tabStringFormat);
            }

        }

        //close tab
        private void tabMain_MouseClick(object sender, MouseEventArgs e) {
            for(int i = 0; i < tabMain.TabCount; i++) {
                Rectangle rect = tabMain.GetTabRect(i);
                Rectangle imageRect = new Rectangle(rect.Right - CloseTab.Width, rect.Top+(rect.Height-CloseTab.Height)/2, CloseTab.Width, CloseTab.Height);

                if(imageRect.Contains(e.Location)) {
                    tabMain.TabPages.Remove(tabMain.SelectedTab);
                    if(tabMain.TabPages.Count == 0) {
                        //add introduce tab
                        AddNewTab(new IntroduceForm());
                    }
                }
            }
        }

        private void itemBanHang_Click(object sender, EventArgs e)
        {
            AddNewTab(new Forms.BanHangForm(CurrentUser));
        }

        private void parentBanHang_DoubleClick(object sender, EventArgs e)
        {
            AddNewTab(new Forms.BanHangForm(CurrentUser));
        }

        private void lbLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void itemLichSu_Click(object sender, EventArgs e)
        {
            AddNewTab(new Forms.BanHangForm_LichSuBanHang());
        }

        private void parentThongKe_Click(object sender, EventArgs e)
        {
            AddNewTab(new HoSyHuy.ThongKeForm());
        }

        private void itemSanPham_Click(object sender, EventArgs e)
        {
            AddNewTab(new Forms.QuanLySanPhamForm());
        }

        private void parentSanPham_DoubleClick(object sender, EventArgs e)
        {
             AddNewTab(new Forms.QuanLySanPhamForm());
        }

        private void parentCaiDat_Click(object sender, EventArgs e)
        {
            AddNewTab(new Forms.CaiDatForm());
        }

        private void parentCaNhan_Click(object sender, EventArgs e)
        {
            AddNewTab(new NguyenHuynhDuc.SuaThongTinCaNhan(CurrentUser.Id));
        }

        private void itemLoaiSanPham_Click(object sender, EventArgs e)
        {
            AddNewTab(new NguyenHuynhDuc.QuanLyLoaiSanPham());
        }

        private void parentNhanVien_Click(object sender, EventArgs e)
        {
            AddNewTab(new DuongDucSon.QuanLyNhanVien(CurrentUser.Id));
        }

    }
}
