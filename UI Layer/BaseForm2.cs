using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Layer
{
    public  partial class BaseForm2 : Form
    {
        public BaseForm2()
        {
            InitializeComponent();
        }
        public void HideMenu()
        {
            buttonDelete.Visible = false;
            buttonModify.Visible = false;
            buttonNew.Visible = false;
            buttonShow.Visible = false;
            ButtonShowAll.Visible = false;

        }
              
        protected virtual void ImplementNew()
        {
     
        }
        protected virtual void ImplementShowAll()
        {

        }


        private void buttonEnterNew_Click(object sender, EventArgs e)
        {

        }

        private void BaseForm2_Load(object sender, EventArgs e)
        {

        }

       
        public void ShowProperties()
        {
        
            buttonEnterShowOne.Visible = true;
            ButtonBackToMenu.Visible = true;
            buttonModifyEnter.Visible = false;
            buttonEnterShowOne.Visible = false;
            buttonEnterNew.Visible = false;
            ButtonDeleteEnter.Visible = false;
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            HideMenu();
            ShowProperties();
            ImplementNew();
            buttonEnterNew.Visible = true;
        }

        private void ButtonShowAll_Click(object sender, EventArgs e)
        {
            {
                textBoxReadAll.Clear();
                HideMenu();
                textBoxReadAll.Visible = true;
                InventoryLabel.Visible = true;
                ButtonBackToMenu.Visible = true;
                ImplementShowAll();
             



            }

        }
        protected virtual void ImplementShow()
        {

        }
        private void buttonShow_Click(object sender, EventArgs e)
        {
            textBoxReadAll.Clear();
            HideMenu();
            ImplementShow();
            buttonEnterShowOne.Visible = true;
            ButtonBackToMenu.Visible = true;
        }
        protected virtual void ImplementModify()
        {

        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            HideMenu();
            ImplementModify();
            buttonModifyEnter.Visible = true;
            ButtonBackToMenu.Visible = true;

        }
        protected virtual void ImplementDelete()
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            HideMenu();
            ImplementDelete();
            ButtonBackToMenu.Visible = true;
            ButtonDeleteEnter.Visible = true;
        }

        private void ButtonBackToMenu_Click(object sender, EventArgs e)
        {
           
            
        }

        private void ButtonDeleteEnter_Click(object sender, EventArgs e)
        {

        }
    }
}
