using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{

    /// <summary>
    /// Represents an owner in a unit ownership registration,
    /// including person, client, ownership, and deed information.
    /// Supports change notifications for data-bound editable properties.
    /// </summary>
    public class UnitOwnerRegistrationItem : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(
                this,
                new PropertyChangedEventArgs(propertyName));
        }

        public int PersonID { get; set; }
        public Person PersonInfo { get; set; }
        public int ClientID { get; set; }
        private decimal _ownershipPercentage;
        public decimal OwnershipPercentage 
        {
            get => this._ownershipPercentage;

            set
            {
                if (this._ownershipPercentage != value)
                {
                    this._ownershipPercentage = value;

                    OnPropertyChanged(nameof(this.OwnershipPercentage));
                }

                else
                    return;
            }
        }

        public bool IsOwnershipRepresentative { get; set; }

        public string DeedNumber { get; set; }

        public DateTime? DeedDate { get; set; }

        public string DeedImagePath { get; set; } 

        public string Notes { get; set; }

        public string FullName => this.PersonInfo.FullName;
        public string NationalNo => this.PersonInfo.NationalNo; 
        public string PhoneNumber => this.PersonInfo.PhoneNumber; 

    }
}
