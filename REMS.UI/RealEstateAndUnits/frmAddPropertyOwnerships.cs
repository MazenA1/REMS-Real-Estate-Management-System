using Interfaces;
using Models;
using Models.DTOs;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using REMS.UI.Client_Roles.Owner;
using REMS.UI.Client_Roles.Owner.Control.Events;
using REMS.UI.RealEstateAndUnits.Events;

namespace REMS.UI.RealEstateAndUnits
{
    public partial class frmAddPropertyOwnerships : Form
    {
        public event EventHandler<OnPropertyOwnerShipSelectedEventArgs> OnPropertyOwnerShipSelected;

        private int _OwnerID;

        private OwnerCardDTO _OwnerInfo;

        private IImageService _imageService = new ImageService();

        public frmAddPropertyOwnerships()
        {
            InitializeComponent();
        }
        private void txtFindOwner_Click(object sender, EventArgs e)
        {
            frmFindOwner frm = new frmFindOwner();
            frm.OnOwnerSelected += _OnOwnerSelected; 
            frm.ShowDialog();
        } 
        private void LlAddDeedImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbSuccess.Visible = true;
            }
        }
        public void RaiseOnOwnerSelected(Models.PropertyOwnership OwnerDetails, OwnerCardDTO ownerCardDTO)
        {
            RaiseOnOwnerSelected(new OnPropertyOwnerShipSelectedEventArgs(OwnerDetails, ownerCardDTO));
        }
        protected virtual void RaiseOnOwnerSelected(OnPropertyOwnerShipSelectedEventArgs e)
        {
            OnPropertyOwnerShipSelected?.Invoke(this, e);
        }
        private void _OnOwnerSelected(object sender, OnOwnerSelectedEventArgs e) 
        {
            txtOwnerName.Text = e.OwnerCard.OwnerName;
            this._OwnerID = e.OwnerCard.OwnerID;
            this._OwnerInfo = e.OwnerCard;
        }

        private string _HandleDeedImage()
        {
            string ImageFolder = @"C:\\REMS_DeedImages";

            string NewPath = _imageService.SaveImage(openFileDialog1.FileName.ToString(), ImageFolder); 

            if (NewPath != null)
            {
                return NewPath;
            }

            return null;
        }
        private PropertyOwnership _InitializeOwnerShipInfo()
        {
            return new PropertyOwnership
            {   
                OwnerID = this._OwnerID,
                DeedNumber = txtInstrumentNumber.Text,
                DeedDate = dtbDateOfInstrument.Value,
                LandNumber = txtPlotNumber.Text.Trim(),
                OwnershipStatusID = null,
                DeedImagePath = _HandleDeedImage(),
                OwnershipPercentage = txtOwnershipPercentage.Value,
                CreatedByUserID = Global.Global.CourentUser.UserID
            };

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (OnPropertyOwnerShipSelected != null)
            {
                RaiseOnOwnerSelected(_InitializeOwnerShipInfo(), this._OwnerInfo);
                this.Close();
            }
            else
                return; // letare handaling error
        }
          

    }
}
