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
    public partial class AUDIT
    {
        #region Primitive Properties
    
        public virtual int ID
        {
            get;
            set;
        }
    
        public virtual Nullable<int> UserID
        {
            get { return _userID; }
            set
            {
                try
                {
                    _settingFK = true;
                    if (_userID != value)
                    {
                        if (USER != null && USER.ID != value)
                        {
                            USER = null;
                        }
                        _userID = value;
                    }
                }
                finally
                {
                    _settingFK = false;
                }
            }
        }
        private Nullable<int> _userID;
    
        public virtual string Action
        {
            get;
            set;
        }
    
        public virtual string Description
        {
            get;
            set;
        }
    
        public virtual Nullable<System.DateTime> TimeStamp
        {
            get;
            set;
        }

        #endregion

        #region Navigation Properties
    
        public virtual USER USER
        {
            get { return _uSER; }
            set
            {
                if (!ReferenceEquals(_uSER, value))
                {
                    var previousValue = _uSER;
                    _uSER = value;
                    FixupUSER(previousValue);
                }
            }
        }
        private USER _uSER;

        #endregion

        #region Association Fixup
    
        private bool _settingFK = false;
    
        private void FixupUSER(USER previousValue)
        {
            if (previousValue != null && previousValue.AUDIT.Contains(this))
            {
                previousValue.AUDIT.Remove(this);
            }
    
            if (USER != null)
            {
                if (!USER.AUDIT.Contains(this))
                {
                    USER.AUDIT.Add(this);
                }
                if (UserID != USER.ID)
                {
                    UserID = USER.ID;
                }
            }
            else if (!_settingFK)
            {
                UserID = null;
            }
        }

        #endregion

    }
}
