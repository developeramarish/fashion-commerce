﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FashionZone.DataLayer.Model;

namespace FashionZone.BL.DAO
{
    public interface IInvitationDAO : IDAO<INVITATION>
    {
        List<INVITATION> GetAllInvitationOfCustomer(int idCust);

    }
}
