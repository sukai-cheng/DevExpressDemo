using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevExpressDemo
{
    public interface INavigablePage
    {
        // Gets the name of the associated ribbon category for this page.
        string AssociatedRibbonCategoryName { get; }
    }
}
