﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TyresStore.Repository.Interfaces;
using TyresStore.Repository.Models;

namespace TyresStore.Repository
{
    public class BasketRepository : IBasketRepository
    {

        TyresStoreContext tyresContext = new TyresStoreContext();

        public void StoreTyre(int tyreId, string description)
        {
            Basket item = new Basket();
            item.TyreId = tyreId;
            item.Description = description;
            item.AddedDate = new DateTime().ToShortDateString() + new DateTime().ToShortTimeString();

            tyresContext.BasketItems.Add(item);
            tyresContext.SaveChanges();
        }



        public List<Basket> GetItems()
        {
            return tyresContext.BasketItems.ToList();
        }



        public bool TyreAlreadyAdded(int tyreId)
        {
            List<Basket> Items = this.GetItems();

            var item = Items.SingleOrDefault(x => x.TyreId == tyreId);

            return item != null;
        }



        public void RemoveItem(int itemId)
        {
            var item = tyresContext.BasketItems.SingleOrDefault(x => x.ID == itemId);

            tyresContext.BasketItems.Remove(item);
            tyresContext.SaveChanges();
        }
    }
}
