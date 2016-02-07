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
    public partial class CUSTOMER
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
    
        public virtual string Surname
        {
            get;
            set;
        }
    
        public virtual string Email
        {
            get;
            set;
        }
    
        public virtual string Password
        {
            get;
            set;
        }
    
        public virtual Nullable<System.DateTime> BirthDate
        {
            get;
            set;
        }
    
        public virtual string Gender
        {
            get;
            set;
        }
    
        public virtual bool Active
        {
            get;
            set;
        }
    
        public virtual Nullable<bool> Newsletter
        {
            get;
            set;
        }
    
        public virtual Nullable<System.DateTime> RegistrationDate
        {
            get;
            set;
        }
    
        public virtual Nullable<int> InvitedFrom
        {
            get { return _invitedFrom; }
            set
            {
                try
                {
                    _settingFK = true;
                    if (_invitedFrom != value)
                    {
                        if (CUSTOMER2 != null && CUSTOMER2.ID != value)
                        {
                            CUSTOMER2 = null;
                        }
                        _invitedFrom = value;
                    }
                }
                finally
                {
                    _settingFK = false;
                }
            }
        }
        private Nullable<int> _invitedFrom;
    
        public virtual string Telephone
        {
            get;
            set;
        }
    
        public virtual string Mobile
        {
            get;
            set;
        }
    
        public virtual Nullable<bool> FirstBuy
        {
            get;
            set;
        }
    
        public virtual string FBId
        {
            get;
            set;
        }

        #endregion

        #region Navigation Properties
    
        public virtual ICollection<ADDRESS> ADDRESS
        {
            get
            {
                if (_aDDRESS == null)
                {
                    var newCollection = new FixupCollection<ADDRESS>();
                    newCollection.CollectionChanged += FixupADDRESS;
                    _aDDRESS = newCollection;
                }
                return _aDDRESS;
            }
            set
            {
                if (!ReferenceEquals(_aDDRESS, value))
                {
                    var previousValue = _aDDRESS as FixupCollection<ADDRESS>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupADDRESS;
                    }
                    _aDDRESS = value;
                    var newValue = value as FixupCollection<ADDRESS>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupADDRESS;
                    }
                }
            }
        }
        private ICollection<ADDRESS> _aDDRESS;
    
        public virtual ICollection<BONUS> BONUS
        {
            get
            {
                if (_bONUS == null)
                {
                    var newCollection = new FixupCollection<BONUS>();
                    newCollection.CollectionChanged += FixupBONUS;
                    _bONUS = newCollection;
                }
                return _bONUS;
            }
            set
            {
                if (!ReferenceEquals(_bONUS, value))
                {
                    var previousValue = _bONUS as FixupCollection<BONUS>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupBONUS;
                    }
                    _bONUS = value;
                    var newValue = value as FixupCollection<BONUS>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupBONUS;
                    }
                }
            }
        }
        private ICollection<BONUS> _bONUS;
    
        public virtual ICollection<CUSTOMER> CUSTOMER1
        {
            get
            {
                if (_cUSTOMER1 == null)
                {
                    var newCollection = new FixupCollection<CUSTOMER>();
                    newCollection.CollectionChanged += FixupCUSTOMER1;
                    _cUSTOMER1 = newCollection;
                }
                return _cUSTOMER1;
            }
            set
            {
                if (!ReferenceEquals(_cUSTOMER1, value))
                {
                    var previousValue = _cUSTOMER1 as FixupCollection<CUSTOMER>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupCUSTOMER1;
                    }
                    _cUSTOMER1 = value;
                    var newValue = value as FixupCollection<CUSTOMER>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupCUSTOMER1;
                    }
                }
            }
        }
        private ICollection<CUSTOMER> _cUSTOMER1;
    
        public virtual CUSTOMER CUSTOMER2
        {
            get { return _cUSTOMER2; }
            set
            {
                if (!ReferenceEquals(_cUSTOMER2, value))
                {
                    var previousValue = _cUSTOMER2;
                    _cUSTOMER2 = value;
                    FixupCUSTOMER2(previousValue);
                }
            }
        }
        private CUSTOMER _cUSTOMER2;
    
        public virtual ICollection<INVITATION> INVITATION
        {
            get
            {
                if (_iNVITATION == null)
                {
                    var newCollection = new FixupCollection<INVITATION>();
                    newCollection.CollectionChanged += FixupINVITATION;
                    _iNVITATION = newCollection;
                }
                return _iNVITATION;
            }
            set
            {
                if (!ReferenceEquals(_iNVITATION, value))
                {
                    var previousValue = _iNVITATION as FixupCollection<INVITATION>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupINVITATION;
                    }
                    _iNVITATION = value;
                    var newValue = value as FixupCollection<INVITATION>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupINVITATION;
                    }
                }
            }
        }
        private ICollection<INVITATION> _iNVITATION;
    
        public virtual ICollection<ORDERS> ORDERS
        {
            get
            {
                if (_oRDERS == null)
                {
                    var newCollection = new FixupCollection<ORDERS>();
                    newCollection.CollectionChanged += FixupORDERS;
                    _oRDERS = newCollection;
                }
                return _oRDERS;
            }
            set
            {
                if (!ReferenceEquals(_oRDERS, value))
                {
                    var previousValue = _oRDERS as FixupCollection<ORDERS>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupORDERS;
                    }
                    _oRDERS = value;
                    var newValue = value as FixupCollection<ORDERS>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupORDERS;
                    }
                }
            }
        }
        private ICollection<ORDERS> _oRDERS;
    
        public virtual ICollection<SHOPPING_CART> SHOPPING_CART
        {
            get
            {
                if (_sHOPPING_CART == null)
                {
                    var newCollection = new FixupCollection<SHOPPING_CART>();
                    newCollection.CollectionChanged += FixupSHOPPING_CART;
                    _sHOPPING_CART = newCollection;
                }
                return _sHOPPING_CART;
            }
            set
            {
                if (!ReferenceEquals(_sHOPPING_CART, value))
                {
                    var previousValue = _sHOPPING_CART as FixupCollection<SHOPPING_CART>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupSHOPPING_CART;
                    }
                    _sHOPPING_CART = value;
                    var newValue = value as FixupCollection<SHOPPING_CART>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupSHOPPING_CART;
                    }
                }
            }
        }
        private ICollection<SHOPPING_CART> _sHOPPING_CART;
    
        public virtual ICollection<CUSTOMER_AUDIT> CUSTOMER_AUDIT
        {
            get
            {
                if (_cUSTOMER_AUDIT == null)
                {
                    var newCollection = new FixupCollection<CUSTOMER_AUDIT>();
                    newCollection.CollectionChanged += FixupCUSTOMER_AUDIT;
                    _cUSTOMER_AUDIT = newCollection;
                }
                return _cUSTOMER_AUDIT;
            }
            set
            {
                if (!ReferenceEquals(_cUSTOMER_AUDIT, value))
                {
                    var previousValue = _cUSTOMER_AUDIT as FixupCollection<CUSTOMER_AUDIT>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupCUSTOMER_AUDIT;
                    }
                    _cUSTOMER_AUDIT = value;
                    var newValue = value as FixupCollection<CUSTOMER_AUDIT>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupCUSTOMER_AUDIT;
                    }
                }
            }
        }
        private ICollection<CUSTOMER_AUDIT> _cUSTOMER_AUDIT;

        #endregion

        #region Association Fixup
    
        private bool _settingFK = false;
    
        private void FixupCUSTOMER2(CUSTOMER previousValue)
        {
            if (previousValue != null && previousValue.CUSTOMER1.Contains(this))
            {
                previousValue.CUSTOMER1.Remove(this);
            }
    
            if (CUSTOMER2 != null)
            {
                if (!CUSTOMER2.CUSTOMER1.Contains(this))
                {
                    CUSTOMER2.CUSTOMER1.Add(this);
                }
                if (InvitedFrom != CUSTOMER2.ID)
                {
                    InvitedFrom = CUSTOMER2.ID;
                }
            }
            else if (!_settingFK)
            {
                InvitedFrom = null;
            }
        }
    
        private void FixupADDRESS(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (ADDRESS item in e.NewItems)
                {
                    item.CUSTOMER = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (ADDRESS item in e.OldItems)
                {
                    if (ReferenceEquals(item.CUSTOMER, this))
                    {
                        item.CUSTOMER = null;
                    }
                }
            }
        }
    
        private void FixupBONUS(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (BONUS item in e.NewItems)
                {
                    item.CUSTOMER = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (BONUS item in e.OldItems)
                {
                    if (ReferenceEquals(item.CUSTOMER, this))
                    {
                        item.CUSTOMER = null;
                    }
                }
            }
        }
    
        private void FixupCUSTOMER1(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (CUSTOMER item in e.NewItems)
                {
                    item.CUSTOMER2 = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (CUSTOMER item in e.OldItems)
                {
                    if (ReferenceEquals(item.CUSTOMER2, this))
                    {
                        item.CUSTOMER2 = null;
                    }
                }
            }
        }
    
        private void FixupINVITATION(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (INVITATION item in e.NewItems)
                {
                    item.CUSTOMER = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (INVITATION item in e.OldItems)
                {
                    if (ReferenceEquals(item.CUSTOMER, this))
                    {
                        item.CUSTOMER = null;
                    }
                }
            }
        }
    
        private void FixupORDERS(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (ORDERS item in e.NewItems)
                {
                    item.CUSTOMER = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (ORDERS item in e.OldItems)
                {
                    if (ReferenceEquals(item.CUSTOMER, this))
                    {
                        item.CUSTOMER = null;
                    }
                }
            }
        }
    
        private void FixupSHOPPING_CART(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (SHOPPING_CART item in e.NewItems)
                {
                    item.CUSTOMER = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (SHOPPING_CART item in e.OldItems)
                {
                    if (ReferenceEquals(item.CUSTOMER, this))
                    {
                        item.CUSTOMER = null;
                    }
                }
            }
        }
    
        private void FixupCUSTOMER_AUDIT(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (CUSTOMER_AUDIT item in e.NewItems)
                {
                    item.CUSTOMER = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (CUSTOMER_AUDIT item in e.OldItems)
                {
                    if (ReferenceEquals(item.CUSTOMER, this))
                    {
                        item.CUSTOMER = null;
                    }
                }
            }
        }

        #endregion

    }
}