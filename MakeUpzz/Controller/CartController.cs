﻿using MakeUpzz.Handler;
using MakeUpzz.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeUpzz.Controller
{
    public class CartController
    {
        public static void addToCart(int userID, int makeupID, int quantity)
        {
            CartHandler.addToCart(userID, makeupID, quantity);
        }

        public static void clearCart(int userID)
        {
            CartHandler.clearCart(userID);
        }

        public static void checkout(int userID)
        {
            CartHandler.checkout(userID);
        }
    }
}