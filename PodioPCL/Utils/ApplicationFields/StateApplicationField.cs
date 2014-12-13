using Newtonsoft.Json.Linq;
using PodioPCL.Models;
using System.Collections.Generic;

namespace PodioPCL.Utils.ApplicationFields
{
	/// <summary>
	/// Class StateApplicationField.
	/// </summary>
    public class StateApplicationField : ApplicationField
    {
        private IEnumerable<string> _allowedValues;
		/// <summary>
		/// Gets or sets the allowed values.
		/// </summary>
		/// <value>The allowed values.</value>
        public IEnumerable<string> AllowedValues
        {
            get
            {
                if (_allowedValues == null)
                {
                    _allowedValues = this.GetSettingsAs<string>("allowed_values");
                }
                return _allowedValues;
            }
            set
            {
                InitializeFieldSettings();
                this.InternalConfig.Settings["allowed_values"] = value != null ? JToken.FromObject(value) : null;
            }
        }
    }
}
