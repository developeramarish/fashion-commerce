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
    public partial class USER
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
    
        public virtual string Email
        {
            get;
            set;
        }
    
        public virtual string Login
        {
            get;
            set;
        }
    
        public virtual string Password
        {
            get;
            set;
        }
    
        public virtual Nullable<int> RoleID
        {
            get { return _roleID; }
            set
            {
                try
                {
                    _settingFK = true;
                    if (_roleID != value)
                    {
                        if (ROLE != null && ROLE.ID != value)
                        {
                            ROLE = null;
                        }
                        _roleID = value;
                    }
                }
                finally
                {
                    _settingFK = false;
                }
            }
        }
        private Nullable<int> _roleID;
    
        public virtual bool Enabled
        {
            get;
            set;
        }
    
        public virtual string LastIP
        {
            get;
            set;
        }

        #endregion

        #region Navigation Properties
    
        public virtual ICollection<AUDIT> AUDIT
        {
            get
            {
                if (_aUDIT == null)
                {
                    var newCollection = new FixupCollection<AUDIT>();
                    newCollection.CollectionChanged += FixupAUDIT;
                    _aUDIT = newCollection;
                }
                return _aUDIT;
            }
            set
            {
                if (!ReferenceEquals(_aUDIT, value))
                {
                    var previousValue = _aUDIT as FixupCollection<AUDIT>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupAUDIT;
                    }
                    _aUDIT = value;
                    var newValue = value as FixupCollection<AUDIT>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupAUDIT;
                    }
                }
            }
        }
        private ICollection<AUDIT> _aUDIT;
    
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
    
        public virtual ROLE ROLE
        {
            get { return _rOLE; }
            set
            {
                if (!ReferenceEquals(_rOLE, value))
                {
                    var previousValue = _rOLE;
                    _rOLE = value;
                    FixupROLE(previousValue);
                }
            }
        }
        private ROLE _rOLE;
    
        public virtual ICollection<PRODUCT> PRODUCT
        {
            get
            {
                if (_pRODUCT == null)
                {
                    var newCollection = new FixupCollection<PRODUCT>();
                    newCollection.CollectionChanged += FixupPRODUCT;
                    _pRODUCT = newCollection;
                }
                return _pRODUCT;
            }
            set
            {
                if (!ReferenceEquals(_pRODUCT, value))
                {
                    var previousValue = _pRODUCT as FixupCollection<PRODUCT>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupPRODUCT;
                    }
                    _pRODUCT = value;
                    var newValue = value as FixupCollection<PRODUCT>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupPRODUCT;
                    }
                }
            }
        }
        private ICollection<PRODUCT> _pRODUCT;
    
        public virtual ICollection<ORDER_NOTES> ORDER_NOTES
        {
            get
            {
                if (_oRDER_NOTES == null)
                {
                    var newCollection = new FixupCollection<ORDER_NOTES>();
                    newCollection.CollectionChanged += FixupORDER_NOTES;
                    _oRDER_NOTES = newCollection;
                }
                return _oRDER_NOTES;
            }
            set
            {
                if (!ReferenceEquals(_oRDER_NOTES, value))
                {
                    var previousValue = _oRDER_NOTES as FixupCollection<ORDER_NOTES>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupORDER_NOTES;
                    }
                    _oRDER_NOTES = value;
                    var newValue = value as FixupCollection<ORDER_NOTES>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupORDER_NOTES;
                    }
                }
            }
        }
        private ICollection<ORDER_NOTES> _oRDER_NOTES;

        #endregion

        #region Association Fixup
    
        private bool _settingFK = false;
    
        private void FixupROLE(ROLE previousValue)
        {
            if (previousValue != null && previousValue.USER.Contains(this))
            {
                previousValue.USER.Remove(this);
            }
    
            if (ROLE != null)
            {
                if (!ROLE.USER.Contains(this))
                {
                    ROLE.USER.Add(this);
                }
                if (RoleID != ROLE.ID)
                {
                    RoleID = ROLE.ID;
                }
            }
            else if (!_settingFK)
            {
                RoleID = null;
            }
        }
    
        private void FixupAUDIT(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (AUDIT item in e.NewItems)
                {
                    item.USER = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (AUDIT item in e.OldItems)
                {
                    if (ReferenceEquals(item.USER, this))
                    {
                        item.USER = null;
                    }
                }
            }
        }
    
        private void FixupCAMPAIGN(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (CAMPAIGN item in e.NewItems)
                {
                    item.USER = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (CAMPAIGN item in e.OldItems)
                {
                    if (ReferenceEquals(item.USER, this))
                    {
                        item.USER = null;
                    }
                }
            }
        }
    
        private void FixupPRODUCT(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (PRODUCT item in e.NewItems)
                {
                    item.USER = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (PRODUCT item in e.OldItems)
                {
                    if (ReferenceEquals(item.USER, this))
                    {
                        item.USER = null;
                    }
                }
            }
        }
    
        private void FixupORDER_NOTES(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (ORDER_NOTES item in e.NewItems)
                {
                    item.USER = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (ORDER_NOTES item in e.OldItems)
                {
                    if (ReferenceEquals(item.USER, this))
                    {
                        item.USER = null;
                    }
                }
            }
        }

        #endregion

    }
}
