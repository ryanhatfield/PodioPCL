using PodioPCL.Models;
using System.Linq;

namespace PodioPCL.Utils.ItemFields
{
    public class NumericItemField : ItemField
    {
        public double? Value
        {
            get
            {
                if (this.HasValue("value"))
                {
                    return (double)this.Values.First()["value"];
                }
                else
                {
                    return null;
                }
            }

            set
            {
                ensureValuesInitialized(true);
                this.Values.First()["value"] = value;
            }
        }
    }
}
