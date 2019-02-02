using System;
using HPlusSports.Services;

namespace HPlusSports.Design
{
    public class ProductModel
    {
        // ABOUT Static Modifier: use the "static" modifier to declare a static member, which belongs to the type itself rather than to a specific object.
        // A static member cannot be referenced through an instance.  Instead, it is referenced through the type name.  
        // To refer to the static member, use the fully qualified name.  

        //this has a static property named Product, and it returns a prebuilt or predefined Product object.
        public static Product Product
        {
            get
            {
                return new Product
                {
                    Name = "V-Neck T-Shirt",
                    Description = "Our pre-shrunk organic cotton t-shirt, with slightly fitted waist and elegant V-neck designed to flatter.  You'll want one in every color!",
                    Id = 524,
                    Image_Title = "v-neck-t-shirt-for-women_lynda_29948",
                    Image = "https://hplussport.com/wp-content/uploads/2016/12/v-neck-t-shirt-for-women_LYNDA_29948.jpg"
                };
            }
        }
    }
}
