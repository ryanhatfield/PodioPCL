using Newtonsoft.Json.Linq;
using PodioPCL.Models;
using System.Collections.Generic;

namespace PodioPCL.Utils.ApplicationFields
{
	/// <summary>
	/// Class FileApplicationField.
	/// </summary>
    public class FileApplicationField : ApplicationField
    {
        private IEnumerable<string> _allowedMimetypes;

		/// <summary>
		/// A list of allowed mimetypes on the form "image/png" or "image/*"
		/// </summary>
		/// <value>The allowed mimetypes.</value>
        public IEnumerable<string> AllowedMimetypes
        {
            get
            {
                if (_allowedMimetypes == null)
                {
                    _allowedMimetypes = this.GetSettingsAs<string>("allowed_mimetypes");
                }
                return _allowedMimetypes;
            }
            set
            {
                InitializeFieldSettings();
                this.InternalConfig.Settings["allowed_mimetypes"] = value != null ? JToken.FromObject(value) : null;
            }
        }
    }
}
