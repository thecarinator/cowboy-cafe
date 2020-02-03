using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class CornDodgers: Side
    {
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.59;
                    case Size.Medium:
                        return 1.79;
                    case Size.Large:
                        return 1.99;
                    default:
                        throw new NotImplementedException();
                }
            }
        }


    }
}
