using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerProductTrack
{
    public interface IShoppingCartService
    {
        public void Add(Category category);
        public void Delete(Category category);
        public void Update(Category category);
    }
}
