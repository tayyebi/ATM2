using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM2.Masters
{
    public partial class Crud : Adam
    {
        public enum Mode
        {
            Details,
            Create,
            Edit,
            Delete
        }


        private Mode currentMode;
        public Mode CurrentMode
        {
            get
            {
                return currentMode;
            }
            set
            {
                Mode_Reset();
                switch (value)
                {
                    case Mode.Details:
                        Mode_Details();
                        break;
                    case Mode.Create:
                        Mode_Create();
                        break;
                    case Mode.Edit:
                        Mode_Edit();
                        break;
                    case Mode.Delete:
                        Mode_Delete();
                        break;
                }
                currentMode = value;
            }
        }

        protected virtual void Mode_Reset()
        {

        }
        // public abstract void Mode_Details()
        protected virtual void Mode_Details()
        {

        }
        protected virtual void Mode_Create()
        {

        }
        protected virtual void Mode_Edit()
        {

        }
        protected virtual void Mode_Delete()
        {

        }



        public Crud()
        {
            InitializeComponent();
        }

        private void Crud_Load(object sender, EventArgs e)
        {

        }

        public virtual void rexaDataGridView_Main_Select(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 0)
                return;
        }
    }
}
