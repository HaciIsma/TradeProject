﻿using Autofac;
using System.Collections.Generic;
using TradeProject.Model;
using TradeProject.Repository.Interface;
using TradeProject.Setting;
using TradeProject.ViewModel.PageControl.Interface;

namespace TradeProject.ViewModel.PageControl
{
    public class StorageProductTablePageControl : IGetDatabaseProductList<StorageProduct>
    {
        public List<StorageProduct> Products { get; private set; }
        public StorageProductTablePageControl()
        {
            Products = ContainerConfig.Configure().Resolve<IRepo<StorageProduct>>().GetAll();
        }
    }
}