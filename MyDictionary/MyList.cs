using System;
using System.Collections.Generic;
using System.Text;

namespace MyList
{
    class MyList<A, B>
    {
        A[] ProductName;
        B[] ProductPrice;

        A[] TempNames;
        B[] TempPrices;

        public MyList()
        {
            ProductName = new A[0];
            ProductPrice = new B[0];

        }

        public void Add(A name, B price)
        {
            TempNames = ProductName;
            TempPrices = ProductPrice;

            ProductName = new A[ProductName.Length + 1];
            ProductPrice = new B[ProductPrice.Length + 1];

            for (int i = 0; i < TempNames.Length; i++)
            {
                ProductName[i] = TempNames[i];
            }

            ProductName[ProductName.Length - 1] = name;

            for (int j = 0; j < TempPrices.Length; j++)
            {
                ProductPrice[j] = TempPrices[j];
            }

            ProductPrice[ProductPrice.Length - 1] = price;

        }

        public A[] Names
        {
            get { return ProductName; }
        }

        public B[] Prices
        {
            get { return ProductPrice; }
        }


    }
}
  
