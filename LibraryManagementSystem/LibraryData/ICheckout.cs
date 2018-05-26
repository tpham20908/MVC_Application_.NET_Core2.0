﻿using LibraryData.Models;
using System;
using System.Collections.Generic;

namespace LibraryData
{
    public interface ICheckout
    {
        IEnumerable<Checkout> GetAll();
        Checkout GetById(int checkoutId);
        void Add(Checkout newCheckout);
        void CheckOutItem(int assetId, int libraryCardId);
        void CheckInItem(int assetId, int libraryCardId);
        IEnumerable<CheckoutHistory> GetCheckoutHistories(int id);

        void PlaceHold(int assetId, int libraryCardId);
        string GetCurrentHoldPatronName(int holdId);
        DateTime GetCurrentHoldPlaced(int id);
        IEnumerable<Hold> GetCurrentHolds(int id);
        Checkout GetLatestCheckout(int assetId);

        void MarkLost(int assetId);
        void MarkFound(int assetId);
    }
}
