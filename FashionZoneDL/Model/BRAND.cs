//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace FashionZone.DataLayer.Model
{
    public partial class BRAND
    {
        #region Primitive Properties
    
        public virtual int ID
        {
            get;
            set;
        }
    
        public virtual string Name
        {
            get;
            set;
        }
    
        public virtual string Description
        {
            get;
            set;
        }
    
        public virtual string Contact
        {
            get;
            set;
        }
    
        public virtual string Telephone
        {
            get;
            set;
        }
    
        public virtual string Website
        {
            get;
            set;
        }
    
        public virtual string Email
        {
            get;
            set;
        }
    
        public virtual string ShowName
        {
            get;
            set;
        }
    
        public virtual Nullable<bool> Shop
        {
            get;
            set;
        }
    
        public virtual string Address
        {
            get;
            set;
        }

        #endregion

        #region Navigation Properties
    
        public virtual ICollection<CAMPAIGN> CAMPAIGN
        {
            get
            {
                if (_cAMPAIGN == null)
                {
                    var newCollection = new FixupCollection<CAMPAIGN>();
                    newCollection.CollectionChanged += FixupCAMPAIGN;
                    _cAMPAIGN = newCollection;
                }
                return _cAMPAIGN;
            }
            set
            {
                if (!ReferenceEquals(_cAMPAIGN, value))
                {
                    var previousValue = _cAMPAIGN as FixupCollection<CAMPAIGN>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupCAMPAIGN;
                    }
                    _cAMPAIGN = value;
                    var newValue = value as FixupCollection<CAMPAIGN>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupCAMPAIGN;
                    }
                }
            }
        }
        private ICollection<CAMPAIGN> _cAMPAIGN;

        #endregion

        #region Association Fixup
    
        private void FixupCAMPAIGN(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (CAMPAIGN item in e.NewItems)
                {
                    item.BRAND = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (CAMPAIGN item in e.OldItems)
                {
                    if (ReferenceEquals(item.BRAND, this))
                    {
                        item.BRAND = null;
                    }
                }
            }
        }

        #endregion

    }
}
