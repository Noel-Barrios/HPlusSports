﻿using System;
namespace HPlusSports.Services
{
    //this class represents a product we're going to retrieve from our HTTP API.
    public class Product
    {
        public string Name
        {
            get;
            set;
        }

        public int Id
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }

        public string Image_Title
        {
            get;
            set;
        }

        public string Image
        {
            get;
            set;
        }

        public Uri ImageUri
        {
            get
            {
                return String.IsNullOrEmpty(Image) ? null : new Uri(Image); 
            }


        }





        public Product()
        {
        }
    }
}
