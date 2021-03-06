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
    public partial class ORDER_DETAIL
    {
        #region Primitive Properties
    
        public virtual int OrderID
        {
            get { return _orderID; }
            set
            {
                if (_orderID != value)
                {
                    if (ORDERS != null && ORDERS.ID != value)
                    {
                        ORDERS = null;
                    }
                    _orderID = value;
                }
            }
        }
        private int _orderID;
    
        public virtual int Quantity
        {
            get;
            set;
        }
    
        public virtual int ProdAttrID
        {
            get { return _prodAttrID; }
            set
            {
                if (_prodAttrID != value)
                {
                    if (PRODUCT_ATTRIBUTE != null && PRODUCT_ATTRIBUTE.ID != value)
                    {
                        PRODUCT_ATTRIBUTE = null;
                    }
                    _prodAttrID = value;
                }
            }
        }
        private int _prodAttrID;
    
        public virtual int CampaignID
        {
            get { return _campaignID; }
            set
            {
                if (_campaignID != value)
                {
                    if (CAMPAIGN != null && CAMPAIGN.ID != value)
                    {
                        CAMPAIGN = null;
                    }
                    _campaignID = value;
                }
            }
        }
        private int _campaignID;
    
        public virtual int ID
        {
            get;
            set;
        }

        #endregion

        #region Navigation Properties
    
        public virtual CAMPAIGN CAMPAIGN
        {
            get { return _cAMPAIGN; }
            set
            {
                if (!ReferenceEquals(_cAMPAIGN, value))
                {
                    var previousValue = _cAMPAIGN;
                    _cAMPAIGN = value;
                    FixupCAMPAIGN(previousValue);
                }
            }
        }
        private CAMPAIGN _cAMPAIGN;
    
        public virtual PRODUCT_ATTRIBUTE PRODUCT_ATTRIBUTE
        {
            get { return _pRODUCT_ATTRIBUTE; }
            set
            {
                if (!ReferenceEquals(_pRODUCT_ATTRIBUTE, value))
                {
                    var previousValue = _pRODUCT_ATTRIBUTE;
                    _pRODUCT_ATTRIBUTE = value;
                    FixupPRODUCT_ATTRIBUTE(previousValue);
                }
            }
        }
        private PRODUCT_ATTRIBUTE _pRODUCT_ATTRIBUTE;
    
        public virtual ORDERS ORDERS
        {
            get { return _oRDERS; }
            set
            {
                if (!ReferenceEquals(_oRDERS, value))
                {
                    var previousValue = _oRDERS;
                    _oRDERS = value;
                    FixupORDERS(previousValue);
                }
            }
        }
        private ORDERS _oRDERS;
    
        public virtual ICollection<RETURN_DETAILS> RETURN_DETAILS
        {
            get
            {
                if (_rETURN_DETAILS == null)
                {
                    var newCollection = new FixupCollection<RETURN_DETAILS>();
                    newCollection.CollectionChanged += FixupRETURN_DETAILS;
                    _rETURN_DETAILS = newCollection;
                }
                return _rETURN_DETAILS;
            }
            set
            {
                if (!ReferenceEquals(_rETURN_DETAILS, value))
                {
                    var previousValue = _rETURN_DETAILS as FixupCollection<RETURN_DETAILS>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupRETURN_DETAILS;
                    }
                    _rETURN_DETAILS = value;
                    var newValue = value as FixupCollection<RETURN_DETAILS>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupRETURN_DETAILS;
                    }
                }
            }
        }
        private ICollection<RETURN_DETAILS> _rETURN_DETAILS;

        #endregion

        #region Association Fixup
    
        private void FixupCAMPAIGN(CAMPAIGN previousValue)
        {
            if (previousValue != null && previousValue.ORDER_DETAIL.Contains(this))
            {
                previousValue.ORDER_DETAIL.Remove(this);
            }
    
            if (CAMPAIGN != null)
            {
                if (!CAMPAIGN.ORDER_DETAIL.Contains(this))
                {
                    CAMPAIGN.ORDER_DETAIL.Add(this);
                }
                if (CampaignID != CAMPAIGN.ID)
                {
                    CampaignID = CAMPAIGN.ID;
                }
            }
        }
    
        private void FixupPRODUCT_ATTRIBUTE(PRODUCT_ATTRIBUTE previousValue)
        {
            if (previousValue != null && previousValue.ORDER_DETAIL.Contains(this))
            {
                previousValue.ORDER_DETAIL.Remove(this);
            }
    
            if (PRODUCT_ATTRIBUTE != null)
            {
                if (!PRODUCT_ATTRIBUTE.ORDER_DETAIL.Contains(this))
                {
                    PRODUCT_ATTRIBUTE.ORDER_DETAIL.Add(this);
                }
                if (ProdAttrID != PRODUCT_ATTRIBUTE.ID)
                {
                    ProdAttrID = PRODUCT_ATTRIBUTE.ID;
                }
            }
        }
    
        private void FixupORDERS(ORDERS previousValue)
        {
            if (previousValue != null && previousValue.ORDER_DETAIL.Contains(this))
            {
                previousValue.ORDER_DETAIL.Remove(this);
            }
    
            if (ORDERS != null)
            {
                if (!ORDERS.ORDER_DETAIL.Contains(this))
                {
                    ORDERS.ORDER_DETAIL.Add(this);
                }
                if (OrderID != ORDERS.ID)
                {
                    OrderID = ORDERS.ID;
                }
            }
        }
    
        private void FixupRETURN_DETAILS(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (RETURN_DETAILS item in e.NewItems)
                {
                    item.ORDER_DETAIL = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (RETURN_DETAILS item in e.OldItems)
                {
                    if (ReferenceEquals(item.ORDER_DETAIL, this))
                    {
                        item.ORDER_DETAIL = null;
                    }
                }
            }
        }

        #endregion

    }
}
