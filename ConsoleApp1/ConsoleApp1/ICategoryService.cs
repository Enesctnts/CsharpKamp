using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerProductTrack
{
    public interface ICategoryService
    {
        public void Add(Category category);
        public void Delete(Category category);
        public void Update(Category category);
    }
}
