using Newtonsoft.Json.Linq;
using PodioPCL.Models;
using System.Collections.Generic;

namespace PodioPCL.Utils.ApplicationFields
{
	/// <summary>
	/// Class AppReferenceApplicationField.
	/// </summary>
    public class AppReferenceApplicationField: ApplicationField
    {
        private IEnumerable<int> _referenceableTypes;

        /// <summary>
        /// List of ids of the apps that can be referenced.
        /// </summary>
        public IEnumerable<int> ReferenceableTypes
        {
            get
            {
                if (_referenceableTypes == null)
                {
                    _referenceableTypes = this.GetSettingsAs<int>("referenceable_types");
                }
                return _referenceableTypes;
            }
            set
            {
                InitializeFieldSettings();
                this.InternalConfig.Settings["referenceable_types"] = value != null ? JToken.FromObject(value) : null;
            }
        }
    }
}
