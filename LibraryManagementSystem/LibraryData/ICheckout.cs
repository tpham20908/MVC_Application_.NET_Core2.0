﻿using LibraryData.Models;
using System;
using System.Collections.Generic;

namespace LibraryData
{
    public interface ICheckout
    {
        void Add(Checkout newCheckout);

        IEnumerable<Checkout> GetAll();
        IEnumerable<Hold> GetCurrentHolds(int id);
        IEnumerable<CheckoutHistory> GetCheckoutHistories(int id);

        Checkout GetById(int checkoutId);
        Checkout GetLatestCheckout(int assetId);
        string GetCurrentHoldPatronName(int holdId);
        string GetCurrentCheckoutPatron(int assetId);
        DateTime GetCurrentHoldPlaced(int holdId);

        void CheckOutItem(int assetId, int libraryCardId);
        void CheckInItem(int assetId, int libraryCardId);
        void PlaceHold(int assetId, int libraryCardId);
        void MarkLost(int assetId);
        void MarkFound(int assetId);
    }
}
